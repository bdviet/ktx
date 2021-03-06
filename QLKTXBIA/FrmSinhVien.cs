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
    public partial class FrmSinhVien : Form
    {
        public FrmSinhVien()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
                ketnoi.CloseCn();
            }
        }

        public string Quyen;
        public string Ten;
        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
            load_masv_truong_phongosv();
            loadDatagridview();
            btHuy_Click(sender,e);
            txtquyen.Text = Quyen;
            txtten.Text = Ten;
            cbSoPhong.Text = null;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmasv.Text=="")
                {
                    MessageBox.Show("Bạn hãy nhập Mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbmasv.Select();
                    return;
                }
                if (txtTensv.Text=="")
                {
                    MessageBox.Show("Bạn hãy nhập tên sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTensv.Select();
                    return;
                }
                if (cbgioitinh.Text=="")
                {
                     MessageBox.Show("Bạn hãy chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     cbgioitinh.Select();
                     return;
                }
                if (txttangso.Text=="")
                {
                     MessageBox.Show("Vui lòng chọn lại số phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     cbSoPhong.Select();
                     return;
                }
                if (txtDiachi.Text=="")
                {
                     MessageBox.Show("Bạn hãy nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     txtDiachi.Select();
                     return;
                }
                if (txtnoisinh.Text=="")
                {
                     MessageBox.Show("Bạn hãy nhập nơi sinh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     txtnoisinh.Select();
                     return;
                }
                if (txtSodt.Text=="")
                {
                      MessageBox.Show("Bạn hãy nhập số điện !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      txtSodt.Select();
                      return;
                }
                if (cbSoPhong.Text=="")
                {
                      MessageBox.Show("Bạn hãy chọn số phòng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      cbSoPhong.Select();
                      return;
                }
                if (cbMatruong.Text=="")
                {
                      MessageBox.Show("Bạn hãy chọn mã trường !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      cbMatruong.Select();
                      return;
                }
                string select = "select Mssv from tbl_SinhVien";
                SqlDataReader dr = ketnoi.ThuchienReader(select);
                if (dr!=null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0)==cbmasv.Text)
                        {
                            dr.Close();
                            dr.Dispose();
                            throw new Exception();
                        }
                    }
               }
                dr.Close();
                dr.Dispose();
                int sosinhvien = Convert.ToInt32(txtSosv.Text);
                if (sosinhvien <= 7)
                {
                    if (cbgioitinh.Text == "Nam")
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
                else { MessageBox.Show("Phòng  '"+cbSoPhong.Text+"' đã đủ người. Vui lòng chọn phòng khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
               
            }
            catch (Exception)
            {
                MessageBox.Show("Mã sinh viên đã có, vui lòng đặt mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
        public void chuyen(object sender, EventArgs e)
        {
            string insert = "insert into tbl_SinhVien values('" + cbmasv.Text + "',N'" + txtTensv.Text + "',N'" + cbgioitinh.Text + "','" + dtpickngaysinh.Text + "',N'" + txtnoisinh.Text + "',N'" + txtDiachi.Text + "','" + txtSodt.Text + "','" + cbMatruong.Text + "','" + cbSoPhong.Text + "')";
            ketnoi.ThucHienCmd(insert);
            string update = "update tbl_PhongSV set Sosinhvien=Sosinhvien + '" + 1 + "', Giuongtrong=Giuongtrong - '" + 1 + "' where Mapsv='" + cbSoPhong.Text + "'";
            ketnoi.ThucHienCmd(update);
            MessageBox.Show("Bạn đã thêm thành công và nhập thông tin hợp đồng của sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btHuy_Click(sender, e);
            FrmHopdong fr = new FrmHopdong();
            fr.Ten = txtten.Text;
            fr.Quyen = txtquyen.Text;
            fr.anthoat();
            fr.ShowDialog();   
        }
        private void txtSodt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        public void load_masv_truong_phongosv()
        {
            string select = "select Mssv from tbl_SinhVien";
            DataSet ds = ketnoi.laytruong(select);
            cbmasv.DataSource = ds.Tables[0];
            cbmasv.DisplayMember = "Mssv";
            
            //--
            string select1 = "select Matruong from tbl_Truong";
            DataSet ds1 = ketnoi.laytruong(select1);
            cbMatruong.DataSource = ds1.Tables[0];
            cbMatruong.DisplayMember = "Matruong";
            //--
            string select2 = "select Mapsv from tbl_PhongSV";
            DataSet ds2 = ketnoi.laytruong(select2);
            cbSoPhong.DataSource = ds2.Tables[0];
            cbSoPhong.DisplayMember = "Mapsv";

        }
        public void loadDatagridview()
        {

            dgvDssv.DataSource = ketnoi.laydlbang("select * from tbl_SinhVien");
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
        }
        public void loadGrid_Control()
        {
            cbmasv.DataBindings.Clear();
            cbmasv.DataBindings.Add("Text", dgvDssv.DataSource, "Mssv");
            txtTensv.DataBindings.Clear();
            txtTensv.DataBindings.Add("Text", dgvDssv.DataSource, "Hotensv");
            cbgioitinh.DataBindings.Clear();
            cbgioitinh.DataBindings.Add("Text", dgvDssv.DataSource, "Gioitinh");
            dtpickngaysinh.DataBindings.Clear();
            dtpickngaysinh.DataBindings.Add("Text", dgvDssv.DataSource, "Ngaysinh");            
            txtnoisinh.DataBindings.Clear();
            txtnoisinh.DataBindings.Add("Text", dgvDssv.DataSource, "Noisinh");
            txtSodt.DataBindings.Clear();
            txtSodt.DataBindings.Add("Text", dgvDssv.DataSource, "Sodt");
            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", dgvDssv.DataSource, "Diachi");
            cbMatruong.DataBindings.Clear();
            cbMatruong.DataBindings.Add("Text", dgvDssv.DataSource, "Matruong");
            cbSoPhong.DataBindings.Clear();
            cbSoPhong.DataBindings.Add("Text", dgvDssv.DataSource, "Mapsv");

        }

        private void dgvDssv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadGrid_Control();
        }

        private void cbmanv_MouseClick(object sender, MouseEventArgs e)
        {
            DataSet ds;
            string select = "select * from tbl_SinhVien";
            ds = ketnoi.laytruong(select);
            cbmasv.DataSource=ds.Tables[0];           
            txtTensv.DataBindings.Clear();
            txtTensv.DataBindings.Add("Text", ds.Tables[0], "Hotensv");
            cbgioitinh.DataBindings.Clear();
            cbgioitinh.DataBindings.Add("Text", ds.Tables[0], "Gioitinh");
            dtpickngaysinh.DataBindings.Clear();
            dtpickngaysinh.DataBindings.Add("Text", ds.Tables[0], "Ngaysinh");
            txtnoisinh.DataBindings.Clear();
            txtnoisinh.DataBindings.Add("Text", ds.Tables[0], "Noisinh");
            txtSodt.DataBindings.Clear();
            txtSodt.DataBindings.Add("Text", ds.Tables[0], "Sodt");
            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", ds.Tables[0], "Diachi");
            cbMatruong.DataBindings.Clear();
            cbMatruong.DataBindings.Add("Text", ds.Tables[0], "Matruong");
            cbSoPhong.DataBindings.Clear();
            cbSoPhong.DataBindings.Add("Text", ds.Tables[0], "Mapsv");
        }

        private void cbMatruong_MouseClick(object sender, MouseEventArgs e)
        {
            DataSet ds;
            string select = "select * from tbl_Truong";
            ds = ketnoi.laytruong(select);
            cbMatruong.DataSource=ds.Tables[0];
            txtTentruong.DataBindings.Clear();
            txtTentruong.DataBindings.Add("Text",ds.Tables[0],"Tentruong");
        }

        //private void cbSoPhong_MouseClick(object sender, MouseEventArgs e)
        //{
        //    DataSet ds;
        //    string select="select * from tbl_PhongSV";
        //    ds = ketnoi.laytruong(select);
        //    cbSoPhong.DataSource= ds.Tables[0];
        //    txtKhu.DataBindings.Clear();
        //    txtKhu.DataBindings.Add("Text",ds.Tables[0],"Makhu");
        //}

        private void txtTensv_TextChanged(object sender, EventArgs e)
        {
            if (txtTensv.Text != "")
            {
                btHuy.Enabled = true;
            }
            else
                btHuy.Enabled = false;
        }

        public void btHuy_Click(object sender, EventArgs e)
        {
            cbmasv.Text = null;
            txtTensv.Text = "";
            cbgioitinh.Text = null;
            dtpickngaysinh.Text = null;
            txtnoisinh.Text = "";
            txtDiachi.Text = "";
            txtSodt.Text = "";
            cbMatruong.Text = null;
            txtTentruong.Text = "";
            cbSoPhong.Text = null;
            txtSosv.Text = "";
            txttangso.Text = "";
            loadDatagridview();
            cbSoPhong.Enabled = true;
            btsua1.Visible = true;
            btSua.Visible = false;
        }
        string select = "select * from tbl_SinhVien";
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (cbmasv.Text=="")
            {
                MessageBox.Show("Bạn hãy nhập mã sinh viên muốn xóa!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                SqlDataReader dr = ketnoi.ThuchienReader(select);
                Boolean kt = false;
                if (dr!=null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0)==cbmasv.Text)
                        {
                            kt = true;
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                if (kt==false)
                {
                     MessageBox.Show("Mã sinh viên không tồn tại, vui lòng nhập đúng Mã cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FrmTraPhong fr = new FrmTraPhong();
                    fr.Ten = txtten.Text;
                    fr.Quyen = txtquyen.Text;
                    fr.Mssv = cbmasv.Text;
                    fr.ShowDialog();
                    //DialogResult rs;
                    //rs = MessageBox.Show("Bạn muốn xóa không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    //if (rs==DialogResult.Yes)
                    //{
                    //    string del = "delete tbl_SinhVien where Mssv='"+cbmasv.Text+"'";
                    //    ketnoi.ThucHienCmd(del);
                    //    MessageBox.Show("Bạn đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btHuy_Click(sender,e);
                    //}
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (cbmasv.Text=="")
            {
                 MessageBox.Show("Bạn hãy nhập mã đúng sinh viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlDataReader dr = ketnoi.ThuchienReader(select);
                Boolean kt = false;
                if (dr!=null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0)==cbmasv.Text)
                        {
                            kt = true;
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                if (kt==false)
                {
                     MessageBox.Show("Mã sinh viên không tồn tại, vui lòng nhập đúng Mã cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {

                    //---
                    DialogResult rs;
                    rs = MessageBox.Show("Bạn muốn sửa không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (rs==DialogResult.Yes)
                    {
                        string sua = "update tbl_SinhVien set Mssv='" + cbmasv.Text + "',Hotensv=N'" + txtTensv.Text + "',Gioitinh=N'" + cbgioitinh.Text + "',Ngaysinh='" + dtpickngaysinh.Text + "',Noisinh=N'" + txtnoisinh.Text + "',Diachi=N'" + txtDiachi.Text + "',Sodt='" + txtSodt.Text + "',Matruong='" + cbMatruong.Text + "',Mapsv='" + cbSoPhong.Text + "' where Mssv='" + cbmasv.Text + "'";
                        ketnoi.ThucHienCmd(sua);
                        MessageBox.Show("Bạn đã sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btHuy_Click(sender,e);
                        btsua1.Visible = true;
                        btSua.Visible = false;
                        cbgioitinh.Enabled = true;
                    }
                    //---
                }
            }
        }
       
        private void btaddtruong_Click(object sender, EventArgs e)
        {
            FrmTruonghoc frm = new FrmTruonghoc();
            frm.Ten = txtten.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }

        private void btaddphong_Click(object sender, EventArgs e)
        {
            FrmPhongOSv frm = new FrmPhongOSv();
            frm.Ten = txtten.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }

        private void cbSoPhong_MouseClick(object sender, MouseEventArgs e)
        {
            string select = "select * from tbl_PhongSV";
            DataSet ds = ketnoi.laytruong(select);
            cbSoPhong.DataSource = ds.Tables[0];
            txttangso.DataBindings.Clear();
            txttangso.DataBindings.Add("Text", ds.Tables[0], "Tang");
            txtSosv.DataBindings.Clear();
            txtSosv.DataBindings.Add("Text", ds.Tables[0], "Sosinhvien");
            //txtgiuong.DataBindings.Clear();
            //txtgiuong.DataBindings.Add("Text", ds.Tables[0], "Sogiuong");
            //txtgiuongtrong.DataBindings.Clear();
            //txtgiuongtrong.DataBindings.Add("Text", ds.Tables[0], "Giuongtrong");
        }

        private void btsua1_Click(object sender, EventArgs e)
        {
            btHuy_Click(sender,e);
            cbSoPhong.Enabled = false;
            btsua1.Visible = false;
            btSua.Visible = true;
            cbgioitinh.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbmasv.Text != "")
            {
                SqlDataReader dr = ketnoi.ThuchienReader(select);
                Boolean kt = false;
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0) == cbmasv.Text)
                        {
                            kt = true;
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                if (kt == false)
                {
                    MessageBox.Show("Mã sinh viên không tồn tại, vui lòng nhập đúng Mã cần in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    FrmInSinhVien frm = new FrmInSinhVien();
                    frm.Mssv = cbmasv.Text;
                    frm.Inthesinhvien(sender, e);
                    frm.ShowDialog();             
                }
               
            }
            else
            {
                MessageBox.Show("Bạn hãy chọn mã sinh viên để in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbmasv.Select();
            }   
           
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            FrmTimKiem fr = new FrmTimKiem();
            fr.ShowDialog();
        }

        private void cbgioitinh_KeyPress(object sender, KeyPressEventArgs e)
        {
           ketnoi.Chivietso(sender, e);          
            MessageBox.Show("Bạn vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);            
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from tbl_SinhVien where Hotensv like N'%"+txttimkiem.Text+"%'";
            dgvDssv.DataSource = ketnoi.laydlbang(sql);          
            dgvDssv.Refresh();
        }


       

     
        
    }
}