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
    public partial class FrmPhongOSv : Form
    {
        public FrmPhongOSv()
        {
            InitializeComponent();
        }
        public string Quyen;
        public string Ten;
        string select = "select * from tbl_PhongSV";
        private void FrmPhongOSv_Load(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
            loadDatagridview();
            load_macv_maphong();
            cbhuy_Click(sender,e);
            //--
            txtquyen.Text = Quyen;
            txtten.Text = Ten;
            if (txtquyen.Text == "Admin")
            {
                btxoa.Enabled = true;
            }
            //--
        }
        public void loadDatagridview()
        {
            dgvPhong.DataSource = ketnoi.laydlbang(select);
            dgvPhong.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPhong.Columns[0].HeaderText = "Mã Phòng";
            dgvPhong.Columns[0].Width = 100;
            dgvPhong.Columns[1].HeaderText = "Mã khu";
            dgvPhong.Columns[1].Width = 80;
            dgvPhong.Columns[2].HeaderText = "Tầng";
            dgvPhong.Columns[2].Width = 80;
            dgvPhong.Columns[3].HeaderText = "Tổng số giường";
            dgvPhong.Columns[3].Width = 100;
            dgvPhong.Columns[4].HeaderText = "Số quạt";
            dgvPhong.Columns[4].Width = 80;
            dgvPhong.Columns[5].HeaderText = "Số sinh viên ở";
            dgvPhong.Columns[5].Width = 160;
        }
        public void load_macv_maphong()
        {
            DataSet ds;            
            ds = ketnoi.laytruong(select);
            cbmaphong.DataSource = ds.Tables[0];
            cbmaphong.DisplayMember = "Mapsv";
            DataSet ds1;
            ds1 = ketnoi.laytruong("Select Makhu from tbl_Khu");
            cbmakhu.DataSource = ds1.Tables[0];
            cbmakhu.DisplayMember = "Makhu";
        }

        private void cbhuy_Click(object sender, EventArgs e)
        {
            cbmakhu.Text = null;
            cbmaphong.Text = null;
            txtSogiuong.Text = "";
            txtsoquat.Text = "";
            txtsotang.Text = "";
            txtTinhtrang.Text = "";
            txttang.Text = "";
            loadDatagridview();
        }

        private void cbmaphong_TextChanged(object sender, EventArgs e)
        {
            if (cbmaphong.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;
            txtTinhtrang.Text = "0";
        }

        private void cbmakhu_TextChanged(object sender, EventArgs e)
        {
            if (cbmakhu.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;  
        }

        private void txtsotang_TextChanged(object sender, EventArgs e)
        {
            if (txtsotang.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;
           
        }

        private void txtSogiuong_TextChanged(object sender, EventArgs e)
        {
            if (txtSogiuong.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;  
        }

        private void txtsoquat_TextChanged(object sender, EventArgs e)
        {
            if (txtsoquat.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;  
        }

        private void txtTinhtrang_TextChanged(object sender, EventArgs e)
        {
            if (txtTinhtrang.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;  
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
            cbmaphong.DataBindings.Clear();
            cbmaphong.DataBindings.Add("Text",dgvPhong.DataSource,"Mapsv");
            cbmakhu.DataBindings.Clear();
            cbmakhu.DataBindings.Add("Text", dgvPhong.DataSource, "Makhu");
            txtsotang.DataBindings.Clear();
            txtsotang.DataBindings.Add("Text", dgvPhong.DataSource, "Tang");
            txtSogiuong.DataBindings.Clear();
            txtSogiuong.DataBindings.Add("Text", dgvPhong.DataSource, "Sogiuong");
            txtsoquat.DataBindings.Clear();
            txtsoquat.DataBindings.Add("Text", dgvPhong.DataSource, "Quat");
            txtTinhtrang.DataBindings.Clear();
            txtTinhtrang.DataBindings.Add("Text", dgvPhong.DataSource, "Sosinhvien");
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmaphong.Text == "")
                {
                    MessageBox.Show("Bạn hãy nhập Mã phòng ở của sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbmaphong.Select();
                    return;
                }
                
                if (cbmakhu.Text == "")
                {
                    MessageBox.Show("Bạn hãy chọn mã khu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbmakhu.Select();
                    return;
                }
                if (txtsotang.Text == "")
                {
                    MessageBox.Show("Bạn hãy nhập số tầng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtsotang.Select();
                    return;
                }
                if (txtSogiuong.Text == "")
                {
                    MessageBox.Show("Bạn hãy nhập tổng số giường !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSogiuong.Select();
                    return;
                }
                if (txtsoquat.Text == "")
                {
                    MessageBox.Show("Bạn hãy nhập số lượng quạt !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtsoquat.Select();
                    return;
                }
                if (txtTinhtrang.Text == "")
                {
                    MessageBox.Show("Bạn hãy nhập tình trạng phòng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTinhtrang.Select();
                    return;
                }
                SqlDataReader dr = ketnoi.ThuchienReader(select);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0) == cbmaphong.Text)
                        {
                            dr.Close();
                            dr.Dispose();
                            throw new Exception();
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                //--
                int sotang=Convert.ToInt32(txttang.Text);
                int tango=Convert.ToInt32(txtsotang.Text);
                if (tango<=sotang)
                {
                    string insert = "insert into tbl_PhongSV values('" + cbmaphong.Text + "',N'" + cbmakhu.Text + "','" + txtsotang.Text + "','" + txtSogiuong.Text + "','" + txtsoquat.Text + "',N'" + txtTinhtrang.Text + "')";
                    ketnoi.ThucHienCmd(insert);
                    MessageBox.Show("Bạn đã thêm mã '" + cbmaphong.Text + "' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbhuy_Click(sender, e);
                }
                else
                    MessageBox.Show("Tầng '" + txtsotang.Text + "' không tồn tại. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //--
                
            }
            catch (Exception)
            {

                MessageBox.Show("Mã phòng đã có, vui lòng đặt mã khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (cbmaphong.Text == "")
            {
                MessageBox.Show("Bạn hãy chọn mã phòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbmaphong.Select();
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
                        if (dr.GetString(0) == cbmaphong.Text)
                        {
                            kt = true;
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                if (kt == false)
                {
                    MessageBox.Show("Mã phòng không tồn tại, vui lòng nhập đúng mã cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult rs;
                    rs = MessageBox.Show("Bạn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (rs == DialogResult.Yes)
                    {
                        string del = "delete tbl_PhongSV where Mapsv='" + cbmaphong.Text + "'";
                        ketnoi.ThucHienCmd(del);
                        MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbhuy_Click(sender,e);

                    }
                }
            }   
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (txtsotang.Text == "" | txttang.Text=="")
            {
                MessageBox.Show("Vui lòng Chọn lại tầng hoặc nhập số tầng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsotang.Select();
                txttang.Select();
                return;
            }
            if (cbmaphong.Text == "")
            {
                MessageBox.Show("Bạn hãy chọn mã phòng cần Sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbmaphong.Select();
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
                        if (dr.GetString(0) == cbmaphong.Text)
                        {
                            kt = true;
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                if (kt == false)
                {
                    MessageBox.Show("Mã phòng không tồn tại, vui lòng nhập đúng mã cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int sotang = Convert.ToInt32(txttang.Text);
                    int tango = Convert.ToInt32(txtsotang.Text);
                    if (tango <= sotang)
                    {
                        DialogResult rs;
                        rs = MessageBox.Show("Bạn muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (rs == DialogResult.Yes)
                        {
                            string sua = "update tbl_PhongSV set Mapsv='" + cbmaphong.Text + "',Makhu=N'" + cbmakhu.Text + "',Tang='" + txtsotang.Text + "',Sogiuong='" + txtSogiuong.Text + "',Quat='" + txtsoquat.Text + "',Sosinhvien=N'" + txtTinhtrang.Text + "' where Mapsv='" + cbmaphong.Text + "'";
                            ketnoi.ThucHienCmd(sua);
                            MessageBox.Show("Đã Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cbhuy_Click(sender, e);
                        }
                    }
                    else
                        MessageBox.Show("Tầng '" + txtsotang.Text + "' không tồn tại. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //--

                    //--
                    
                }
            } 
        }

        private void cbmaphong_MouseClick(object sender, MouseEventArgs e)
        {
            DataSet ds;
            ds = ketnoi.laytruong("SELECT * FROM dbo.tbl_Khu INNER JOIN dbo.tbl_PhongSV ON dbo.tbl_Khu.Makhu = dbo.tbl_PhongSV.Makhu");
            cbmaphong.DataSource = ds.Tables[0];            
            cbmakhu.DataBindings.Clear();
            cbmakhu.DataBindings.Add("Text", ds.Tables[0], "Makhu");
            txtsotang.DataBindings.Clear();
            txtsotang.DataBindings.Add("Text", ds.Tables[0], "Tang");
            txtSogiuong.DataBindings.Clear();
            txtSogiuong.DataBindings.Add("Text", ds.Tables[0], "Sogiuong");
            txtsoquat.DataBindings.Clear();
            txtsoquat.DataBindings.Add("Text", ds.Tables[0], "Quat");
            txtTinhtrang.DataBindings.Clear();
            txtTinhtrang.DataBindings.Add("Text", ds.Tables[0], "Sosinhvien");
            txttang.DataBindings.Clear();
            txttang.DataBindings.Add("Text", ds.Tables[0], "Sotang");
        }

        private void txtSogiuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            ketnoi.Chivietso(sender, e);
        }
        

        private void txtsoquat_KeyPress(object sender, KeyPressEventArgs e)
        {
            ketnoi.Chivietso(sender, e);
        }

        private void txtsotang_KeyPress(object sender, KeyPressEventArgs e)
        {
            ketnoi.Chivietso(sender, e);
        }

        private void txtTinhtrang_KeyPress(object sender, KeyPressEventArgs e)
        {
            ketnoi.Chivietso(sender,e);
        }

        private void cbmakhu_MouseClick(object sender, MouseEventArgs e)
        {
            DataSet ds = ketnoi.laytruong("select * from tbl_Khu");
            cbmakhu.DataSource = ds.Tables[0];
            txttang.DataBindings.Clear();
            txttang.DataBindings.Add("Text",ds.Tables[0],"Sotang");
        }

        
    }
}