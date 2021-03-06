using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKTXBIA
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public string Quyen;
        public string Ten;
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ketnoi.ExitAll();
        }
        public void hien()
        {
            quảnLýNgườiDùngToolStripMenuItem.Enabled = true;
            saoLưuVàPhụcHồiDữLiệuToolStripMenuItem.Enabled = true;
            toolNguoidung.Enabled = true;
            toolsaoluu.Enabled = true;
        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNguoidung frm = new FrmNguoidung();
            frm.ShowDialog();
        }

        private void saoLưuVàPhụcHồiDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSaoluuVaPhuchoidl frm = new FrmSaoluuVaPhuchoidl();
            frm.ShowDialog();
        }

        private void cậpNhậtSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSinhVien frm = new FrmSinhVien();
            frm.Ten = txtname.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }

        private void cậpNhậtChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChucvu frm = new FrmChucvu();
            frm.Ten = txtname.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }

        private void thôngTinVềTácGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTacgia frm = new FrmTacgia();
            frm.ShowDialog();
        }

        private void cậpNhậtKhuSinhViênỞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhu frm = new FrmKhu();
            frm.Ten = txtname.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();

        }

        private void giaHạnThêmThờiGianỞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiahan frm = new FrmGiahan();
            frm.Ten = txtname.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }

        private void hoạtĐộngTrongKýTúcXáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoatDong frm = new FrmHoatDong();
            frm.Ten = txtname.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }

        private void cậpNhậtPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhongBan frm = new FrmPhongBan();
            frm.Ten = txtname.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }

        private void cậpNhậtTrườngSinhViênĐangHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTruonghoc frm = new FrmTruonghoc();
            frm.Ten = txtname.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();

        }

        private void cậpNhậtPhòngỞSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPhongOSv frm = new FrmPhongOSv();
            frm.Ten = txtname.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }

        private void cậpNhậtThôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNhanVien frm = new FrmNhanVien();
            frm.Ten = txtname.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }

        private void cậpNhậtHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHopdong frm = new FrmHopdong();
            frm.Ten = txtname.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoaDon frm = new FrmHoaDon();
            frm.Ten = txtname.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimKiem frm = new FrmTimKiem();
            frm.Ten = txtname.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTraPhong frm = new FrmTraPhong();
            frm.Ten = txtname.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }

        private void sinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInSinhVien frm = new FrmInSinhVien();
            frm.Ten = txtname.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInHoaDon frm = new FrmInHoaDon();
            frm.Ten = txtname.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }

       
        private void trảPhòngToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmInTraPhong frm = new FrmInTraPhong();
            frm.Ten = txtname.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }

        private void hợpĐồngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmInHopDong frm = new FrmInHopDong();
            frm.Ten = txtname.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }

        private void nhânViênQuảnLýKTXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInNhanVien frm = new FrmInNhanVien();
            frm.Ten = txtname.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }

        private void hoạtĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHoatDongKTX frm = new FrmHoatDongKTX();
            frm.Ten = txtname.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }

        private void chuyểnPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChuyenPhong frm = new FrmChuyenPhong();
            frm.Ten = txtname.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }

       

        private void đăngNhậpLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            

        }

        private void toolthoat_Click(object sender, EventArgs e)
        {
            ketnoi.ExitAll();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
            txtquyen.Text = Quyen;
            txtname.Text = Ten;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            frmmaps frm = new frmmaps();
            frm.ShowDialog();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }     
    }
}