namespace QLKTXBIA
{
    partial class FrmInHopDong
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
            this.rdtruong = new System.Windows.Forms.RadioButton();
            this.btIn = new System.Windows.Forms.Button();
            this.rdPhong = new System.Windows.Forms.RadioButton();
            this.rdInAll = new System.Windows.Forms.RadioButton();
            this.rdInma = new System.Windows.Forms.RadioButton();
            this.cbchon = new System.Windows.Forms.ComboBox();
            this.crtInhd = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdquahan = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtten = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtquyen = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdtruong
            // 
            this.rdtruong.AutoSize = true;
            this.rdtruong.BackColor = System.Drawing.Color.Transparent;
            this.rdtruong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdtruong.ForeColor = System.Drawing.Color.Blue;
            this.rdtruong.Location = new System.Drawing.Point(766, 49);
            this.rdtruong.Name = "rdtruong";
            this.rdtruong.Size = new System.Drawing.Size(128, 23);
            this.rdtruong.TabIndex = 31;
            this.rdtruong.TabStop = true;
            this.rdtruong.Text = "In theo Trường";
            this.rdtruong.UseVisualStyleBackColor = false;
            this.rdtruong.CheckedChanged += new System.EventHandler(this.rdtruong_CheckedChanged);
            // 
            // btIn
            // 
            this.btIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIn.ForeColor = System.Drawing.Color.Blue;
            this.btIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIn.Location = new System.Drawing.Point(561, 136);
            this.btIn.Margin = new System.Windows.Forms.Padding(4);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(69, 31);
            this.btIn.TabIndex = 30;
            this.btIn.Text = "In";
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // rdPhong
            // 
            this.rdPhong.AutoSize = true;
            this.rdPhong.BackColor = System.Drawing.Color.Transparent;
            this.rdPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPhong.ForeColor = System.Drawing.Color.Blue;
            this.rdPhong.Location = new System.Drawing.Point(628, 49);
            this.rdPhong.Name = "rdPhong";
            this.rdPhong.Size = new System.Drawing.Size(123, 23);
            this.rdPhong.TabIndex = 28;
            this.rdPhong.TabStop = true;
            this.rdPhong.Text = "In theo Phòng ";
            this.rdPhong.UseVisualStyleBackColor = false;
            this.rdPhong.CheckedChanged += new System.EventHandler(this.rdPhong_CheckedChanged);
            // 
            // rdInAll
            // 
            this.rdInAll.AutoSize = true;
            this.rdInAll.BackColor = System.Drawing.Color.Transparent;
            this.rdInAll.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdInAll.ForeColor = System.Drawing.Color.Blue;
            this.rdInAll.Location = new System.Drawing.Point(457, 79);
            this.rdInAll.Name = "rdInAll";
            this.rdInAll.Size = new System.Drawing.Size(147, 23);
            this.rdInAll.TabIndex = 27;
            this.rdInAll.TabStop = true;
            this.rdInAll.Text = "In tất cả hợp đồng";
            this.rdInAll.UseVisualStyleBackColor = false;
            this.rdInAll.CheckedChanged += new System.EventHandler(this.rdInAll_CheckedChanged);
            // 
            // rdInma
            // 
            this.rdInma.AutoSize = true;
            this.rdInma.BackColor = System.Drawing.Color.Transparent;
            this.rdInma.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdInma.ForeColor = System.Drawing.Color.Blue;
            this.rdInma.Location = new System.Drawing.Point(457, 50);
            this.rdInma.Name = "rdInma";
            this.rdInma.Size = new System.Drawing.Size(163, 23);
            this.rdInma.TabIndex = 26;
            this.rdInma.TabStop = true;
            this.rdInma.Text = "In theo mã hợp đồng";
            this.rdInma.UseVisualStyleBackColor = false;
            this.rdInma.CheckedChanged += new System.EventHandler(this.rdInma_CheckedChanged);
            // 
            // cbchon
            // 
            this.cbchon.Enabled = false;
            this.cbchon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbchon.FormattingEnabled = true;
            this.cbchon.Location = new System.Drawing.Point(618, 79);
            this.cbchon.Name = "cbchon";
            this.cbchon.Size = new System.Drawing.Size(227, 27);
            this.cbchon.TabIndex = 23;
            // 
            // crtInhd
            // 
            this.crtInhd.ActiveViewIndex = -1;
            this.crtInhd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.crtInhd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtInhd.Location = new System.Drawing.Point(-6, 174);
            this.crtInhd.Name = "crtInhd";
            this.crtInhd.SelectionFormula = "";
            this.crtInhd.Size = new System.Drawing.Size(1038, 471);
            this.crtInhd.TabIndex = 22;
            this.crtInhd.ViewTimeSelectionFormula = "";
            // 
            // btThoat
            // 
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.Blue;
            this.btThoat.Image = global::QLKTXBIA.Properties.Resources.exit;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(683, 136);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(72, 31);
            this.btThoat.TabIndex = 29;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Image = global::QLKTXBIA.Properties.Resources.thanhtab;
            this.label2.Location = new System.Drawing.Point(538, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "IN ẤN HỢP ĐỒNG";
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
            this.pictureBox1.Size = new System.Drawing.Size(1026, 45);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // rdquahan
            // 
            this.rdquahan.AutoSize = true;
            this.rdquahan.BackColor = System.Drawing.Color.Transparent;
            this.rdquahan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdquahan.ForeColor = System.Drawing.Color.Blue;
            this.rdquahan.Location = new System.Drawing.Point(457, 103);
            this.rdquahan.Name = "rdquahan";
            this.rdquahan.Size = new System.Drawing.Size(293, 23);
            this.rdquahan.TabIndex = 34;
            this.rdquahan.TabStop = true;
            this.rdquahan.Text = "Danh sách sinh viên quá hạn thuê phòng";
            this.rdquahan.UseVisualStyleBackColor = false;
            this.rdquahan.CheckedChanged += new System.EventHandler(this.rdquahan_CheckedChanged);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 618);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1026, 22);
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
            // FrmInHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKTXBIA.Properties.Resources.nen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 640);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rdquahan);
            this.Controls.Add(this.rdtruong);
            this.Controls.Add(this.btIn);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.rdPhong);
            this.Controls.Add(this.rdInAll);
            this.Controls.Add(this.rdInma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbchon);
            this.Controls.Add(this.crtInhd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInHopDong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In ấn hợp đồng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInHopDong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdtruong;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.RadioButton rdPhong;
        private System.Windows.Forms.RadioButton rdInAll;
        private System.Windows.Forms.RadioButton rdInma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbchon;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crtInhd;
        private System.Windows.Forms.RadioButton rdquahan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtten;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel txtquyen;
    }
}