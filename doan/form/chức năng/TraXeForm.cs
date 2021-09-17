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
    public partial class TraXeForm : Form
    {
        GUIXE gx = new GUIXE();
        public TraXeForm()
        {
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM guixe ");
            dataGridViewXeGui.ReadOnly = true;
            dataGridViewXeGui.RowTemplate.Height = 30;
            dataGridViewXeGui.DataSource = gx.getXe(command);
            dataGridViewXeGui.AllowUserToAddRows = false;
        }

        private void dataGridViewXeGui_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridViewXeGui.CurrentRow.Cells[0].Value.ToString();
            textBoxChuSoHuu.Text = dataGridViewXeGui.CurrentRow.Cells[1].Value.ToString();
            //if ((dataGridViewXeGui.CurrentRow.Cells[2].Value.ToString() == "gio"))
            //{

            //    radioButtonGio.Checked = true;
            //    radioButtonNgay.Checked = false;
            //    radioButtonThang.Checked = false;
            //    radioButtonTuan.Checked = false;
            //}
            //else if ((dataGridViewXeGui.CurrentRow.Cells[2].Value.ToString() == "tuan"))
            //{
            //    radioButtonGio.Checked = false;
            //    radioButtonNgay.Checked = false;
            //    radioButtonThang.Checked = false;
            //    radioButtonTuan.Checked = true;
            //}
            //else if ((dataGridViewXeGui.CurrentRow.Cells[2].Value.ToString() == "ngay"))
            //{
            //    radioButtonGio.Checked = false;
            //    radioButtonNgay.Checked = true;
            //    radioButtonThang.Checked = false;
            //    radioButtonTuan.Checked = false;
            //}
            //else
            //{
            //    radioButtonGio.Checked = false;
            //    radioButtonNgay.Checked = false;
            //    radioButtonThang.Checked = true;
            //    radioButtonTuan.Checked = false;
            //}    
            textBoxGuiTheo.Text= dataGridViewXeGui.CurrentRow.Cells[2].Value.ToString();
            dateTimePickerNgayGui.Value = (DateTime)dataGridViewXeGui.CurrentRow.Cells[3].Value;
            dateTimePickerHanGui.Value = (DateTime)dataGridViewXeGui.CurrentRow.Cells[4].Value;
        }

        private void buttonThoát_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TraXeForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM guixe ");
            dataGridViewXeGui.ReadOnly = true;
            dataGridViewXeGui.RowTemplate.Height = 30;
            dataGridViewXeGui.DataSource = gx.getXe(command);
            dataGridViewXeGui.AllowUserToAddRows = false;
        }

        private void buttonTra_Click(object sender, EventArgs e)
        {
            //trả xe thì xóa ở bảng gửi xe,insert vào bảng phí,nếu quá hạn thì sẽ insert vào cột phí phạt,nếu ko thì insert vào cột phí gửi
            string id = textBoxID.Text;
            string chusohuu = textBoxChuSoHuu.Text;
            DateTime hangui=Convert.ToDateTime(dateTimePickerHanGui.Value.ToString());
            DateTime ngaygui = Convert.ToDateTime(dateTimePickerNgayGui.Value.ToString());
            DateTime ngaytra = Convert.ToDateTime(dateTimePickerNgayTra.Value.ToString(""));
            string guitheo = textBoxGuiTheo.Text;
            int giatien = 0;
            double phigui = 0;
            double phiphat = 0;
            int kiemtra = checkmaxegandung(id);
            TimeSpan check1 = hangui - ngaytra;
            //kiểm tra loại xe nè
            if (kiemtra == 1)
            {
                //là xe đạp nè
                giatien = 5000;
            }
            else if (kiemtra == 2)
            {
                //là xe máy nè
                giatien = 8000;
            }
            else if (kiemtra == 3)
            {
                giatien = 20000;
            }
            if (guitheo == "gio")
            {
                if (check1.Days == 0) //trong một ngày
                {
                    int sogio = Math.Abs(check1.Hours);
                    phiphat = 0;
                    phigui = sogio * giatien;
                    double tongtien = phigui + phiphat;
                    if (gx.insertPhi(id, chusohuu, phigui, phiphat, tongtien, ngaygui, ngaytra))
                    {
                        gx.DeleteXeGui(id); //xóa bên bảng nhận gửi
                        gx.DeleteXeNhanGui(id); //xóa bên bảng công việc của xe nhận gửi
                        MessageBox.Show("da thanh toan", "phi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("thanh toán chưa thành công", "phi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (check1.Days < 0) //hạn trả - ngày trả <0 tức là bị quá hạn
                {
                    TimeSpan layngaychuaphat = hangui - ngaygui;
                    TimeSpan laysongayphat = ngaytra - hangui;
                    int sogiongay1 = layngaychuaphat.Hours;
                    int sogiongay2 = laysongayphat.Hours;
                    phiphat = sogiongay2 * 2 * 8 * giatien;
                    phigui = sogiongay1 * 8 * giatien;
                    double tongtien = phigui + phiphat;
                    if (gx.insertPhi(id, chusohuu, phigui, phiphat, tongtien, ngaygui, ngaytra))
                    {
                        gx.DeleteXeGui(id);
                        gx.DeleteXeNhanGui(id); //xóa bên bảng công việc của xe nhận gửi
                        MessageBox.Show("qua han tra", "phi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("thanh toán chưa thành công", "phi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else //han trả > ngày trả 
                {
                    //ngày trả phải > ngày gửi
                    TimeSpan check2 = ngaytra - ngaygui;
                    if (check2.Days < 0)
                    {
                        //thông báo lỗi 
                        MessageBox.Show("sai ngay", "loi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int songio = check2.Hours;
                        phigui = giatien * songio;
                        phiphat = 0;
                        double tongtien = phigui + phiphat;
                        if (gx.insertPhi(id, chusohuu, phigui, phiphat, tongtien, ngaygui, ngaytra))
                        {
                            gx.DeleteXeGui(id);
                            gx.DeleteXeNhanGui(id); //xóa bên bảng công việc của xe nhận gửi
                            MessageBox.Show("da thanh toan", "phi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("thanh toán chưa thành công", "phi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
            else if(guitheo=="ngay")
            {
                if (check1.Days == 0) //trong một ngày (=1 mới là 1 ngày còn =0 là chưa được một ngày nên vẫn tính theo giờ)
                {
                    int sogio = Math.Abs(check1.Hours);
                    phiphat = 0;
                    phigui = sogio * giatien;
                    double tongtien = phigui + phiphat;
                    if (gx.insertPhi(id, chusohuu, phigui, phiphat, tongtien, ngaygui, ngaytra))
                    {
                        gx.DeleteXeGui(id); //xóa bên bảng nhận gửi
                        gx.DeleteXeNhanGui(id); //xóa bên bảng công việc của xe nhận gửi
                        MessageBox.Show("da thanh toan", "phi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("thanh toán chưa thành công", "phi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (check1.Days <0) //hạn trả - ngày trả <0 tức là bị quá hạn
                {
                    TimeSpan layngaychuaphat = hangui - ngaygui;
                    TimeSpan laysongayphat = ngaytra - hangui;
                    int songay1 = layngaychuaphat.Days;
                    int songay2 = laysongayphat.Days;
                    phiphat = songay2 * 3 * 8 * giatien;
                    phigui = songay1 * 8 * giatien;
                    double tongtien = phigui + phiphat;
                    if (gx.insertPhi(id, chusohuu, phigui, phiphat, tongtien, ngaygui, ngaytra))
                    {
                        gx.DeleteXeGui(id);
                        gx.DeleteXeNhanGui(id); //xóa bên bảng công việc của xe nhận gửi
                        MessageBox.Show("qua han tra", "phi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("thanh toán chưa thành công", "phi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else //han trả > ngày trả 
                {
                    //ngày trả phải > ngày gửi
                    TimeSpan check2 = ngaytra - ngaygui;
                    if (check2.Days < 0)
                    {
                        //thông báo lỗi 
                        MessageBox.Show("sai ngay", "loi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int songay = check2.Days;
                        phigui = giatien *8* songay;
                        phiphat = 0;
                        double tongtien = phigui + phiphat;
                        if (gx.insertPhi(id, chusohuu, phigui, phiphat, tongtien, ngaygui, ngaytra))
                        {
                            gx.DeleteXeGui(id);
                            gx.DeleteXeNhanGui(id); //xóa bên bảng công việc của xe nhận gửi
                            MessageBox.Show("da thanh toan", "phi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("thanh toán chưa thành công", "phi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
            else if(guitheo=="tuan")
            {
                if (check1.Days == 0) //trong một ngày (=1 mới là 1 ngày còn =0 là chưa được một ngày nên vẫn tính theo giờ)
                {
                    int sogio = Math.Abs(check1.Hours);
                    phiphat = 0;
                    phigui = sogio * giatien;
                    double tongtien = phigui + phiphat;
                    if (gx.insertPhi(id, chusohuu, phigui, phiphat, tongtien, ngaygui, ngaytra))
                    {
                        gx.DeleteXeGui(id); //xóa bên bảng nhận gửi
                        gx.DeleteXeNhanGui(id); //xóa bên bảng công việc của xe nhận gửi
                        MessageBox.Show("da thanh toan", "phi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("thanh toán chưa thành công", "phi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (check1.Days < 0) //hạn trả - ngày trả <0 tức là bị quá hạn
                {
                    TimeSpan layngaychuaphat = hangui - ngaygui;
                    TimeSpan laysongayphat = ngaytra - hangui;
                    int songay1 = layngaychuaphat.Days;
                    int songay2 = laysongayphat.Days;
                    if (songay2 >= 10 && songay2 <= 30)
                    {
                        phiphat = songay2 * 8 * 3 * 2 * giatien;
                        phigui = songay1 * 8 *3* giatien;
                        double tongtien = phigui + phiphat;
                        if (gx.insertPhi(id, chusohuu, phigui, phiphat, tongtien, ngaygui, ngaytra))
                        {
                            gx.DeleteXeGui(id);
                            gx.DeleteXeNhanGui(id); //xóa bên bảng công việc của xe nhận gửi
                            MessageBox.Show("qua han tra", "phi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("thanh toán chưa thành công", "phi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else //quá một tháng 
                    {
                        phiphat = (songay2 * 8 * 3 * 2 * giatien)*2;
                        phigui = songay1 * 8 * 3 * giatien;
                        double tongtien = phigui + phiphat;
                        if (gx.insertPhi(id, chusohuu, phigui, phiphat, tongtien, ngaygui, ngaytra))
                        {
                            gx.DeleteXeGui(id);
                            gx.DeleteXeNhanGui(id); //xóa bên bảng công việc của xe nhận gửi
                            MessageBox.Show("qua han tra", "phi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("thanh toán chưa thành công", "phi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }    

                }
                else //han trả > ngày trả 
                {
                    //ngày trả phải > ngày gửi
                    TimeSpan check2 = ngaytra - ngaygui;
                    if (check2.Days < 0)
                    {
                        //thông báo lỗi 
                        MessageBox.Show("sai ngay", "loi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int songay = check2.Days;
                        if (songay < 7) //chưa được 1 tuần thì vẫn tính theo ngày
                        {
                            phigui = giatien * 8 * songay;
                            phiphat = 0;
                            double tongtien = phigui + phiphat;
                            if (gx.insertPhi(id, chusohuu, phigui, phiphat, tongtien, ngaygui, ngaytra))
                            {
                                gx.DeleteXeGui(id);
                                gx.DeleteXeNhanGui(id); //xóa bên bảng công việc của xe nhận gửi
                                MessageBox.Show("da thanh toan", "phi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("thanh toán chưa thành công", "phi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else //bắt đầu tính theo tuần
                        {
                            phigui = giatien * 8 *3* songay;
                            phiphat = 0;
                            double tongtien = phigui + phiphat;
                            if (gx.insertPhi(id, chusohuu, phigui, phiphat, tongtien, ngaygui, ngaytra))
                            {
                                gx.DeleteXeGui(id);
                                gx.DeleteXeNhanGui(id); //xóa bên bảng công việc của xe nhận gửi
                                MessageBox.Show("da thanh toan", "phi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("thanh toán chưa thành công", "phi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }    
                    }
                }
            }  
            else //tính theo tháng
            {
                if (check1.Days == 0) //trong một ngày (=1 mới là 1 ngày còn =0 là chưa được một ngày nên vẫn tính theo giờ)
                {
                    int sogio = Math.Abs(check1.Hours);
                    phiphat = 0;
                    phigui = sogio * giatien;
                    double tongtien = phigui + phiphat;
                    if (gx.insertPhi(id, chusohuu, phigui, phiphat, tongtien, ngaygui, ngaytra))
                    {
                        gx.DeleteXeGui(id); //xóa bên bảng nhận gửi
                        gx.DeleteXeNhanGui(id); //xóa bên bảng công việc của xe nhận gửi
                        MessageBox.Show("da thanh toan", "phi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("thanh toán chưa thành công", "phi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (check1.Days < 0) //hạn trả - ngày trả <0 tức là bị quá hạn
                {
                    TimeSpan layngaychuaphat = hangui - ngaygui;
                    TimeSpan laysongayphat = ngaytra - hangui;
                    int songay1 = layngaychuaphat.Days;
                    int songay2 = laysongayphat.Days;
                    if (songay2 <= 30) //dưới 1 tháng thì tính theo ngày
                    {
                        phiphat = songay2 * 8 * 3 * 2 * giatien; //phạt theo ngày luôn
                        phigui = songay1 * 8 *3* giatien;
                        double tongtien = phigui + phiphat;
                        if (gx.insertPhi(id, chusohuu, phigui, phiphat, tongtien, ngaygui, ngaytra))
                        {
                            gx.DeleteXeGui(id);
                            gx.DeleteXeNhanGui(id); //xóa bên bảng công việc của xe nhận gửi
                            MessageBox.Show("qua han tra", "phi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("thanh toán chưa thành công", "phi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else //quá một tháng 
                    {
                        phiphat = (songay2 * 8 * 3 * 2 * giatien) * 4; //phạt gấp đôi
                        phigui = songay1 * 8 * 3 *2* giatien; //tính phạt theo  tháng 
                        double tongtien = phigui + phiphat;
                        if (gx.insertPhi(id, chusohuu, phigui, phiphat, tongtien, ngaygui, ngaytra))
                        {
                            gx.DeleteXeGui(id);
                            gx.DeleteXeNhanGui(id); //xóa bên bảng công việc của xe nhận gửi
                            MessageBox.Show("qua han tra", "phi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("thanh toán chưa thành công", "phi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }

                }
                else //han trả > ngày trả 
                {
                    //ngày trả phải > ngày gửi
                    TimeSpan check2 = ngaytra - ngaygui;
                    if (check2.Days < 0)
                    {
                        //thông báo lỗi 
                        MessageBox.Show("sai ngay", "loi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int songay = check2.Days;
                        if (songay <=30 ) //chưa được 1 tháng thì vẫn tính theo ngày
                        {
                            phigui = giatien * 8 * songay;
                            phiphat = 0;
                            double tongtien = phigui + phiphat;
                            if (gx.insertPhi(id, chusohuu, phigui, phiphat, tongtien, ngaygui, ngaytra))
                            {
                                gx.DeleteXeGui(id);
                                gx.DeleteXeNhanGui(id); //xóa bên bảng công việc của xe nhận gửi
                                MessageBox.Show("da thanh toan", "phi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("thanh toán chưa thành công", "phi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else //bắt đầu tính theo tháng
                        {
                            phigui = giatien * 8 * 3 *  2 * songay;
                            phiphat = 0;
                            double tongtien = phigui + phiphat;
                            if (gx.insertPhi(id, chusohuu, phigui, phiphat, tongtien, ngaygui, ngaytra))
                            {
                                gx.DeleteXeGui(id);
                                gx.DeleteXeNhanGui(id); //xóa bên bảng công việc của xe nhận gửi
                                MessageBox.Show("da thanh toan", "phi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("thanh toán chưa thành công", "phi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }
            }
        }
        int checkmaxegandung(string id)
        {
            if(gx.checkMaXedap(id)==false)
            {
                return 1;
            }
            else if(gx.checkMaXeMay(id)==false)
            {
                return 2;
            }
            else if(gx.checkMaXeHoi(id)==false)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
        bool verif()
        {
            if ((textBoxID.Text.Trim() == "") || (textBoxChuSoHuu.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
       
    }
}
