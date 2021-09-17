using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan
{
    public partial class XemCTHD : Form
    {
        private int mahd;
        private int loaihopdong;
        public XemCTHD()
        {
            InitializeComponent();
        }
        public XemCTHD(int mahd,int loaihopdong)
        {
            InitializeComponent();
            this.mahd = mahd;
            this.loaihopdong = loaihopdong;
        }

        private void XemCTHD_Load(object sender, EventArgs e)
        {
            CTHD cthd = new CTHD();
            textBoxMaHD.Text = mahd.ToString();
            textBoxLoaiHopDong.Text = loaihopdong.ToString(); ;
            int mahopdong = Convert.ToInt32(textBoxMaHD.Text);
            int loaihd = Convert.ToInt32(textBoxLoaiHopDong.Text);
            //bang muon
            SqlCommand command = new SqlCommand("SELECT maxe,chusohuu,biensoxe,makhachhang,tenkhachhang,ngaybatdau,ngayhethanhd,phihopdong FROM CTHD WHERE mahopdong = " + mahopdong+" AND loaihopdong = "+loaihd);
            dataGridViewXemCTHD.ReadOnly = true;
            dataGridViewXemCTHD.RowTemplate.Height = 80;
            dataGridViewXemCTHD.DataSource = cthd.getCTHD(command);
            dataGridViewXemCTHD.AllowUserToAddRows = false;
        }
    }
}
