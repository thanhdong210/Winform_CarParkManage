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
    public partial class TimXeForm : Form
    {
        XEDAP xedap = new XEDAP();
        XEMAY xemay = new XEMAY();
        XEHOI xehoi = new XEHOI();
        public TimXeForm()
        {
            InitializeComponent();
        }
        private void TimXeForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from xedap");
            dataGridViewTimXe.ReadOnly = true;

            dataGridViewTimXe.RowTemplate.Height = 130;
            dataGridViewTimXe.DataSource = xedap.getXe(command);
            //dataGridViewTimXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
          

            dataGridViewTimXe.AllowUserToAddRows = false;
        }
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (radioButtonXeDap.Checked)
            {
                if ((textBoxID.Text.Trim() == ""))
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM xedap");
                    dataGridViewTimXe.DataSource = xedap.getXe(command);
                }
                else
                {

                    try
                    {
                        string xeid = textBoxID.Text;
                        SqlCommand command = new SqlCommand("SELECT * FROM xedap WHERE xeid LIKE '%" + xeid + "%'");
                        dataGridViewTimXe.DataSource = xedap.getXe(command);
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng", "LOI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else if(radioButtonXeMay.Checked)
            {
                if ((textBoxID.Text.Trim() == ""))
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM xemay");
                    dataGridViewTimXe.DataSource = xemay.getXe(command);
                }
                else
                {

                    try
                    {
                        string xeid = textBoxID.Text;
                        SqlCommand command = new SqlCommand("SELECT * FROM xemay WHERE xeid LIKE '%" + xeid + "%'");
                        dataGridViewTimXe.DataSource = xemay.getXe(command);
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng", "LOI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            else
            {
                if ((textBoxID.Text.Trim() == ""))
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM xehoi");
                    dataGridViewTimXe.DataSource = xehoi.getXe(command);
                }
                else
                {
                    string xeid = textBoxID.Text;
                    SqlCommand command = new SqlCommand("SELECT * FROM xehoi WHERE xeid LIKE '%" + xeid + "%'");
                    dataGridViewTimXe.DataSource = xehoi.getXe(command);
                }
            }    
        }

        private void buttonCheck_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
