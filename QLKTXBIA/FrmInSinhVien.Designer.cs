namespace QLKTXBIA
{
    partial class FrmInSinhVien
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
            this.btThoat = new System.Windows.Forms.Button();
            this.rdPhong = new System.Windows.Forms.RadioButton();
            this.rdInAll = new System.Windows.Forms.RadioButton();
            this.rdInma = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbchon = new System.Windows.Forms.ComboBox();
            this.crtInsv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rdtruong = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtten = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtquyen = new System.Windows.Forms.ToolStripStatusLabel();
            this.btIn = new System.Windows.Forms.Button();
            this.rdinAllthe = new System.Windows.Forms.RadioButton();
            this.rdthePhong = new System.Windows.Forms.RadioButton();
            this.rdchuyen = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btThoat
            // 
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.Blue;
            this.btThoat.Image = global::QLKTXBIA.Properties.Resources.exit;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(686, 140);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(72, 31);
            this.btThoat.TabIndex = 19;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // rdPhong
            // 
            this.rdPhong.AutoSize = true;
            this.rdPhong.BackColor = System.Drawing.Color.Transparent;
            this.rdPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPhong.ForeColor = System.Drawing.Color.Blue;
            this.rdPhong.Location = new System.Drawing.Point(621, 58);
            this.rdPhong.Name = "rdPhong";
            this.rdPhong.Size = new System.Drawing.Size(123, 23);
            this.rdPhong.TabIndex = 18;
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
            this.rdInAll.Location = new System.Drawing.Point(460, 116);
            this.rdInAll.Name = "rdInAll";
            this.rdInAll.Size = new System.Drawing.Size(145, 23);
            this.rdInAll.TabIndex = 17;
            this.rdInAll.TabStop = true;
            this.rdInAll.Text = "In tất cả sinh viên";
            this.rdInAll.UseVisualStyleBackColor = false;
            this.rdInAll.CheckedChanged += new System.EventHandler(this.rdInAll_CheckedChanged);
            // 
            // rdInma
            // 
            this.rdInma.AutoSize = true;
            this.rdInma.BackColor = System.Drawing.Color.Transparent;
            this.rdInma.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdInma.ForeColor = System.Drawing.Color.Blue;
            this.rdInma.Location = new System.Drawing.Point(460, 58);
            this.rdInma.Name = "rdInma";
            this.rdInma.Size = new System.Drawing.Size(98, 23);
            this.rdInma.TabIndex = 16;
            this.rdInma.TabStop = true;
            this.rdInma.Text = "In theo mã";
            this.rdInma.UseVisualStyleBackColor = false;
            this.rdInma.CheckedChanged += new System.EventHandler(this.rdInma_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Image = global::QLKTXBIA.Properties.Resources.thanhtab;
            this.label2.Location = new System.Drawing.Point(541, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "IN ẤN SINH VIÊN";
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
            this.pictureBox1.Size = new System.Drawing.Size(1032, 45);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // cbchon
            // 
            this.cbchon.Enabled = false;
            this.cbchon.FormattingEnabled = true;
            this.cbchon.Location = new System.Drawing.Point(621, 116);
            this.cbchon.Name = "cbchon";
            this.cbchon.Size = new System.Drawing.Size(146, 21);
            this.cbchon.TabIndex = 13;
            // 
            // crtInsv
            // 
            this.crtInsv.ActiveViewIndex = -1;
            this.crtInsv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.crtInsv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtInsv.Location = new System.Drawing.Point(-3, 178);
            this.crtInsv.Name = "crtInsv";
            this.crtInsv.SelectionFormula = "";
            this.crtInsv.Size = new System.Drawing.Size(1038, 471);
            this.crtInsv.TabIndex = 12;
            this.crtInsv.ViewTimeSelectionFormula = "";
            // 
            // rdtruong
            // 
            this.rdtruong.AutoSize = true;
            this.rdtruong.BackColor = System.Drawing.Color.Transparent;
            this.rdtruong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdtruong.ForeColor = System.Drawing.Color.Blue;
            this.rdtruong.Location = new System.Drawing.Point(762, 58);
            this.rdtruong.Name = "rdtruong";
            this.rdtruong.Size = new System.Drawing.Size(128, 23);
            this.rdtruong.TabIndex = 21;
            this.rdtruong.TabStop = true;
            this.rdtruong.Text = "In theo Trường";
            this.rdtruong.UseVisualStyleBackColor = false;
            this.rdtruong.CheckedChanged += new System.EventHandler(this.rdtruong_CheckedChanged);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 624);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1032, 22);
            this.statusStrip1.TabIndex = 69;
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
            // btIn
            // 
            this.btIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIn.ForeColor = System.Drawing.Color.Blue;
            this.btIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btIn.Location = new System.Drawing.Point(578, 143);
            this.btIn.Margin = new System.Windows.Forms.Padding(4);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(69, 31);
            this.btIn.TabIndex = 71;
            this.btIn.Text = "In";
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // rdinAllthe
            // 
            this.rdinAllthe.AutoSize = true;
            this.rdinAllthe.BackColor = System.Drawing.Color.Transparent;
            this.rdinAllthe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdinAllthe.ForeColor = System.Drawing.Color.Blue;
            this.rdinAllthe.Location = new System.Drawing.Point(460, 87);
            this.rdinAllthe.Name = "rdinAllthe";
            this.rdinAllthe.Size = new System.Drawing.Size(154, 23);
            this.rdinAllthe.TabIndex = 72;
            this.rdinAllthe.TabStop = true;
            this.rdinAllthe.Text = "In tất cả thẻ nội trú";
            this.rdinAllthe.UseVisualStyleBackColor = false;
            this.rdinAllthe.CheckedChanged += new System.EventHandler(this.rdinAllthe_CheckedChanged);
            // 
            // rdthePhong
            // 
            this.rdthePhong.AutoSize = true;
            this.rdthePhong.BackColor = System.Drawing.Color.Transparent;
            this.rdthePhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdthePhong.ForeColor = System.Drawing.Color.Blue;
            this.rdthePhong.Location = new System.Drawing.Point(620, 87);
            this.rdthePhong.Name = "rdthePhong";
            this.rdthePhong.Size = new System.Drawing.Size(194, 23);
            this.rdthePhong.TabIndex = 73;
            this.rdthePhong.TabStop = true;
            this.rdthePhong.Text = "In  thẻ nội trú theo phòng";
            this.rdthePhong.UseVisualStyleBackColor = false;
            this.rdthePhong.CheckedChanged += new System.EventHandler(this.rdthePhong_CheckedChanged);
            // 
            // rdchuyen
            // 
            this.rdchuyen.AutoSize = true;
            this.rdchuyen.BackColor = System.Drawing.Color.Transparent;
            this.rdchuyen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdchuyen.ForeColor = System.Drawing.Color.Blue;
            this.rdchuyen.Location = new System.Drawing.Point(820, 87);
            this.rdchuyen.Name = "rdchuyen";
            this.rdchuyen.Size = new System.Drawing.Size(199, 23);
            this.rdchuyen.TabIndex = 74;
            this.rdchuyen.TabStop = true;
            this.rdchuyen.Text = "In sinh viên chuyển phòng";
            this.rdchuyen.UseVisualStyleBackColor = false;
            this.rdchuyen.CheckedChanged += new System.EventHandler(this.rdchuyen_CheckedChanged);
            // 
            // FrmInSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKTXBIA.Properties.Resources.nen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1032, 646);
            this.ControlBox = false;
            this.Controls.Add(this.rdchuyen);
            this.Controls.Add(this.rdthePhong);
            this.Controls.Add(this.rdinAllthe);
            this.Controls.Add(this.btIn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.rdtruong);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.rdPhong);
            this.Controls.Add(this.rdInAll);
            this.Controls.Add(this.rdInma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbchon);
            this.Controls.Add(this.crtInsv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInSinhVien";
            this.Text = "In sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.RadioButton rdPhong;
        private System.Windows.Forms.RadioButton rdInAll;
        private System.Windows.Forms.RadioButton rdInma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbchon;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crtInsv;
        private System.Windows.Forms.RadioButton rdtruong;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtten;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel txtquyen;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.RadioButton rdinAllthe;
        private System.Windows.Forms.RadioButton rdthePhong;
        private System.Windows.Forms.RadioButton rdchuyen;
    }
}