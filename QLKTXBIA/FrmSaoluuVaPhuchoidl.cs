using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace QLKTXBIA
{
    public partial class FrmSaoluuVaPhuchoidl : Form
    {
        public FrmSaoluuVaPhuchoidl()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            ketnoi.CloseCn();
        }

        private void btnoiluu_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "quanlykytucxa.bak";
            save.Filter ="File(*.bak)|*.bak";
            if (save.ShowDialog()==DialogResult.OK)
            {
                txtvitriluu.Text = save.FileName;
            }
        }
       
        private void btluu_Click(object sender, EventArgs e)
        {
            if (txtvitriluu.Text=="")
            {
                MessageBox.Show("Bạn chưa chọn đường dẫn để lưu!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtvitriluu.Focus();
            }
            else
            {
                
                try
                {
                    ketnoi.OpenCn();
                    string saoluu = "Backup Database Qlyktxa to DISK='"+txtvitriluu.Text+"'";
                    ketnoi.ThucHienCmd(saoluu);
                    MessageBox.Show("Lưu thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtvitriluu.Text = "";
                    ketnoi.CloseCn();
                }
                    
                catch (Exception)
                {
                    
                    MessageBox.Show("Không thể lưu cơ sở dữ liệu!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);         
                
                }
            }
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.FileName = "";
            open.Filter = "File(*.bak)|*.bak";
            if (open.ShowDialog()== DialogResult.OK)
            {
                txtvitrifile.Text = open.FileName;
            }
        }
        
        private void btphuchoi_Click(object sender, EventArgs e)
        {
            ketnoi.OpenCn();
            if (txtvitrifile.Text=="")
            {
                 MessageBox.Show("Bạn chưa chọn file để phục hồi, Vui lòng chọn file!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);         
            }
            else
            {

                    string phuchoi = "ALTER DATABASE Qlyktxa SET SINGLE_USER WITH ROLLBACK IMMEDIATE USE master Restore database Qlyktxa from DISK = N'" + txtvitrifile.Text + "'with replace;";
                    ketnoi.ThucHienCmd(phuchoi);
                    MessageBox.Show("Phục hồi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtvitrifile.Text = "";
                    ketnoi.CloseCn();
                }
               
        }

        private void FrmSaoluuVaPhuchoidl_Load(object sender, EventArgs e)
        {

        }

       

       
    }
}