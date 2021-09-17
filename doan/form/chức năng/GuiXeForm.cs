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
    public partial class GuiXeForm : Form
    {
        XEDAP xedap = new XEDAP();
        XEMAY xemay = new XEMAY();
        XEHOI xehoi = new XEHOI();
        CONGVIEC cv = new CONGVIEC();
        GUIXE gx = new GUIXE();
        public GuiXeForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GuiXeForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM congviec WHERE loaicv='Trong coi xe'");
            dataGridViewGuiXe.ReadOnly = true;
            dataGridViewGuiXe.RowTemplate.Height = 30;
            dataGridViewGuiXe.DataSource = cv.getCV(command);
            dataGridViewGuiXe.AllowUserToAddRows = false;
        }

        private void buttonGui_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string chusohuu = textBoxChuSoHuu.Text;
            DateTime ngaygui = dateTimePickerNgayGui.Value;
            DateTime hangui = dateTimePickerHanGui.Value;
            string guitheo = "gio";

            if (radioButtonNgay.Checked)
            {
                guitheo = "ngay";
            }
            else if(radioButtonTuan.Checked)
            {
                guitheo = "tuan";
            }
            else if(radioButtonThang.Checked)
            {
                guitheo = "thang";
            }
            
            //hàm check ngày gửi


            if (gx.checkMaXe(id) == false)
            {
                MessageBox.Show("Xe đang được gửi", "Gui Xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                if (kiemtrangay())
                {
                    if (gx.insertXeGui(id, chusohuu,guitheo,ngaygui, hangui))
                    {
                        MessageBox.Show("Da gui thanh cong", "Gui Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Loi", "Gui Xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ngày gửi xe phải >=1", "Gui Xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Gui Xe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        bool verif()
        {
            if ((textBoxID.Text.Trim() == "") || (textBoxChuSoHuu.Text.Trim() == "") )
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        bool kiemtrangay()
        {
            int namgui = dateTimePickerNgayGui.Value.Year;
            int namhangui = dateTimePickerHanGui.Value.Year;
            int thanggui = dateTimePickerNgayGui.Value.Month;
            int thanghangui = dateTimePickerHanGui.Value.Month;
            int ngaygui = dateTimePickerNgayGui.Value.Day;
            int ngayhangui = dateTimePickerHanGui.Value.Day;
            if(namgui==namhangui)
            {
                if(thanggui==thanghangui)
                {
                    if (ngaygui == ngayhangui) //ngày gửi phải ít nhất là 1
                    {
                        return true; ;
                    }
                    else if (ngaygui < ngayhangui)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if(thanggui<thanghangui)
                {
                    return true;
                }
                else
                {
                    return false;
                }    
            }
            else if(namgui<namhangui)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void dataGridViewGuiXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewGuiXe.CurrentRow.Cells[0].Value.ToString();
            textBoxChuSoHuu.Text = dataGridViewGuiXe.CurrentRow.Cells[1].Value.ToString();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

    

