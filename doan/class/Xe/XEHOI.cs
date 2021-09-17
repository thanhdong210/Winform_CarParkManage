using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan
{
    class XEHOI
    {
        MY_DB mydb = new MY_DB();
        public bool insertXeHoi(string Id, string chusohuu,  string bangsoxe, MemoryStream hieuxe)
        {
            SqlCommand command = new SqlCommand("INSERT INTO xehoi (xeid,chusohuu,bangsoxe,hieuxe)" + "VALUES (@id, @csh,@bsxe,@hx)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Char).Value = Id;
            command.Parameters.Add("@csh", SqlDbType.VarChar).Value = chusohuu;

           
            command.Parameters.Add("@bsxe", SqlDbType.VarChar).Value = bangsoxe.ToArray();
            command.Parameters.Add("@hx", SqlDbType.Image).Value = hieuxe.ToArray();
           
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
        public bool checkID(string id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM xehoi WHERE xeid='" + id + "'", mydb.getConnection);
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

        public DataTable getXe(SqlCommand command)
        {

            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool DeleteXeHoi(string id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM xehoi where xeid = '" + id + "'", mydb.getConnection);
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
        public bool updateXeHoi(string Id, string chusohuu, MemoryStream hieuxe, string bangsoxe)
        {

            SqlCommand command = new SqlCommand("UPDATE xehoi SET chusohuu=@csh,hieuxe=@hx,bangsoxe=@bsxe WHERE xeid=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Char).Value = Id;
            command.Parameters.Add("@csh", SqlDbType.VarChar).Value = chusohuu;

            command.Parameters.Add("@hx", SqlDbType.Image).Value = hieuxe.ToArray();
            command.Parameters.Add("@bsxe", SqlDbType.VarChar).Value = bangsoxe.ToArray();
            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
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
