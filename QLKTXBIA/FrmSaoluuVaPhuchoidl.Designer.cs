namespace QLKTXBIA
{
    partial class FrmSaoluuVaPhuchoidl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btphuchoi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnoiluu = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.bttim = new System.Windows.Forms.Button();
            this.txtvitrifile = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtvitriluu = new System.Windows.Forms.TextBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btphuchoi
            // 
            this.btphuchoi.Image = global::QLKTXBIA.Properties.Resources.phuchoi;
            this.btphuchoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btphuchoi.Location = new System.Drawing.Point(226, 53);
            this.btphuchoi.Name = "btphuchoi";
            this.btphuchoi.Size = new System.Drawing.Size(85, 27);
            this.btphuchoi.TabIndex = 5;
            this.btphuchoi.Text = "Phục hồi";
            this.btphuchoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btphuchoi.UseVisualStyleBackColor = true;
            this.btphuchoi.Click += new System.EventHandler(this.btphuchoi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QLKTXBIA.Properties.Resources.thanhtab;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btnoiluu
            // 
            this.btnoiluu.Location = new System.Drawing.Point(232, 22);
            this.btnoiluu.Name = "btnoiluu";
            this.btnoiluu.Size = new System.Drawing.Size(79, 27);
            this.btnoiluu.TabIndex = 1;
            this.btnoiluu.Text = "Nơi lưu";
            this.btnoiluu.UseVisualStyleBackColor = true;
            this.btnoiluu.Click += new System.EventHandler(this.btnoiluu_Click);
            // 
            // btluu
            // 
            this.btluu.Image = global::QLKTXBIA.Properties.Resources.luu;
            this.btluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btluu.Location = new System.Drawing.Point(232, 55);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(79, 27);
            this.btluu.TabIndex = 2;
            this.btluu.Text = "Lưu";
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // bttim
            // 
            this.bttim.Location = new System.Drawing.Point(232, 20);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(79, 27);
            this.bttim.TabIndex = 4;
            this.bttim.Text = "Tìm";
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // txtvitrifile
            // 
            this.txtvitrifile.Location = new System.Drawing.Point(16, 21);
            this.txtvitrifile.Name = "txtvitrifile";
            this.txtvitrifile.Size = new System.Drawing.Size(210, 26);
            this.txtvitrifile.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btphuchoi);
            this.groupBox2.Controls.Add(this.bttim);
            this.groupBox2.Controls.Add(this.txtvitrifile);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(12, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 88);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phục hồi dữ liệu";
            // 
            // txtvitriluu
            // 
            this.txtvitriluu.Location = new System.Drawing.Point(16, 22);
            this.txtvitriluu.Name = "txtvitriluu";
            this.txtvitriluu.Size = new System.Drawing.Size(210, 26);
            this.txtvitriluu.TabIndex = 0;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.Blue;
            this.btThoat.Image = global::QLKTXBIA.Properties.Resources.exit;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(244, 227);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(79, 27);
            this.btThoat.TabIndex = 36;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btluu);
            this.groupBox1.Controls.Add(this.btnoiluu);
            this.groupBox1.Controls.Add(this.txtvitriluu);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 85);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lưu dữ liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Image = global::QLKTXBIA.Properties.Resources.thanhtab;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 24);
            this.label1.TabIndex = 37;
            this.label1.Text = "SAO LƯU VÀ PHỤC HỒI DỮ LIỆU";
            // 
            // FrmSaoluuVaPhuchoidl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKTXBIA.Properties.Resources.nen;
            this.ClientSize = new System.Drawing.Size(342, 258);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSaoluuVaPhuchoidl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sao lưu và phục hồi cơ sở dữ liệu";
            this.Load += new System.EventHandler(this.FrmSaoluuVaPhuchoidl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btphuchoi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnoiluu;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.TextBox txtvitrifile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtvitriluu;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;

    }
}