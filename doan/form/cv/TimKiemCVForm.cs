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
    public partial class TimKiemCVForm : Form
    {
        CONGVIEC cv = new CONGVIEC();
        public TimKiemCVForm()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (radioButtonTenCV.Checked)
            {
                if ((textBoxTimKiem.Text.Trim() == ""))
                {
                    SqlCommand command = new SqlCommand("select A.xeid,A.chusohuu,A.loaicv,A.matho,B.tentho from congviec A,tho B where A.matho=B.matho");
                    dataGridViewTimCV.DataSource = cv.getCV(command);
                }
                else
                {

                    try
                    {
                        string ten = textBoxTimKiem.Text;
                        SqlCommand command = new SqlCommand("select A.xeid,A.chusohuu,A.loaicv,A.matho,B.tentho from congviec A,tho B where A.matho=B.matho AND A.loaicv LIKE '%" + ten + "%'");
                        dataGridViewTimCV.DataSource = cv.getCV(command);
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng", "LOI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            { 
                if ((textBoxTimKiem.Text.Trim() == ""))
                {
                    SqlCommand command = new SqlCommand("select A.xeid,A.chusohuu,A.loaicv,A.matho,B.tentho from congviec A,tho B where A.matho=B.matho");
                    dataGridViewTimCV.DataSource = cv.getCV(command);
                }
                else
                {
                    string xeid = textBoxTimKiem.Text;
                    SqlCommand command = new SqlCommand("select A.xeid,A.chusohuu,A.loaicv,A.matho,B.tentho from congviec A,tho B where A.matho=B.matho AND A.xeid='"+xeid +"'");
                    dataGridViewTimCV.DataSource = cv.getCV(command);
                }

            }
        }

        private void TimKiemCVForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select A.xeid,A.chusohuu,A.loaicv,A.matho,B.tentho from congviec A,tho B where A.matho=B.matho");
            dataGridViewTimCV.ReadOnly = true;

            dataGridViewTimCV.RowTemplate.Height = 20;
            dataGridViewTimCV.DataSource = cv.getCV(command);
            //dataGridViewTimXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
