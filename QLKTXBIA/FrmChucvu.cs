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
    public partial class FrmChucvu : Form
    {
        public FrmChucvu()
        {
            InitializeComponent();
        }
        public string Quyen;
        public string Ten;
        string select = "select * from tbl_ChucVu";
        private void FrmChucvu_Load(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
            loadDatagridview();
            load_macv();
            cbmacv.Text = null;
            txtquyen.Text = Quyen;
            txtten.Text = Ten;
            if (txtquyen.Text == "Admin")
            {
                btXoa.Enabled = true;
            }
        }
        public void loadDatagridview()
        {
            dgvDscv.DataSource = ketnoi.laydlbang(select);
            dgvDscv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDscv.Columns[0].HeaderText = "Mã Chức vụ";
            dgvDscv.Columns[0].Width = 100;
            dgvDscv.Columns[1].HeaderText = "Tên Chức vụ";
            dgvDscv.Columns[1].Width = 180;
        }

        private void dgvDscv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbmacv.DataBindings.Clear();
            cbmacv.DataBindings.Add("Text",dgvDscv.DataSource,"Macv");
            txttencv.DataBindings.Clear();
            txttencv.DataBindings.Add("Text",dgvDscv.DataSource,"Tencv");
        }

        public void load_macv()
        {
            DataSet ds;
            string select = "select Macv from tbl_ChucVu";
            ds = ketnoi.laytruong(select);
            cbmacv.DataSource = ds.Tables[0];
            cbmacv.DisplayMember = "Macv";
        }
       
        private void cbmacv_MouseClick(object sender, MouseEventArgs e)
        {
            DataSet ds;            
            ds = ketnoi.laytruong(select);
            cbmacv.DataSource=ds.Tables[0];
            txttencv.DataBindings.Clear();
            txttencv.DataBindings.Add("Text",ds.Tables[0],"Tencv");
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
               // ketnoi.CloseCn();
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            cbmacv.Text = null;
            txttencv.Text = "";
            loadDatagridview();
        }
        private void cbmacv_TextChanged(object sender, EventArgs e)
        {
            if (cbmacv.Text == "")
                btHuy.Enabled = false;            
            else
               btHuy.Enabled = true;              
            
        }

        private void txttencv_TextChanged(object sender, EventArgs e)
        {
            if (txttencv.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;  
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                 if (cbmacv.Text == "")
                {
                    MessageBox.Show("Bạn hãy nhập Mã chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbmacv.Select();
                    return;
                }
                if (txttencv.Text == "")
                {
                    MessageBox.Show("Bạn hãy nhập tên chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttencv.Select();
                    return;
                }
                SqlDataReader dr = ketnoi.ThuchienReader(select);
                if (dr!=null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0)==cbmacv.Text)
                        {
                            dr.Close();
                            dr.Dispose();
                            throw new Exception();
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                string insert = "insert into tbl_ChucVu values('"+cbmacv.Text+"',N'"+txttencv.Text+"')";
                ketnoi.ThucHienCmd(insert);
                MessageBox.Show("Bạn đã thêm mã '"+cbmacv.Text+"' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btHuy_Click(sender,e);
            }
            catch (Exception)
            {

                MessageBox.Show("Mã chức vụ đã có, vui lòng đặt mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmacv.Text=="")
                {
                     MessageBox.Show("Bạn hãy chọn mã chức vụ cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     cbmacv.Select();
                     return;
                }
                else
                {
                    SqlDataReader dr = ketnoi.ThuchienReader(select);
                    Boolean kt = false;
                    if (dr!=null)
                    {
                        while (dr.Read())
                        {
                            if (dr.GetString(0)==cbmacv.Text)
                            {
                                kt = true;
                            }
                        }
                    }
                    dr.Close();
                    dr.Dispose();
                    if (kt==false)
                    {
                        MessageBox.Show("Mã chức vụ không tồn tại, vui lòng nhập đúng mã cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        DialogResult rs;
                        rs = MessageBox.Show("Bạn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (rs == DialogResult.Yes)
                        {
                            string del = "delete tbl_ChucVu where Macv='" + cbmacv.Text + "'";
                            ketnoi.ThucHienCmd(del);
                            MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btHuy_Click(sender, e);
                            
                        }
                    }
                }   
            }
            catch (Exception)
            {
                
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (cbmacv.Text == "")
            {
                MessageBox.Show("Bạn hãy chọn mã chức vụ cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbmacv.Select();
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
                        if (dr.GetString(0) == cbmacv.Text)
                        {
                            kt = true;
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                if (kt == false)
                {
                    MessageBox.Show("Mã chức vụ không tồn tại, vui lòng nhập đúng mã cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult rs;
                    rs = MessageBox.Show("Bạn muốn sửa không?", "Sua", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rs == DialogResult.Yes)
                    {
                        string sua = "update tbl_ChucVu set Macv='" + cbmacv.Text + "',Tencv=N'" + txttencv.Text + "' where Macv='" + cbmacv.Text + "'";
                        ketnoi.ThucHienCmd(sua);
                        MessageBox.Show("Bạn đã sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btHuy_Click(sender, e);

                    }
                }
            }   
        }
    }
}