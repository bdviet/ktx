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
    public partial class FrmHoaDon : Form
    {
        public FrmHoaDon()
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
	
        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
            load_datagridview();
            loadPhong_mahd();
            btHuy_Click(sender,e);
            //--
            txtquyen.Text = Quyen;
            txtten.Text = Ten;
            if (txtquyen.Text == "Admin")
            {
                btXoa.Enabled = true;
            }
        }
        string select = "select * from tbl_HoaDon";
        public void load_datagridview()
        {
            dgvDshd.DataSource = ketnoi.laydlbang(select);
            dgvDshd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDshd.Columns[0].HeaderText = "Số hóa đơn";
            dgvDshd.Columns[0].Width = 90;
            dgvDshd.Columns[1].HeaderText = "Mã phòng";
            dgvDshd.Columns[1].Width = 90;
            dgvDshd.Columns[2].HeaderText = "Ngày lập hóa đơn";
            dgvDshd.Columns[2].Width = 130;
            dgvDshd.Columns[3].HeaderText = "Mã công tơ điện";
            dgvDshd.Columns[3].Width = 130;            
            dgvDshd.Columns[4].HeaderText = "Chỉ số điện cũ";
            dgvDshd.Columns[4].Width = 130;
            dgvDshd.Columns[5].HeaderText = "Chỉ số điện mới";
            dgvDshd.Columns[5].Width = 130;
            dgvDshd.Columns[6].HeaderText = "Tiền nước/SV";
            dgvDshd.Columns[6].Width = 130;
            dgvDshd.Columns[7].HeaderText = "Số lượng sinh viên ở";
            dgvDshd.Columns[7].Width = 130;
            dgvDshd.Columns[8].HeaderText = "Số tiền/1kwh";
            dgvDshd.Columns[8].Width = 130;
            dgvDshd.Columns[9].HeaderText = "Ngày ghi chỉ số điện";
            dgvDshd.Columns[9].Width = 130;
            dgvDshd.Columns[10].HeaderText = "Tổng tiền";
            dgvDshd.Columns[10].Width = 110;
        }

        public void loadPhong_mahd()
        {
            DataSet ds;
            string select1 = "select * from tbl_PhongSV";
            ds = ketnoi.laytruong(select1);
            cbSoPhong.DataSource = ds.Tables[0];
            cbSoPhong.DisplayMember = "Mapsv";
            //--
            ds = ketnoi.laytruong(select);
            cbSohd.DataSource = ds.Tables[0];
            cbSohd.DisplayMember = "Mahdon";
        }
        private void txttiennuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ketnoi.Chivietso(sender,e);
        }

        private void txtsoSv_KeyPress(object sender, KeyPressEventArgs e)
        {
            ketnoi.Chivietso(sender,e);
        }

        private void txtTiendien_KeyPress(object sender, KeyPressEventArgs e)
        {
            ketnoi.Chivietso(sender, e);
        }

        private void txtCSDD_KeyPress(object sender, KeyPressEventArgs e)
        {
            ketnoi.Chivietso(sender, e);
        }

        private void txtCSDC_KeyPress(object sender, KeyPressEventArgs e)
        {
            ketnoi.Chivietso(sender, e);
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            cbSohd.Text = "";
            cbSoPhong.Text = null;
            txtmaCTD.Text = "";
            txtTiendien.Text = "";
            txtCSDD.Text = "";
            txtCSDC.Text = "";
            txtTongTien.Text = "";            
            txttiennuoc.Text = "";
            txtsoSv.Text = "";
            load_datagridview();
        }

        private void cbSohd_TextChanged(object sender, EventArgs e)
        {
            if (cbSohd.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;
        }

        private void cbSoPhong_TextChanged(object sender, EventArgs e)
        {
            if (cbSoPhong.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;
        }

        private void txtmaCTD_TextChanged(object sender, EventArgs e)
        {
            if (txtmaCTD.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;
        }

        private void txtCSDD_TextChanged(object sender, EventArgs e)
        {
            if (txtCSDD.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;
        }

        private void txtCSDC_TextChanged(object sender, EventArgs e)
        {
            if (txtCSDC.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;
        }

        private void txttiennuoc_TextChanged(object sender, EventArgs e)
        {
            if (txttiennuoc.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;
        }

        private void txtsoSv_TextChanged(object sender, EventArgs e)
        {
            if (txtsoSv.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;
        }

        private void txtTiendien_TextChanged(object sender, EventArgs e)
        {
            if (txtTiendien.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;
        }

        private void dgvDshd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbSohd.DataBindings.Clear();
            cbSohd.DataBindings.Add("Text", dgvDshd.DataSource, "Mahdon");
            cbSoPhong.DataBindings.Clear();
            cbSoPhong.DataBindings.Add("Text", dgvDshd.DataSource, "Mapsv");
            dtpngaylap.DataBindings.Clear();
            dtpngaylap.DataBindings.Add("Text", dgvDshd.DataSource, "Ngaylap");
            txtmaCTD.DataBindings.Clear();
            txtmaCTD.DataBindings.Add("Text", dgvDshd.DataSource, "MaCtd");            
            txtCSDD.DataBindings.Clear();
            txtCSDD.DataBindings.Add("Text", dgvDshd.DataSource, "Chisodd");
            txtCSDC.DataBindings.Clear();
            txtCSDC.DataBindings.Add("Text", dgvDshd.DataSource, "Chisodc");
            txttiennuoc.DataBindings.Clear();
            txttiennuoc.DataBindings.Add("Text",dgvDshd.DataSource,"TienNuoc");
            txtsoSv.DataBindings.Clear();
            txtsoSv.DataBindings.Add("Text", dgvDshd.DataSource, "SoSvO");
            txtTiendien.DataBindings.Clear();
            txtTiendien.DataBindings.Add("Text", dgvDshd.DataSource, "Tien1kw");
            dtpngayghi.DataBindings.Clear();
            dtpngayghi.DataBindings.Add("Text", dgvDshd.DataSource, "Ngayghichiso");
            txtTongTien.DataBindings.Clear();
            txtTongTien.DataBindings.Add("Text", dgvDshd.DataSource, "TongTien");

        }

        private void cbSohd_MouseClick(object sender, MouseEventArgs e)
        {
            DataSet ds;
            ds = ketnoi.laytruong(select);
            cbSohd.DataSource = ds.Tables[0];
            cbSoPhong.DataBindings.Clear();
            cbSoPhong.DataBindings.Add("Text", ds.Tables[0], "Mapsv");
            dtpngaylap.DataBindings.Clear();
            dtpngaylap.DataBindings.Add("Text", ds.Tables[0], "Ngaylap");
            txtmaCTD.DataBindings.Clear();
            txtmaCTD.DataBindings.Add("Text", ds.Tables[0], "MaCtd");
            txtCSDD.DataBindings.Clear();
            txtCSDD.DataBindings.Add("Text", ds.Tables[0], "Chisodd");
            txtCSDC.DataBindings.Clear();
            txtCSDC.DataBindings.Add("Text", ds.Tables[0], "Chisodc");
            txttiennuoc.DataBindings.Clear();
            txttiennuoc.DataBindings.Add("Text", ds.Tables[0], "TienNuoc");
            txtsoSv.DataBindings.Clear();
            txtsoSv.DataBindings.Add("Text", ds.Tables[0], "SoSvO");
            txtTiendien.DataBindings.Clear();
            txtTiendien.DataBindings.Add("Text", ds.Tables[0], "Tien1kw");
            dtpngayghi.DataBindings.Clear();
            dtpngayghi.DataBindings.Add("Text", ds.Tables[0], "Ngayghichiso");
            txtTongTien.DataBindings.Clear();
            txtTongTien.DataBindings.Add("Text", ds.Tables[0], "TongTien");
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSohd.Text == "")
                {
                    MessageBox.Show("Hãy nhập mã hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbSohd.Select();
                    return;
                }
                if (cbSoPhong.Text == "")
                {
                    MessageBox.Show("Hãy chọn Số phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbSoPhong.Select();
                    return;
                }
                if (txtTiendien.Text == "")
                {
                    MessageBox.Show("Hãy nhập giá tiền điện / 1kwh !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTiendien.Select();
                    return;
                }
                if (txtmaCTD.Text == "")
                {
                    MessageBox.Show("Hãy nhập mã công tơ điện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtmaCTD.Select();
                    return;
                }
                if (txtCSDD.Text == "")
                {
                    MessageBox.Show("Hãy nhập chỉ số điện tháng trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCSDD.Select();
                    return;
                }
                if (txtCSDC.Text == "")
                {
                    MessageBox.Show("Hãy nhập chỉ số điện tháng này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCSDC.Select();
                    return;
                }
                if (txtsoSv.Text=="")
                {
                    MessageBox.Show("Hãy nhập tổng số sinh viên trong phòng tháng này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtsoSv.Select();
                    return;
                }
                if (txttiennuoc.Text=="")
                {
                    MessageBox.Show("Hãy nhập tiền nước/sinh viên này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txttiennuoc.Select();
                    return;
                }               
                SqlDataReader dr = ketnoi.ThuchienReader(select);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0) == cbSohd.Text)
                        {
                            dr.Close();
                            dr.Dispose();
                            throw new Exception();
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                // tinhtien();
                int a = Convert.ToInt32(txtCSDD.Text);
                int b = Convert.ToInt32(txtCSDC.Text);
                int c = Convert.ToInt32(txtTiendien.Text);
                int d = Convert.ToInt32(txttiennuoc.Text);
                int f = Convert.ToInt32(txtsoSv.Text);
                if (a <= b && a >= 0 && b >= 0 && dtpngayghi.Value <= dtpngaylap.Value)
                { 
                    double tongtien = ((b - a) * c)+(f * d);                   
                    txtTongTien.Text = tongtien.ToString();
                    string insert = "insert into tbl_HoaDon values('" + cbSohd.Text + "','" + cbSoPhong.Text + "','" + dtpngaylap.Text + "','" + txtmaCTD.Text + "','" + txtCSDD.Text + "','" + txtCSDC.Text + "','"+ txttiennuoc.Text +"',"+ txtsoSv.Text +","+ txtTiendien.Text +",'" + dtpngayghi.Text + "','" + txtTongTien.Text + "')";
                    ketnoi.ThucHienCmd(insert);
                    MessageBox.Show("Đã thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btHuy_Click(sender, e);
                }
                else
                    MessageBox.Show("Chỉ số điện cũ(đầu) phải nhỏ hơn chỉ số điện mới(Cuối), hoặc số tiền nhập âm hoặc ngày ghi phải <= ngày lập!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception)
            {
                MessageBox.Show("Mã hoá đơn này đã tồn tại, vui lòng đặt mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (cbSohd.Text == "")
                MessageBox.Show("Hãy chọn dữ liệu trước khi xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                SqlDataReader dr = ketnoi.ThuchienReader(select);

                Boolean kt = false;
                if (dr != null)
                {

                    while (dr.Read())
                    {
                        if (dr.GetString(0) == cbSohd.Text)
                        {
                            kt = true;

                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                if (kt == false)
                {
                    MessageBox.Show("Mã hóa đơn không tồn tại, vui lòng chọn đúng mã cần Xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult rs;
                    rs = MessageBox.Show("Bạn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        string del = "delete tbl_HoaDon where Mahdon='" + cbSohd.Text + "'";
                        ketnoi.ThucHienCmd(del);
                        btHuy_Click(sender, e);
                        MessageBox.Show("Bạn đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }      
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (cbSohd.Text == "")                
                MessageBox.Show("Hãy nhập chọn dữ liệu trước khi sửa!");
            else
            {
                SqlDataReader dr = ketnoi.ThuchienReader(select);

                Boolean kt = false;
                if (dr != null)
                {

                    while (dr.Read())
                    {
                        if (dr.GetString(0) == cbSohd.Text)
                        {
                            kt = true;

                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                if (kt == false)
                {
                    MessageBox.Show("Số hóa đơn không tồn tại, vui lòng nhập đúng số cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int a = Convert.ToInt32(txtCSDD.Text);
                    int b = Convert.ToInt32(txtCSDC.Text);
                    int c = Convert.ToInt32(txtTiendien.Text);
                    int d = Convert.ToInt32(txttiennuoc.Text);
                    int f = Convert.ToInt32(txtsoSv.Text);
                    if (a <= b && a >= 0 && b >= 0 && dtpngayghi.Value <= dtpngaylap.Value)
                    {
                        double tongtien = ((b - a) * c) + (f * d);
                        txtTongTien.Text = tongtien.ToString();
                        DialogResult rs;
                        rs = MessageBox.Show("Bạn muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rs == DialogResult.Yes)
                        {
                            string sua = "update tbl_HoaDon set Mahdon='" + cbSohd.Text + "',Mapsv='" + cbSoPhong.Text + "',Ngaylap='" + dtpngaylap.Text + "',Mactd='" + txtmaCTD.Text + "',Chisodd='" + txtCSDD.Text + "',Chisodc='" + txtCSDC.Text + "',TienNuoc='" + txttiennuoc.Text + "',SoSvO=" + txtsoSv.Text + ",Tien1kw=" + txtTiendien.Text + ",Ngayghichiso='" + dtpngayghi.Text + "',TongTien='" + txtTongTien.Text + "' where Mahdon = '" + cbSohd.Text + "'";
                            ketnoi.ThucHienCmd(sua);
                            btHuy_Click(sender, e);
                            MessageBox.Show("Bạn đã sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                        MessageBox.Show("Chỉ số điện cũ(đầu) phải nhỏ hơn chỉ số điện mới(Cuối), hoặc số tiền nhập âm hoặc ngày ghi phải <= ngày lập!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void cbSoPhong_MouseClick(object sender, MouseEventArgs e)
        {
            string select = "select * from tbl_PhongSV";
            DataSet ds = ketnoi.laytruong(select);
            cbSoPhong.DataSource = ds.Tables[0];
            txtsoSv.DataBindings.Clear();
            txtsoSv.DataBindings.Add("Text", ds.Tables[0], "Sosinhvien");
        }

       
    }
}