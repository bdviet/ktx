namespace QLKTXBIA
{
    partial class FrmPhongBan
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
            this.btthoat = new System.Windows.Forms.Button();
            this.dgvDsPhong = new System.Windows.Forms.DataGridView();
            this.txttenphong = new System.Windows.Forms.TextBox();
            this.btHuy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btthem = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbmapban = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btsua = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtten = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtquyen = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsPhong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btthoat
            // 
            this.btthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btthoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat.ForeColor = System.Drawing.Color.Blue;
            this.btthoat.Image = global::QLKTXBIA.Properties.Resources.exit;
            this.btthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthoat.Location = new System.Drawing.Point(331, 224);
            this.btthoat.Name = "btthoat";
            this.btthoat.Size = new System.Drawing.Size(75, 30);
            this.btthoat.TabIndex = 37;
            this.btthoat.Text = "Thoát";
            this.btthoat.UseVisualStyleBackColor = true;
            this.btthoat.Click += new System.EventHandler(this.btthoat_Click);
            // 
            // dgvDsPhong
            // 
            this.dgvDsPhong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDsPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsPhong.Location = new System.Drawing.Point(30, 28);
            this.dgvDsPhong.Name = "dgvDsPhong";
            this.dgvDsPhong.ReadOnly = true;
            this.dgvDsPhong.Size = new System.Drawing.Size(344, 132);
            this.dgvDsPhong.TabIndex = 0;
            this.dgvDsPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsPhong_CellContentClick);
            // 
            // txttenphong
            // 
            this.txttenphong.Location = new System.Drawing.Point(139, 90);
            this.txttenphong.Name = "txttenphong";
            this.txttenphong.Size = new System.Drawing.Size(189, 29);
            this.txttenphong.TabIndex = 3;
            this.txttenphong.TextChanged += new System.EventHandler(this.txttenphong_TextChanged);
            // 
            // btHuy
            // 
            this.btHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHuy.Enabled = false;
            this.btHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.ForeColor = System.Drawing.Color.Blue;
            this.btHuy.Image = global::QLKTXBIA.Properties.Resources.huy;
            this.btHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHuy.Location = new System.Drawing.Point(253, 224);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(75, 30);
            this.btHuy.TabIndex = 36;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Phòng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Image = global::QLKTXBIA.Properties.Resources.thanhtab;
            this.label1.Location = new System.Drawing.Point(89, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 26);
            this.label1.TabIndex = 39;
            this.label1.Text = "QUẢN LÝ PHÒNG";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvDsPhong);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(11, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 177);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Phòng";
            // 
            // btthem
            // 
            this.btthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btthem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.ForeColor = System.Drawing.Color.Blue;
            this.btthem.Image = global::QLKTXBIA.Properties.Resources.them;
            this.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthem.Location = new System.Drawing.Point(19, 224);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 30);
            this.btthem.TabIndex = 33;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // btxoa
            // 
            this.btxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btxoa.Enabled = false;
            this.btxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.ForeColor = System.Drawing.Color.Blue;
            this.btxoa.Image = global::QLKTXBIA.Properties.Resources.xoa;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(95, 224);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 30);
            this.btxoa.TabIndex = 34;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbmapban);
            this.groupBox1.Controls.Add(this.txttenphong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 136);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // cbmapban
            // 
            this.cbmapban.FormattingEnabled = true;
            this.cbmapban.Location = new System.Drawing.Point(139, 40);
            this.cbmapban.Name = "cbmapban";
            this.cbmapban.Size = new System.Drawing.Size(189, 30);
            this.cbmapban.TabIndex = 1;
            this.cbmapban.TextChanged += new System.EventHandler(this.cbmapban_TextChanged);
            this.cbmapban.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbmapban_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Phòng :";
            // 
            // btsua
            // 
            this.btsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.ForeColor = System.Drawing.Color.Blue;
            this.btsua.Image = global::QLKTXBIA.Properties.Resources.sua;
            this.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsua.Location = new System.Drawing.Point(176, 224);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 30);
            this.btsua.TabIndex = 35;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QLKTXBIA.Properties.Resources.thanhtab;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = global::QLKTXBIA.Properties.Resources.thanhtab;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtten,
            this.toolStripStatusLabel2,
            this.txtquyen});
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(417, 22);
            this.statusStrip1.TabIndex = 68;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabel1.Text = "Chào :";
            // 
            // txtten
            // 
            this.txtten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.ForeColor = System.Drawing.Color.Red;
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel2.Text = "Quyền :";
            // 
            // txtquyen
            // 
            this.txtquyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquyen.ForeColor = System.Drawing.Color.Red;
            this.txtquyen.Name = "txtquyen";
            this.txtquyen.Size = new System.Drawing.Size(0, 17);
            // 
            // FrmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKTXBIA.Properties.Resources.nen;
            this.ClientSize = new System.Drawing.Size(417, 463);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btthoat);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btsua);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Phòng ban";
            this.Load += new System.EventHandler(this.FrmPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsPhong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btthoat;
        private System.Windows.Forms.DataGridView dgvDsPhong;
        private System.Windows.Forms.TextBox txttenphong;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.ComboBox cbmapban;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtten;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel txtquyen;
    }
}