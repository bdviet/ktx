using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKTXBIA
{
    public partial class FrmInHoaDon : Form
    {
        public FrmInHoaDon()
        {
            InitializeComponent();
        }

        public string Quyen;
        public string Ten;
        private void FrmInHoaDon_Load(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
            txtquyen.Text = Quyen;
            txtten.Text = Ten;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        DataSet ds;
        public void load_mahd()
        {
            ds = ketnoi.laytruong("select Mahdon from tbl_HoaDon");
            cbchon.DataSource = ds.Tables[0]; ;
            cbchon.DisplayMember = "Mahdon";
        }
        public void load_maphong()
        {
            ds = ketnoi.laytruong("select Mapsv from tbl_PhongSV");
            cbchon.DataSource = ds.Tables[0]; ;
            cbchon.DisplayMember = "Mapsv";
        }
        public void load_makhu()
        {
            ds = ketnoi.laytruong("select Makhu from tbl_Khu");
            cbchon.DataSource = ds.Tables[0]; ;
            cbchon.DisplayMember = "Makhu";
        }
        private void btIn_Click(object sender, EventArgs e)
        {
            if (rdInAll.Checked==true)
            {
                string select = "select * from tbl_HoaDon";
                CryReportHoaDon inhd = new CryReportHoaDon();
                inhd.SetDataSource(ketnoi.laydlbang(select));
                CrtInHoaDon.ReportSource = inhd;
                CrtInHoaDon.Refresh();
            }
            else
            {
                if (rdmahd.Checked==true)
                {
                    string select = "select * from tbl_HoaDon where Mahdon='"+cbchon.Text+"'";
                    CryReportHoaDon inhd = new CryReportHoaDon();
                    inhd.SetDataSource(ketnoi.laydlbang(select));
                    CrtInHoaDon.ReportSource = inhd;
                    CrtInHoaDon.Refresh();
                }
                else
                {
                    if (rdPhong.Checked == true)
                    {
                        string select = "select * from tbl_HoaDon where Mapsv='" + cbchon.Text + "'";
                        CryReportHoaDon inhd = new CryReportHoaDon();
                        inhd.SetDataSource(ketnoi.laydlbang(select));
                        CrtInHoaDon.ReportSource = inhd;
                        CrtInHoaDon.Refresh();
                    }

                    else
                    {
                        if (rdngay.Checked == true)
                        {
                            if (dtgtu.Value <= dtgden.Value)
                            {
                                string select = "select * from tbl_HoaDon where Ngaylap BETWEEN '" + dtgtu.Text + "' AND '" + dtgden.Text + "'";
                                CryReportHoaDon inhd = new CryReportHoaDon();
                                inhd.SetDataSource(ketnoi.laydlbang(select));
                                CrtInHoaDon.ReportSource = inhd;
                                CrtInHoaDon.Refresh();
                            }
                            else
                                MessageBox.Show("Kiểm tra lại ngày . từ ngày < ngày đến!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            if (rdkhu.Checked==true)
                            {
                                if (dtgtu.Value <= dtgden.Value)
                                {
                                    string select = "SELECT * FROM View_hoadonkhu Where Makhu='" + cbchon.Text + "' and Ngaylap BETWEEN '" + dtgtu.Text + "' AND '" + dtgden.Text + "' ";
                                    CryReportInHDKhu inhd = new CryReportInHDKhu();
                                    inhd.SetDataSource(ketnoi.laydlbang(select));
                                    CrtInHoaDon.ReportSource = inhd;
                                    CrtInHoaDon.Refresh();
                                }
                                else
                                    MessageBox.Show("Kiểm tra lại ngày . từ ngày <= ngày đến!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               
                            }
                            else
                                MessageBox.Show("Bạn hãy chọn mục để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                             
                        
                    }
                       
                }
            }
        }

        private void rdPhong_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = true;
            load_maphong();
            dtgden.Enabled = false;
            dtgtu.Enabled = false;
        }

        private void rdmahd_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = true;
            load_mahd();
            dtgden.Enabled = false;
            dtgtu.Enabled = false;
        }

        private void rdInAll_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = false;
            dtgden.Enabled = false;
            dtgtu.Enabled = false;
        }

        private void rdngay_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = false;
            dtgden.Enabled = true;
            dtgtu.Enabled = true;
        }

        private void rdkhu_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = true;
            load_makhu();
            dtgden.Enabled = true;
            dtgtu.Enabled = true;
        }

      
    }
}