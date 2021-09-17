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
    class XEMAY
    {
        MY_DB mydb = new MY_DB();
        public bool insertXeMay(string Id, string chusohuu, MemoryStream hinhnguoigui,string bangsoxe)
        {
            SqlCommand command = new SqlCommand("INSERT INTO xemay (xeid,chusohuu,hinhnguoigui,bangsoxe)" + "VALUES (@id, @csh,@hng,@bsxe)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Char).Value = Id;
            command.Parameters.Add("@csh", SqlDbType.VarChar).Value = chusohuu;
           
            command.Parameters.Add("@hng", SqlDbType.Image).Value = hinhnguoigui.ToArray();
            command.Parameters.Add("@bsxe", SqlDbType.VarChar).Value = bangsoxe.ToArray();
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
            SqlCommand command = new SqlCommand("SELECT * FROM xemay WHERE xeid='" + id + "'", mydb.getConnection);
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
        public bool DeleteXeMay(string id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM xemay where xeid = '" + id + "'", mydb.getConnection);
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
        public bool updateXeMay(string Id, string chusohuu, MemoryStream hinhnguoigui, string bangsoxe)
        {

            SqlCommand command = new SqlCommand("UPDATE xemay SET chusohuu=@csh,hinhnguoigui=@hng,bangsoxe=@bsxe WHERE xeid=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Char).Value = Id;
            command.Parameters.Add("@csh", SqlDbType.VarChar).Value = chusohuu;

            command.Parameters.Add("@hng", SqlDbType.Image).Value = hinhnguoigui.ToArray();
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
