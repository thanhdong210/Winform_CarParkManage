using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doan
{
    class CTHD
    {
        MY_DB mydb = new MY_DB();
        public bool insertCTHD(int mahd,int loaihopdong,string maxe,string chusohuu,string biensoxe,int makh,string tenkhachhang,DateTime ngaybatdau,DateTime ngayhethanhd,double phihopdong)
        {
            SqlCommand command = new SqlCommand("INSERT INTO CTHD (mahopdong,loaihopdong,maxe,chusohuu,biensoxe,makhachhang,tenkhachhang,ngaybatdau,ngayhethanhd,phihopdong)" + "VALUES (@mhd,@lhd,@mx,@csh,@bsx,@mkh,@tkh,@nbd,@nhh,@phd)", mydb.getConnection);
            command.Parameters.Add("@mhd", SqlDbType.Int).Value = mahd;
            command.Parameters.Add("@lhd", SqlDbType.Int).Value = loaihopdong;
            command.Parameters.Add("@mx", SqlDbType.Char).Value = maxe;
            command.Parameters.Add("@csh", SqlDbType.VarChar).Value = chusohuu;
            command.Parameters.Add("@bsx", SqlDbType.Char).Value = biensoxe;
            command.Parameters.Add("@mkh", SqlDbType.Int).Value = makh;
            command.Parameters.Add("@tkh", SqlDbType.VarChar).Value = tenkhachhang;
            command.Parameters.Add("@nbd", SqlDbType.DateTime).Value = ngaybatdau;
            command.Parameters.Add("@nhh", SqlDbType.DateTime).Value = ngayhethanhd;
            command.Parameters.Add("@phd", SqlDbType.Float).Value = phihopdong;
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


        public DataTable getCTHD(SqlCommand command)
        {

            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
        public bool checkMaHD(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM CTHD WHERE mahopdong='" + id + "'", mydb.getConnection);
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
        public bool DeleteCTHD(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM CTHD where mahopdong=" + id, mydb.getConnection);
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
        public bool updateCTHD(int mahd, int loaihopdong, string maxe, string chusohuu, string biensoxe, int makh, string tenkhachhang, DateTime ngaybatdau, DateTime ngayhethanhd, double phihopdong)
        {

            SqlCommand command = new SqlCommand("UPDATE CTHD SET loaihopdong=@lhd,maxe=@mx,chusohuu=@csh,biensoxe=@bsx,makhachhang=@mkh,tenkhachhang=@tkh,ngaybatdau=@nbd,ngayhethanhd=@nhh,phihopdong=@phd WHERE mahopdong=@mhd", mydb.getConnection);
            command.Parameters.Add("@mhd", SqlDbType.Int).Value = mahd;
            command.Parameters.Add("@lhd", SqlDbType.Int).Value = loaihopdong;
            command.Parameters.Add("@mx", SqlDbType.Char).Value = maxe;
            command.Parameters.Add("@bsx", SqlDbType.Char).Value = biensoxe;
            command.Parameters.Add("@mkh", SqlDbType.Int).Value = makh;
            command.Parameters.Add("@tkh", SqlDbType.VarChar).Value = tenkhachhang;
            command.Parameters.Add("@nbd", SqlDbType.DateTime).Value = ngaybatdau;
            command.Parameters.Add("@nhh", SqlDbType.DateTime).Value = ngayhethanhd;
            command.Parameters.Add("@phd", SqlDbType.Float).Value = phihopdong;
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
