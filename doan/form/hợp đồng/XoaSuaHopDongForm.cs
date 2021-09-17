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
    public partial class XoaSuaHopDongForm : Form
    {
        HOPDONG hd = new HOPDONG();
        public XoaSuaHopDongForm()
        {
            InitializeComponent();
        }

        private void XoaSuaHopDongForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM hopdong");
            dataGridViewXoaSuaHD.ReadOnly = true;
            dataGridViewXoaSuaHD.RowTemplate.Height = 30;
            dataGridViewXoaSuaHD.DataSource = hd.getHopDong(command);
            dataGridViewXoaSuaHD.AllowUserToAddRows = false;
        }

        private void buttonRF_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM hopdong");
            dataGridViewXoaSuaHD.ReadOnly = true;
            dataGridViewXoaSuaHD.RowTemplate.Height = 30;
            dataGridViewXoaSuaHD.DataSource = hd.getHopDong(command);
            dataGridViewXoaSuaHD.AllowUserToAddRows = false;
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (textBoxMaHD.Text.Trim() == "")
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
                        int id = Convert.ToInt32(textBoxMaHD.Text);
                        if (hd.DeleteHopDong(id))
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
            if (textBoxMaHD.Text.Trim() == "")
            {
                MessageBox.Show("nhap thong tin", "xoa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = Convert.ToInt32(textBoxMaHD.Text);
                int loaihopdong = 1;
                if (radioButtonLoai2.Checked)
                {
                    loaihopdong = 2;
                }
                if (verif())
                {

                    if (hd.updateHD(id, loaihopdong))
                    {
                        MessageBox.Show("Da sua thanh cong", "Hop Dong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Loi", "Hop Dong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Fields", "Hop Dong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            bool verif()
            {
                if ((textBoxMaHD.Text.Trim() == ""))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }

        private void dataGridViewXoaSuaHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaHD.Text = dataGridViewXoaSuaHD.CurrentRow.Cells[0].Value.ToString();
            if ((dataGridViewXoaSuaHD.CurrentRow.Cells[1].Value.ToString().Trim() == "1"))
            {
                radioButtonLoai2.Checked = false;
                radioButtonLoai1.Checked = true;

            }
            else
            {
                radioButtonLoai2.Checked = true;
                radioButtonLoai1.Checked = false;
            }
        }

        private void radioButtonLoai2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonLoai1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMaHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewXoaSuaHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
