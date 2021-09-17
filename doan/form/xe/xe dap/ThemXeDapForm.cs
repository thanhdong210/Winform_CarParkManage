using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan
{
    public partial class ThemXeDapForm : Form
    {
        public ThemXeDapForm()
        {
            InitializeComponent();
        }

        private void buttonThêm_Click(object sender, EventArgs e)
        {
            XEDAP xedap = new XEDAP();
            string id = textBoxID.Text;
            string chusohuu = textBoxChuSoHuu.Text;
           

            MemoryStream hinhxe = new MemoryStream();
            MemoryStream hinhnguoigui = new MemoryStream();
            if(xedap.checkID(id)==false)
            {
                MessageBox.Show("Trung ID", "them Xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else if (verif())
            {
                pictureBoxHinhXe.Image.Save(hinhxe, pictureBoxHinhXe.Image.RawFormat);
                pictureBoxNguoiGui.Image.Save(hinhnguoigui, pictureBoxNguoiGui.Image.RawFormat);
                if (xedap.insertXeDap(id,chusohuu,hinhxe,hinhnguoigui))
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
            if ((textBoxID.Text.Trim() == "") || (textBoxChuSoHuu.Text.Trim() == "") || (pictureBoxHinhXe.Image == null)||(pictureBoxNguoiGui.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxHinhXe_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxNguoiGui_Click(object sender, EventArgs e)
        {

        }
    }
}
