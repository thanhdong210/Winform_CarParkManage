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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void xeĐạpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemXeDapForm xedap = new ThemXeDapForm();
            xedap.Show();
        }

        private void xeMáyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemXeMayForm xemay = new ThemXeMayForm();
            xemay.Show();
        }

        private void xeHơiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemXeHoiForm xehoi = new ThemXeHoiForm();
            xehoi.Show();
        }

        private void tìmXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimXeForm timxe = new TimXeForm();
            timxe.Show();
        }

        private void xeĐạpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            XoaSuaXeDapForm xoasuaxedap = new XoaSuaXeDapForm();
            xoasuaxedap.Show();
        }

        private void xeMáyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            XoaSuaXeMayForm xoasuaxemay = new XoaSuaXeMayForm();
            xoasuaxemay.Show();
        }

        private void xeHơiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            XoaSuaXeHoiForm xoasuaxehoi = new XoaSuaXeHoiForm();
            xoasuaxehoi.Show();
        }

        private void xeĐạpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            QuanLyXeDapForm qlyxedap = new QuanLyXeDapForm();
            qlyxedap.Show();
        }

        private void xeMáyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            QuanLyXeMayForm qlyxemay = new QuanLyXeMayForm();
            qlyxemay.Show();
        }

        private void xeHơiToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            QuanLyXeHoiForm qlyxehoi = new QuanLyXeHoiForm();
            qlyxehoi.Show();
        }

        private void thêmCôngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemCVForm themcv = new ThemCVForm();
            themcv.Show();
        }

        private void tìmCôngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemCVForm timcv = new TimKiemCVForm();
            timcv.Show();
        }

        private void xóasửaCôngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaSuaCVForm xoasuacv = new XoaSuaCVForm();
            xoasuacv.Show();
        }

        private void quảnLýCôngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyCVForm qlycv = new QuanLyCVForm();
            qlycv.Show();
        }

        private void thêmThợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemThoForm themtho = new ThemThoForm();
            themtho.Show();
        }

        private void xóaSửaThợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaSuaThoForm xoasuatho = new XoaSuaThoForm();
            xoasuatho.Show();
        }

        private void quảnLýThợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyThoForm qlytho = new QuanLyThoForm();
            qlytho.Show();
        }

        private void phíGửiXeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gửiXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuiXeForm gui = new GuiXeForm();
            gui.Show();
        }

        private void trảXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraXeForm tra = new TraXeForm();
            tra.Show();
        }

        private void phạtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThanhToanForm thanhtoan = new ThanhToanForm();
            thanhtoan.Show();
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoanhThuForm doanhthu = new DoanhThuForm();
            doanhthu.Show();
        }

        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemKhachHangForm themkh = new ThemKhachHangForm();
            themkh.Show();
        }

        private void xóaSửaKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaSuaKHForm xoasuakh = new XoaSuaKHForm();
            xoasuakh.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyKHForm qlykh = new QuanLyKHForm();
            qlykh.Show();
        }

        private void thêmHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemHopDongForm themhd = new ThemHopDongForm();
            themhd.Show();
        }

        private void xóaSửaHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaSuaHopDongForm xoasuahd = new XoaSuaHopDongForm();
            xoasuahd.Show();
        }

        private void quảnLýHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHDForm qlyhd = new QuanLyHDForm();
            qlyhd.Show();
        }

        private void chiTiếtHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CTHDForm cthd = new CTHDForm();
            cthd.Show();
        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemXoaCTHDForm chinhsua = new ThemXoaCTHDForm();
            chinhsua.Show();
        }

       
    }
}
