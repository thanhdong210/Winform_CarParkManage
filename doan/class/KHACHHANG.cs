using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan
{
   
    class KHACHHANG
    {
        MY_DB mydb = new MY_DB();
        public bool insertKH(int makh,string hoten,string gioitinh,DateTime ngaysinh,string sdt,string diachi)
        {
            SqlCommand command = new SqlCommand("INSERT INTO khachhang (Id,hoten,gioitinh,ngaysinh,sdt,diachi)" + "VALUES (@id,@ht,@gt,@ns,@sdt,@dc)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = makh;
            command.Parameters.Add("@ht", SqlDbType.VarChar).Value = hoten;
            command.Parameters.Add("@gt", SqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@ns", SqlDbType.DateTime).Value = ngaysinh;
            command.Parameters.Add("@sdt", SqlDbType.Char).Value = sdt;
            command.Parameters.Add("@dc", SqlDbType.VarChar).Value = diachi;


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
        public DataTable getKH(SqlCommand command)
        {

            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool checkMaKH(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM khachhang WHERE Id='" + id + "'", mydb.getConnection);
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
        public bool updateKH(int makh, string hoten, string gioitinh, DateTime ngaysinh, string sdt, string diachi)
        {

            SqlCommand command = new SqlCommand("UPDATE khachhang SET hoten=@ht,gioitinh=@gt,ngaysinh=@ns,sdt=@sdt,diachi=@dc WHERE Id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = makh;
            command.Parameters.Add("@ht", SqlDbType.VarChar).Value = hoten;
            command.Parameters.Add("@gt", SqlDbType.VarChar).Value = gioitinh;
            command.Parameters.Add("@ns", SqlDbType.DateTime).Value = ngaysinh;
            command.Parameters.Add("@sdt", SqlDbType.Char).Value = sdt;
            command.Parameters.Add("@dc", SqlDbType.VarChar).Value = diachi;
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
        public bool DeleteKH(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM khachhang where Id =" + id, mydb.getConnection);
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
    }
}
