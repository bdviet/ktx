using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKTXBIA
{
    public partial class FrmHoatDongKTX : Form
    {
        public FrmHoatDongKTX()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string Quyen;
        public string Ten;
        private void FrmHoatDongKTX_Load(object sender, EventArgs e)
        {
            ketnoi.OpenCn();

            txtquyen.Text = Quyen;
            txtten.Text = Ten;
        }
        DataSet ds;
        public void load_Mahd()
        {
            ds = ketnoi.laytruong("select * from tbl_HoatDong");
            cbchon.DataSource = ds.Tables[0];
            cbchon.DisplayMember = "Tenhd";
            cbchon.ValueMember = "Mahdong";
        }
        public void load_manv()
        {
            ds = ketnoi.laytruong("select * from tbl_NhanVien ");
            cbchon.DataSource = ds.Tables[0];
            cbchon.DisplayMember = "Hotennv";
            cbchon.ValueMember = "Manv";
        }
        private void btIn_Click(object sender, EventArgs e)
        {
            if (rdInAll.Checked==true)
            {
                string select = "SELECT * FROM dbo.tbl_NhanVien INNER JOIN dbo.tbl_HoatDong ON dbo.tbl_NhanVien.Manv = dbo.tbl_HoatDong.Manv";
                CryReportHoatDong inhd = new CryReportHoatDong();
                inhd.SetDataSource(ketnoi.laydlbang(select));
                crtInhdong.ReportSource = inhd;
                crtInhdong.Refresh();
            }
            else
            {
                if (rdHdong.Checked == true)
                {
                    string select = "SELECT * FROM dbo.tbl_NhanVien INNER JOIN dbo.tbl_HoatDong ON dbo.tbl_NhanVien.Manv = dbo.tbl_HoatDong.Manv where Mahdong='" + cbchon.SelectedValue.ToString() + "'";
                    CryReportHoatDong inhd = new CryReportHoatDong();
                    inhd.SetDataSource(ketnoi.laydlbang(select));
                    crtInhdong.ReportSource = inhd;
                    crtInhdong.Refresh();

                }
                else
                {
                    if (rdInnv.Checked == true)
                    {
                        string select = "select * FROM dbo.tbl_NhanVien INNER JOIN dbo.tbl_HoatDong ON dbo.tbl_NhanVien.Manv = dbo.tbl_HoatDong.Manv where dbo.tbl_HoatDong.Manv='" + cbchon.SelectedValue.ToString() + "'";
                        CryReportHoatDong inhd = new CryReportHoatDong();
                        inhd.SetDataSource(ketnoi.laydlbang(select));
                        crtInhdong.ReportSource = inhd;
                        crtInhdong.Refresh();
                    }
                    else
                        MessageBox.Show("Bạn phải chọn mục để in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void rdInnv_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = true;
            load_manv();
        }

        private void rdHdong_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = true;
            load_Mahd();
        }

        private void rdInAll_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = false;
            cbchon.Text = "";
        }

      
    }
}