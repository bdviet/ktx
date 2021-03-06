using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKTXBIA
{
    public partial class FrmInSinhVien : Form
    {
        public FrmInSinhVien()
        {
            InitializeComponent();
        }
        public string Quyen;
        public string Ten;
        public void load_masv()
        {
            DataSet ds;
            ds = ketnoi.laytruong("select Mssv from tbl_SinhVien");
            cbchon.DataSource=ds.Tables[0];
            cbchon.DisplayMember = "Mssv";
        }
        public void load_Maphong()
        { 
            DataSet ds;
            ds = ketnoi.laytruong("select Mapsv from tbl_PhongSV");
            cbchon.DataSource=ds.Tables[0];
            cbchon.DisplayMember = "Mapsv";
        }
        public void load_matruong()
        {
            DataSet ds;
            ds = ketnoi.laytruong("select Matruong from tbl_Truong");
            cbchon.DataSource = ds.Tables[0];
            cbchon.DisplayMember = "Matruong";
        }
        
        public string Mssv;
        public string Tensv;
        public string Truong;
        public string Phong;
        private void FrmInSinhVien_Load(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
            txtquyen.Text = Quyen;
            txtten.Text = Ten;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdInma_CheckedChanged(object sender, EventArgs e)
        {
            
        	    cbchon.Enabled=true;
	            load_masv();
	        
        }

        private void rdInAll_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = false;
        }

        private void rdPhong_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = true;
            load_Maphong();
            
        }

        private void rdtruong_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = true;            
            load_matruong();
        }

       public void Inthesinhvien(object sender, EventArgs e)
        {
            string select = "select Hotensv,Gioitinh,convert(nvarchar,Ngaysinh,104) As Ngaysinh,Mapsv from tbl_SinhVien where Mssv='"+Mssv+"'";
            CryReportTheTamtru insv = new CryReportTheTamtru();
            insv.SetDataSource(ketnoi.laydlbang(select));
            crtInsv.ReportSource = insv;
            crtInsv.Refresh();
        }
        public void InSVChuyenPhong(object sender, EventArgs e)
        {
            string select = "SELECT     dbo.tbl_SinhVien.Mssv, dbo.tbl_SVChuyenPhong.MaChuyenPhong, dbo.tbl_SVChuyenPhong.Mssv AS Expr1, dbo.tbl_SinhVien.Hotensv, dbo.tbl_SinhVien.Gioitinh, dbo.tbl_SinhVien.Ngaysinh, dbo.tbl_SVChuyenPhong.Phongdango, dbo.tbl_SVChuyenPhong.Phongchuyenden, dbo.tbl_SVChuyenPhong.Ngaychuyen FROM dbo.tbl_SinhVien INNER JOIN dbo.tbl_SVChuyenPhong ON dbo.tbl_SinhVien.Mssv = dbo.tbl_SVChuyenPhong.Mssv where Mssv='" + Mssv + "'";
            CryReportChuyenPhong insv = new CryReportChuyenPhong();
            insv.SetDataSource(ketnoi.laydlbang(select));
            crtInsv.ReportSource = insv;
            crtInsv.Refresh();
        }
        public void tktheoMaSV(object sender, EventArgs e)
        {
            string select = "select   Mssv, Hotensv, Gioitinh, convert(nvarchar,Ngaysinh,104) As Ngaysinh, Noisinh, Diachi, Sodt, Matruong, Mapsv from tbl_SinhVien where Mssv like '%" + Mssv + "%'";
            CryReportSV insv = new CryReportSV();
            insv.SetDataSource(ketnoi.laydlbang(select));
            crtInsv.ReportSource = insv;
            crtInsv.Refresh();
        }
        public void tktheoTensv(object sender, EventArgs e)
        {
            string select = "select   Mssv, Hotensv, Gioitinh, convert(nvarchar,Ngaysinh,104) As Ngaysinh, Noisinh, Diachi, Sodt, Matruong, Mapsv from tbl_SinhVien where Hotensv like N'%" + Ten + "%'";
            CryReportSV insv = new CryReportSV();
            insv.SetDataSource(ketnoi.laydlbang(select));
            crtInsv.ReportSource = insv;
            crtInsv.Refresh();
        }
        public void tktheoPhong(object sender, EventArgs e)
        {
            string select = "select   Mssv, Hotensv, Gioitinh, convert(nvarchar,Ngaysinh,104) As Ngaysinh, Noisinh, Diachi, Sodt, Matruong, Mapsv from tbl_SinhVien where Mapsv like N'%" + Phong + "%'";
            CryReportSV insv = new CryReportSV();
            insv.SetDataSource(ketnoi.laydlbang(select));
            crtInsv.ReportSource = insv;
            crtInsv.Refresh();
        }
        public void tktheoTruong(object sender, EventArgs e)
        {
            string select = "select   Mssv, Hotensv, Gioitinh, convert(nvarchar,Ngaysinh,104) As Ngaysinh, Noisinh, Diachi, Sodt, Matruong, Mapsv from tbl_SinhVien where Matruong like N'%" + Truong + "%'";
            CryReportSV insv = new CryReportSV();
            insv.SetDataSource(ketnoi.laydlbang(select));
            crtInsv.ReportSource = insv;
            crtInsv.Refresh();
        }
        private void btIn_Click(object sender, EventArgs e)
        {
            if (rdInAll.Checked == true)
            {
                string select = "select * from tbl_SinhVien";
                CryReportSV insv = new CryReportSV();
                insv.SetDataSource(ketnoi.laydlbang(select));
                crtInsv.ReportSource = insv;
                crtInsv.Refresh();
            }
            else
            {
                if (rdInma.Checked == true)
                {
                    string select = "select * from tbl_SinhVien where Mssv='" + cbchon.Text + "'";
                    CryReportSV insv = new CryReportSV();
                    insv.SetDataSource(ketnoi.laydlbang(select));
                    crtInsv.ReportSource = insv;
                    crtInsv.Refresh();
                }
                else
                {
                    if (rdPhong.Checked == true)
                    {
                        string select = "select * from tbl_SinhVien where Mapsv='" + cbchon.Text + "'";
                        CryReportSV insv = new CryReportSV();
                        insv.SetDataSource(ketnoi.laydlbang(select));
                        crtInsv.ReportSource = insv;
                        crtInsv.Refresh();
                    }
                    else
                    {
                        if (rdtruong.Checked == true)
                        {
                            string select = "select * from tbl_SinhVien where Matruong='" + cbchon.Text + "'";
                            CryReportSV insv = new CryReportSV();
                            insv.SetDataSource(ketnoi.laydlbang(select));
                            crtInsv.ReportSource = insv;
                            crtInsv.Refresh();
                        }
                        else
                        {
                            if (rdinAllthe.Checked == true)
                            {
                                string select = "select Hotensv,Gioitinh,convert(nvarchar,Ngaysinh,104) As Ngaysinh,Mapsv from tbl_SinhVien";
                                CryReportTheTamtru insv = new CryReportTheTamtru();
                                insv.SetDataSource(ketnoi.laydlbang(select));
                                crtInsv.ReportSource = insv;
                                crtInsv.Refresh();
                            }
                            else
                            {
                                if (rdthePhong.Checked == true)
                                {
                                    string select = "select Hotensv,Gioitinh,convert(nvarchar,Ngaysinh,104) As Ngaysinh,Mapsv from tbl_SinhVien where Mapsv='" + cbchon.Text + "'";
                                    CryReportTheTamtru insv = new CryReportTheTamtru();
                                    insv.SetDataSource(ketnoi.laydlbang(select));
                                    crtInsv.ReportSource = insv;
                                    crtInsv.Refresh();
                                }
                                else
                                {
                                    if (rdchuyen.Checked==true)
                                    {
                                        string select = "SELECT dbo.tbl_SVChuyenPhong.MaChuyenPhong, dbo.tbl_SinhVien.Mssv, dbo.tbl_SinhVien.Hotensv, dbo.tbl_SinhVien.Gioitinh, dbo.tbl_SinhVien.Ngaysinh, dbo.tbl_SVChuyenPhong.Phongdango, dbo.tbl_SVChuyenPhong.Phongchuyenden,convert(nvarchar,Ngaychuyen,104) AS Ngaychuyen FROM dbo.tbl_SinhVien INNER JOIN dbo.tbl_SVChuyenPhong ON dbo.tbl_SinhVien.Mssv = dbo.tbl_SVChuyenPhong.Mssv";
                                        CryReportChuyenPhong insv = new CryReportChuyenPhong();
                                        insv.SetDataSource(ketnoi.laydlbang(select));
                                        crtInsv.ReportSource = insv;
                                        crtInsv.Refresh();
                                    }
                                    else
                                        MessageBox.Show("Bạn phải chọn trước khi in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                    
                            }
                                
                        }
                            
                    }
                }
            }
           
        }

        private void rdinAllthe_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = false;
            cbchon.Text = "";
        }

        private void rdthePhong_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = true;
            load_Maphong();
        }

        private void rdchuyen_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = false;
            
        }

        
    }
}