using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan
{
    public partial class ThemHopDongForm : Form
    {
        HOPDONG hd = new HOPDONG();
        public ThemHopDongForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int mahd = Convert.ToInt32(textBoxMaHD.Text);
            int loaihopdong = 1;
            if(radioButtonLoai2.Checked)
            {
                loaihopdong = 2;
            }
            if (hd.checkMaHD(mahd) == false)
            {
                MessageBox.Show("Trung Hop Dong", "Hop Dong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
              
                if (hd.inserHopDong(mahd,loaihopdong))
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
