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
    public partial class FrmTruonghoc : Form
    {
        public FrmTruonghoc()
        {
            InitializeComponent();
        }
        public string Quyen;
        public string Ten;
        string select ="select * from tbl_Truong";
        private void cbthoat_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
               // ketnoi.CloseCn();
            }
        }

        private void FrmTruonghoc_Load(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
            loadDatagridview();
            load_matruong();
            cbhuy_Click(sender,e);
            txtquyen.Text=Quyen;
            txtten.Text = Ten;
            if (txtquyen.Text=="Admin")
            {
                btxoa.Enabled = true;
            }
        }
        public void load_matruong()
        {
            DataSet ds;           
            ds = ketnoi.laytruong(select);
            cbmatruong.DataSource = ds.Tables[0];
            cbmatruong.DisplayMember = "Matruong";
        }
       
        public void loadDatagridview()
        {
            dgvTruong.DataSource = ketnoi.laydlbang(select);
            dgvTruong.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTruong.Columns[0].HeaderText = "Mã trường";
            dgvTruong.Columns[0].Width = 100;
            dgvTruong.Columns[1].HeaderText = "Tên trường";
            dgvTruong.Columns[1].Width = 350;
            dgvTruong.Columns[2].HeaderText = "Địa chỉ";
            dgvTruong.Columns[2].Width = 450;
        }

        private void dgvTruong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbmatruong.DataBindings.Clear();
            cbmatruong.DataBindings.Add("Text", dgvTruong.DataSource, "Matruong");
            txttentruong.DataBindings.Clear();
            txttentruong.DataBindings.Add("Text", dgvTruong.DataSource, "Tentruong");
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", dgvTruong.DataSource, "Diachi");
        }

        private void cbmatruong_MouseClick(object sender, MouseEventArgs e)
        {
            DataSet ds;
            ds = ketnoi.laytruong(select);
            cbmatruong.DataSource = ds.Tables[0];
            txttentruong.DataBindings.Clear();
            txttentruong.DataBindings.Add("Text", ds.Tables[0], "Tentruong");
            txtdiachi.DataBindings.Clear();
            txtdiachi.DataBindings.Add("Text", ds.Tables[0], "Diachi");
        }

        private void cbhuy_Click(object sender, EventArgs e)
        {
            txtdiachi.Text = "";
            cbmatruong.Text = null;
            txttentruong.Text = "";
            loadDatagridview();
        }

        private void cbmatruong_TextChanged(object sender, EventArgs e)
        {
            if (cbmatruong.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true; 
        }

        private void txttentruong_TextChanged(object sender, EventArgs e)
        {
            if (txttentruong.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true; 
        }

        private void txtdiachi_TextChanged(object sender, EventArgs e)
        {
            if (txtdiachi.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true; 
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmatruong.Text == "")
                {
                    MessageBox.Show("Bạn hãy nhập Mã trường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbmatruong.Select();
                    return;
                }
                if (txttentruong.Text == "")
                {
                    MessageBox.Show("Bạn hãy nhập tên trường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttentruong.Select();
                    return;
                }
                if (txtdiachi.Text == "")
                {
                    MessageBox.Show("Bạn hãy nhập địa chỉ trường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtdiachi.Select();
                    return;
                }
                SqlDataReader dr = ketnoi.ThuchienReader(select);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0) == cbmatruong.Text)
                        {
                            dr.Close();
                            dr.Dispose();
                            throw new Exception();
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                string insert = "insert into tbl_Truong values('" + cbmatruong.Text + "',N'" + txttentruong.Text + "',N'"+txtdiachi.Text+"')";
                ketnoi.ThucHienCmd(insert);
                MessageBox.Show("Bạn đã thêm mã '" + cbmatruong.Text + "' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbhuy_Click(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Mã trường đã có, vui lòng đặt mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (cbmatruong.Text == "")
            {
                MessageBox.Show("Bạn hãy chọn mã cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbmatruong.Select();
                return;
            }
            else
            {
                SqlDataReader dr = ketnoi.ThuchienReader(select);
                Boolean kt = false;
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0) == cbmatruong.Text)
                        {
                            kt = true;
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                if (kt == false)
                {
                    MessageBox.Show("Mã trường không tồn tại, vui lòng nhập đúng mã cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult rs;
                    rs = MessageBox.Show("Bạn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rs == DialogResult.Yes)
                    {
                        string del = "delete tbl_Truong where Matruong='" + cbmatruong.Text + "'";
                        ketnoi.ThucHienCmd(del);
                        MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbhuy_Click(sender, e);

                    }
                }
            }   
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (cbmatruong.Text == "")
            {
                MessageBox.Show("Bạn hãy chọn mã cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbmatruong.Select();
                return;
            }
            else
            {
                SqlDataReader dr = ketnoi.ThuchienReader(select);
                Boolean kt = false;
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0) == cbmatruong.Text)
                        {
                            kt = true;
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                if (kt == false)
                {
                    MessageBox.Show("Mã trường không tồn tại, vui lòng nhập đúng mã cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult rs;
                    rs = MessageBox.Show("Bạn muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rs == DialogResult.Yes)
                    {
                        string sua = "update tbl_Truong set Matruong='" + cbmatruong.Text + "',Tentruong=N'" + txttentruong.Text + "',Diachi=N'" + txtdiachi.Text + "' where Matruong='" + cbmatruong.Text + "'";
                        ketnoi.ThucHienCmd(sua);
                        MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbhuy_Click(sender, e);

                    }
                }
            }   
        }
    }
}