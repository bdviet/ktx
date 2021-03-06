using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKTXBIA
{
    public partial class FrmInNhanVien : Form
    {
        public FrmInNhanVien()
        {
            InitializeComponent();
        }
        DataSet ds;
        public void load_manv()
        {
            ds = ketnoi.laytruong("select * from tbl_NhanVien ");
            cbchon.DataSource = ds.Tables[0];
            cbchon.DisplayMember = "Hotennv";
            cbchon.ValueMember = "Manv";
        }
        public void load_Macv()
        {
            ds = ketnoi.laytruong("select * from tbl_ChucVu");
            cbchon.DataSource = ds.Tables[0];
            cbchon.DisplayMember = "Tencv";
            cbchon.ValueMember = "Macv";
        }
        public void load_pban()
        {
            ds = ketnoi.laytruong("select * from tbl_PhongBan");
            cbchon.DataSource = ds.Tables[0];
            cbchon.DisplayMember = "Tenphong";
            cbchon.ValueMember = "Mapban";
        }
        private void rdInma_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = true;
            load_manv();
        }
        public string Quyen;
        public string Ten;
        private void FrmInNhanVien_Load(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
            txtquyen.Text = Quyen;
            txtten.Text = Ten;
        }

        private void rdPhong_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = true;
            load_pban();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdtruong_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = true;
            load_Macv();
        }

        private void rdInAll_CheckedChanged(object sender, EventArgs e)
        {
            cbchon.Enabled = false;
            cbchon.Text = "";
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            if (rdInAll.Checked==true)
            {
                string select = "select * from tbl_NhanVien";
                CryReportNhanVien innv= new CryReportNhanVien();
                innv.SetDataSource(ketnoi.laydlbang(select));
                crtInnv.ReportSource = innv;
                crtInnv.Refresh();
            }
            else
            {
                if (rdInma.Checked==true)
                {
                    string select = "select * from tbl_NhanVien where Manv ='"+cbchon.SelectedValue.ToString()+"'";
                    CryReportNhanVien innv = new CryReportNhanVien();
                    innv.SetDataSource(ketnoi.laydlbang(select));
                    crtInnv.ReportSource = innv;
                    crtInnv.Refresh();
                }
                else
                {
                    if (rdPhong.Checked==true)
                    {
                        string select = "select * from tbl_NhanVien where Mapban ='"+cbchon.SelectedValue.ToString()+"'";
                        CryReportNhanVien innv = new CryReportNhanVien();
                        innv.SetDataSource(ketnoi.laydlbang(select));
                        crtInnv.ReportSource = innv;
                        crtInnv.Refresh();
                    }
                    else
                    {
                        if (rdcv.Checked == true)
                        {
                            string select = "select * from tbl_NhanVien where Macv ='" + cbchon.SelectedValue.ToString() + "'";
                            CryReportNhanVien innv = new CryReportNhanVien();
                            innv.SetDataSource(ketnoi.laydlbang(select));
                            crtInnv.ReportSource = innv;
                            crtInnv.Refresh();
                        }
                        else
                            MessageBox.Show("Bạn phải chọn mục để in","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}