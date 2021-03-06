using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKTXBIA
{
    public partial class FrmInTraPhong : Form
    {
        public FrmInTraPhong()
        {
            InitializeComponent();
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            if (rdInAll.Checked==true)
            {
                string select = "select * from tbl_Traphongsv";
                CryReportTraphong insv = new CryReportTraphong();
                insv.SetDataSource(ketnoi.laydlbang(select));
                crtInsv.ReportSource = insv;
                crtInsv.Refresh();
            }
            else
            {
                if (rdInma.Checked==true)
                {
                    string select = "select * from tbl_Traphongsv where Mssv='"+cbchon.Text+"'";
                    CryReportTraphong insv = new CryReportTraphong();
                    insv.SetDataSource(ketnoi.laydlbang(select));
                    crtInsv.ReportSource = insv;
                    crtInsv.Refresh();
                }
                else
                {
                    if (rdPhong.Checked==true)
                    {
                        string select = "select * from tbl_Traphongsv where Mapsv='"+cbchon.Text+"'";
                        CryReportTraphong insv = new CryReportTraphong();
                        insv.SetDataSource(ketnoi.laydlbang(select));
                        crtInsv.ReportSource = insv;
                        crtInsv.Refresh();
                    }
                    else
                    {
                        if (rdtruong.Checked == true)
                        {
                            string select = "select * from tbl_Traphongsv where Matruong='" + cbchon.Text + "'";
                            CryReportTraphong insv = new CryReportTraphong();
                            insv.SetDataSource(ketnoi.laydlbang(select));
                            crtInsv.ReportSource = insv;
                            crtInsv.Refresh();
                        }
                        else
                            MessageBox.Show("Bạn phải chọn mục trước khi in!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);  
                    }
                }
            }
        }
        public void load_masv()
        {
            DataSet ds;
            ds = ketnoi.laytruong("select Mssv from tbl_Traphongsv");
            cbchon.DataSource = ds.Tables[0];
            cbchon.DisplayMember = "Mssv";
        }
        public void load_Maphong()
        {
            DataSet ds;
            ds = ketnoi.laytruong("select Mapsv from tbl_PhongSV");
            cbchon.DataSource = ds.Tables[0];
            cbchon.DisplayMember = "Mapsv";
        }
        public void load_matruong()
        {
            DataSet ds;
            ds = ketnoi.laytruong("select Matruong from tbl_Truong");
            cbchon.DataSource = ds.Tables[0];
            cbchon.DisplayMember = "Matruong";
        }
        private void FrmInTraPhong_Load(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
            txtquyen.Text = Quyen;
            txtten.Text = Ten;
        }
        public string Quyen;
        public string Ten;
        private void rdInma_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = true;
            load_masv();
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

        private void rdInAll_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = false;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}