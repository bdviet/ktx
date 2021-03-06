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
    public partial class FrmChuyenPhong : Form
    {
        public FrmChuyenPhong()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        public string Quyen;
        public string Ten;
        private void FrmChuyenPhong_Load(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
            load_masv();
            cbmasv.Text = null;            
            load_datagidview();
            matutang();
            load_phongsv();
            cbPhongchuyenden.Text = null;
            txtquyen.Text = Quyen;
            txtten.Text = Ten;
        }
        public void load_phongsv()
        {
            ds = ketnoi.laytruong("select Mapsv from tbl_PhongSV");
            cbPhongchuyenden.DataSource=ds.Tables[0];
            cbPhongchuyenden.DisplayMember="Mapsv";
        }
        private void XoaControl(object sender, EventArgs e)
        {
            cbmasv.Text = null;
            txtTensv.Text = "";
            txtGioitinh.Text = null;
            cbPhongchuyenden.Text = null;
            txtphongdango.Text = "";            
            load_datagidview();
            txtSosv.Text = "";
            txttangso.Text = "";
            
        }
        DataSet ds;
        public void matutang()
        {
            if (kn.LayGiaTri("Select count(MaChuyenPhong) from tbl_SVChuyenPhong") == "0")
                txtchuyenphong.Text = "Ma-1";
            else
                txtchuyenphong.Text = "Ma-" + ((float.Parse(kn.LayGiaTri("Select Top(1) CONVERT(float,RIGHT(MaChuyenPhong,len(MaChuyenPhong)-3)) from tbl_SVChuyenPhong Order by  CONVERT(float,RIGHT(MaChuyenPhong,len(MaChuyenPhong)-3)) DESC"))) + 1); 
        }
        public void load_datagidview()
        {
            dgvDssv.DataSource = ketnoi.laydlbang("SELECT tbl_SVChuyenPhong.MaChuyenPhong,tbl_SinhVien.Mssv,tbl_SinhVien.Hotensv,tbl_SinhVien.Gioitinh,tbl_SVChuyenPhong.Phongdango,tbl_SVChuyenPhong.Phongchuyenden, tbl_SVChuyenPhong.Ngaychuyen FROM tbl_SinhVien INNER JOIN tbl_SVChuyenPhong ON dbo.tbl_SinhVien.Mssv = tbl_SVChuyenPhong.Mssv");
            dgvDssv.ColumnHeadersDefaultCellStyle.Alignment= DataGridViewContentAlignment.MiddleCenter;

            dgvDssv.Columns[0].HeaderText = "Mã Chuyển";
            dgvDssv.Columns[0].Width = 100;
            dgvDssv.Columns[1].HeaderText = "Mã SV";
            dgvDssv.Columns[1].Width = 120;
            dgvDssv.Columns[2].HeaderText = "Họ và Tên";
            dgvDssv.Columns[2].Width = 180;
            dgvDssv.Columns[3].HeaderText = "Giới Tính";
            dgvDssv.Columns[3].Width = 80;
            dgvDssv.Columns[4].HeaderText = "Phòng đang ở";
            dgvDssv.Columns[4].Width = 100;
            dgvDssv.Columns[5].HeaderText = "Phòng chuyển đến";
            dgvDssv.Columns[5].Width = 150;
            dgvDssv.Columns[6].HeaderText = "Ngày chuyển";
            dgvDssv.Columns[6].Width = 150;
            
        }
        public void load_masv()
        {
            ds = ketnoi.laytruong("select Mssv from tbl_SinhVien");
            cbmasv.DataSource = ds.Tables[0];
            cbmasv.DisplayMember = "Mssv";
        }
        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbchuyenphong_Click(object sender, EventArgs e)
        {
            if (cbmasv.Text=="")
            {
                 MessageBox.Show("Bạn phải chọn sinh viên muốn chuyển phòng!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                cbmasv.Select();
                return;
            }
            if (cbPhongchuyenden.Text=="")
	            {
            		 MessageBox.Show("Bạn phải chọn phòng cần chuyển!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                     cbPhongchuyenden.Select();
                     return;
	            }
            //--
            int sosv=Convert.ToInt32(txtSosv.Text);
            if (sosv <= 7)
            {
                if (txtGioitinh.Text == "Nam")
                {
                    if (txttangso.Text == "3" | txttangso.Text == "4" | txttangso.Text == "5")
                    {
                        chuyen(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng xem  lại giới tính(Tầng '" + txttangso.Text + "' là tầng Nữ ở)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    if (txttangso.Text == "1" | txttangso.Text == "2")
                    {
                        chuyen(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng xem  lại giới tính(Tầng '" + txttangso.Text + "' là tầng Nam ở)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            else
            {
                MessageBox.Show("Phòng '"+cbchuyenphong.Text+"' đã đủ người. Vui lòng chọn phòng khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //--
               
            
        }
        public void chuyen(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn muốn thực hiện chuyển phòng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                string insert = "insert into tbl_SVChuyenPhong values('" + txtchuyenphong.Text + "','" + cbmasv.Text + "','" + txtphongdango.Text + "','" + cbPhongchuyenden.Text + "','" + dtngaychuyen.Text + "') ";
                ketnoi.ThucHienCmd(insert);
                MessageBox.Show("Sinh viên '" + txtTensv.Text + "' đã chuyển phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string update = "update tbl_PhongSV set Sosinhvien=Sosinhvien + '" + 1 + "' where Mapsv='" + cbPhongchuyenden.Text + "'";
                ketnoi.ThucHienCmd(update);
                string update1 = "update tbl_PhongSV set Sosinhvien=Sosinhvien - '" + 1 + "' where Mapsv='" + txtphongdango.Text + "'";
                ketnoi.ThucHienCmd(update1);
                string update2 = "update tbl_SinhVien set Mapsv ='" + cbPhongchuyenden.Text + "' where Mssv='" + cbmasv.Text + "'";
                ketnoi.ThucHienCmd(update2);
                matutang();
                XoaControl(sender, e);
            }
        }
        private void cbmasv_MouseClick(object sender, MouseEventArgs e)
        {
            ds = ketnoi.laytruong("Select * from tbl_SinhVien");
            cbmasv.DataSource=ds.Tables[0];
            txtTensv.DataBindings.Clear();
            txtTensv.DataBindings.Add("Text",ds.Tables[0],"Hotensv");           
            txtGioitinh.DataBindings.Clear();
            txtGioitinh.DataBindings.Add("Text", ds.Tables[0], "Gioitinh");
            txtphongdango.DataBindings.Clear();
            txtphongdango.DataBindings.Add("Text", ds.Tables[0], "Mapsv");
        }

        private void btaddphong_Click(object sender, EventArgs e)
        {
            FrmPhongOSv frm = new FrmPhongOSv();
            frm.ShowDialog();
        }

        private void cbPhongchuyenden_MouseClick(object sender, MouseEventArgs e)
        {
            ds = ketnoi.laytruong("select * from tbl_PhongSV");
            cbPhongchuyenden.DataSource = ds.Tables[0];
            txttangso.DataBindings.Clear();
            txttangso.DataBindings.Add("Text",ds.Tables[0],"Tang");
            txtSosv.DataBindings.Clear();
            txtSosv.DataBindings.Add("Text", ds.Tables[0], "Sosinhvien");
        }

       

       
    }
}