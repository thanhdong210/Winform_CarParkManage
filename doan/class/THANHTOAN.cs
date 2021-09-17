using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan
{
    class THANHTOAN
    {
        MY_DB mydb = new MY_DB();
        public bool insertThanhToan(string maxe, string chusohuu,DateTime ngaytra,double tientra)
        {
            SqlCommand command = new SqlCommand("INSERT INTO doanhthu (xeid,chusohuu,ngaytra,tientra)" + "VALUES (@mx,@csh,@nt,@tt)", mydb.getConnection);
            command.Parameters.Add("@mx", SqlDbType.Char).Value = maxe;
            command.Parameters.Add("@csh", SqlDbType.VarChar).Value = chusohuu;
            command.Parameters.Add("@nt", SqlDbType.DateTime).Value = ngaytra;
            
            command.Parameters.Add("@tt", SqlDbType.Float).Value = tientra;

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
        public DataTable getDT(SqlCommand command)
        {

            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool DeleteThanhToanThanhCong(string id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM phi where xeid='" + id + "'", mydb.getConnection);
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
