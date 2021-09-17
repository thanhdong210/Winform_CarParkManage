using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan
{
    public partial class XoaSuaXeDapForm : Form
    {
        XEDAP xedap = new XEDAP();
        public XoaSuaXeDapForm()
        {
            InitializeComponent();
        }
        private void XoaSuaXeDapForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from xedap");
            dataGridViewXoaSuaXeDap.ReadOnly = true;

            dataGridViewXoaSuaXeDap.RowTemplate.Height = 130;
            dataGridViewXoaSuaXeDap.DataSource = xedap.getXe(command);
            dataGridViewXoaSuaXeDap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            dataGridViewXoaSuaXeDap.AllowUserToAddRows = false;
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

        private void dataGridViewXoaSuaXeDap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewXoaSuaXeDap.CurrentRow.Cells[0].Value.ToString();
            textBoxChuSoHuu.Text = dataGridViewXoaSuaXeDap.CurrentRow.Cells[1].Value.ToString();
        
            byte[] pic1;
            pic1 = (byte[])dataGridViewXoaSuaXeDap.CurrentRow.Cells[2].Value;
            MemoryStream picture = new MemoryStream(pic1);
            pictureBoxHinhXe.Image = Image.FromStream(picture);
            byte[] pic2;
            pic2 = (byte[])dataGridViewXoaSuaXeDap.CurrentRow.Cells[3].Value;
            MemoryStream picture2 = new MemoryStream(pic2);
            pictureBoxNguoiGui.Image = Image.FromStream(picture2);
           
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
            string id=textBoxID.Text;
            string chusohuu = textBoxChuSoHuu.Text;
            
            MemoryStream hinhxe = new MemoryStream();
            MemoryStream hinhnguoigui = new MemoryStream();

            if (verif())
            {
                try
                {

                    pictureBoxHinhXe.Image.Save(hinhxe, pictureBoxHinhXe.Image.RawFormat);
                    pictureBoxNguoiGui.Image.Save(hinhnguoigui, pictureBoxNguoiGui.Image.RawFormat);
                    if (xedap.updateXeDap(id,chusohuu,hinhxe,hinhnguoigui))
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
                if ((textBoxChuSoHuu.Text.Trim() == "") || (pictureBoxHinhXe.Image == null)|| (pictureBoxNguoiGui.Image == null))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM xedap");
            dataGridViewXoaSuaXeDap.ReadOnly = true;
            DataGridViewImageColumn picCol1 = new DataGridViewImageColumn();
            DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
            dataGridViewXoaSuaXeDap.RowTemplate.Height = 80;
            dataGridViewXoaSuaXeDap.DataSource = xedap.getXe(command);
            picCol1 = (DataGridViewImageColumn)dataGridViewXoaSuaXeDap.Columns[2];
            picCol1.ImageLayout = DataGridViewImageCellLayout.Stretch;
            picCol2 = (DataGridViewImageColumn)dataGridViewXoaSuaXeDap.Columns[3];
            picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridViewXoaSuaXeDap.AllowUserToAddRows = false;
        }

        private void dataGridViewXoaSuaXeDap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBoxHinhXe_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxNguoiGui_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonChuaThue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonThue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxChuSoHuu_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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
    }
}
