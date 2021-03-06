using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKTXBIA
{
    public partial class FrmInHopDong : Form
    {
        public FrmInHopDong()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public string Quyen;
        public string Ten;	
	
        private void FrmInHopDong_Load(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
            txtquyen.Text = Quyen;
            txtten.Text = Ten;
        }
        DataSet ds;
        public void load_mahd()
        {
            ds = ketnoi.laytruong("select Mahd from tbl_HopDong");
            cbchon.DataSource = ds.Tables[0];
            cbchon.DisplayMember = "Mahd";
        }
        public void load_phong()
        {
            ds = ketnoi.laytruong("select Mapsv from tbl_PhongSV");
            cbchon.DataSource = ds.Tables[0];
            cbchon.DisplayMember = "Mapsv";
        }
        public void load_Truong()
        {
            ds = ketnoi.laytruong("select Matruong from tbl_Truong");
            cbchon.DataSource = ds.Tables[0];
            cbchon.DisplayMember = "Matruong";
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdInma_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = true;
            load_mahd();
        }

        private void rdPhong_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = true;
            load_phong();
        }

        private void rdtruong_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = true;
            load_Truong();
        }

        private void rdInAll_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = false;
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            if (rdInAll.Checked==true)
            {
                string select = "select * from tbl_HopDong";
                CryReportDSHopDong inhd = new CryReportDSHopDong();
                inhd.SetDataSource(ketnoi.laydlbang(select));
                crtInhd.ReportSource = inhd;
                crtInhd.Refresh();
            }
            else
            {
                if (rdInma.Checked==true)
                {
                    string select = "select * from tbl_HopDong where Mahd='"+cbchon.Text+"'";
                    //CryReportHopDong inhd = new CryReportHopDong();
                    CrystalReportInhopdong_sv inhd = new CrystalReportInhopdong_sv();
                    inhd.SetDataSource(ketnoi.laydlbang(select));
                    crtInhd.ReportSource = inhd;
                    crtInhd.Refresh();
                }
                else
                {
                    if (rdPhong.Checked==true)
                    {
                        string select = "select * from tbl_HopDong where Mapsv='"+cbchon.Text+"'";
                        CryReportDSHopDong inhd = new CryReportDSHopDong();
                        inhd.SetDataSource(ketnoi.laydlbang(select));
                        crtInhd.ReportSource = inhd;
                        crtInhd.Refresh();
                    }
                    else
                    {
                        if (rdtruong.Checked==true)
                        {
                            string select = "SELECT dbo.tbl_HopDong.Mahd, dbo.tbl_HopDong.Mssv, dbo.tbl_SinhVien.Hotensv, dbo.tbl_SinhVien.Gioitinh, dbo.tbl_SinhVien.Ngaysinh, dbo.tbl_SinhVien.Noisinh, dbo.tbl_SinhVien.Diachi, dbo.tbl_SinhVien.Sodt, dbo.tbl_Truong.Tentruong, dbo.tbl_SinhVien.Mapsv, dbo.tbl_HopDong.Tgbd, dbo.tbl_HopDong.Tgkt FROM dbo.tbl_HopDong INNER JOIN dbo.tbl_SinhVien ON dbo.tbl_HopDong.Mssv = dbo.tbl_SinhVien.Mssv INNER JOIN dbo.tbl_Truong ON dbo.tbl_SinhVien.Matruong = dbo.tbl_Truong.Matruong where dbo.tbl_Truong.Matruong='" + cbchon.Text + "'";
                            CryReportDSHopDong inhd = new CryReportDSHopDong();
                            inhd.SetDataSource(ketnoi.laydlbang(select));
                            crtInhd.ReportSource = inhd;
                            crtInhd.Refresh();
                        }
                        else
                        {
                            if (rdquahan.Checked==true)
                            {
                                string select = "SELECT *, DATEDIFF(dd, Tgkt, GETDATE()) FROM dbo.tbl_HopDong where DATEDIFF(dd, Tgkt, GETDATE())>='0'";
                                // int year = int.Parse(kn.LayGiaTri("SELECT YEAR(GETDATE()) - YEAR(Tgkt) FROM dbo.tbl_HopDong"));
                                CryReportDSHopDong inhd = new CryReportDSHopDong();
                                inhd.SetDataSource(ketnoi.laydlbang(select));
                                crtInhd.ReportSource = inhd;
                                crtInhd.Refresh();
                            }
                            else
                            MessageBox.Show("Bạn chưa mục cần in","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    }

                }
            }
        }
        
        private void rdquahan_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = false;
        }
       
    }
}