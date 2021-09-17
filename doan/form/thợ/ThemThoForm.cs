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
    public partial class ThemThoForm : Form
    {
        THO tho = new THO();
        public ThemThoForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ThemThoForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int matho =Convert.ToInt32(textBoxID.Text);
            string tentho = textBoxTenTho.Text;
            string gioitinh = "Nu";

            if (radioButtonNam.Checked)
            {
                gioitinh ="Nam";
            }
            DateTime ngaysinh = dateTimePickerNgaysinh.Value;
            string sdt = textBoxSDT.Text;
            int born_year = dateTimePickerNgaysinh.Value.Year;
            int this_year = DateTime.Now.Year;
            //ràng buộc dữ liệu về độ tuổi(ko cho người dùng nhập sai)
            //svv từ 10-100
            
            if(tho.checkMaTho(matho) == false)
            {
                MessageBox.Show("Trung Tho", "Them Tho", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (((this_year - born_year) < 18) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("Do tuoi phai trong khoang tu 18-100", "Nhap sai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif())
            {
                if (tho.insertTho(matho,tentho,gioitinh,ngaysinh,sdt))
                {
                    MessageBox.Show("Da them thanh cong", "Them Tho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Loi", "Them Tho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Them Tho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((textBoxID.Text.Trim() == "") || (textBoxTenTho.Text.Trim() == "") || (textBoxSDT.Text.Trim() == ""))
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
