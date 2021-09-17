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
    public partial class ThemCVForm : Form
    {
        CONGVIEC cv = new CONGVIEC();
        public ThemCVForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string chusohuu = textBoxChuSoHuu.Text;
            string loaicv = comboBoxLoaiCongViec.Text;
            int matho = Convert.ToInt32(textBoxMaTho.Text.ToString());
            /*if (cv.checkMaTho(matho) == false)
            {
                MessageBox.Show("Trung Tho", "Them Cong Viec", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else */if (verif())
            {
                if (cv.insertCV(id,chusohuu,loaicv,matho))
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
        }
        bool verif()
        {
            if ((textBoxID.Text.Trim() == "") || (textBoxChuSoHuu.Text.Trim() == "")||(textBoxMaTho.Text.Trim()=="") )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ThemCVForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from tho");
            dataGridViewTho.ReadOnly = true;

            dataGridViewTho.RowTemplate.Height = 20;
            dataGridViewTho.DataSource = cv.getCV(command);
            //dataGridViewTho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            dataGridViewTho.AllowUserToAddRows = false;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonXeDap_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select xeid,chusohuu from xedap");
            dataGridViewThongTinXe.ReadOnly = true;

            dataGridViewThongTinXe.RowTemplate.Height = 20;
            dataGridViewThongTinXe.DataSource = cv.getCV(command);
        }

        private void buttonXeMay_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select xeid,chusohuu from xemay");
            dataGridViewThongTinXe.ReadOnly = true;

            dataGridViewThongTinXe.RowTemplate.Height = 20;
            dataGridViewThongTinXe.DataSource = cv.getCV(command);
        }

        private void buttonXeHoi_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select xeid,chusohuu from xehoi");
            dataGridViewThongTinXe.ReadOnly = true;

            dataGridViewThongTinXe.RowTemplate.Height = 20;
            dataGridViewThongTinXe.DataSource = cv.getCV(command);
        }

        private void dataGridViewThongTinXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewThongTinXe.CurrentRow.Cells[0].Value.ToString();
            textBoxChuSoHuu.Text = dataGridViewThongTinXe.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
