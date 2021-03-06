using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKTXBIA
{
    public partial class FrmTimKiem : Form
    {
        public FrmTimKiem()
        {
            InitializeComponent();
        }
        public string Quyen;
        public string Ten;

        private void FrmTimKiem_Load(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
            txtquyen.Text = Quyen;
            txtten.Text = Ten;

        }
        public void loadDatagridview()
        {                       
            dgvDssv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDssv.Columns[0].HeaderText = "Mã SV";
            dgvDssv.Columns[0].Width = 120;
            dgvDssv.Columns[1].HeaderText = "Họ và Tên";
            dgvDssv.Columns[1].Width = 200;
            dgvDssv.Columns[2].HeaderText = "Giới Tính";
            dgvDssv.Columns[2].Width = 80;
            dgvDssv.Columns[3].HeaderText = "Ngày Sinh";
            dgvDssv.Columns[3].Width = 150;
            dgvDssv.Columns[4].HeaderText = "Nơi sinh";
            dgvDssv.Columns[4].Width = 150;
            dgvDssv.Columns[5].HeaderText = "Địa chỉ";
            dgvDssv.Columns[5].Width = 170;
            dgvDssv.Columns[6].HeaderText = "Số điện thoại";
            dgvDssv.Columns[6].Width = 150;
            dgvDssv.Columns[7].HeaderText = "Mã trường";
            dgvDssv.Columns[7].Width = 80;
            dgvDssv.Columns[8].HeaderText = "Phòng";
            dgvDssv.Columns[8].Width = 80;
        }
        private void bttim_Click(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
            if (cbchon.Text=="Mã SV" && txtnhaptk.Text!="")
            {
                string tk = "select * from tbl_SinhVien where Mssv like N'%"+txtnhaptk.Text+"%'";
               
                    dgvDssv.DataSource = ketnoi.laydlbang(tk);                
                    loadDatagridview();
                    dgvDssv.Refresh();
                    ktradulieu(sender,e);
                
            }
            else
            {
                if (cbchon.Text=="Tên SV" && txtnhaptk.Text!="")
                {
                    
                    string tk = "select * from tbl_SinhVien where Hotensv like N'%" + txtnhaptk.Text + "%'";                    
                    dgvDssv.DataSource = ketnoi.laydlbang(tk);                    
                        loadDatagridview();
                        dgvDssv.Refresh();
                        ktradulieu(sender, e);
                }
                else
                {
                    if (cbchon.Text=="Mã Trường" && txtnhaptk.Text!="")
                    {
                        string tk = "select * from tbl_SinhVien where Matruong like N'%" + txtnhaptk.Text + "%'";
                        dgvDssv.DataSource = ketnoi.laydlbang(tk);
                        loadDatagridview();
                        dgvDssv.Refresh();
                        ktradulieu(sender, e);
                    }
                    else
                    {
                        if (cbchon.Text=="Mã Phòng" && txtnhaptk.Text!="")
                        {
                            string tk = "select * from tbl_SinhVien where Mapsv like N'%" + txtnhaptk.Text + "%'";
                            dgvDssv.DataSource = ketnoi.laydlbang(tk);
                            loadDatagridview();
                            dgvDssv.Refresh();
                            ktradulieu(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Bạn hãy nhập thông tin cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtnhaptk.Select();
                        }

                    }
                }
            }
           
        }
        private void ktradulieu(object sender, EventArgs e)
        {
            if (dgvDssv.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Dữ liệu không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btinan.Enabled = false;
            }
            else
                btinan.Enabled = true;  

        }
        private void btthoat_Click(object sender, EventArgs e)
        {
            DialogResult rs;
            rs = MessageBox.Show("Bạn muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
                //ketnoi.CloseCn();
            }
        }

        private void txtinan_Click(object sender, EventArgs e)
        {
            //FrmInSinhVien frm = new FrmInSinhVien();
            //frm.ShowDialog();
            //---
            ketnoi.OpenCn();
            if (cbchon.Text == "Mã SV" && txtnhaptk.Text != "")
            {
                FrmInSinhVien frm = new FrmInSinhVien();
                frm.Mssv =txtnhaptk.Text;
                frm.tktheoMaSV(sender,e);
                frm.ShowDialog();

            }
            else
            {
                if (cbchon.Text == "Tên SV" && txtnhaptk.Text != "")
                {
                    FrmInSinhVien frm = new FrmInSinhVien();
                    frm.Ten = txtnhaptk.Text;
                    frm.tktheoTensv(sender, e);
                    frm.ShowDialog();
                }
                else
                {
                    if (cbchon.Text == "Mã Trường" && txtnhaptk.Text != "")
                    {
                        FrmInSinhVien frm = new FrmInSinhVien();
                        frm.Truong = txtnhaptk.Text;
                        frm.tktheoTruong(sender, e);
                        frm.ShowDialog();
                    }
                    else
                    {
                        if (cbchon.Text == "Mã Phòng" && txtnhaptk.Text != "")
                        {
                            FrmInSinhVien frm = new FrmInSinhVien();
                            frm.Phong = txtnhaptk.Text;
                            frm.tktheoPhong(sender, e);
                            frm.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Bạn hãy nhập thông tin cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtnhaptk.Select();
                        }

                    }
                }
            }
            //---
        }
    }
}