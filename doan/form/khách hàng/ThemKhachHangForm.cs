using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan
{
    public partial class ThemKhachHangForm : Form
    {
        KHACHHANG kh = new KHACHHANG();
        public ThemKhachHangForm()
        {
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
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
        bool verif()
        {
            if ((textBoxID.Text.Trim() == "") || (textBoxHoTen.Text.Trim() == "") || (textBoxSDT.Text.Trim() == "")|| (textBoxDiaChi.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    
}
