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
    public partial class FrmGiahan : Form
    {
        public FrmGiahan()
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
               // ketnoi.CloseCn();
            }
        }
        public string Quyen;
        public string Ten;
        string select = "select * from tbl_GiaHan";
        private void FrmGiahan_Load(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
            load_Datagridview();
            load_masv_mahd();
            btHuy_Click(sender,e);             
            	
	        txtquyen.Text = Quyen;
            txtten.Text = Ten;
            if (txtquyen.Text == "Admin")
            {
                btXoa.Enabled = true;
            }
        }
        public void load_Datagridview()
        {
            dgvDsgh.DataSource = ketnoi.laydlbang(select);
            dgvDsgh.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDsgh.Columns[0].HeaderText = "Mã gia hạn";
            dgvDsgh.Columns[0].Width = 120;
            dgvDsgh.Columns[1].HeaderText = "Mã sinh viên";
            dgvDsgh.Columns[1].Width = 120;
            dgvDsgh.Columns[2].HeaderText = "Mã hợp đồng";
            dgvDsgh.Columns[2].Width = 120;
            dgvDsgh.Columns[3].HeaderText = "Thời gian bắt đầu";
            dgvDsgh.Columns[3].Width = 120;
            dgvDsgh.Columns[4].HeaderText = "Thời gian kết thúc";
            dgvDsgh.Columns[4].Width = 120;
        }

        public void load_masv_mahd()
        {
            DataSet ds;
            ds = ketnoi.laytruong("select Mssv from tbl_SinhVien");
            cbmasv.DataSource = ds.Tables[0];
            cbmasv.DisplayMember = "Mssv";
           // --
            //ds = ketnoi.laytruong("select Mahd from tbl_HopDong");
            //cbmahd.DataSource = ds.Tables[0];
            //cbmahd.DisplayMember = "Mahd";
            //--
            ds = ketnoi.laytruong("select Magh from tbl_GiaHan");
            cbmagh.DataSource = ds.Tables[0];
            cbmagh.DisplayMember = "Magh";

        }

        private void cbmasv_MouseClick(object sender, MouseEventArgs e)
        {
            
            DataSet ds1;
            ds1 = ketnoi.laytruong("SELECT dbo.tbl_HopDong.Mahd,dbo.tbl_HopDong.Tgkt,dbo.tbl_SinhVien.Mssv,dbo.tbl_SinhVien.Hotensv FROM dbo.tbl_HopDong INNER JOIN dbo.tbl_SinhVien ON dbo.tbl_HopDong.Mssv = dbo.tbl_SinhVien.Mssv");
            cbmasv.DataSource = ds1.Tables[0];
            cbmahd.DataBindings.Clear();
            cbmahd.DataBindings.Add("Text", ds1.Tables[0], "Mahd");
            txtensv.DataBindings.Clear();
            txtensv.DataBindings.Add("Text",ds1.Tables[0],"Hotensv");
            dtpngaybt.DataBindings.Clear();
            dtpngaybt.DataBindings.Add("Text",ds1.Tables[0],"Tgkt");
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            cbmagh.Text = null;
            cbmasv.Text = null;
            
            cbmahd.Text = null;
            dtpngaybt.Text = DateTime.Today.TimeOfDay.ToString();
            dtpngaykt.Text = DateTime.Today.TimeOfDay.ToString();
            load_Datagridview();
        }

        private void dgvDsgh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            load_control();
        }
        public void load_control()
        {
            cbmagh.DataBindings.Clear();
            cbmagh.DataBindings.Add("Text", dgvDsgh.DataSource, "Magh");
            cbmasv.DataBindings.Clear();
            cbmasv.DataBindings.Add("Text", dgvDsgh.DataSource, "Mssv");            
            cbmahd.DataBindings.Clear();
            cbmahd.DataBindings.Add("Text", dgvDsgh.DataSource, "Mahd");
            dtpngaybt.DataBindings.Clear();
            dtpngaybt.DataBindings.Add("Text", dgvDsgh.DataSource, "Tgbd");
            dtpngaykt.DataBindings.Clear();
            dtpngaykt.DataBindings.Add("Text", dgvDsgh.DataSource, "Tgkt");
        }

        private void cbmagh_MouseClick(object sender, MouseEventArgs e)
        {
            DataSet ds;
            ds = ketnoi.laytruong(select);
            cbmagh.DataSource = ds.Tables[0];
            cbmasv.DataBindings.Clear();
            cbmasv.DataBindings.Add("Text", ds.Tables[0], "Mssv");            
            cbmahd.DataBindings.Clear();
            cbmahd.DataBindings.Add("Text", ds.Tables[0], "Mahd");
            dtpngaybt.DataBindings.Clear();
            dtpngaybt.DataBindings.Add("Text", ds.Tables[0], "Tgbd");
            dtpngaykt.DataBindings.Clear();
            dtpngaykt.DataBindings.Add("Text", ds.Tables[0], "Tgkt");
        }

        private void cbmagh_TextChanged(object sender, EventArgs e)
        {
            if (cbmagh.Text == "")
                btHuy.Enabled = false;
            else
                btHuy.Enabled = true;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbmagh.Text=="")
                {
                    MessageBox.Show("Bạn hãy nhập Mã gia hạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbmagh.Select();
                    return;
                }
                if (cbmasv.Text=="")
                {
                    MessageBox.Show("Bạn hãy chọn mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbmasv.Select();
                    return;
                }
                if (cbmahd.Text=="")
                {
                    MessageBox.Show("Bạn hãy chọn mã hợp đồng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbmahd.Select();
                    return;
                }
                SqlDataReader dr = ketnoi.ThuchienReader(select);
                if (dr!=null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0)==cbmagh.Text|| dr.GetString(1)==cbmasv.Text)
                        {
                            dr.Close();
                            dr.Dispose();
                            throw new Exception();
                        }
                    }
                }
                //if (dr!=null)
                //{
                //    while (dr.Read())
                //    {
                //        if (dr.GetString(0)==cbmasv.Text)
                //        {
                //            dr.Close();
                //            dr.Dispose();
                //            throw new Exception();
                //        }
                //    }
                //}
                dr.Close();
                dr.Dispose();
                if (dtpngaybt.Value < dtpngaykt.Value)
                {
                    string insert = "insert into tbl_GiaHan values('"+cbmagh.Text+"','"+cbmasv.Text+"','"+cbmahd.Text+"','"+dtpngaybt.Value.ToString()+"','"+dtpngaykt.Value.ToString()+"')";
                    ketnoi.ThucHienCmd(insert);
                    String update = "update tbl_HopDong set Tgkt='"+dtpngaykt.Text+"' where Mssv='"+cbmasv.Text+"'";
                    ketnoi.ThucHienCmd(update);
                    MessageBox.Show("Bạn đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btHuy_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc, Vui lòng xem lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Mã gia hạn đã tồn tại hoặc mã sinh viên này đã gia hạn, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (cbmagh.Text == "")
                MessageBox.Show("Bạn hãy chọn mã gia hạn muốn xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                SqlDataReader dr = ketnoi.ThuchienReader(select);

                Boolean kt = false;
                if (dr != null)
                {

                    while (dr.Read())
                    {
                        if (dr.GetString(0) == cbmagh.Text)
                        {
                            kt = true;

                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                if (kt == false)
                {
                    MessageBox.Show("Mã gia hạn không tồn tại, vui lòng nhập đúng Mã cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult rs;
                    rs = MessageBox.Show("Bạn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        string del = "delete tbl_GiaHan where Magh='" + cbmagh.Text + "'";
                        ketnoi.ThucHienCmd(del);
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btHuy_Click(sender, e);
                    }
                }
            }      
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (cbmagh.Text == "")
                MessageBox.Show("Bạn hãy chọn mã gia hạn muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                SqlDataReader dr = ketnoi.ThuchienReader(select);

                Boolean kt = false;
                if (dr != null)
                {

                    while (dr.Read())
                    {
                        if (dr.GetString(0) == cbmagh.Text)
                        {
                            kt = true;

                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                if (kt == false)
                {
                    MessageBox.Show("Mã gia hạn không tồn tại, vui lòng nhập đúng Mã cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (dtpngaybt.Value < dtpngaykt.Value)
                    {
                        DialogResult rs;
                        rs = MessageBox.Show("Bạn muốn sửa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rs == DialogResult.Yes)
                        {
                            string sua = "update tbl_GiaHan set Magh='" + cbmagh.Text + "',Mssv='" + cbmasv.Text + "',Mahd='" + cbmahd.Text + "',Tgbd='" + dtpngaybt.Value.ToString() + "',Tgkt='" + dtpngaykt.Value.ToString() + "' where Magh='" + cbmagh.Text + "'";
                            ketnoi.ThucHienCmd(sua);
                            String update = "update tbl_HopDong set Tgkt='" + dtpngaykt.Text + "' where Mssv='" + cbmasv.Text + "'";
                            ketnoi.ThucHienCmd(update);
                            MessageBox.Show("Đã Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btHuy_Click(sender, e);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc, Vui lòng xem lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }


            }      
        }

       

       
       

       
    }
}