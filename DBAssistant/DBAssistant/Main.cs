using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WalkerCommon;

namespace DBAssistant
{
    public partial class Main : Form
    {
        private string curDbName;
        private List<string> tableNameList=new List<string>();
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Init();

                //查询所有数据库
                var sqlAllDbs = "SELECT * FROM  sysdatabases";
                SqlHelper.connStr = txtSqlConStr.Text;
                //"Initial Catalog=WalkerDB;Data Source=.;User ID =sa;password=123456";

                //SqlConnection con = new SqlConnection(conStr);
                //con.Open();

                //lblDbVersion.Text = "数据库版本" + con.ServerVersion;

                //SqlCommand cmd = new SqlCommand(sqlAllDbs, con);
                //cmd.CommandType = CommandType.Text;

                //var table = new DataTable();
                //var sqlAda = new SqlDataAdapter(cmd);
                //sqlAda.Fill(table);

                var table = SqlHelper.GetTable(sqlAllDbs);

                clbDbList.DataSource = table;
                clbDbList.ValueMember = "name";
                clbDbList.DisplayMember = "name";

                //foreach(DataRow row in table.Rows)
                //{
                //    tableNameList.Add(row["name"].ToString());
                //}
               //tableNameList=  GenericityHelper.TableToList(table, "name");

                var reg = "Catalog=(.*?);";
                curDbName = RegexHelper.GetFirstMatchValue(txtSqlConStr.Text, reg);
                //默认选中连接字符串中的数据库
                for (var i = 0; i < clbDbList.Items.Count; i++)
                {
                    var dtr = clbDbList.Items[i] as DataRowView;

                    if (dtr.Row["name"].ToString() == curDbName)
                    {
                        clbDbList.SetItemCheckState(i, CheckState.Checked);
                        break;
                    }
                }

                this.lblMsg.Text = "获取数据库成功" + curDbName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
        /// <summary>
        /// 初始化
        /// </summary>
        private void Init()
        {
            this.clbDbList.DataSource = null;
            this.tableNameList.Clear();
        }

        private void dbList_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            var checkedItem = (CheckedListBox)sender;

            //var pattern = "Catalog=(.*?);";

            //如果是选中
            if (e.NewValue == CheckState.Checked)
            {
                //先清空
                clbTableList.Items.Clear();

                var selected = clbDbList.Items[e.Index] as DataRowView;
                var newDbName = selected.Row["name"].ToString();
                this.txtSqlConStr.Text = this.txtSqlConStr.Text.Replace(curDbName, newDbName);
                curDbName = newDbName;

                //获取所有表
                var sqlGetAllTables = "select * from  INFORMATION_SCHEMA.TABLES";
                SqlHelper.connStr = this.txtSqlConStr.Text;
                var table = SqlHelper.GetTable(sqlGetAllTables);

                //存为list
                tableNameList = GenericityHelper.TableToList(table, "TABLE_NAME");

                clbTableList.Items.AddRange(tableNameList.ToArray());
            }

            //设置单选
            for (int i = 0; i < clbDbList.Items.Count; i++)
            {
                if (i != e.Index)//除去触发SelectedIndexChanged事件以外的选中项都处于未选中状态
                {
                    clbDbList.SetItemCheckState(i, System.Windows.Forms.CheckState.Unchecked);
                }
            }
        }

        private void clbDbList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 表名搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTableSearch_TextChanged(object sender, EventArgs e)
        {
            this.clbTableList.Items.Clear();

            var sValue = this.txtTableSearch.Text;

            var result = tableNameList.FindAll(m => m.Contains(sValue));

            //var objCollection = new ListBox.ObjectCollection();
            //objCollection.AddRange(result);

            this.clbTableList.Items.AddRange(result.ToArray());
        }
    }
}
