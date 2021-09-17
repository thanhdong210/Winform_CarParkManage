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
    public partial class CTHDForm : Form
    {
        CTHD cthd = new CTHD();
        public CTHDForm()
        {
            InitializeComponent();
        }

        private void CTHDForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM CTHD");
            dataGridViewCTHD.ReadOnly = true;
            dataGridViewCTHD.RowTemplate.Height = 30;
            dataGridViewCTHD.DataSource = cthd.getCTHD(command);
            dataGridViewCTHD.AllowUserToAddRows = false;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            DateTime end = dateTimePicker1.Value;
            if (radioButtonBienSoXe.Checked)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM CTHD WHERE biensoxe LIKE '%" + textBox1.Text + "%'");
                dataGridViewCTHD.DataSource = cthd.getCTHD(command);
            }
            else
            {
                SqlCommand command = new SqlCommand("SELECT * from CTHD where ngaybatdau=@end ");
                
                command.Parameters.Add("@end", SqlDbType.DateTime).Value = end;
                dataGridViewCTHD.DataSource = cthd.getCTHD(command);
            }
        }
    }
}
