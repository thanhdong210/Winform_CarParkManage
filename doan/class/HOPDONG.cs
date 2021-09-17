using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan
{
    class HOPDONG
    {
        MY_DB mydb = new MY_DB();
        public bool inserHopDong(int mahd,int loaihopdong)
        {
            SqlCommand command = new SqlCommand("INSERT INTO hopdong (mahopdong,loaihopdong)" + "VALUES (@mhd,@lhd)", mydb.getConnection);
            command.Parameters.Add("@mhd", SqlDbType.Int).Value = mahd;
            command.Parameters.Add("@lhd", SqlDbType.Int).Value = loaihopdong;
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
        public DataTable getHopDong(SqlCommand command)
        {

            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool checkMaHD(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM hopdong WHERE mahopdong='" + id + "'", mydb.getConnection);
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
        public bool updateHD(int mahd, int loaihopdong)
        {

            SqlCommand command = new SqlCommand("UPDATE hopdong SET loaihopdong=@lhd WHERE mahopdong=@mhd", mydb.getConnection);
            command.Parameters.Add("@mhd", SqlDbType.Int).Value = mahd;
            command.Parameters.Add("@lhd", SqlDbType.Int).Value = loaihopdong;
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
        public bool DeleteHopDong(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM hopdong where mahopdong =" + id, mydb.getConnection);
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
