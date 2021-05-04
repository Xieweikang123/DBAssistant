using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WalkerCommon;

namespace DBAssistant
{
    public partial class Main : Form
    {
        private string curDbName;
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
                string conStr = txtSqlConStr.Text;
                //"Initial Catalog=WalkerDB;Data Source=.;User ID =sa;password=123456";

                SqlConnection con = new SqlConnection(conStr);
                con.Open();

                lblDbVersion.Text = "数据库版本" + con.ServerVersion;

                SqlCommand cmd = new SqlCommand(sqlAllDbs, con);
                cmd.CommandType = CommandType.Text;
                //string str = "select Name from 1;";
                //cmd.CommandText = str;
                //cmd.Connection = con;

                var table = new DataTable();
                var sqlAda = new SqlDataAdapter(cmd);
                sqlAda.Fill(table);

                clbDbList.DataSource = table;
                clbDbList.ValueMember = "name";
                clbDbList.DisplayMember = "name"; ;

                var reg = "Catalog=(.*?);";
                curDbName = RegexHelper.GetFirstMatchValue(conStr, reg);
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

                con.Close();
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

        }

        private void dbList_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            var checkedItem = (CheckedListBox)sender;

            //var pattern = "Catalog=(.*?);";

            if (e.NewValue == CheckState.Checked)
            {
                var selected = clbDbList.Items[e.Index] as DataRowView;
                var newDbName = selected.Row["name"].ToString();
                this.txtSqlConStr.Text = this.txtSqlConStr.Text.Replace(curDbName, newDbName);
                curDbName = newDbName;
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
    }
}
