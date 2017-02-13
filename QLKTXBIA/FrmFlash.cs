using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLKTXBIA
{
    public partial class FrmFlash : Form
    {
        public FrmFlash()
        {
            InitializeComponent();
        }

        private void timer_Splash_Tick(object sender, EventArgs e)
        {
            prload.Value += 2;
            lbPhantram.Text = prload.Value + "%";
            if (prload.Value == prload.Maximum)
            {
                this.DialogResult = DialogResult.OK;
                timer_Splash.Stop();
                FrmDangNhap fr = new FrmDangNhap();
                this.Visible = false;
                fr.ShowDialog();
            }
        }

        private void FrmFlash_Load(object sender, EventArgs e)
        {
            timer_Splash.Interval = 100;
            timer_Splash.Start();
            timer_chuchay.Start();
        }

        private void timer_chuchay_Tick(object sender, EventArgs e)
        {
            string ch = label1.Text;
            label1.Text = ch.Substring(1,ch.Length-1);//bo 1
            label1.Text += ch.Substring(0,1);//1-> ch.length-1
        }

       

        
       
    }
}