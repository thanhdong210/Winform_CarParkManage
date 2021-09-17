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
    public partial class ThemXeHoiForm : Form
    {
        XEHOI xehoi = new XEHOI();
        public ThemXeHoiForm()
        {
            InitializeComponent();
        }

        private void buttonThêm_Click(object sender, EventArgs e)
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

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
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

        private void ThemXeHoiForm_Load(object sender, EventArgs e)
        {

        }
    }
    
}
