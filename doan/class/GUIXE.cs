using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan
{
    class GUIXE
    {
        MY_DB mydb = new MY_DB();
        public bool insertXeGui(string maxe,string chusohuu,string guitheo,DateTime ngaygui,DateTime hangui)
        {
            SqlCommand command = new SqlCommand("INSERT INTO guixe (xeid,chusohuu,guitheo,ngaygui,hangui)" + "VALUES (@mx,@csh,@gt,@ng,@hg)", mydb.getConnection);
            command.Parameters.Add("@mx", SqlDbType.Char).Value =maxe;
            command.Parameters.Add("@csh", SqlDbType.VarChar).Value = chusohuu;
            command.Parameters.Add("@gt", SqlDbType.VarChar).Value = guitheo;
            command.Parameters.Add("@ng", SqlDbType.DateTime).Value = ngaygui;
            command.Parameters.Add("@hg", SqlDbType.DateTime).Value = hangui;
            
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
        public bool insertPhi(string maxe, string chusohuu,double phigui,double phiphat,double tongtien,DateTime ngaygui,DateTime ngaytra)
        {
            SqlCommand command = new SqlCommand("INSERT INTO phi (xeid,chusohuu,phiphat,phigui,tongtien,ngaygui,ngaytra)" + "VALUES (@mx,@csh,@pp,@pg,@tt,@ng,@nt)", mydb.getConnection);
            command.Parameters.Add("@mx", SqlDbType.Char).Value = maxe;
            command.Parameters.Add("@csh", SqlDbType.VarChar).Value = chusohuu;
            command.Parameters.Add("@pp", SqlDbType.Float).Value = phiphat;
            command.Parameters.Add("@pg", SqlDbType.Float).Value = phigui;
            command.Parameters.Add("@tt", SqlDbType.Float).Value = tongtien;
            command.Parameters.Add("@ng", SqlDbType.DateTime).Value = ngaygui;
            command.Parameters.Add("@nt", SqlDbType.DateTime).Value = ngaytra;
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
        public bool checkMaXe(string id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM guixe WHERE xeid='" + id+"'", mydb.getConnection);
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

        public bool checkMaXedap(string id)
        {
            SqlCommand command = new SqlCommand("select * from guixe where xeid like 'XD%' And xeid='" + id + "'", mydb.getConnection);
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
        public bool checkMaXeHoi(string id)
        {
            SqlCommand command = new SqlCommand("select * from guixe where xeid like 'XH%' And xeid='" + id + "'", mydb.getConnection);
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
        public bool checkMaXeMay(string id)
        {
            SqlCommand command = new SqlCommand("select * from guixe where xeid like 'XM%' And xeid='" + id + "'", mydb.getConnection);
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
        public bool DeleteXeNhanGui(string id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM congviec WHERE loaicv='Trong coi xe' AND xeid = '" + id + "'", mydb.getConnection);
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
       
        public bool DeleteXeGui(string id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM guixe where xeid='" + id + "'", mydb.getConnection);
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
