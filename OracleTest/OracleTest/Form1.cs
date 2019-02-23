using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace OracleTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection conn = null;
        OleDbDataAdapter adapter = null;
        DataSet ds = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ds = new DataSet("emp"); //emp라는이름에 DataSet을 만듬
                string conStr =
                    //topcredu는 tns 이름임..
                    "Provider=OraOLEDB.Oracle;data source=topcredu; User ID =scott; Password =tiger";
                conn = new OleDbConnection(conStr);
                conn.Open();
                OleDbCommand command = new OleDbCommand("insert into emp(empno,ename) values(8977, 'OJC')", conn);
                command.ExecuteNonQuery();

                adapter = new OleDbDataAdapter("select * from emp WHERE ename='OJC'", conn);
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "emp Table Loading Error");
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
