using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doan
{
    public partial class XoaSuaXeHoiForm : Form
    {

        XEHOI xehoi = new XEHOI();
        public XoaSuaXeHoiForm()
        {
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM xehoi");
            dataGridViewXoaSuaXeHoi.ReadOnly = true;
            DataGridViewImageColumn picCol1 = new DataGridViewImageColumn();

            dataGridViewXoaSuaXeHoi.RowTemplate.Height = 80;
            dataGridViewXoaSuaXeHoi.DataSource = xehoi.getXe(command);
            picCol1 = (DataGridViewImageColumn)dataGridViewXoaSuaXeHoi.Columns[3];
            picCol1.ImageLayout = DataGridViewImageCellLayout.Stretch;

            dataGridViewXoaSuaXeHoi.AllowUserToAddRows = false;
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

        private void XoaSuaXeHoiForm_Load(object sender, EventArgs e)
        {
           
                SqlCommand command = new SqlCommand("select * from xehoi");
                dataGridViewXoaSuaXeHoi.ReadOnly = true;

                dataGridViewXoaSuaXeHoi.RowTemplate.Height = 130;
                dataGridViewXoaSuaXeHoi.DataSource = xehoi.getXe(command);
                dataGridViewXoaSuaXeHoi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewXoaSuaXeHoi.AllowUserToAddRows = false;
            
        }

        private void dataGridViewXoaSuaXeHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewXoaSuaXeHoi.CurrentRow.Cells[0].Value.ToString();
            textBoxChuSoHuu.Text = dataGridViewXoaSuaXeHoi.CurrentRow.Cells[1].Value.ToString();
            byte[] pic2;
            pic2 = (byte[])dataGridViewXoaSuaXeHoi.CurrentRow.Cells[3].Value;
            MemoryStream picture2 = new MemoryStream(pic2);
            pictureBoxHieuXe.Image = Image.FromStream(picture2);
            textBoxBangSoXe.Text = dataGridViewXoaSuaXeHoi.CurrentRow.Cells[2].Value.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            string chusohuu = textBoxChuSoHuu.Text;
            
            string bangsoxe = textBoxBangSoXe.Text;
            MemoryStream hieuxe = new MemoryStream();

            if (verif())
            {
                try
                {


                    pictureBoxHieuXe.Image.Save(hieuxe, pictureBoxHieuXe.Image.RawFormat);
                    if (xehoi.updateXeHoi(id,chusohuu,hieuxe,bangsoxe))
                    {
                        MessageBox.Show("Da cap nhat thanh cong", "Sua Xe May", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Sua Xe May", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Sua Xe May", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Sua Xe May", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            bool verif()
            {
                if ((textBoxChuSoHuu.Text.Trim() == "") || (textBoxBangSoXe.Text.Trim() == "") || (pictureBoxHieuXe.Image == null))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Trim() == "")
            {
                MessageBox.Show("nhap thong tin", "xoa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DialogResult result;
                    result = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Hệ Thống", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        string chiSo = textBoxID.Text;
                        if (xehoi.DeleteXeHoi(chiSo))
                        {
                            MessageBox.Show("xoa thanh cong", "xoa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("xoa khong thanh cong", "xoa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }



                    }
                }
                catch
                {
                    MessageBox.Show("nhap dung dinh dang ID", "xoa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
