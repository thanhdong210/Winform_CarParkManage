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
    public partial class ThemXoaCTHDForm : Form
    {
        MY_DB mydb = new MY_DB();
        CTHD cthd = new CTHD();
        public ThemXoaCTHDForm()
        {
            InitializeComponent();
        }

        private void ThemXoaCTHDForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM CTHD");
            dataGridViewCTHD.ReadOnly = true;
            dataGridViewCTHD.RowTemplate.Height = 30;
            dataGridViewCTHD.DataSource = cthd.getCTHD(command);
            dataGridViewCTHD.AllowUserToAddRows = false;
            ShowComboboxMaHD();
            ShowComboboxMaKH();
        }

        private void buttonRF_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM CTHD");
            dataGridViewCTHD.ReadOnly = true;
            dataGridViewCTHD.RowTemplate.Height = 30;
            dataGridViewCTHD.DataSource = cthd.getCTHD(command);
            dataGridViewCTHD.AllowUserToAddRows = false;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            HOPDONG hd = new HOPDONG();
            if (comboBoxMaHD.Text.Trim() == "")
            {
                MessageBox.Show("nhap thong tin", "xoa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult result;
                    result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(comboBoxMaHD.Text);
                        if (cthd.DeleteCTHD(id))
                        {
                            hd.DeleteHopDong(id);
                            MessageBox.Show("xoa thanh cong", "xoa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("xoa khong thanh cong", "xoa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("nhap dung dinh dang ID", "xoa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
           
                int id = Convert.ToInt32(comboBoxMaHD.Text);
            int loaihd = Convert.ToInt32(textBoxLoaiHopDong.Text);
            string maxe = textBoxMaXe.Text;
            string chusohuu = textBoxChuSoHuu.Text;
            string biensoxe = textBoxBienSoXe.Text;
            int makh = Convert.ToInt32(comboBoxMaKH.Text);
            string hoten = textBoxHoTen.Text;
            double phi= Convert.ToDouble(textBoxPhi.Text);

            DateTime ngaybatdau = dateTimePickerBatDau.Value;
            DateTime ngayhethan = dateTimePickerHetHan.Value;
            
                if (cthd.checkMaHD(id) == false)
                {
                    MessageBox.Show("Trung ID", "Chi tiết hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verif())
                {
                    if (cthd.insertCTHD(id,loaihd,maxe,chusohuu,biensoxe,makh,hoten,ngaybatdau,ngayhethan,phi))
                    {
                        MessageBox.Show("Da them thanh cong", "Chi tiết hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Loi", "TChi tiết hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Chi tiết hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            
        }
        bool verif()
        {
            if ((textBoxMaXe.Text.Trim() == "") || (textBoxChuSoHuu.Text.Trim() == "") || (textBoxMaXe.Text.Trim() == "") || (textBoxPhi.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void ShowComboboxMaHD()
        {
            SqlCommand command = new SqlCommand("SELECT mahopdong,loaihopdong FROM hopdong", mydb.getConnection);
            mydb.openConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);
            comboBoxMaHD.DataSource = table;
            comboBoxMaHD.DisplayMember = "mahopdong";
            comboBoxMaHD.ValueMember = "loaihopdong";
            
        }
        private void comboBoxMaHD_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string loaihopdong = comboBoxMaHD.SelectedValue.ToString();
                textBoxLoaiHopDong.Text = loaihopdong;
               
            }
            catch
            {

                textBoxLoaiHopDong.Text = "";
                
            }
            //textBoxTenSach.Text = comboBoxMaSach.SelectedValue.ToString();


        }
        public void ShowComboboxMaKH()
        {
            SqlCommand command = new SqlCommand("SELECT Id,hoten FROM khachhang", mydb.getConnection);
            mydb.openConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable table = new DataTable();
            da.Fill(table);
            comboBoxMaKH.DataSource = table;
            comboBoxMaKH.DisplayMember = "Id";
            comboBoxMaKH.ValueMember = "hoten";

        }
        private void comboBoxMaKH_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string hoten = comboBoxMaKH.SelectedValue.ToString();
                textBoxHoTen.Text = hoten;

            }
            catch
            {

                textBoxHoTen.Text = "";

            }
            //textBoxTenSach.Text = comboBoxMaSach.SelectedValue.ToString();


        }

        private void dataGridViewCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxMaHD.Text = dataGridViewCTHD.CurrentRow.Cells[0].Value.ToString();
            textBoxLoaiHopDong.Text = dataGridViewCTHD.CurrentRow.Cells[1].Value.ToString();
            textBoxMaXe.Text = dataGridViewCTHD.CurrentRow.Cells[2].Value.ToString();
            textBoxChuSoHuu.Text = dataGridViewCTHD.CurrentRow.Cells[3].Value.ToString();
            textBoxBienSoXe.Text = dataGridViewCTHD.CurrentRow.Cells[4].Value.ToString();
            comboBoxMaKH.Text = dataGridViewCTHD.CurrentRow.Cells[5].Value.ToString();
            textBoxHoTen.Text = dataGridViewCTHD.CurrentRow.Cells[6].Value.ToString();
            dateTimePickerBatDau.Value = (DateTime)dataGridViewCTHD.CurrentRow.Cells[7].Value;
            dateTimePickerHetHan.Value = (DateTime)dataGridViewCTHD.CurrentRow.Cells[8].Value;
           textBoxPhi.Text = dataGridViewCTHD.CurrentRow.Cells[9].Value.ToString();
           
        }
    }
}
