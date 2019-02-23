using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using Oracle.ManagedDataAccess.Client;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "data source=topcredu=  (DESCRIPTION =   (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.27)(PORT = 1521))   (CONNECT_DATA =   (SERVER = DEDICATED)(SERVICE_NAME = topcredu)) User ID = scott; Password = tiger";

            OracleConnection Conn = new OracleConnection(str);

            Conn.Open();
            //갱신 및 기타 작업을 위한 Adapter 를 하나 만든다.
            OracleDataAdapter adapter = new OracleDataAdapter("select * from emp", Conn);

            DataSet ds = new DataSet("myemp");
            adapter.Fill(ds, "사원"); // myemp 안에 사원이라는 데이터셋이 만들어짐 
            //가지고 온 자료를 화면에 뿌리자...
            foreach (DataRow r in ds.Tables["사원"].Rows)
            {
                Console.WriteLine("Empno : {0}, Ename : {1}, Sal : {2}", r["empno"],
                r["ename"], r["sal"]);
            }//데이터를 변경 하자...
            ds.Tables["사원"].Rows[0]["ename"] = "홍길동";
            // CommandBuilder 가 insert, update 등 command 를 만들어줌 
            OracleCommandBuilder thisBuilder = new OracleCommandBuilder(adapter);

            adapter.Update(ds, "사원");
            //변경 후 DataTable 자료 출력
            Console.WriteLine();
            foreach (DataRow r in ds.Tables["사원"].Rows)
            {
                Console.WriteLine("Empno : {0}, Ename : {1}, Sal : {2}", r["empno"], r["ename"],
r["sal"]);
            }
            DataRow row = ds.Tables["사원"].NewRow();
            row["empno"] = 8788; row["ename"] = "87 길동"; row["sal"] = 7777;
            ds.Tables["사원"].Rows.Add(row);
            adapter.Update(ds, "사원");
            //다시 DB 에서 데이터 원본을 추출, 테이블의 내용이 바뀐 것을 확인하자.
            adapter = new OracleDataAdapter("select * from emp", Conn);
            adapter.Fill(ds, "사원");
            //추가 후 자료 출력
            Console.WriteLine();
            foreach (DataRow r in ds.Tables["사원"].Rows)
            {
                Console.WriteLine("Empno : {0}, Ename : {1}, Sal : {2}", r["empno"], r["ename"],
                r["sal"]);
            }
            Console.WriteLine(" 총 {0} 건 입니다.", ds.Tables["사원"].Rows.Count);
        }
    }
}



 
