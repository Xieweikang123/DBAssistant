using CommonLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using WalkerCommon;

namespace DBAssistant
{
    public partial class Main : Form
    {
        private float xPos = 0;
        private float yPos = 0;
        private Point startPos;
        private Button currentBtn;      //当前选中按钮
        private string curDbName;
        private List<string> tableNameList = new List<string>();
        private Dictionary<string, List<string>> tableWithFieldDic = new Dictionary<string, List<string>>();
        private string dbConfigPath = AppDomain.CurrentDomain.BaseDirectory + "dbConfig.xml";

        private float x;//定义当前窗体的宽度
        private float y;//定义当前窗体的高度

        private MoveControl moveControlTable;
        //是否连接数据库
        private bool IsConnectDb {
            get
            {
                return this.clbDbList.Items.Count > 0;
            }
        }
        /// <summary>
        /// 鼠标按下
        /// </summary>
        private bool mouseIsDown = false;
        private Rectangle mouseRect = Rectangle.Empty;
        public Main()
        {
            InitializeComponent();

            x = this.Width;
            y = this.Height;
            setTag(this);
        }
        private void Main_Load(object sender, EventArgs e)
        {

            //数据库配置文件是否存在
            //var path = AppDomain.CurrentDomain.BaseDirectory + "dbConfig.xml";
            if (!File.Exists(dbConfigPath))
            {
                CreateDbConfig(dbConfigPath);
            }
            InitCmbDbConfig();

            //配置控件缩放
            //moveControlTable = new MoveControl(this.clbTableList);
            //moveControlTable.lblMsg = this.lblMsg;
        }
        #region 缩放控件
        /// <summary>
        /// 单击窗体时，刷新空间，目的为了把按钮放大缩小标识隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Click(object sender, EventArgs e)
        {
            //moveControlTable.fc.Visible = false;
            this.Refresh();
        }
        #endregion

        private void InitCmbDbConfig()
        {
            this.SafeInvoke(() =>
            {
                cmbSqlConStr.Text = string.Empty;
                cmbSqlConStr.Items.Clear();
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(dbConfigPath);
                var dbNodeList = xmlDoc.SelectNodes("//DB/ConnectionStr");
                foreach (XmlNode node in dbNodeList)
                {
                    cmbSqlConStr.Items.Add(node.InnerText);
                }

                //数据库默认选中第一项
                cmbSqlConStr.SelectedIndex = 0;
            });
        }
        /// <summary>
        /// 配置数据库按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnConfig_Click(object sender, EventArgs e)
        {
            var proc = System.Diagnostics.Process.Start(dbConfigPath);
            proc.EnableRaisingEvents = true;
            proc.Exited += ConfigOk;
        }
        /// <summary>
        /// 配置完毕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConfigOk(object sender, EventArgs e)
        {
            InitCmbDbConfig();
        }
        /// <summary>
        /// 创建数据库xml
        /// </summary>
        private void CreateDbConfig(string path)
        {
            //创建
            XElement xElement = new XElement(
                  new XElement("DBConfig",
                      new XElement("DB",
                          new XElement("ConnectionStr", "Initial Catalog=WalkerDB;Data Source=.;User ID =sa;password=123456"),
                          new XElement("Date", DateTime.Now.ToString("G"))
                          )
                  ));

            //需要指定编码格式，否则在读取时会抛：根级别上的数据无效。 第 1 行 位置 1异常
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = new UTF8Encoding(false);
            settings.Indent = true;
            XmlWriter xw = XmlWriter.Create(path, settings);
            xElement.Save(xw);
            //写入文件
            xw.Flush();
            xw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Init();

                //查询所有数据库
                var sqlAllDbs = "SELECT * FROM  sysdatabases";
                SqlHelper.connStr = cmbSqlConStr.Text;
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
                var reg = "Catalog=(.*?);";
                curDbName = RegexHelper.GetFirstMatchValue(cmbSqlConStr.Text, reg);
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
            this.tableWithFieldDic.Clear();
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
                txtTableSearch.Text = string.Empty;

                var selected = clbDbList.Items[e.Index] as DataRowView;
                var newDbName = selected.Row["name"].ToString();
                this.cmbSqlConStr.Text = this.cmbSqlConStr.Text.Replace(curDbName, newDbName);
                curDbName = newDbName;

                //获取所有表
                var sqlGetAllTables = "select * from  INFORMATION_SCHEMA.TABLES";
                SqlHelper.connStr = this.cmbSqlConStr.Text;
                var table = SqlHelper.GetTable(sqlGetAllTables);

           
                //存为list
                tableNameList = GenericityHelper.TableToList(table, "TABLE_NAME");

                //表对应字段
                //foreach(var tableName in tableNameList)
                //{

                //}

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
            if (!IsConnectDb)
            {
                MessageBox.Show("请先连接数据库");
                return;
            }
            this.clbTableList.Items.Clear();

            var sValue = this.txtTableSearch.Text;

            //忽略大小写
            var result = tableNameList.FindAll(m => m.ToUpper().Contains(sValue.ToUpper()));

            //var objCollection = new ListBox.ObjectCollection();
            //objCollection.AddRange(result);

            this.clbTableList.Items.AddRange(result.ToArray());
        }
        
        /// <summary>
        /// 字段搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxFile_TextChanged(object sender, EventArgs e)
        {
            if (!IsConnectDb)
            {
                MessageBox.Show("请先连接数据库");
                return;
            }

            var sValue = this.txtBoxFile.Text;
            if (string.IsNullOrWhiteSpace(sValue))
            {
                this.rtbSql.Text = string.Empty;
                return;
            }
            var sql = $"SELECT * FROM INFORMATION_SCHEMA.columns  where TABLE_CATALOG='{curDbName}' AND COLUMN_NAME like '%{sValue}%'";
            var table = SqlHelper.GetTable(sql);

            var sb = new StringBuilder("表名  列名\n");
            var index = 1;
            foreach(DataRow row in table.Rows)
            {
                sb.Append($"{index++}: {row["TABLE_NAME"]}  {row["COLUMN_NAME"]}\n");
            }
            this.rtbSql.Text = sb.ToString();
            //存为list
            //tableNameList = GenericityHelper.TableToList(table, "TABLE_NAME");

        }
        /// <summary>
        /// 右键菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 备份表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //清空输出框
            this.rtbSql.Text = string.Empty;
         
            var checkedItems = clbTableList.CheckedItems;
            if (checkedItems.Count == 0)
            {
                MessageBox.Show("请选择表");
                return;
            }

            var sql = "CREATE TABLE ";

            var tempSql = "";
            foreach (var ckItem in checkedItems)
            {
                tempSql = $"table:{ckItem}\n";
                //table

            }

        }

        /// <summary>
        /// 右键菜单 生成sql插入语句
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //清空输出框
            this.rtbSql.Text = string.Empty;
            var checkedItems = clbTableList.CheckedItems;
            if (checkedItems.Count == 0)
            {
                MessageBox.Show("请选择表");
                return;
            }

            var querySql = "SELECT * FROM {0}.INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '{1}'";


            foreach (var ckItem in checkedItems)
            {
                //查询表列信息
                querySql = string.Format(querySql, curDbName, ckItem);
                var columnTable = SqlHelper.GetTable(querySql);

                var insertSql = $"INSERT INTO {ckItem}(";

                var columns = new StringBuilder();
                var values = new StringBuilder();
                foreach (DataRow row in columnTable.Rows)
                {
                    columns.Append(row["COLUMN_NAME"] + ",");
                    //是否为空
                    if (row["IS_NULLABLE"].ToString() == "YES")
                    {
                        values.Append("NULL");
                    }
                    else
                    {
                        switch (row["DATA_TYPE"])
                        {
                            case "uniqueidentifier":
                                values.Append($"'{Guid.NewGuid()}'");
                                break;
                            case "int":
                            case "tinyint":
                            case "smallint":
                            case "bigint":
                            case "bit":
                            case "decimal":
                                values.Append("0");
                                break;
                            case "nchar":
                            case "nvarchar":
                                values.Append("''");
                                break;
                            case "date":
                            case "datetime":
                            case "datetime2":
                                values.Append($"'{DateTime.Now}'");
                                break;
                            default:
                                values.Append($"未兼容类型:{row["DATA_TYPE"]}");
                                break;
                        }
                    }
                    values.Append($",");
                }
                insertSql += $"{columns.ToString().TrimEnd(',')}) VALUES ({values.ToString().TrimEnd(',')})\n\n";
                this.rtbSql.Text += insertSql;
            }
            this.lblMsg.Text = "生成insert语句成功";
        }



        private void setTag(Control cons)
        {
            foreach (Control con in cons.Controls)
            {
                con.Tag = con.Width + ";" + con.Height + ";" + con.Left + ";" + con.Top + ";" + con.Font.Size;
                if (con.Controls.Count > 0)
                {
                    setTag(con);
                }
            }
        }
        private void setControls(float newx, float newy, Control cons)
        {
            //遍历窗体中的控件，重新设置控件的值
            foreach (Control con in cons.Controls)
            {
                //获取控件的Tag属性值，并分割后存储字符串数组
                if (con.Tag != null)
                {
                    string[] mytag = con.Tag.ToString().Split(new char[] { ';' });
                    //根据窗体缩放的比例确定控件的值
                    con.Width = Convert.ToInt32(System.Convert.ToSingle(mytag[0]) * newx);//宽度
                    con.Height = Convert.ToInt32(System.Convert.ToSingle(mytag[1]) * newy);//高度
                    con.Left = Convert.ToInt32(System.Convert.ToSingle(mytag[2]) * newx);//左边距
                    con.Top = Convert.ToInt32(System.Convert.ToSingle(mytag[3]) * newy);//顶边距
                    Single currentSize = System.Convert.ToSingle(mytag[4]) * newy;//字体大小
                    con.Font = new Font(con.Font.Name, currentSize, con.Font.Style, con.Font.Unit);
                    if (con.Controls.Count > 0)
                    {
                        setControls(newx, newy, con);
                    }
                }
            }
        }
        private void Main_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / x;
            float newy = (this.Height) / y;
            setControls(newx, newy, this);
        }

      
    }
}
