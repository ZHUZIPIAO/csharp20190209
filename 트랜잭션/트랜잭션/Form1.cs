using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace 트랜잭션
{
    public partial class Form1 : Form
    {
        OleDbDataAdapter adapter = null;
        DataSet ds = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ds = new DataSet("emp");

            string conStr = "Provider=MSDAORA;data source=topcredu;User ID=scott;Password=tiger";
            using(OleDbConnection connection = new OleDbConnection(conStr))
            {
                OleDbCommand command = new OleDbCommand();
                OleDbTransaction tr = null;

                try
                {
                    connection.Open();
                    tr = connection.BeginTransaction(); // 트랜젝션 만들어짐
                    command.Connection = connection; 
                    command.Transaction = tr; //commend 에 트랜잭션할당됨

                    command.CommandText = "insert into emp (empno, ename)"
                    + " values (3456, '3000 길동')";
                    int i = command.ExecuteNonQuery();
                    Console.WriteLine(i + "건 Inserted!");
                    command.CommandText = "insert into emp (empno, ename)"
                    + " values (7890, '3000 길동')";
                    i = command.ExecuteNonQuery();
                    tr.Commit(); //실행되면 데이터베이스에 영구히 반영한다.
                    adapter = new OleDbDataAdapter("select * from emp", connection);
                    adapter.Fill(ds, "EMP");
                    dataGridView1.DataSource = ds.Tables["EMP"];
                    adapter.Fill(ds, "EMP");
                }
                catch(Exception ex)
                {
                    //에러나면 rollback 
                    tr?.Rollback();
                    MessageBox.Show(ex.Message, "emp Table Loading Error");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
