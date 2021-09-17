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
    public partial class XoaSuaXeMayForm : Form
    {
        XEMAY xemay = new XEMAY();
        public XoaSuaXeMayForm()
        {
            InitializeComponent();
        }

        

        private void dataGridViewXoaSuaXeMay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewXoaSuaXeMay.CurrentRow.Cells[0].Value.ToString();
            textBoxChuSoHuu.Text = dataGridViewXoaSuaXeMay.CurrentRow.Cells[1].Value.ToString();
            byte[] pic2;
            pic2 = (byte[])dataGridViewXoaSuaXeMay.CurrentRow.Cells[2].Value;
            MemoryStream picture2 = new MemoryStream(pic2);
            pictureBoxNguoiGui.Image = Image.FromStream(picture2);
            textBoxBangSoXe.Text = dataGridViewXoaSuaXeMay.CurrentRow.Cells[3].Value.ToString();
           
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

        private void XoaSuaXeMayForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from xemay");
            dataGridViewXoaSuaXeMay.ReadOnly = true;

            dataGridViewXoaSuaXeMay.RowTemplate.Height = 130;
            dataGridViewXoaSuaXeMay.DataSource = xemay.getXe(command);
            dataGridViewXoaSuaXeMay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewXoaSuaXeMay.AllowUserToAddRows = false;
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
                        if (xemay.DeleteXeMay(chiSo))
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
            MemoryStream hinhnguoigui = new MemoryStream();

            if (verif())
            {
                try
                {

                   
                    pictureBoxNguoiGui.Image.Save(hinhnguoigui, pictureBoxNguoiGui.Image.RawFormat);
                    if (xemay.updateXeMay(id,chusohuu,hinhnguoigui,bangsoxe))
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
                if ((textBoxChuSoHuu.Text.Trim() == "") || (textBoxBangSoXe.Text.Trim() == "") || (pictureBoxNguoiGui.Image == null))
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
            SqlCommand command = new SqlCommand("SELECT * FROM xemay");
            dataGridViewXoaSuaXeMay.ReadOnly = true;
            DataGridViewImageColumn picCol1 = new DataGridViewImageColumn();

            dataGridViewXoaSuaXeMay.RowTemplate.Height = 80;
            dataGridViewXoaSuaXeMay.DataSource = xemay.getXe(command);
            picCol1 = (DataGridViewImageColumn)dataGridViewXoaSuaXeMay.Columns[2];
            picCol1.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridViewXoaSuaXeMay.AllowUserToAddRows = false;
        }

        private void dataGridViewXoaSuaXeMay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButtonChuaThue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonThue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBangSoXe_TextChanged(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxNguoiGui_Click(object sender, EventArgs e)
        {

        }
    }
}
