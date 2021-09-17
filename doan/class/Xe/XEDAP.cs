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
    class XEDAP
    {
        MY_DB mydb = new MY_DB();
        public bool insertXeDap(string Id, string chusohuu,MemoryStream hinhxe, MemoryStream hinhnguoigui)
        {
            SqlCommand command = new SqlCommand("INSERT INTO xedap (xeid,chusohuu,hinhxe,hinhnguoigui)" + "VALUES (@id, @csh,@hx,@hng)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Char).Value = Id;
            command.Parameters.Add("@csh", SqlDbType.VarChar).Value = chusohuu;
            command.Parameters.Add("@hx", SqlDbType.Image).Value = hinhxe.ToArray();
            command.Parameters.Add("@hng", SqlDbType.Image).Value = hinhnguoigui.ToArray();          
           
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


        public DataTable getXe(SqlCommand command)
        {

            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool checkID(string id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM xedap WHERE xeid='"+id+"'", mydb.getConnection);
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
        public bool DeleteXeDap(string id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM xedap where xeid = '" + id+"'", mydb.getConnection);
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
        public bool updateXeDap(string Id, string chusohuu, MemoryStream hinhxe, MemoryStream hinhnguoigui)
        {

            SqlCommand command = new SqlCommand("UPDATE xedap SET chusohuu=@csh,hinhxe=@hx,hinhnguoigui=@hng WHERE xeid=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Char).Value = Id;
            command.Parameters.Add("@csh", SqlDbType.VarChar).Value = chusohuu;
            command.Parameters.Add("@hx", SqlDbType.Image).Value = hinhxe.ToArray();
            command.Parameters.Add("@hng", SqlDbType.Image).Value = hinhnguoigui.ToArray();
           

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
