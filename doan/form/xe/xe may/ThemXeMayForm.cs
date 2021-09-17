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
    public partial class ThemXeMayForm : Form
    {
        public ThemXeMayForm()
        {
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonThêm_Click(object sender, EventArgs e)
        {
            XEMAY xemay = new XEMAY();
            string id = textBoxID.Text;
            string chusohuu = textBoxChuSoHuu.Text;
            string bangsoxe = textBoxBangSoXe.Text;
            
            MemoryStream hinhnguoigui = new MemoryStream();
            if (xemay.checkID(id) == false)
            {
                MessageBox.Show("Trung ID", "them Xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
             else if (verif())
            {
                
                pictureBoxNguoiGui.Image.Save(hinhnguoigui, pictureBoxNguoiGui.Image.RawFormat);
                
                if (xemay.insertXeMay(id, chusohuu, hinhnguoigui,bangsoxe))
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
            if ((textBoxID.Text.Trim() == "") || (textBoxChuSoHuu.Text.Trim() == "") || (textBoxBangSoXe.Text.Trim() == "") || (pictureBoxNguoiGui.Image == null))
            {
                return false;
            }
            else
            {
                return true;
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

        
    }
}
