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
    public partial class FrmKhu : Form
    {
        public FrmKhu()
        {
            InitializeComponent();
        }
        public string Quyen;
        public string Ten;
        string select = "select * from tbl_Khu";
        private void FrmKhu_Load(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
            load_Datagridview();
            load_cbmakhu();
            btHuy_Click(sender,e);
            txtquyen.Text = Quyen;
            txtten.Text = Ten;
            if (txtquyen.Text == "Admin")
            {
                btxoa.Enabled = true;
            }
        }
        public void load_cbmakhu()
        {
            DataSet ds;
            ds = ketnoi.laytruong(select);
            cbmakhu.DataSource = ds.Tables[0];
            cbmakhu.DisplayMember = "Makhu";
            
        }
        public void load_Datagridview()
        {
            dgvPhong.DataSource = ketnoi.laydlbang(select);
            dgvPhong.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhong.Columns[0].HeaderText = "Mã khu";
            dgvPhong.Columns[0].Width = 120;
            dgvPhong.Columns[1].HeaderText = "Số phòng";
            dgvPhong.Columns[1].Width = 150;
            dgvPhong.Columns[2].HeaderText = "Số tầng";
            dgvPhong.Columns[2].Width = 120;
        }

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

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbmakhu.DataBindings.Clear();
            cbmakhu.DataBindings.Add("Text",dgvPhong.DataSource,"Makhu");
            txtsophong.DataBindings.Clear();
            txtsophong.DataBindings.Add("Text",dgvPhong.DataSource,"Sophong");
            txtsotang.DataBindings.Clear();
            txtsotang.DataBindings.Add("Text",dgvPhong.DataSource,"Sotang");
        }

        private void cbmakhu_MouseClick(object sender, MouseEventArgs e)
        {
            DataSet ds;
            ds = ketnoi.laytruong(select);
            cbmakhu.DataSource = ds.Tables[0];           
            txtsophong.DataBindings.Clear();
            txtsophong.DataBindings.Add("Text", ds.Tables[0], "Sophong");
            txtsotang.DataBindings.Clear();
            txtsotang.DataBindings.Add("Text", ds.Tables[0], "Sotang");
        }

        private void cbmakhu_TextChanged(object sender, EventArgs e)
        {
            if (cbmakhu.Text == "")
            {
                btHuy.Enabled = false;
            }
            else
                btHuy.Enabled = true;
            txtsotang.Text ="5";
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            cbmakhu.Text = null;
            txtsophong.Text = "";
            txtsotang.Text = "";
            load_Datagridview();
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmakhu.Text == "")
                {
                    MessageBox.Show("Bạn hãy nhập Mã Khu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbmakhu.Select();
                    return;
                }
                if (txtsotang.Text == "")
                {
                    MessageBox.Show("Bạn hãy nhập số tầng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtsotang.Select();
                    return;
                }
                if (txtsophong.Text == "")
                {
                    MessageBox.Show("Bạn hãy nhập số phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtsophong.Select();
                    return;
                }
                SqlDataReader dr = ketnoi.ThuchienReader(select);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0) == cbmakhu.Text)
                        {
                            dr.Close();
                            dr.Dispose();
                            throw new Exception();
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                string insert = "insert into tbl_Khu values('" + cbmakhu.Text + "',N'" + txtsophong.Text + "','"+txtsotang.Text+"')";
                ketnoi.ThucHienCmd(insert);
                MessageBox.Show("Bạn đã thêm mã '" + cbmakhu.Text + "' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btHuy_Click(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Mã Khu đã có, vui lòng đặt mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (cbmakhu.Text == "")
            {
                MessageBox.Show("Bạn hãy chọn mã khu cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbmakhu.Select();
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
                        if (dr.GetString(0) == cbmakhu.Text)
                        {
                            kt = true;
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                if (kt == false)
                {
                    MessageBox.Show("Mã khu không tồn tại, vui lòng nhập đúng mã cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult rs;
                    rs = MessageBox.Show("Bạn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rs == DialogResult.Yes)
                    {
                        string del = "delete tbl_Khu where Makhu='" + cbmakhu.Text + "'";
                        ketnoi.ThucHienCmd(del);
                        MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btHuy_Click(sender, e);

                    }
                }
            }   
        }

        private void txtsotang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtsophong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (cbmakhu.Text == "")
            {
                MessageBox.Show("Bạn hãy chọn mã khu cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbmakhu.Select();
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
                        if (dr.GetString(0) == cbmakhu.Text)
                        {
                            kt = true;
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                if (kt == false)
                {
                    MessageBox.Show("Mã khu không tồn tại, vui lòng nhập đúng mã cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult rs;
                    rs = MessageBox.Show("Bạn muốn xóa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rs == DialogResult.Yes)
                    {
                        string sua = "update tbl_Khu set Makhu='"+cbmakhu.Text+"',Sophong='"+txtsophong.Text+"',Sotang='"+txtsotang.Text+"' where Makhu='" + cbmakhu.Text + "'";
                        ketnoi.ThucHienCmd(sua);
                        MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btHuy_Click(sender, e);

                    }
                }
            }   
        }

       

       
    }
}