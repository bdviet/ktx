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
    public partial class FrmNhanVien : Form
    {
        public FrmNhanVien()
        {
            InitializeComponent();
        }
        public string Quyen;
        public string Ten;
        string select = "select * from tbl_NhanVien";
        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
            loadDatagridview();
            load_manv_macv_maphog_makhu();
            btHuy_Click(sender,e);

            txtquyen.Text = Quyen;
            txtten.Text = Ten;
            if (txtquyen.Text == "Admin")
            {
                btXoa.Enabled = true;
            }
        }
        public void loadDatagridview()
        {
            dgvDsnv.DataSource = ketnoi.laydlbang(select);
            dgvDsnv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDsnv.Columns[0].HeaderText = "Mã nhân viên";
            dgvDsnv.Columns[0].Width = 100;
            dgvDsnv.Columns[1].HeaderText = "Tên tên nhân viên";
            dgvDsnv.Columns[1].Width = 180;
            dgvDsnv.Columns[2].HeaderText = "Giới tính";
            dgvDsnv.Columns[2].Width = 100;
            dgvDsnv.Columns[3].HeaderText = "Địa chỉ";
            dgvDsnv.Columns[3].Width = 380;
            dgvDsnv.Columns[4].HeaderText = "Số điện thoại";
            dgvDsnv.Columns[4].Width = 150;
            dgvDsnv.Columns[5].HeaderText = "Mã chức vụ";
            dgvDsnv.Columns[5].Width = 100;
            dgvDsnv.Columns[6].HeaderText = "Mã khu";
            dgvDsnv.Columns[6].Width = 80;
            dgvDsnv.Columns[7].HeaderText = "Mã phòng ban";
            dgvDsnv.Columns[7].Width = 80;
        }
        public void load_manv_macv_maphog_makhu()
        {
            DataSet ds;
            string select = "select Macv from tbl_ChucVu";
            ds = ketnoi.laytruong(select);
            cbmacv.DataSource = ds.Tables[0];
            cbmacv.DisplayMember = "Macv";
            //--
            DataSet ds1;
            string select1 = "select Manv from tbl_NhanVien";
            ds1 = ketnoi.laytruong(select1);
            cbmanv.DataSource = ds1.Tables[0];
            cbmanv.DisplayMember = "Manv";
            //--
            DataSet ds2;
            string select2 = "select Makhu from tbl_Khu";
            ds2 = ketnoi.laytruong(select2);
            cbmakhu.DataSource = ds2.Tables[0];
            cbmakhu.DisplayMember = "Makhu";
            //--
            DataSet ds3;
            string select3 = "select Mapban from tbl_PhongBan";
            ds3 = ketnoi.laytruong(select3);
            cbmaphongban.DataSource = ds3.Tables[0];
            cbmaphongban.DisplayMember = "Mapban";
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

        private void btHuy_Click(object sender, EventArgs e)
        {
            cbmanv.Text = null;
            txttencv.Text = "";
            cbgioitinh.Text = null;
            txtDiachi.Text = "";
            txtSodt.Text = "";
            cbmacv.Text = null;
            txtTenNV.Text = "";
            cbmakhu.Text = null;
            cbmaphongban.Text = null;
            txttenpban.Text = "";
            loadDatagridview();
        }

        private void cbmanv_TextChanged(object sender, EventArgs e)
        {
            if (cbmanv.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;
        }

        private void txtDiachi_TextChanged(object sender, EventArgs e)
        {
            if (txtDiachi.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;
        }

        private void cbgioitinh_TextChanged(object sender, EventArgs e)
        {
            if (cbgioitinh.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;
        }

        private void txtSodt_TextChanged(object sender, EventArgs e)
        {
            if (txtSodt.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;
        }

        private void cbmacv_TextChanged(object sender, EventArgs e)
        {
            if (cbmacv.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;
        }

        private void cbmaphongban_TextChanged(object sender, EventArgs e)
        {
            if (cbmaphongban.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;
        }

        private void cbmakhu_TextChanged(object sender, EventArgs e)
        {
            if (cbmakhu.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;
        }

        private void cbmacv_MouseClick(object sender, MouseEventArgs e)
        {
            DataSet ds;
            ds = ketnoi.laytruong("select * from tbl_ChucVu");
            cbmacv.DataSource = ds.Tables[0];
            txttencv.DataBindings.Clear();
            txttencv.DataBindings.Add("Text", ds.Tables[0], "Tencv");
        }

        private void cbmaphongban_MouseClick(object sender, MouseEventArgs e)
        {
            DataSet ds;
            ds = ketnoi.laytruong("select * from tbl_PhongBan");
            cbmaphongban.DataSource = ds.Tables[0];
            txttenpban.DataBindings.Clear();
            txttenpban.DataBindings.Add("Text", ds.Tables[0], "Tenphong");
        }

        private void cbmanv_MouseClick(object sender, MouseEventArgs e)
        {
            DataSet ds;
            ds = ketnoi.laytruong(select);
            cbmanv.DataSource = ds.Tables[0];
            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", ds.Tables[0], "Hotennv");
            cbgioitinh.DataBindings.Clear();
            cbgioitinh.DataBindings.Add("Text", ds.Tables[0], "Gioitinh");
            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", ds.Tables[0], "Diachi");
            txtSodt.DataBindings.Clear();
            txtSodt.DataBindings.Add("Text", ds.Tables[0], "Sodt");
            cbmacv.DataBindings.Clear();
            cbmacv.DataBindings.Add("Text", ds.Tables[0], "Macv");
            cbmakhu.DataBindings.Clear();
            cbmakhu.DataBindings.Add("Text", ds.Tables[0], "Makhu");
            cbmaphongban.DataBindings.Clear();
            cbmaphongban.DataBindings.Add("Text", ds.Tables[0], "Mapban");
        }

        private void dgvDsnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbmanv.DataBindings.Clear();
            cbmanv.DataBindings.Add("Text",dgvDsnv.DataSource,"Manv");
            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", dgvDsnv.DataSource, "Hotennv");
            cbgioitinh.DataBindings.Clear();
            cbgioitinh.DataBindings.Add("Text", dgvDsnv.DataSource, "Gioitinh");
            txtDiachi.DataBindings.Clear();
            txtDiachi.DataBindings.Add("Text", dgvDsnv.DataSource, "Diachi");
            txtSodt.DataBindings.Clear();
            txtSodt.DataBindings.Add("Text", dgvDsnv.DataSource, "Sodt");
            cbmacv.DataBindings.Clear();
            cbmacv.DataBindings.Add("Text", dgvDsnv.DataSource, "Macv");
            cbmakhu.DataBindings.Clear();
            cbmakhu.DataBindings.Add("Text", dgvDsnv.DataSource, "Makhu");
            cbmaphongban.DataBindings.Clear();
            cbmaphongban.DataBindings.Add("Text", dgvDsnv.DataSource, "Mapban");
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmanv.Text == "")
                {
                    MessageBox.Show("Bạn hãy nhập Mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbmanv.Select();
                    return;
                }
                if (txtTenNV.Text == "")
                {
                    MessageBox.Show("Bạn hãy nhập tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenNV.Select();
                    return;
                }
                if (cbgioitinh.Text == "")
                {
                    MessageBox.Show("Bạn hãy chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbgioitinh.Select();
                    return;
                }
                if (txtDiachi.Text == "")
                {
                    MessageBox.Show("Bạn hãy nhập địa chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDiachi.Select();
                    return;
                }
                if (txtSodt.Text == "")
                {
                    MessageBox.Show("Bạn hãy nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSodt.Select();
                    return;
                }
                if (cbmakhu.Text == "")
                {
                    MessageBox.Show("Bạn hãy chọn mã khu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbmakhu.Select();
                    return;
                }
                if (cbmacv.Text == "")
                {
                    MessageBox.Show("Bạn hãy chọn mã chức vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbmacv.Select();
                    return;
                }
                if (cbmaphongban.Text == "")
                {
                    MessageBox.Show("Bạn hãy chọn mã phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbmaphongban.Select();
                    return;
                }
                SqlDataReader dr = ketnoi.ThuchienReader(select);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0) == cbmanv.Text)
                        {
                            dr.Close();
                            dr.Dispose();
                            throw new Exception();
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                string insert = "insert into tbl_NhanVien values('" + cbmanv.Text + "',N'" + txtTenNV.Text + "',N'"+cbgioitinh.Text+"',N'"+txtDiachi.Text+"','"+txtSodt.Text+"','"+cbmacv.Text+"','"+cbmakhu.Text+"','"+cbmaphongban.Text+"')";
                ketnoi.ThucHienCmd(insert);
                MessageBox.Show("Bạn đã thêm mã '" + cbmanv.Text + "' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btHuy_Click(sender, e);
            }
            catch (Exception)
            {

                MessageBox.Show("Mã Nhân viên đã có, vui lòng đặt mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (cbmanv.Text == "")
            {
                MessageBox.Show("Bạn hãy chọn mã nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbmanv.Select();
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
                        if (dr.GetString(0) == cbmanv.Text)
                        {
                            kt = true;
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                if (kt == false)
                {
                    MessageBox.Show("Mã Nhân viên không tồn tại, vui lòng nhập đúng mã cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult rs;
                    rs = MessageBox.Show("Bạn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rs == DialogResult.Yes)
                    {
                        string del = "delete tbl_NhanVien where Manv='" + cbmanv.Text + "'";
                        ketnoi.ThucHienCmd(del);
                        MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btHuy_Click(sender, e);

                    }
                }
            }   
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (cbmanv.Text == "")
            {
                MessageBox.Show("Bạn hãy chọn mã nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbmanv.Select();
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
                        if (dr.GetString(0) == cbmanv.Text)
                        {
                            kt = true;
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                if (kt == false)
                {
                    MessageBox.Show("Mã Nhân viên không tồn tại, vui lòng nhập đúng mã cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult rs;
                    rs = MessageBox.Show("Bạn muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rs == DialogResult.Yes)
                    {
                        string sua = "update tbl_NhanVien set Manv='" + cbmanv.Text + "',Hotennv=N'" + txtTenNV.Text + "',Gioitinh=N'" + cbgioitinh.Text + "',Diachi=N'" + txtDiachi.Text + "',Sodt='" + txtSodt.Text + "',Macv='" + cbmacv.Text + "',Makhu='" + cbmakhu.Text + "',Mapban='" + cbmaphongban.Text + "' where Manv='" + cbmanv.Text + "'";
                        ketnoi.ThucHienCmd(sua);
                        MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btHuy_Click(sender, e);

                    }
                }
            }   
        }

        private void txtSodt_KeyPress(object sender, KeyPressEventArgs e)
        {
            ketnoi.Chivietso(sender,e);
        }

        private void btaddchucvu_Click(object sender, EventArgs e)
        {
            FrmChucvu frm = new FrmChucvu();
            frm.Ten = txtten.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }

        private void btaddkhu_Click(object sender, EventArgs e)
        {
            FrmKhu frm = new FrmKhu();
            frm.Ten = txtten.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }

        private void btaddphong_Click(object sender, EventArgs e)
        {
            FrmPhongBan frm = new FrmPhongBan();
            frm.Ten = txtten.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }

       
    }
}