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
    public partial class XoaSuaCVForm : Form
    {
        CONGVIEC cv = new CONGVIEC();
        public XoaSuaCVForm()
        {
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM congviec");
            dataGridViewXoaSuaCV.ReadOnly = true;
            dataGridViewXoaSuaCV.RowTemplate.Height = 50;
            dataGridViewXoaSuaCV.DataSource = cv.getCV(command);
            dataGridViewXoaSuaCV.AllowUserToAddRows = false;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Trim() == ""||(textBoxMaTho.Text.Trim()==""))
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
                        string chiSo = textBoxID.Text;
                        int matho = Convert.ToInt32(textBoxMaTho.Text.ToString());
                        if (cv.DeleteCV(chiSo, matho))
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
            string id = textBoxID.Text;
            string chusohuu = textBoxChuSoHuu.Text;
            string loaicv = textBoxLoaiCV.Text;
            int matho = Convert.ToInt32(textBoxMaTho.Text.ToString());
            if (verif())
            {
                if (cv.updateCV(id, chusohuu, loaicv, matho))
                {
                    MessageBox.Show("Da sua thanh cong", "Sua Cong Viec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Loi", " Cong Viec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Them Cong Viec", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((textBoxID.Text.Trim() == "") || (textBoxChuSoHuu.Text.Trim() == "") || (textBoxMaTho.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void XoaSuaCVForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM congviec");
            dataGridViewXoaSuaCV.ReadOnly = true;
            dataGridViewXoaSuaCV.RowTemplate.Height = 50;
            dataGridViewXoaSuaCV.DataSource = cv.getCV(command);
            dataGridViewXoaSuaCV.AllowUserToAddRows = false;
        }

        private void dataGridViewXoaSuaCV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewXoaSuaCV.CurrentRow.Cells[0].Value.ToString();
            textBoxChuSoHuu.Text = dataGridViewXoaSuaCV.CurrentRow.Cells[1].Value.ToString();
            textBoxLoaiCV.Text = dataGridViewXoaSuaCV.CurrentRow.Cells[2].Value.ToString();
            textBoxMaTho.Text = dataGridViewXoaSuaCV.CurrentRow.Cells[3].Value.ToString();
        }
    }
    
}
