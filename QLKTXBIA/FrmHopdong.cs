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
    public partial class FrmHopdong : Form
    {
        public FrmHopdong()
        {
            InitializeComponent();
        }
        public string Quyen;
        public string Ten;
        private void FrmHopdong_Load(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
            loadDatagridview();
            loadMasv_SoPhong();
            btHuy_Click(sender,e);      
            	
	        txtquyen.Text = Quyen;
            txtten.Text = Ten;
            //if (txtquyen.Text == "Admin")
            //{
            //    btXoa.Enabled = true;
            //}
        }
        public void anthoat()
        {
            btThoat.Enabled = false;
        }
        string select = "select * from tbl_HopDong";
        public void loadMasv_SoPhong()
        {
            DataSet ds;
            string select1 = "select * from tbl_SinhVien";
            ds = ketnoi.laytruong(select1);
            cbmasv.DataSource = ds.Tables[0];
            cbmasv.DisplayMember = "Mssv";
            //--
            string select2 = "select * from tbl_PhongSV";
            ds = ketnoi.laytruong(select2);
            cbsophong.DataSource = ds.Tables[0];
            cbsophong.DisplayMember = "Mapsv";
            //--
            ds = ketnoi.laytruong(select);
            cbmahd.DataSource = ds.Tables[0];
            cbmahd.DisplayMember = "Mahd";

        }
        public void loadDatagridview()
        {
            dgvDshd.DataSource = ketnoi.laydlbang(select);
            dgvDshd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDshd.Columns[0].HeaderText = "Mã Hợp đồng";
            dgvDshd.Columns[0].Width = 100;
            dgvDshd.Columns[1].HeaderText = "Mã sinh viên";
            dgvDshd.Columns[1].Width = 100;
            dgvDshd.Columns[2].HeaderText = "Số Phòng";
            dgvDshd.Columns[2].Width = 90;
            dgvDshd.Columns[3].HeaderText = "Ngày lập hợp đồng";
            dgvDshd.Columns[3].Width = 180;
            dgvDshd.Columns[4].HeaderText = "Ngày bắt đầu ở";
            dgvDshd.Columns[4].Width = 180;
            dgvDshd.Columns[5].HeaderText = "Ngày kết thúc hợp đồng";
            dgvDshd.Columns[5].Width = 180;


        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
                FrmHopdong fr = new FrmHopdong();
                fr.btHuy_Click(sender,e);
            }
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            cbmahd.Text = null;
            cbmasv.Text = null;
            txttensv.Text = "";
            cbsophong.Text = null;            
            loadDatagridview();
        }

        private void dgvDshd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbmahd.DataBindings.Clear();
            cbmahd.DataBindings.Add("Text", dgvDshd.DataSource, "Mahd");
            cbmasv.DataBindings.Clear();
            cbmasv.DataBindings.Add("Text", dgvDshd.DataSource, "Mssv");
            cbsophong.DataBindings.Clear();
            cbsophong.DataBindings.Add("Text", dgvDshd.DataSource, "Mapsv");
            dtpngaylap.DataBindings.Clear();
            dtpngaylap.DataBindings.Add("Text", dgvDshd.DataSource, "NgayLap");
            dtpngaybt.DataBindings.Clear();
            dtpngaybt.DataBindings.Add("Text", dgvDshd.DataSource, "Tgbd");
            dtpngaykt.DataBindings.Clear();
            dtpngaykt.DataBindings.Add("Text", dgvDshd.DataSource, "Tgkt");
        }

        private void cbmasv_MouseClick(object sender, MouseEventArgs e)
        {
            DataSet ds;
            ds = ketnoi.laytruong("select * from tbl_SinhVien");
            cbmasv.DataSource = ds.Tables[0];
            txttensv.DataBindings.Clear();
            txttensv.DataBindings.Add("Text", ds.Tables[0], "Hotensv");
            cbsophong.DataBindings.Clear();
            cbsophong.DataBindings.Add("Text",ds.Tables[0],"Mapsv");
        }

        private void cbmahd_MouseClick(object sender, MouseEventArgs e)
        {
            DataSet ds;
            ds = ketnoi.laytruong(select);
            cbmahd.DataSource = ds.Tables[0];
            cbmasv.DataBindings.Clear();
            cbmasv.DataBindings.Add("Text", ds.Tables[0], "Mssv");
            cbsophong.DataBindings.Clear();
            cbsophong.DataBindings.Add("Text", ds.Tables[0], "Mapsv");
            dtpngaylap.DataBindings.Clear();
            dtpngaylap.DataBindings.Add("Text", ds.Tables[0], "NgayLap");
            dtpngaybt.DataBindings.Clear();
            dtpngaybt.DataBindings.Add("Text", ds.Tables[0], "Tgbd");
            dtpngaykt.DataBindings.Clear();
            dtpngaykt.DataBindings.Add("Text", ds.Tables[0], "Tgkt");
        }

        private void cbmahd_TextChanged(object sender, EventArgs e)
        {
            if (cbmahd.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;  
        }

        private void cbmasv_TextChanged(object sender, EventArgs e)
        {
            if (cbmasv.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true; 
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmahd.Text == "")
                {
                    MessageBox.Show("Hãy nhập Mã hợp đồng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbmahd.Select();
                    return;
                }
                if (cbmasv.Text == "")
                {
                    MessageBox.Show("Hãy chọn mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbmasv.Select();
                    return;
                }
                if (cbsophong.Text == "")
                {
                    MessageBox.Show("Hãy chọn mã phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbsophong.Select();
                    return;
                }

                
                SqlDataReader dr = ketnoi.ThuchienReader(select);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0) == cbmahd.Text|| dr.GetString(1)==cbmasv.Text)
                        {
                            dr.Close();
                            dr.Dispose();
                            throw new Exception();
                        }

                    }
                }
               
                dr.Close();
                dr.Dispose();

                if (dtpngaybt.Value < dtpngaykt.Value && dtpngaylap.Value <= dtpngaybt.Value)
                {
                    string insert = "insert into tbl_HopDong values('" + cbmahd.Text + "','" + cbmasv.Text + "','" + cbsophong.Text + "','" + dtpngaylap.Value.ToString() + "','" + dtpngaybt.Value.ToString() + "','" + dtpngaykt.Value.ToString() + "')";
                    ketnoi.ThucHienCmd(insert);
                    MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                    btHuy_Click(sender, e);
                    btThoat.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc Hoặc ngày lập hợp đồng phải nhỏ hơn ngày bắt đầu, Vui lòng xem lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Mã hợp đồng đã tồn tại hoặc mã sinh viên này đã ký hợp đồng, vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //private void btXoa_Click(object sender, EventArgs e)
        //{
        //    //if (cbmahd.Text == "")
        //    //    MessageBox.Show("Hãy nhập chọn dữ liệu trước khi xóa!");
        //    //else
        //    //{
        //    //    SqlDataReader dr = ketnoi.ThuchienReader(select);

        //    //    Boolean kt = false;
        //    //    if (dr != null)
        //    //    {

        //    //        while (dr.Read())
        //    //        {
        //    //            if (dr.GetString(0) == cbmahd.Text)
        //    //            {
        //    //                kt = true;

        //    //            }
        //    //        }
        //    //    }
        //    //    dr.Close();
        //    //    dr.Dispose();
        //    //    if (kt == false)
        //    //    {
        //    //        MessageBox.Show("Mã hợp đồng không tồn tại, vui lòng nhập đúng Mã cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    //    }
        //    //    else
        //    //    {
        //    //        DialogResult rs;
        //    //        rs = MessageBox.Show("Bạn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    //        if (rs == DialogResult.Yes)
        //    //        {
        //    //            string del = "delete tbl_HopDong where Mahd='" + cbmahd.Text + "'";
        //    //            ketnoi.ThucHienCmd(del);
        //    //            btHuy_Click(sender, e);
        //    //            MessageBox.Show("Bạn đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    //        }
        //    //    }

        //    //}       
        //}

        private void btSua_Click(object sender, EventArgs e)
        {
            if (cbmahd.Text == "")
                MessageBox.Show("Hãy nhập chọn mã hợp đồng cần sửa!");
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
                    MessageBox.Show("Mã hợp đồng không tồn tại, vui lòng nhập đúng Mã cần Sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (dtpngaybt.Value <= dtpngaykt.Value && dtpngaylap.Value <= dtpngaybt.Value)
                    {
                        DialogResult rs;
                        rs = MessageBox.Show("Bạn muốn sửa không?", "Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rs == DialogResult.Yes)
                        {
                            string sua = "update tbl_HopDong set Mahd='" + cbmahd.Text + "',Ngaylap='" + dtpngaylap.Text + "',Tgbd='" + dtpngaybt.Text + "',Tgkt='" + dtpngaykt.Text + "' where Mahd='" + cbmahd.Text + "'";
                            ketnoi.ThucHienCmd(sua);
                            btHuy_Click(sender, e);
                            MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                        }
                       
                    }
                    else
                    {
                        MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc Hoặc ngày lập hợp đồng phải nhỏ hơn ngày bắt đầu, Vui lòng xem lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }

            }
        }

        private void tbgiahan_Click(object sender, EventArgs e)
        {
            FrmGiahan frm = new FrmGiahan();
            frm.Ten = txtten.Text;
            frm.Quyen = txtquyen.Text;
            frm.ShowDialog();
        }
    }
}