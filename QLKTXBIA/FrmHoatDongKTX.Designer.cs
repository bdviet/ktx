namespace QLKTXBIA
{
    partial class FrmHoatDongKTX
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
            this.rdHdong = new System.Windows.Forms.RadioButton();
            this.rdInAll = new System.Windows.Forms.RadioButton();
            this.rdInnv = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbchon = new System.Windows.Forms.ComboBox();
            this.crtInhdong = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtten = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtquyen = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btIn
            // 
            this.btIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIn.ForeColor = System.Drawing.Color.Blue;
            this.btIn.Image = global::QLKTXBIA.Properties.Resources.print;
            this.btIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIn.Location = new System.Drawing.Point(558, 131);
            this.btIn.Margin = new System.Windows.Forms.Padding(4);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(69, 31);
            this.btIn.TabIndex = 40;
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
            this.btThoat.Location = new System.Drawing.Point(680, 131);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(72, 31);
            this.btThoat.TabIndex = 39;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // rdHdong
            // 
            this.rdHdong.AutoSize = true;
            this.rdHdong.BackColor = System.Drawing.Color.Transparent;
            this.rdHdong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHdong.ForeColor = System.Drawing.Color.Blue;
            this.rdHdong.Location = new System.Drawing.Point(615, 58);
            this.rdHdong.Name = "rdHdong";
            this.rdHdong.Size = new System.Drawing.Size(198, 23);
            this.rdHdong.TabIndex = 38;
            this.rdHdong.TabStop = true;
            this.rdHdong.Text = "Theo hoạt động Ký túc xá";
            this.rdHdong.UseVisualStyleBackColor = false;
            this.rdHdong.CheckedChanged += new System.EventHandler(this.rdHdong_CheckedChanged);
            // 
            // rdInAll
            // 
            this.rdInAll.AutoSize = true;
            this.rdInAll.BackColor = System.Drawing.Color.Transparent;
            this.rdInAll.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdInAll.ForeColor = System.Drawing.Color.Blue;
            this.rdInAll.Location = new System.Drawing.Point(424, 87);
            this.rdInAll.Name = "rdInAll";
            this.rdInAll.Size = new System.Drawing.Size(151, 23);
            this.rdInAll.TabIndex = 37;
            this.rdInAll.TabStop = true;
            this.rdInAll.Text = "In tất cả hoạt động";
            this.rdInAll.UseVisualStyleBackColor = false;
            this.rdInAll.CheckedChanged += new System.EventHandler(this.rdInAll_CheckedChanged);
            // 
            // rdInnv
            // 
            this.rdInnv.AutoSize = true;
            this.rdInnv.BackColor = System.Drawing.Color.Transparent;
            this.rdInnv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdInnv.ForeColor = System.Drawing.Color.Blue;
            this.rdInnv.Location = new System.Drawing.Point(424, 58);
            this.rdInnv.Name = "rdInnv";
            this.rdInnv.Size = new System.Drawing.Size(185, 23);
            this.rdInnv.TabIndex = 36;
            this.rdInnv.TabStop = true;
            this.rdInnv.Text = "Theo Nhân viên quản lý";
            this.rdInnv.UseVisualStyleBackColor = false;
            this.rdInnv.CheckedChanged += new System.EventHandler(this.rdInnv_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Image = global::QLKTXBIA.Properties.Resources.thanhtab;
            this.label2.Location = new System.Drawing.Point(464, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 26);
            this.label2.TabIndex = 35;
            this.label2.Text = "IN ẤN HOẠT ĐỘNG TRONG KÝ TÚC XÁ";
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
            this.pictureBox1.Size = new System.Drawing.Size(1020, 45);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // cbchon
            // 
            this.cbchon.Enabled = false;
            this.cbchon.FormattingEnabled = true;
            this.cbchon.Location = new System.Drawing.Point(615, 88);
            this.cbchon.Name = "cbchon";
            this.cbchon.Size = new System.Drawing.Size(227, 21);
            this.cbchon.TabIndex = 33;
            // 
            // crtInhdong
            // 
            this.crtInhdong.ActiveViewIndex = -1;
            this.crtInhdong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.crtInhdong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtInhdong.Cursor = System.Windows.Forms.Cursors.Default;
            this.crtInhdong.Location = new System.Drawing.Point(-9, 169);
            this.crtInhdong.Name = "crtInhdong";
            this.crtInhdong.SelectionFormula = "";
            this.crtInhdong.Size = new System.Drawing.Size(1038, 471);
            this.crtInhdong.TabIndex = 32;
            this.crtInhdong.ViewTimeSelectionFormula = "";
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 612);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1020, 22);
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
            // FrmHoatDongKTX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKTXBIA.Properties.Resources.nen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 634);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btIn);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.rdHdong);
            this.Controls.Add(this.rdInAll);
            this.Controls.Add(this.rdInnv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbchon);
            this.Controls.Add(this.crtInhdong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHoatDongKTX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In ấn hoạt động trong Ký túc xá";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmHoatDongKTX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.RadioButton rdHdong;
        private System.Windows.Forms.RadioButton rdInAll;
        private System.Windows.Forms.RadioButton rdInnv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbchon;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crtInhdong;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtten;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel txtquyen;
    }
}