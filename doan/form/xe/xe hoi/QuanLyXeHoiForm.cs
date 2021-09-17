using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan
{
    public partial class QuanLyXeHoiForm : Form
    {
        XEHOI xehoi = new XEHOI();
        public QuanLyXeHoiForm()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM xehoi WHERE chusohuu LIKE '%" + textBoxSearch.Text + "%'");
            dataGridViewQuanLyXeHoi.ReadOnly = true;
            DataGridViewImageColumn picCol1 = new DataGridViewImageColumn();
            dataGridViewQuanLyXeHoi.RowTemplate.Height = 80;
            dataGridViewQuanLyXeHoi.DataSource = xehoi.getXe(command);
            picCol1 = (DataGridViewImageColumn)dataGridViewQuanLyXeHoi.Columns[3];
            picCol1.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridViewQuanLyXeHoi.AllowUserToAddRows = false;
        }
        private void QuanLyXeHoiForm_Load(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("select * from xehoi");
            dataGridViewQuanLyXeHoi.ReadOnly = true;

            dataGridViewQuanLyXeHoi.RowTemplate.Height = 130;
            dataGridViewQuanLyXeHoi.DataSource = xehoi.getXe(command);
            dataGridViewQuanLyXeHoi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewQuanLyXeHoi.AllowUserToAddRows = false;
            labelTongXe.Text = ("Total Students: " + dataGridViewQuanLyXeHoi.Rows.Count);

        }

        private void dataGridViewQuanLyXeHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewQuanLyXeHoi.CurrentRow.Cells[0].Value.ToString();
            textBoxChuSoHuu.Text = dataGridViewQuanLyXeHoi.CurrentRow.Cells[1].Value.ToString();
            byte[] pic2;
            pic2 = (byte[])dataGridViewQuanLyXeHoi.CurrentRow.Cells[3].Value;
            MemoryStream picture2 = new MemoryStream(pic2);
            pictureBoxHieuXe.Image = Image.FromStream(picture2);
            textBoxBangSoXe.Text = dataGridViewQuanLyXeHoi.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM xehoi");
            dataGridViewQuanLyXeHoi.ReadOnly = true;
            DataGridViewImageColumn picCol1 = new DataGridViewImageColumn();

            dataGridViewQuanLyXeHoi.RowTemplate.Height = 80;
            dataGridViewQuanLyXeHoi.DataSource = xehoi.getXe(command);
            picCol1 = (DataGridViewImageColumn)dataGridViewQuanLyXeHoi.Columns[3];
            picCol1.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridViewQuanLyXeHoi.AllowUserToAddRows = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        { 
            string id = textBoxID.Text;
            string chusohuu = textBoxChuSoHuu.Text;
            string bangsoxe = textBoxBangSoXe.Text;


            MemoryStream hieuxe = new MemoryStream();
            if (xehoi.checkID(id) == false)
            {
                MessageBox.Show("Trung ID", "them Xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                pictureBoxHieuXe.Image.Save(hieuxe, pictureBoxHieuXe.Image.RawFormat);
                if (xehoi.insertXeHoi(id, chusohuu, bangsoxe, hieuxe))
                {
                    MessageBox.Show("Da them thanh cong", "Them Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Loi", "them Xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "them Xe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((textBoxID.Text.Trim() == "") || (textBoxChuSoHuu.Text.Trim() == "") || (textBoxBangSoXe.Text.Trim() == "") || (pictureBoxHieuXe.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
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
                        string chiSo = textBoxID.Text;
                        if (xehoi.DeleteXeHoi(chiSo))
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
            string bangsoxe = textBoxBangSoXe.Text;
            MemoryStream hieuxe = new MemoryStream();

            if (verif())
            {
                try
                {


                    pictureBoxHieuXe.Image.Save(hieuxe, pictureBoxHieuXe.Image.RawFormat);
                    if (xehoi.updateXeHoi(id, chusohuu, hieuxe, bangsoxe))
                    {
                        MessageBox.Show("Da cap nhat thanh cong", "Sua Xe May", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Sua Xe May", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sua Xe May", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Sua Xe May", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            bool verif()
            {
                if ((textBoxChuSoHuu.Text.Trim() == "") || (textBoxBangSoXe.Text.Trim() == "") || (pictureBoxHieuXe.Image == null))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ xe không ?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("xoa thanh cong", "xoa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlCommand command = new SqlCommand("DELETE FROM xehoi");
                DataTable table = xehoi.getXe(command);
            }
        }

        private void buttonDownloadHieuXe_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("xedap_" + textBoxID.Text);
            if (pictureBoxHieuXe.Image == null)
            {
                MessageBox.Show("No Image In The PictureBox");
            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxHieuXe.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }

        private void buttonUploadHieuXe_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofp = new OpenFileDialog();
            ofp.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((ofp.ShowDialog() == DialogResult.OK))
            {
                pictureBoxHieuXe.Image = Image.FromFile(ofp.FileName);
            }
        }
    }
    
}
