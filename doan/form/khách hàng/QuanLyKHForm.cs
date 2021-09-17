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
    public partial class QuanLyKHForm : Form
    {
        KHACHHANG kh = new KHACHHANG();
        public QuanLyKHForm()
        {
            InitializeComponent();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Trim() == "")
            {
                MessageBox.Show("nhap thong tin", "xoa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = Convert.ToInt32(textBoxID.Text);
                string hoten = textBoxHoTen.Text;
                string gioitinh = "Nu";

                if (radioButtonNam.Checked)
                {
                    gioitinh = "Nam";
                }
                DateTime ngaysinh = dateTimePickerNgaySinh.Value;
                string sdt = textBoxSDT.Text;
                string diachi = textBoxDiaChi.Text;
                int born_year = dateTimePickerNgaySinh.Value.Year;
                int this_year = DateTime.Now.Year;
                //ràng buộc dữ liệu về độ tuổi(ko cho người dùng nhập sai)
                //svv từ 10-100

                if (((this_year - born_year) < 18) || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("Do tuoi phai trong khoang tu 18-100", "Nhap sai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (verif())
                {
                    if (kh.updateKH(id, hoten, gioitinh, ngaysinh, sdt, diachi))
                    {
                        MessageBox.Show("Cap Nhat thanh cong", "Khach Hang", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Loi", "Khach Hang", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Khach Hang", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        bool verif()
        {
            if ((textBoxID.Text.Trim() == "") || (textBoxHoTen.Text.Trim() == "") || (textBoxSDT.Text.Trim() == "") || (textBoxDiaChi.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM khachhang");
            dataGridViewXoaSuaKH.ReadOnly = true;
            dataGridViewXoaSuaKH.RowTemplate.Height = 30;
            dataGridViewXoaSuaKH.DataSource = kh.getKH(command);
            dataGridViewXoaSuaKH.AllowUserToAddRows = false;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Trim() == "")
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
                        int id = Convert.ToInt32(textBoxID.Text);
                        if (kh.DeleteKH(id))
                        {
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
            if (textBoxID.Text.Trim() == "")
            {
                MessageBox.Show("nhap thong tin", "xoa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = Convert.ToInt32(textBoxID.Text);
                string hoten = textBoxHoTen.Text;
                string gioitinh = "Nu";

                if (radioButtonNam.Checked)
                {
                    gioitinh = "Nam";
                }
                DateTime ngaysinh = dateTimePickerNgaySinh.Value;
                string sdt = textBoxSDT.Text;
                string diachi = textBoxDiaChi.Text;
                int born_year = dateTimePickerNgaySinh.Value.Year;
                int this_year = DateTime.Now.Year;
                //ràng buộc dữ liệu về độ tuổi(ko cho người dùng nhập sai)
                //svv từ 10-100

                if (kh.checkMaKH(id) == false)
                {
                    MessageBox.Show("Trung ID", "Them Khach Hang", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (((this_year - born_year) < 18) || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("Do tuoi phai trong khoang tu 18-100", "Nhap sai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (verif())
                {
                    if (kh.insertKH(id, hoten, gioitinh, ngaysinh, sdt, diachi))
                    {
                        MessageBox.Show("Da them thanh cong", "Them Khach Hang", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Loi", "Them Khach Hang", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Them Khach Hang", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ khách hàng không ?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("xoa thanh cong", "xoa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlCommand command = new SqlCommand("DELETE FROM khachhang");
                DataTable table =kh.getKH(command);
            }
        }

        private void QuanLyKHForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM khachhang");
            dataGridViewXoaSuaKH.ReadOnly = true;
            dataGridViewXoaSuaKH.RowTemplate.Height = 30;
            dataGridViewXoaSuaKH.DataSource = kh.getKH(command);
            dataGridViewXoaSuaKH.AllowUserToAddRows = false;
        }

        private void dataGridViewXoaSuaKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewXoaSuaKH.CurrentRow.Cells[0].Value.ToString();
            textBoxHoTen.Text = dataGridViewXoaSuaKH.CurrentRow.Cells[1].Value.ToString();
            if ((dataGridViewXoaSuaKH.CurrentRow.Cells[2].Value.ToString().Trim() == "Nam"))
            {
                radioButtonNu.Checked = false;
                radioButtonNam.Checked = true;

            }
            else
            {
                radioButtonNu.Checked = true;
                radioButtonNam.Checked = false;
            }
            dateTimePickerNgaySinh.Value = (DateTime)dataGridViewXoaSuaKH.CurrentRow.Cells[3].Value;
            textBoxSDT.Text = dataGridViewXoaSuaKH.CurrentRow.Cells[4].Value.ToString();
            textBoxDiaChi.Text = dataGridViewXoaSuaKH.CurrentRow.Cells[5].Value.ToString();
        }
    }
    
}
