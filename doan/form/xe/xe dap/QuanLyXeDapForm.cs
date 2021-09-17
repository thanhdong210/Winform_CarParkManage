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
    public partial class QuanLyXeDapForm : Form
    {
        XEDAP xedap = new XEDAP();
        public QuanLyXeDapForm()
        {
            InitializeComponent();
        }

        private void QuanLyXeDapForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from xedap");
            dataGridViewQuanLyXeDap.ReadOnly = true;

            dataGridViewQuanLyXeDap.RowTemplate.Height = 130;
            dataGridViewQuanLyXeDap.DataSource = xedap.getXe(command);
            dataGridViewQuanLyXeDap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            dataGridViewQuanLyXeDap.AllowUserToAddRows = false;
            labelTongXe.Text = ("Total Students: " + dataGridViewQuanLyXeDap.Rows.Count);
        }
        private void dataGridViewQuanLyXeDap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewQuanLyXeDap.CurrentRow.Cells[0].Value.ToString();
            textBoxChuSoHuu.Text = dataGridViewQuanLyXeDap.CurrentRow.Cells[1].Value.ToString();

            byte[] pic1;
            pic1 = (byte[])dataGridViewQuanLyXeDap.CurrentRow.Cells[2].Value;
            MemoryStream picture = new MemoryStream(pic1);
            pictureBoxHinhXe.Image = Image.FromStream(picture);
            byte[] pic2;
            pic2 = (byte[])dataGridViewQuanLyXeDap.CurrentRow.Cells[3].Value;
            MemoryStream picture2 = new MemoryStream(pic2);
            pictureBoxNguoiGui.Image = Image.FromStream(picture2);
           
        }

        private void buttonUploadHinhXe_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofp = new OpenFileDialog();
            ofp.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((ofp.ShowDialog() == DialogResult.OK))
            {
                pictureBoxHinhXe.Image = Image.FromFile(ofp.FileName);
            }
        }

        private void buttonUploadNguoiGui_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofp = new OpenFileDialog();
            ofp.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if ((ofp.ShowDialog() == DialogResult.OK))
            {
                pictureBoxNguoiGui.Image = Image.FromFile(ofp.FileName);
            }
        }

        private void buttonDownloadXe_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("xedap_" + textBoxID.Text);
            if (pictureBoxHinhXe.Image == null)
            {
                MessageBox.Show("No Image In The PictureBox");
            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxHinhXe.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }

        private void buttonDownloadNguoiGui_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("xedap_" + textBoxID.Text);
            if (pictureBoxNguoiGui.Image == null)
            {
                MessageBox.Show("No Image In The PictureBox");
            }
            else if ((svf.ShowDialog() == DialogResult.OK))
            {
                pictureBoxNguoiGui.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM xedap WHERE chusohuu LIKE '%" + textBoxSearch.Text + "%'");
            dataGridViewQuanLyXeDap.ReadOnly = true;

            DataGridViewImageColumn picCol1 = new DataGridViewImageColumn();
            DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
            dataGridViewQuanLyXeDap.RowTemplate.Height = 80;
            dataGridViewQuanLyXeDap.DataSource = xedap.getXe(command);
            picCol1 = (DataGridViewImageColumn)dataGridViewQuanLyXeDap.Columns[2];
            picCol1.ImageLayout = DataGridViewImageCellLayout.Stretch;
            picCol2 = (DataGridViewImageColumn)dataGridViewQuanLyXeDap.Columns[3];
            picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewQuanLyXeDap.AllowUserToAddRows = false;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM xedap");
            dataGridViewQuanLyXeDap.ReadOnly = true;
            DataGridViewImageColumn picCol1 = new DataGridViewImageColumn();
            DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
            dataGridViewQuanLyXeDap.RowTemplate.Height = 80;
            dataGridViewQuanLyXeDap.DataSource = xedap.getXe(command);
            picCol1 = (DataGridViewImageColumn)dataGridViewQuanLyXeDap.Columns[2];
            picCol1.ImageLayout = DataGridViewImageCellLayout.Stretch;
            picCol2 = (DataGridViewImageColumn)dataGridViewQuanLyXeDap.Columns[3];
            picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewQuanLyXeDap.AllowUserToAddRows = false;
            dataGridViewQuanLyXeDap.Text = ("Total Students: " + dataGridViewQuanLyXeDap.Rows.Count);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ xe không ?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("xoa thanh cong", "xoa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlCommand command = new SqlCommand("DELETE FROM xedap");
                DataTable table = xedap.getXe(command);
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
                        if (xedap.DeleteXeDap(chiSo))
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
           
            MemoryStream hinhxe = new MemoryStream();
            MemoryStream hinhnguoigui = new MemoryStream();

            if (verif())
            {
                try
                {

                    pictureBoxHinhXe.Image.Save(hinhxe, pictureBoxHinhXe.Image.RawFormat);
                    pictureBoxNguoiGui.Image.Save(hinhnguoigui, pictureBoxNguoiGui.Image.RawFormat);
                    if (xedap.updateXeDap(id, chusohuu, hinhxe, hinhnguoigui))
                    {
                        MessageBox.Show("Da cap nhat thanh cong", "Sua Xe Dap", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Sua Xe Dap", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sua Xe Dap", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Sua Xe Dap", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            bool verif()
            {
                if ((textBoxChuSoHuu.Text.Trim() == "") || (pictureBoxHinhXe.Image == null) || (pictureBoxNguoiGui.Image == null))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string chusohuu = textBoxChuSoHuu.Text;


            MemoryStream hinhxe = new MemoryStream();
            MemoryStream hinhnguoigui = new MemoryStream();
            if (xedap.checkID(id) == false)
            {
                MessageBox.Show("Trung ID", "them Xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(verif())
            {
                pictureBoxHinhXe.Image.Save(hinhxe, pictureBoxHinhXe.Image.RawFormat);
                pictureBoxNguoiGui.Image.Save(hinhnguoigui, pictureBoxNguoiGui.Image.RawFormat);
                if (xedap.insertXeDap(id, chusohuu, hinhxe, hinhnguoigui))
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
            if ((textBoxID.Text.Trim() == "") || (textBoxChuSoHuu.Text.Trim() == "") || (pictureBoxHinhXe.Image == null) || (pictureBoxNguoiGui.Image == null))
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
