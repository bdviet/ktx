namespace QLKTXBIA
{
    partial class FrmInHoaDon
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
            this.btIn = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.cbchon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CrtInHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rdPhong = new System.Windows.Forms.RadioButton();
            this.rdmahd = new System.Windows.Forms.RadioButton();
            this.rdInAll = new System.Windows.Forms.RadioButton();
            this.rdngay = new System.Windows.Forms.RadioButton();
            this.dtgtu = new System.Windows.Forms.DateTimePicker();
            this.dtgden = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtten = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtquyen = new System.Windows.Forms.ToolStripStatusLabel();
            this.rdkhu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btIn
            // 
            this.btIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIn.ForeColor = System.Drawing.Color.Blue;
            this.btIn.Location = new System.Drawing.Point(529, 164);
            this.btIn.Margin = new System.Windows.Forms.Padding(4);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(72, 31);
            this.btIn.TabIndex = 21;
            this.btIn.Text = "In";
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // btThoat
            // 
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.Blue;
            this.btThoat.Image = global::QLKTXBIA.Properties.Resources.exit;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(661, 164);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(67, 31);
            this.btThoat.TabIndex = 20;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // cbchon
            // 
            this.cbchon.Enabled = false;
            this.cbchon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbchon.FormattingEnabled = true;
            this.cbchon.Location = new System.Drawing.Point(639, 85);
            this.cbchon.Name = "cbchon";
            this.cbchon.Size = new System.Drawing.Size(158, 29);
            this.cbchon.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Image = global::QLKTXBIA.Properties.Resources.thanhtab;
            this.label2.Location = new System.Drawing.Point(541, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "IN ẤN HÓA ĐƠN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QLKTXBIA.Properties.Resources.thanhtab;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(982, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // CrtInHoaDon
            // 
            this.CrtInHoaDon.ActiveViewIndex = -1;
            this.CrtInHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CrtInHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CrtInHoaDon.Location = new System.Drawing.Point(0, 202);
            this.CrtInHoaDon.Name = "CrtInHoaDon";
            this.CrtInHoaDon.SelectionFormula = "";
            this.CrtInHoaDon.Size = new System.Drawing.Size(982, 300);
            this.CrtInHoaDon.TabIndex = 22;
            this.CrtInHoaDon.ViewTimeSelectionFormula = "";
            // 
            // rdPhong
            // 
            this.rdPhong.AutoSize = true;
            this.rdPhong.BackColor = System.Drawing.Color.Transparent;
            this.rdPhong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPhong.ForeColor = System.Drawing.Color.Blue;
            this.rdPhong.Location = new System.Drawing.Point(466, 56);
            this.rdPhong.Name = "rdPhong";
            this.rdPhong.Size = new System.Drawing.Size(142, 26);
            this.rdPhong.TabIndex = 23;
            this.rdPhong.TabStop = true;
            this.rdPhong.Text = "In theo Phòng";
            this.rdPhong.UseVisualStyleBackColor = false;
            this.rdPhong.CheckedChanged += new System.EventHandler(this.rdPhong_CheckedChanged);
            // 
            // rdmahd
            // 
            this.rdmahd.AutoSize = true;
            this.rdmahd.BackColor = System.Drawing.Color.Transparent;
            this.rdmahd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdmahd.ForeColor = System.Drawing.Color.Blue;
            this.rdmahd.Location = new System.Drawing.Point(639, 53);
            this.rdmahd.Name = "rdmahd";
            this.rdmahd.Size = new System.Drawing.Size(146, 26);
            this.rdmahd.TabIndex = 24;
            this.rdmahd.TabStop = true;
            this.rdmahd.Text = "In mã hóa đơn";
            this.rdmahd.UseVisualStyleBackColor = false;
            this.rdmahd.CheckedChanged += new System.EventHandler(this.rdmahd_CheckedChanged);
            // 
            // rdInAll
            // 
            this.rdInAll.AutoSize = true;
            this.rdInAll.BackColor = System.Drawing.Color.Transparent;
            this.rdInAll.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdInAll.ForeColor = System.Drawing.Color.Blue;
            this.rdInAll.Location = new System.Drawing.Point(466, 88);
            this.rdInAll.Name = "rdInAll";
            this.rdInAll.Size = new System.Drawing.Size(167, 26);
            this.rdInAll.TabIndex = 25;
            this.rdInAll.TabStop = true;
            this.rdInAll.Text = "In tất cả hóa đơn";
            this.rdInAll.UseVisualStyleBackColor = false;
            this.rdInAll.CheckedChanged += new System.EventHandler(this.rdInAll_CheckedChanged);
            // 
            // rdngay
            // 
            this.rdngay.AutoSize = true;
            this.rdngay.BackColor = System.Drawing.Color.Transparent;
            this.rdngay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdngay.ForeColor = System.Drawing.Color.Blue;
            this.rdngay.Location = new System.Drawing.Point(466, 124);
            this.rdngay.Name = "rdngay";
            this.rdngay.Size = new System.Drawing.Size(129, 26);
            this.rdngay.TabIndex = 26;
            this.rdngay.TabStop = true;
            this.rdngay.Text = "In theo ngày";
            this.rdngay.UseVisualStyleBackColor = false;
            this.rdngay.CheckedChanged += new System.EventHandler(this.rdngay_CheckedChanged);
            // 
            // dtgtu
            // 
            this.dtgtu.Enabled = false;
            this.dtgtu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgtu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtgtu.Location = new System.Drawing.Point(650, 126);
            this.dtgtu.Name = "dtgtu";
            this.dtgtu.Size = new System.Drawing.Size(91, 26);
            this.dtgtu.TabIndex = 27;
            this.dtgtu.Value = new System.DateTime(2013, 12, 11, 0, 0, 0, 0);
            // 
            // dtgden
            // 
            this.dtgden.Enabled = false;
            this.dtgden.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgden.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtgden.Location = new System.Drawing.Point(802, 126);
            this.dtgden.Name = "dtgden";
            this.dtgden.Size = new System.Drawing.Size(96, 26);
            this.dtgden.TabIndex = 28;
            this.dtgden.Value = new System.DateTime(2013, 12, 11, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(606, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Từ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(747, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Đến  :";
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(982, 22);
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
            // rdkhu
            // 
            this.rdkhu.AutoSize = true;
            this.rdkhu.BackColor = System.Drawing.Color.Transparent;
            this.rdkhu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdkhu.ForeColor = System.Drawing.Color.Blue;
            this.rdkhu.Location = new System.Drawing.Point(802, 53);
            this.rdkhu.Name = "rdkhu";
            this.rdkhu.Size = new System.Drawing.Size(121, 26);
            this.rdkhu.TabIndex = 69;
            this.rdkhu.TabStop = true;
            this.rdkhu.Text = "In theo khu";
            this.rdkhu.UseVisualStyleBackColor = false;
            this.rdkhu.CheckedChanged += new System.EventHandler(this.rdkhu_CheckedChanged);
            // 
            // FrmInHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKTXBIA.Properties.Resources.nen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 498);
            this.ControlBox = false;
            this.Controls.Add(this.rdkhu);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgden);
            this.Controls.Add(this.dtgtu);
            this.Controls.Add(this.rdngay);
            this.Controls.Add(this.rdInAll);
            this.Controls.Add(this.rdmahd);
            this.Controls.Add(this.rdPhong);
            this.Controls.Add(this.CrtInHoaDon);
            this.Controls.Add(this.btIn);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.cbchon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInHoaDon";
            this.Text = "In hóa đơn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.ComboBox cbchon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrtInHoaDon;
        private System.Windows.Forms.RadioButton rdPhong;
        private System.Windows.Forms.RadioButton rdmahd;
        private System.Windows.Forms.RadioButton rdInAll;
        private System.Windows.Forms.RadioButton rdngay;
        private System.Windows.Forms.DateTimePicker dtgtu;
        private System.Windows.Forms.DateTimePicker dtgden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtten;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel txtquyen;
        private System.Windows.Forms.RadioButton rdkhu;
    }
}