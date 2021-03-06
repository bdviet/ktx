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
    public partial class FrmNguoidung : Form
    {
        public FrmNguoidung()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Bạn có muốn thoát hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr==DialogResult.Yes)
            {
                this.Close();
                ketnoi.CloseCn();
            }
        }

        private void FrmNguoidung_Load(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
            loadDatagridview();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtpass.Text = "";
            cbquyen.Text = null;
            loadDatagridview();
            txtName.Select();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                btHuy.Enabled = true;
            }
            else
            {
                btHuy.Enabled = false;
                txtName.Select();
            }
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            if (txtpass.Text != "")
            {
                btHuy.Enabled = true;
            }
            else
                  btHuy.Enabled = false;
                
            
        }
        public void loadDatagridview()
        {
            dgvDsuser.DataSource = ketnoi.laydlbang("select * from tbl_DangNhap");
            dgvDsuser.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDsuser.Columns[0].HeaderText = "Tên Đăng Nhập";
            dgvDsuser.Columns[0].Width = 140;
            dgvDsuser.Columns[1].HeaderText = "Mật Khẩu";
            dgvDsuser.Columns[1].Width = 140;
            dgvDsuser.Columns[2].HeaderText = "Quyền người dùng";
            dgvDsuser.Columns[2].Width = 140;
        }
        
        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text=="")
	            {
		            MessageBox.Show("Hãy nhập tên đăng nhập!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtName.Select();
                    return;
	            }
                if (txtpass.Text=="")
	            {
		            MessageBox.Show("Hãy nhập mật khẩu!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtpass.Select();
                    return;
	            }
                if (cbquyen.Text=="")
	            {
		            MessageBox.Show("Hãy chọn quyền người dùng!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    cbquyen.Select();
                    return;
	            }
                string select = "select Tendn from tbl_DangNhap";
                SqlDataReader dr = ketnoi.ThuchienReader(select);
                if (dr!=null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0)==txtName.Text)
                        {
                            dr.Close();
                            dr.Dispose();
                            throw new Exception();
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                string insert = "insert into tbl_DangNhap values('"+txtName.Text+"','"+txtpass.Text+"','"+cbquyen.Text+"')";
                ketnoi.ThucHienCmd(insert);
                MessageBox.Show("Hệ thống đã thêm "+txtName.Text+" Vào danh sách người dùng!");
                btHuy_Click(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Tên đăng nhập đã có, vui lòng đặt tên khác!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                btHuy_Click(sender,e);
            }
        }

        private void dgvDsuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("Text", dgvDsuser.DataSource, "Tendn");
            txtpass.DataBindings.Clear();
            txtpass.DataBindings.Add("Text", dgvDsuser.DataSource, "Matkhau");
            cbquyen.DataBindings.Clear();
            cbquyen.DataBindings.Add("Text", dgvDsuser.DataSource, "Quyen");
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtName.Text=="")
            {
                MessageBox.Show("Hãy nhập tên đăng nhập cần xóa!","Chú ý",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                SqlDataReader dr = ketnoi.ThuchienReader("select * from tbl_DangNhap");
                Boolean kt = false;
                if (dr!=null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0)==txtName.Text)
                        {
                            kt = true;
                        }   
                    }
                }
                dr.Close();
                dr.Dispose();
                if (kt==false)
                {
                    MessageBox.Show("Tên đăng nhập không tồn tại, vui lòng nhập đúng tên cần xóa!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    btHuy_Click(sender,e);
                }
                else
                {
                    DialogResult rs;
                    rs = MessageBox.Show("Bạn muốn xóa không?","Xóa",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                    if (rs==DialogResult.Yes)
                    {
                        string del = "delete tbl_DangNhap where Tendn='"+txtName.Text+"'";
                        ketnoi.ThucHienCmd(del);
                        btHuy_Click(sender,e); 
                    }
                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Hãy nhập tên đăng nhập cần Sửa!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlDataReader dr = ketnoi.ThuchienReader("select * from tbl_DangNhap");
                Boolean kt = false;
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0) == txtName.Text)
                        {
                            kt = true;
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                if (kt == false)
                {
                    MessageBox.Show("Tên đăng nhập không tồn tại, vui lòng nhập đúng tên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btHuy_Click(sender, e);
                }
                else
                {
                    DialogResult rs;
                    rs = MessageBox.Show("Bạn muốn sửa không?", "Sủa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rs == DialogResult.Yes)
                    {
                        string sua = "update tbl_DangNhap set Tendn='" + txtName.Text + "',Matkhau ='"+txtpass.Text+"',Quyen='"+cbquyen.Text+"' where Tendn ='"+txtName.Text+"'";
                        ketnoi.ThucHienCmd(sua);
                        btHuy_Click(sender, e);
                    }
                }
            }
        }

       
    }
}