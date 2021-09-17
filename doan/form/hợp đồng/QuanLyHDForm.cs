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
    public partial class QuanLyHDForm : Form
    {
        HOPDONG hd = new HOPDONG();
        public QuanLyHDForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int mahd = Convert.ToInt32(textBoxMaHD.Text);
            int loaihopdong = 1;
            if (radioButtonLoai2.Checked)
            {
                loaihopdong = 2;
            }
            if (hd.checkMaHD(mahd) == false)
            {
                MessageBox.Show("Trung Hop Dong", "Hop Dong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {

                if (hd.inserHopDong(mahd, loaihopdong))
                {
                    MessageBox.Show("Da them thanh cong", "Hop Dong", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ hợp đồng không ?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("xoa thanh cong", "xoa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlCommand command = new SqlCommand("DELETE FROM hopdong");
                DataTable table = hd.getHopDong(command);
            }
        }

        private void buttonRF_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM hopdong");
            dataGridViewQuanLyHD.ReadOnly = true;
            dataGridViewQuanLyHD.RowTemplate.Height = 30;
            dataGridViewQuanLyHD.DataSource = hd.getHopDong(command);
            dataGridViewQuanLyHD.AllowUserToAddRows = false;
        }

        private void QuanLyHDForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM hopdong");
            dataGridViewQuanLyHD.ReadOnly = true;
            dataGridViewQuanLyHD.RowTemplate.Height = 30;
            dataGridViewQuanLyHD.DataSource = hd.getHopDong(command);
            dataGridViewQuanLyHD.AllowUserToAddRows = false;
        }

        private void dataGridViewXoaSuaHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaHD.Text = dataGridViewQuanLyHD.CurrentRow.Cells[0].Value.ToString();
            if ((dataGridViewQuanLyHD.CurrentRow.Cells[1].Value.ToString().Trim() == "1"))
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

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int dong = dataGridViewQuanLyHD.CurrentRow.Index;
            int mahd =Convert.ToInt32(dataGridViewQuanLyHD.Rows[dong].Cells[0].Value.ToString());
            int loaihopdong =Convert.ToInt32(dataGridViewQuanLyHD.Rows[dong].Cells[1].Value.ToString());
            XemCTHD ls = new XemCTHD(mahd,loaihopdong);
            ls.Show();
        }
    }
    
}
