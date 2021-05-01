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
            string Str = "Initial Catalog=WalkerDB;Data Source=.;User ID =sa;password=123456";
           
            SqlConnection con = new SqlConnection(Str);
            con.Open();

            lblDbVersion.Text = con.ServerVersion;

            SqlCommand cmd = new SqlCommand(sqlAllDbs,con);
            cmd.CommandType = CommandType.Text;
            //string str = "select Name from 1;";
            //cmd.CommandText = str;
            //cmd.Connection = con;

            var talbe = new DataTable();
            var sqlAda = new SqlDataAdapter(cmd);
            sqlAda.Fill(talbe);
            
      
            //DataSet ds = new DataSet();
            //read

            //Console.WriteLine("{0} {1} {2:d}", rdr["OrderID"], rdr"CustomerID"], rdr["OrderDate"]);

            //SqlDataReader Reader = cmd.ExecuteReader();
            //Reader.Read();
            //this.textBox1.Text = Reader.GetString(0);
            //Reader.Close();
            con.Close();

        }
    }
}
