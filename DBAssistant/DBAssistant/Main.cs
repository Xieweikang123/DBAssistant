using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBAssistant
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //查询所有数据库
            var sqlAllDbs = "SELECT * FROM  sysdatabases";
            string Str = txtSqlConStr.Text;
                //"Initial Catalog=WalkerDB;Data Source=.;User ID =sa;password=123456";
            
             SqlConnection con = new SqlConnection(Str);
            con.Open();

            lblDbVersion.Text = con.ServerVersion;

            SqlCommand cmd = new SqlCommand(sqlAllDbs,con);
            cmd.CommandType = CommandType.Text;
            //string str = "select Name from 1;";
            //cmd.CommandText = str;
            //cmd.Connection = con;

            var table = new DataTable();
            var sqlAda = new SqlDataAdapter(cmd);
            sqlAda.Fill(table);

            dbList.DataSource = table;
            dbList.ValueMember = "name";
            dbList.DisplayMember = "name";

            //foreach(DataRow row in table.Rows)
            //{
            //    dbList.Items.Add(row["name"]);
            //}

            con.Close();

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dbList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //设置单选
            for (int i = 0; i < dbList.Items.Count; i++)
            {
                if (i != e.Index)//除去触发SelectedIndexChanged事件以外的选中项都处于未选中状态
                {
                    dbList.SetItemCheckState(i, System.Windows.Forms.CheckState.Unchecked);
                }
            }
        }
    }
}
