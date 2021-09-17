using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan
{
    class THO
    {
        MY_DB mydb = new MY_DB();
        public bool insertTho(int matho,string tentho, string gioitinh,DateTime ngaysinh,string sdt)
        {
            SqlCommand command = new SqlCommand("INSERT INTO tho (matho,tentho,gioitinh,ngaysinh,sdt)" + "VALUES (@mt,@tt,@gt,@ns,@sdt)", mydb.getConnection);
            command.Parameters.Add("@mt", SqlDbType.Int).Value = matho;
            command.Parameters.Add("@tt", SqlDbType.VarChar).Value = tentho;
            command.Parameters.Add("@gt", SqlDbType.Char).Value = gioitinh;
            command.Parameters.Add("@ns", SqlDbType.DateTime).Value = ngaysinh;
            command.Parameters.Add("@sdt", SqlDbType.Char).Value = sdt;
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }


        public DataTable getTho(SqlCommand command)
        {

            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool checkMaTho(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM tho WHERE matho=" + id, mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if ((table.Rows.Count == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteTho(int matho)
        {
            SqlCommand command = new SqlCommand("DELETE FROM tho where matho =" + matho, mydb.getConnection);
            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;

            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }
        public bool updateTho(int matho, string tentho, string gioitinh, DateTime ngaysinh, string sdt)
        {

            SqlCommand command = new SqlCommand("UPDATE tho SET tentho=@tt,gioitinh=@gt,ngaysinh=@ns,sdt=@sdt WHERE matho=@mt", mydb.getConnection);
            command.Parameters.Add("@mt", SqlDbType.Int).Value = matho;
            command.Parameters.Add("@tt", SqlDbType.VarChar).Value = tentho;
            command.Parameters.Add("@gt", SqlDbType.Char).Value = gioitinh;
            command.Parameters.Add("@ns", SqlDbType.DateTime).Value = ngaysinh;
            command.Parameters.Add("@sdt", SqlDbType.Char).Value = sdt;
            mydb.openConnection();

            if (command.ExecuteNonQuery() == -1)
            {
                mydb.closeConnection();
                return false;
            }
            else
            {
                mydb.closeConnection();
                return true;
            }


        }
    }
}
