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
    public partial class CVcuaThoForm : Form
    {
        THO tho = new THO();
        CONGVIEC cv = new CONGVIEC();
        private int ma;
        private string ten;
        public CVcuaThoForm()
        {
            InitializeComponent();
        }
        public CVcuaThoForm(int ma, string ten)
        {
            InitializeComponent();
            this.ma = ma;
            this.ten = ten;
        }

        private void CVcuaThoForm_Load(object sender, EventArgs e)
        {
            textBoxID.Text = ma.ToString();

            textBoxHoTen.Text = ten;
            int matho = Convert.ToInt32(textBoxID.Text);

            //bang muon
            SqlCommand command = new SqlCommand("SELECT xeid,chusohuu,loaicv FROM congviec WHERE matho=" + matho);
            dataGridViewCV.ReadOnly = true;
            dataGridViewCV.RowTemplate.Height = 30;
            dataGridViewCV.DataSource = cv.getCV(command);

            dataGridViewCV.AllowUserToAddRows = false;
        }
    }
}
