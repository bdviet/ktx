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
    public partial class FrmHoatDong : Form
    {
        public FrmHoatDong()
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

       
        string select = "select * from tbl_HoatDong";
        public void load_Datagridview()
        {
            dgvDshd.DataSource = ketnoi.laydlbang(select);
            dgvDshd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDshd.Columns[0].HeaderText = "Mã hoạt động";
            dgvDshd.Columns[0].Width = 130;
            dgvDshd.Columns[1].HeaderText = "Tên hoạt động";
            dgvDshd.Columns[1].Width = 320;
            dgvDshd.Columns[2].HeaderText = "Thơi gian tổ chức";
            dgvDshd.Columns[2].Width = 130;
            dgvDshd.Columns[3].HeaderText = "Mã nhân viên";
            dgvDshd.Columns[3].Width = 130;
        }
        public string Quyen;
        public string Ten;

        private void FrmHoatDong_Load(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
            load_Datagridview();
            load_mahd_manv();
            btHuy_Click(sender,e);
        	
        	txtquyen.Text = Quyen;
            txtten.Text = Ten;
            if (txtquyen.Text == "Admin")
            {
                btXoa.Enabled = true;
            }

        }
        public void load_mahd_manv()
        {
            DataSet ds;
            ds = ketnoi.laytruong(select);
            cbmahd.DataSource=ds.Tables[0];
            cbmahd.DisplayMember = "Mahdong";
            //--
            DataSet ds1;
            ds1 = ketnoi.laytruong("select Manv from tbl_NhanVien");
            cbmanv.DataSource = ds1.Tables[0];
            cbmanv.DisplayMember = "Manv";
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            cbmahd.Text = null;
            txttenhd.Text = "";
            txttennv.Text = "";
            cbmanv.Text = null;
            dtpTgtochuc.Text = DateTime.Today.TimeOfDay.ToString();
            load_Datagridview();
        }

        private void dgvDshd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbmahd.DataBindings.Clear();
            cbmahd.DataBindings.Add("Text",dgvDshd.DataSource,"Mahdong");
            txttenhd.DataBindings.Clear();
            txttenhd.DataBindings.Add("Text", dgvDshd.DataSource, "Tenhd");
            dtpTgtochuc.DataBindings.Clear();
            dtpTgtochuc.DataBindings.Add("Text",dgvDshd.DataSource,"Tgtchuc");
            cbmanv.DataBindings.Clear();
            cbmanv.DataBindings.Add("Text",dgvDshd.DataSource,"Manv");
        }

        private void cbmanv_MouseClick(object sender, MouseEventArgs e)
        {
            DataSet ds;
            ds = ketnoi.laytruong("select * from tbl_NhanVien");
            cbmanv.DataSource = ds.Tables[0];
            txttennv.DataBindings.Clear();
            txttennv.DataBindings.Add("Text", ds.Tables[0], "Hotennv");
        }

        private void cbmahd_MouseClick(object sender, MouseEventArgs e)
        {
            DataSet ds;
            ds = ketnoi.laytruong(select);
            cbmahd.DataSource = ds.Tables[0];
            txttenhd.DataBindings.Clear();
            txttenhd.DataBindings.Add("Text", ds.Tables[0], "Tenhd");
            dtpTgtochuc.DataBindings.Clear();
            dtpTgtochuc.DataBindings.Add("Text", ds.Tables[0], "Tgtchuc");
            cbmanv.DataBindings.Clear();
            cbmanv.DataBindings.Add("Text", ds.Tables[0], "Manv");
        }

        private void cbmahd_TextChanged(object sender, EventArgs e)
        {
            if (cbmahd.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;
        }

        private void txttenhd_TextChanged(object sender, EventArgs e)
        {
            if (txttenhd.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;
        }

        private void cbmanv_TextChanged(object sender, EventArgs e)
        {
            if (cbmanv.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmahd.Text=="")
                {
                    MessageBox.Show("Bạn hãy nhập Mã hoạt động!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbmahd.Select();
                    return;
                }
                if (txttenhd.Text=="")
                {
                    MessageBox.Show("Bạn hãy tên hoạt động!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttenhd.Select();
                    return;
                }
                if (cbmanv.Text=="")
                {
                    MessageBox.Show("Bạn hãy chọn mã nhân viên quản lý hoạt động!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbmanv.Select();
                    return;
                }
                SqlDataReader dr = ketnoi.ThuchienReader(select);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0) == cbmahd.Text)
                        {
                            dr.Close();
                            dr.Dispose();
                            throw new Exception();
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                string insert = "insert into tbl_HoatDong values('" + cbmahd.Text + "',N'" + txttenhd.Text + "','"+dtpTgtochuc.Value.ToString()+"','"+cbmanv.Text+"')";
                ketnoi.ThucHienCmd(insert);
                MessageBox.Show("Bạn đã thêm mã '" + cbmahd.Text + "' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btHuy_Click(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Mã hoạt động trùng, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (cbmahd.Text == "")
                MessageBox.Show("Bạn hãy chọn mã gia hạn muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                SqlDataReader dr = ketnoi.ThuchienReader(select);

                Boolean kt = false;
                if (dr != null)
                {

                    while (dr.Read())
                    {
                        if (dr.GetString(0) == cbmahd.Text)
                        {
                            kt = true;

                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                if (kt == false)
                {
                    MessageBox.Show("Mã hoạt động không tồn tại, vui lòng nhập đúng Mã cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult rs;
                    rs = MessageBox.Show("Bạn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        string del = "delete tbl_HoatDong where Mahdong='" + cbmahd.Text + "'";
                        ketnoi.ThucHienCmd(del);
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btHuy_Click(sender, e);
                    }
                }
            }  
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (cbmahd.Text == "")
                MessageBox.Show("Bạn hãy chọn mã gia hạn muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                SqlDataReader dr = ketnoi.ThuchienReader(select);

                Boolean kt = false;
                if (dr != null)
                {

                    while (dr.Read())
                    {
                        if (dr.GetString(0) == cbmahd.Text)
                        {
                            kt = true;

                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                if (kt == false)
                {
                    MessageBox.Show("Mã hoạt động không tồn tại, vui lòng nhập đúng Mã cần Sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult rs;
                    rs = MessageBox.Show("Bạn muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        string sua = "update tbl_HoatDong set Mahdong='" + cbmahd.Text + "',Tenhd=N'" + txttenhd.Text + "',Tgtchuc='" + dtpTgtochuc.Value.ToString() + "',Manv='" + cbmanv.Text + "' where Mahdong='" + cbmahd.Text + "'";
                        ketnoi.ThucHienCmd(sua);
                        MessageBox.Show("Bạn đã sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btHuy_Click(sender, e);
                    }
                }
            }
        }


       
        
        
    }
}