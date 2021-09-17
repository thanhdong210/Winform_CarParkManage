using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan
{
    class CONGVIEC
    {
        MY_DB mydb = new MY_DB();
        public bool insertCV(string Id, string chusohuu,string loaicongviec,int matho)
        {
            SqlCommand command = new SqlCommand("INSERT INTO congviec (xeid,chusohuu,loaicv,matho)" + "VALUES (@id, @csh,@lcv,@mt)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Char).Value = Id;
            command.Parameters.Add("@csh", SqlDbType.VarChar).Value = chusohuu;
            command.Parameters.Add("@lcv", SqlDbType.VarChar).Value = loaicongviec;
            command.Parameters.Add("@mt", SqlDbType.Int).Value = matho;
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


        public DataTable getCV(SqlCommand command)
        {

            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool checkMaTho(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM congviec WHERE matho="+id, mydb.getConnection);
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
        public bool DeleteCV(string id,int matho)
        {
            SqlCommand command = new SqlCommand("DELETE FROM congviec where xeid = '" + id + "' AND matho="+matho, mydb.getConnection);
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
        public bool updateCV(string Id, string chusohuu, string loaicongviec, int matho)
        {

            SqlCommand command = new SqlCommand("UPDATE congviec SET chusohuu=@csh,loaicv=@lcv,matho=@mt WHERE xeid=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Char).Value = Id;
            command.Parameters.Add("@csh", SqlDbType.VarChar).Value = chusohuu;
            command.Parameters.Add("@lcv", SqlDbType.VarChar).Value = loaicongviec;
            command.Parameters.Add("@mt", SqlDbType.Int).Value = matho;

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
