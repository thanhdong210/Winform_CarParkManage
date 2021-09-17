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
    public partial class QuanLyCVForm : Form
    {
        CONGVIEC cv = new CONGVIEC();
        public QuanLyCVForm()
        {
            InitializeComponent();
        }
        private void QuanLyCVForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM congviec");
            dataGridViewQuanLyCV.ReadOnly = true;
            dataGridViewQuanLyCV.RowTemplate.Height = 50;
            dataGridViewQuanLyCV.DataSource = cv.getCV(command);
            dataGridViewQuanLyCV.AllowUserToAddRows = false;
            labelTotal.Text = ("Tổng công viêc: " + dataGridViewQuanLyCV.Rows.Count);
        }
        private void dataGridViewQuanLyCV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewQuanLyCV.CurrentRow.Cells[0].Value.ToString();
            textBoxChuSoHuu.Text = dataGridViewQuanLyCV.CurrentRow.Cells[1].Value.ToString();
            textBoxLoaiCV.Text = dataGridViewQuanLyCV.CurrentRow.Cells[2].Value.ToString();
            textBoxMaTho.Text = dataGridViewQuanLyCV.CurrentRow.Cells[3].Value.ToString();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string chusohuu = textBoxChuSoHuu.Text;
            string loaicv = textBoxLoaiCV.Text;
            int matho = Convert.ToInt32(textBoxMaTho.Text.ToString());
            if (cv.checkMaTho(matho) == false)
            {
                MessageBox.Show("Trung Tho", "Them Cong Viec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                if (cv.insertCV(id, chusohuu, loaicv, matho))
                {
                    MessageBox.Show("Da them thanh cong", "Them Cong Viec", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Loi", "Them Cong Viec", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Them Cong Viec", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("Empty Fields", "Sua Cong Viec", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Trim() == "" || (textBoxMaTho.Text.Trim() == ""))
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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ công việc không ?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("xoa thanh cong", "xoa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlCommand command = new SqlCommand("DELETE FROM congviec");
                DataTable table = cv.getCV(command);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM congviec");
            dataGridViewQuanLyCV.ReadOnly = true;
            dataGridViewQuanLyCV.RowTemplate.Height = 50;
            dataGridViewQuanLyCV.DataSource = cv.getCV(command);
            dataGridViewQuanLyCV.AllowUserToAddRows = false;
        }
    }
}
