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
    public partial class ThanhToanForm : Form
    {
        THANHTOAN thanhtoan = new THANHTOAN();
        public ThanhToanForm()
        {
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DongPhatForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT xeid,chusohuu,tongtien,ngaytra FROM phi");
            dataGridViewThanhToan.ReadOnly = true;
            dataGridViewThanhToan.RowTemplate.Height = 30;
            dataGridViewThanhToan.DataSource = thanhtoan.getDT(command);
            dataGridViewThanhToan.AllowUserToAddRows = false;
        }

        private void dataGridViewThanhToan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewThanhToan.CurrentRow.Cells[0].Value.ToString();
            textBoxChuSoHuu.Text = dataGridViewThanhToan.CurrentRow.Cells[1].Value.ToString();
            textBoxTienPhaiTra.Text = dataGridViewThanhToan.CurrentRow.Cells[2].Value.ToString();
            dateTimePickerNgayTra.Value = (DateTime)dataGridViewThanhToan.CurrentRow.Cells[3].Value;
            
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string chusohuu = textBoxChuSoHuu.Text;
            DateTime ngaytra = Convert.ToDateTime(dateTimePickerNgayTra.Value.ToString());
            double tienphaitra = Convert.ToDouble(textBoxTienPhaiTra.Text);
           
            if (verif())
            {
                if (thanhtoan.insertThanhToan(id, chusohuu, ngaytra, tienphaitra))
                    {
                        thanhtoan.DeleteThanhToanThanhCong(id);
                        MessageBox.Show("Da Thanh toan", "Thanh toan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Loi", "Thanh toan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }
            else
            {
                MessageBox.Show("Empty Fields", "Thanh toan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((textBoxID.Text.Trim() == "") || (textBoxChuSoHuu.Text.Trim() == "") || (textBoxTienPhaiTra.Text.Trim() == "") )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT xeid,chusohuu,tongtien,ngaytra FROM phi");
            dataGridViewThanhToan.ReadOnly = true;
            dataGridViewThanhToan.RowTemplate.Height = 30;
            dataGridViewThanhToan.DataSource = thanhtoan.getDT(command);
            dataGridViewThanhToan.AllowUserToAddRows = false;
        }
    }
    
}
