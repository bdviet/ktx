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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        string chon = "select * from tbl_DangNhap";
        private void btDangnhap_Click(object sender, EventArgs e)
        {
            string tenDN = txtName.Text.Trim();
            string mk = txtpass.Text.Trim();
            string quyen = cbquyen.Text.Trim();
            try
            {
                if (tenDN =="")
                {
                    MessageBox.Show("Bạn hãy nhập tên đăng nhập!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtName.Select();
                    return;
                }
                if (mk =="")
                {
                   MessageBox.Show("Bạn hãy nhập mật khẩu!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtpass.Select();
                    return;
                }
                if (quyen =="")
                {
                   MessageBox.Show("Bạn hãy chọn quyền!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    cbquyen.Select();
                    return;
                }
                SqlDataReader dr = ketnoi.ThuchienReader(chon);
                Boolean kt = false;
                if (dr!=null)
                {
                    while (dr.Read())
                    {
                        if (dr.GetString(0)== tenDN && dr.GetString(1)== mk && dr.GetString(2)==quyen)
                        {
                            kt = true;
                            FrmMain frmmain = new FrmMain();
                            if (quyen == "Admin")
                            {
                                frmmain.hien();
                            }
                            this.Visible = false;
                            MessageBox.Show("Đăng nhập thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);                            
                            frmmain.Quyen = cbquyen.Text;
                            frmmain.Ten = txtName.Text;
                            frmmain.ShowDialog();
                        }
                    }
                }
                dr.Close();
                dr.Dispose();
                if (kt==false)
                {
                    MessageBox.Show("Nhập sai thông tin(Name,pass, quyen), Vui lòng nhập lại!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtName.Text = "";
                    txtpass.Text = "";
                    cbquyen.Text = null;
                }
            }
            catch
            {               
                
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            ketnoi.ExitAll();
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
        }

        private void cbquyen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                btDangnhap_Click(sender,e);
            }
        }

       

       
        
    }
}