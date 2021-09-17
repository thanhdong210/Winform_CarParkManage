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
    public partial class XoaSuaThoForm : Form
    {
        THO tho = new THO();
        public XoaSuaThoForm()
        {
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM tho");
            dataGridViewXoaSuaTho.ReadOnly = true;
            dataGridViewXoaSuaTho.RowTemplate.Height = 30;
            dataGridViewXoaSuaTho.DataSource = tho.getTho(command);
            dataGridViewXoaSuaTho.AllowUserToAddRows = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
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
                        int matho = Convert.ToInt32(textBoxID.Text);
                        if (tho.DeleteTho(matho))
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Trim() == "")
            {
                MessageBox.Show("nhap thong tin", "xoa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int matho = Convert.ToInt32(textBoxID.Text);
                string tentho = textBoxTenTho.Text;
                string gioitinh = "Nam";

                if (radioButtonNu.Checked)
                {
                    gioitinh = "Nu";
                }
                DateTime ngaysinh = dateTimePickerNgaysinh.Value;
                string sdt = textBoxSDT.Text;
                int born_year = dateTimePickerNgaysinh.Value.Year;
                int this_year = DateTime.Now.Year;
                //ràng buộc dữ liệu về độ tuổi(ko cho người dùng nhập sai)
                //svv từ 10-100

               if (((this_year - born_year) < 18) || ((this_year - born_year) > 100))
                {
                    MessageBox.Show("Do tuoi phai trong khoang tu 18-100", "Nhap sai", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (verif())
                {
                    if (tho.updateTho(matho, tentho, gioitinh, ngaysinh, sdt))
                    {
                        MessageBox.Show("Da sua thanh cong", "Sua Tho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Loi", "Them Tho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Sua Tho", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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

        private void XoaSuaThoForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM tho");
            dataGridViewXoaSuaTho.ReadOnly = true;
            dataGridViewXoaSuaTho.RowTemplate.Height = 30;
            dataGridViewXoaSuaTho.DataSource = tho.getTho(command);
            dataGridViewXoaSuaTho.AllowUserToAddRows = false;
        }

        private void dataGridViewXoaSuaTho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewXoaSuaTho.CurrentRow.Cells[0].Value.ToString();
            textBoxTenTho.Text = dataGridViewXoaSuaTho.CurrentRow.Cells[1].Value.ToString();
            if ((dataGridViewXoaSuaTho.CurrentRow.Cells[2].Value.ToString().Trim() == "Nam"))
            {
                radioButtonNu.Checked= false;
                radioButtonNam.Checked = true;
                
            }
            else 
            {
                radioButtonNu.Checked = true;
                radioButtonNam.Checked = false;
            }
            dateTimePickerNgaysinh.Value= (DateTime)dataGridViewXoaSuaTho.CurrentRow.Cells[3].Value;
            textBoxSDT.Text = dataGridViewXoaSuaTho.CurrentRow.Cells[4].Value.ToString();
        }
    }
    
}
