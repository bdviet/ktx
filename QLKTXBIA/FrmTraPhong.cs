using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLKTXBIA
{
    public partial class FrmTraPhong : Form
    {
        public FrmTraPhong()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public string Quyen;
        public string Ten;
        public string Mssv;
        private void FrmTraPhong_Load(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
            loadDatagridview();
            load_masv();
            loadDatagridview_traphong();
            cbmasv.Text = null;
            TaoMaTang();
            //--
            txtquyen.Text = Quyen;
            txtten.Text = Ten;
            txttimkiem.Text = Mssv;
            if (txtquyen.Text == "Admin")
            {
                btxoa.Enabled = true;
            }
            
        }
       
      public  void TaoMaTang()
        {
            if (kn.LayGiaTri("Select count(Matraphong) from tbl_Traphongsv") == "0")
                txttraphong.Text = "Ma-1";
            else
                txttraphong.Text = "Ma-" + ((float.Parse(kn.LayGiaTri("Select Top(1) CONVERT(float,RIGHT(Matraphong,len(Matraphong)-3)) from tbl_Traphongsv Order by  CONVERT(float,RIGHT(Matraphong,len(Matraphong)-3)) DESC"))) + 1); 
        }
        //---
        string select = "SELECT dbo.tbl_SinhVien.*, dbo.tbl_HopDong.Tgbd, dbo.tbl_HopDong.Tgkt FROM dbo.tbl_HopDong INNER JOIN dbo.tbl_SinhVien ON dbo.tbl_HopDong.Mssv = dbo.tbl_SinhVien.Mssv";
        public void loadDatagridview()
        {

            dgvDssv.DataSource = ketnoi.laydlbang(select);
            dgvDssv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvDssv.Columns[0].HeaderText = "Mã SV";
            dgvDssv.Columns[0].Width = 120;
            dgvDssv.Columns[1].HeaderText = "Họ và Tên";
            dgvDssv.Columns[1].Width = 180;
            dgvDssv.Columns[2].HeaderText = "Giới Tính";
            dgvDssv.Columns[2].Width = 80;
            dgvDssv.Columns[3].HeaderText = "Ngày Sinh";
            dgvDssv.Columns[3].Width = 100;
            dgvDssv.Columns[4].HeaderText = "Nơi sinh";
            dgvDssv.Columns[4].Width = 150;
            dgvDssv.Columns[5].HeaderText = "Địa chỉ";
            dgvDssv.Columns[5].Width = 170;
            dgvDssv.Columns[6].HeaderText = "Số điện thoại";
            dgvDssv.Columns[6].Width = 150;
            dgvDssv.Columns[7].HeaderText = "Mã trường";
            dgvDssv.Columns[7].Width = 80;
            dgvDssv.Columns[8].HeaderText = "Phòng";
            dgvDssv.Columns[8].Width = 80;
            dgvDssv.Columns[9].HeaderText = "Ngày bắt đầu ở";
            dgvDssv.Columns[9].Width = 100;
            dgvDssv.Columns[10].HeaderText = "Ngày trả phòng";
            dgvDssv.Columns[10].Width = 100;
        }
        string select1 = "select * from tbl_Traphongsv";
        public void loadDatagridview_traphong()
        {

            dgvDssvtp.DataSource = ketnoi.laydlbang(select1);
            dgvDssvtp.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDssvtp.Columns[0].HeaderText = "Mã Trả phòng";
            dgvDssvtp.Columns[0].Width = 120;
            dgvDssvtp.Columns[1].HeaderText = "Mã SV";
            dgvDssvtp.Columns[1].Width = 120;
            dgvDssvtp.Columns[2].HeaderText = "Họ và Tên";
            dgvDssvtp.Columns[2].Width = 180;
            dgvDssvtp.Columns[3].HeaderText = "Giới Tính";
            dgvDssvtp.Columns[3].Width = 80;
            dgvDssvtp.Columns[4].HeaderText = "Ngày Sinh";
            dgvDssvtp.Columns[4].Width = 100;
            dgvDssvtp.Columns[5].HeaderText = "Nơi sinh";
            dgvDssvtp.Columns[5].Width = 150;
            dgvDssvtp.Columns[6].HeaderText = "Địa chỉ";
            dgvDssvtp.Columns[6].Width = 170;
            dgvDssvtp.Columns[7].HeaderText = "Số điện thoại";
            dgvDssvtp.Columns[7].Width = 150;
            dgvDssvtp.Columns[8].HeaderText = "Mã trường";
            dgvDssvtp.Columns[8].Width = 80;
            dgvDssvtp.Columns[9].HeaderText = "Phòng";
            dgvDssvtp.Columns[9].Width = 80;
            dgvDssvtp.Columns[10].HeaderText = "Ngày bắt đầu ở";
            dgvDssvtp.Columns[10].Width = 100;
            dgvDssvtp.Columns[11].HeaderText = "Ngày trả phòng";
            dgvDssvtp.Columns[11].Width = 100;
            
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
                FrmSinhVien fr = new FrmSinhVien();
                fr.btHuy_Click(sender, e);
            }
        }

        private void dgvDssv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            load_control();

        }
        public void load_control()
        {
            cbmasv.DataBindings.Clear();
            cbmasv.DataBindings.Add("Text", dgvDssv.DataSource, "Mssv");
            txtTensv.DataBindings.Clear();
            txtTensv.DataBindings.Add("Text", dgvDssv.DataSource, "Hotensv");
            txtGioitinh.DataBindings.Clear();
            txtGioitinh.DataBindings.Add("Text", dgvDssv.DataSource, "Gioitinh");
            dtpickngaysinh.DataBindings.Clear();
            dtpickngaysinh.DataBindings.Add("Text", dgvDssv.DataSource, "Ngaysinh");
            txtnoisinh.DataBindings.Clear();
            txtnoisinh.DataBindings.Add("Text", dgvDssv.DataSource, "Noisinh");
            txtSodt.DataBindings.Clear();
            txtSodt.DataBindings.Add("Text", dgvDssv.DataSource, "Sodt");
            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", dgvDssv.DataSource, "Diachi");
            txtMatruong.DataBindings.Clear();
            txtMatruong.DataBindings.Add("Text", dgvDssv.DataSource, "Matruong");
            txtMaphong.DataBindings.Clear();
            txtMaphong.DataBindings.Add("Text", dgvDssv.DataSource, "Mapsv");
            dtpngaybd.DataBindings.Clear();
            dtpngaybd.DataBindings.Add("Text", dgvDssv.DataSource, "Tgbd");
            dtpngaykt.DataBindings.Clear();
            dtpngaykt.DataBindings.Add("Text", dgvDssv.DataSource, "Tgkt");
        }
        public void load_masv()
        {
            DataSet ds;
            ds = ketnoi.laytruong(select);
            cbmasv.DataSource=ds.Tables[0];
            cbmasv.DisplayMember = "Mssv";
        }
        public void load_matrphong()
        {
            DataSet ds = ketnoi.laytruong(select1);
            cbmatraphong.DataSource = ds.Tables[0];
            cbmatraphong.DisplayMember = "Matraphong";

        }
        private void cbmasv_MouseClick(object sender, MouseEventArgs e)
        {
            load_masv();

        }
        public void loadmasv()
        {
            DataSet ds = ketnoi.laytruong(select);
            cbmasv.DataSource = ds.Tables[0];
            txtTensv.DataBindings.Clear();
            txtTensv.DataBindings.Add("Text", ds.Tables[0], "Hotensv");
            txtGioitinh.DataBindings.Clear();
            txtGioitinh.DataBindings.Add("Text", ds.Tables[0], "Gioitinh");
            dtpickngaysinh.DataBindings.Clear();
            dtpickngaysinh.DataBindings.Add("Text", ds.Tables[0], "Ngaysinh");
            txtnoisinh.DataBindings.Clear();
            txtnoisinh.DataBindings.Add("Text", ds.Tables[0], "Noisinh");
            txtSodt.DataBindings.Clear();
            txtSodt.DataBindings.Add("Text", ds.Tables[0], "Sodt");
            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", ds.Tables[0], "Diachi");
            txtMatruong.DataBindings.Clear();
            txtMatruong.DataBindings.Add("Text", ds.Tables[0], "Matruong");
            txtMaphong.DataBindings.Clear();
            txtMaphong.DataBindings.Add("Text", ds.Tables[0], "Mapsv");
            dtpngaybd.DataBindings.Clear();
            dtpngaybd.DataBindings.Add("Text", ds.Tables[0], "Tgbd");
            dtpngaykt.DataBindings.Clear();
            dtpngaykt.DataBindings.Add("Text", ds.Tables[0], "Tgkt");
        }
        private void XoaControl(object sender, EventArgs e)
        {
            cbmasv.Text = null;
            txtTensv.Text = "";
            txtGioitinh.Text = null;
            dtpickngaysinh.Text = null;
            txtnoisinh.Text = "";
            txtDiachi.Text = "";
            txtSodt.Text = "";
            txtMatruong.Text = null;           
            txtMaphong.Text = null;            
            loadDatagridview();
            loadDatagridview_traphong();
        }
        private void txtMatruong_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvDssvtp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            load_control();
        }

        private void btTraphong_Click(object sender, EventArgs e)
        {
            if (cbmasv.Text=="")
            {
                MessageBox.Show("Bạn phải chọn sinh viên muốn trả phòng!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {

                //int sott = 1;
                DialogResult rs;
                rs = MessageBox.Show("Bạn muốn thực hiện trả phòng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    string insert = "insert into tbl_Traphongsv values('"+txttraphong.Text+"','" + cbmasv.Text + "',N'" + txtTensv.Text + "',N'" + txtGioitinh.Text + "','" + dtpickngaysinh.Text + "',N'" + txtnoisinh.Text + "',N'" + txtDiachi.Text + "','" + txtSodt.Text + "','" + txtMatruong.Text + "','" + txtMaphong.Text + "','"+dtpngaybd.Text+"','"+dtpngaykt.Text+"') ";
                    ketnoi.ThucHienCmd(insert);
                    string del = "delete tbl_SinhVien where Mssv='" + cbmasv.Text + "'";
                    ketnoi.ThucHienCmd(del);
                    string del1 = "delete tbl_HopDong where Mssv='" + cbmasv.Text + "'";
                    ketnoi.ThucHienCmd(del1);
                    MessageBox.Show("Sinh viên '" + txtTensv.Text + "' đã trả phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string update = "update tbl_PhongSV set Sosinhvien=Sosinhvien - '" + 1 + "' where Mapsv='" + txtMaphong.Text + "'";
                    ketnoi.ThucHienCmd(update);

                    TaoMaTang();
                    XoaControl(sender,e);                    
                }
                
               
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            cbmatraphong.Visible = true;
            load_matrphong();
            btxoa.Visible = false;
            btluu.Enabled = true;
            MessageBox.Show("Bạn hãy chọn mã trả phòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            cbmatraphong.Visible = false;
            btxoa.Visible = true;
            btluu.Enabled = false;
            DialogResult rs;
            rs = MessageBox.Show("Bạn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                string del = "delete tbl_Traphongsv where Matraphong='" + cbmatraphong.Text + "'";
                ketnoi.ThucHienCmd(del);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_matrphong();
                loadDatagridview_traphong();
            }      

        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string sql = select + " where tbl_SinhVien.Mssv like '%" + txttimkiem.Text + "%' or Hotensv like '%" + txttimkiem.Text + "%'";
            dgvDssv.DataSource = ketnoi.laydlbang(sql);
            dgvDssv.Refresh();
        }

         
    }
}