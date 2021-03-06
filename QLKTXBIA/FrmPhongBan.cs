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
    public partial class FrmPhongBan : Form
    {
        public FrmPhongBan()
        {
            InitializeComponent();
        }
        public string Quyen;
        public string Ten;
        string select = "select * from tbl_PhongBan";
        private void FrmPhongBan_Load(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
            load_maphongban();
            loadDatagridview();
            bthuy_Click(sender,e);
            //--
            txtquyen.Text = Quyen;
            txtten.Text = Ten;
            if (txtquyen.Text == "Admin")
            {
                btxoa.Enabled = true;
            }
            //--
        }

        public void load_maphongban()
        {
            DataSet ds;            
            ds = ketnoi.laytruong(select);
            cbmapban.DataSource = ds.Tables[0];
            cbmapban.DisplayMember = "Mapban";
        }
        public void loadDatagridview()
        {
            dgvDsPhong.DataSource = ketnoi.laydlbang(select);
            dgvDsPhong.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDsPhong.Columns[0].HeaderText = "Mã Chức vụ";
            dgvDsPhong.Columns[0].Width = 150;
            dgvDsPhong.Columns[1].HeaderText = "Tên Chức vụ";
            dgvDsPhong.Columns[1].Width = 180;
        }
        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
               // ketnoi.CloseCn();
            }
        }

        private void cbmapban_MouseClick(object sender, MouseEventArgs e)
        {
            DataSet ds;
            ds = ketnoi.laytruong(select);
            cbmapban.DataSource = ds.Tables[0];
            txttenphong.DataBindings.Clear();
            txttenphong.DataBindings.Add("Text", ds.Tables[0], "Tenphong");
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            cbmapban.Text = null;
            txttenphong.Text = "";
            loadDatagridview();
        }

        private void cbmapban_TextChanged(object sender, EventArgs e)
        {
            if (cbmapban.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true; 
        }

        private void txttenphong_TextChanged(object sender, EventArgs e)
        {
            if (txttenphong.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true; 
        }

        private void dgvDsPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbmapban.DataBindings.Clear();
            cbmapban.DataBindings.Add("Text",dgvDsPhong.DataSource,"Mapban");
            txttenphong.DataBindings.Clear();
            txttenphong.DataBindings.Add("Text",dgvDsPhong.DataSource,"Tenphong");
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmapban.Text == "")
                {
                    MessageBox.Show("Bạn hãy nhập Mã phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbmapban.Select();
                    return;
                }
                if (txttenphong.Text == "")
                {
                    MessageBox.Show("Bạn hãy nhập tên phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttenphong.Select();
                    return;
                }
                SqlDataReader dr = ketnoi.ThuchienReader(select);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0) == cbmapban.Text)
                        {
                            dr.Close();
                            dr.Dispose();
                            throw new Exception();
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                string insert = "insert into tbl_PhongBan values('" + cbmapban.Text + "',N'" + txttenphong.Text + "')";
                ketnoi.ThucHienCmd(insert);
                MessageBox.Show("Bạn đã thêm mã '" + cbmapban.Text + "' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bthuy_Click(sender,e);
            }
            catch (Exception)
            {

                MessageBox.Show("Mã phòng ban đã có, vui lòng đặt mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (cbmapban.Text == "")
            {
                MessageBox.Show("Bạn hãy chọn mã phòng ban cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbmapban.Select();
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
                        if (dr.GetString(0) == cbmapban.Text)
                        {
                            kt = true;
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                if (kt == false)
                {
                    MessageBox.Show("Mã phòng ban không tồn tại, vui lòng nhập đúng mã cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult rs;
                    rs = MessageBox.Show("Bạn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rs == DialogResult.Yes)
                    {
                        string del = "delete tbl_PhongBan where Mapban='" + cbmapban.Text + "'";
                        ketnoi.ThucHienCmd(del);
                        MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bthuy_Click(sender, e);

                    }
                }
            }
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (cbmapban.Text == "")
            {
                MessageBox.Show("Bạn hãy chọn mã phòng ban cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbmapban.Select();
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
                        if (dr.GetString(0) == cbmapban.Text)
                        {
                            kt = true;
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                if (kt == false)
                {
                    MessageBox.Show("Mã phòng ban không tồn tại, vui lòng nhập đúng mã cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult rs;
                    rs = MessageBox.Show("Bạn muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rs == DialogResult.Yes)
                    {
                        string sua = "update tbl_PhongBan set Mapban='" + cbmapban.Text + "',Tenphong=N'" + txttenphong.Text + "' where Mapban='" + cbmapban.Text + "'";
                        ketnoi.ThucHienCmd(sua);
                        MessageBox.Show("Đã sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bthuy_Click(sender, e);

                    }
                }
            }
        }

       

        
    }
}