namespace QLKTXBIA
{
    partial class FrmHopdong
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
            this.label1 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbmahd = new System.Windows.Forms.ComboBox();
            this.txttensv = new System.Windows.Forms.TextBox();
            this.dtpngaykt = new System.Windows.Forms.DateTimePicker();
            this.dtpngaybt = new System.Windows.Forms.DateTimePicker();
            this.dtpngaylap = new System.Windows.Forms.DateTimePicker();
            this.cbsophong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbmasv = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDshd = new System.Windows.Forms.DataGridView();
            this.btSua = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbgiahan = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtten = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtquyen = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDshd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Image = global::QLKTXBIA.Properties.Resources.thanhtab;
            this.label1.Location = new System.Drawing.Point(247, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 26);
            this.label1.TabIndex = 45;
            this.label1.Text = "QUẢN LÝ HỢP ĐỒNG";
            // 
            // btThoat
            // 
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.Blue;
            this.btThoat.Image = global::QLKTXBIA.Properties.Resources.exit;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(601, 318);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(95, 36);
            this.btThoat.TabIndex = 42;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbmahd);
            this.groupBox1.Controls.Add(this.txttensv);
            this.groupBox1.Controls.Add(this.dtpngaykt);
            this.groupBox1.Controls.Add(this.dtpngaybt);
            this.groupBox1.Controls.Add(this.dtpngaylap);
            this.groupBox1.Controls.Add(this.cbsophong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbmasv);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(21, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 251);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hợp đồng";
            // 
            // cbmahd
            // 
            this.cbmahd.BackColor = System.Drawing.SystemColors.Window;
            this.cbmahd.FormattingEnabled = true;
            this.cbmahd.Location = new System.Drawing.Point(132, 55);
            this.cbmahd.MaxLength = 10;
            this.cbmahd.Name = "cbmahd";
            this.cbmahd.Size = new System.Drawing.Size(115, 29);
            this.cbmahd.TabIndex = 1;
            this.cbmahd.TextChanged += new System.EventHandler(this.cbmahd_TextChanged);
            this.cbmahd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbmahd_MouseClick);
            // 
            // txttensv
            // 
            this.txttensv.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txttensv.Location = new System.Drawing.Point(134, 149);
            this.txttensv.Name = "txttensv";
            this.txttensv.ReadOnly = true;
            this.txttensv.Size = new System.Drawing.Size(179, 29);
            this.txttensv.TabIndex = 24;
            // 
            // dtpngaykt
            // 
            this.dtpngaykt.CustomFormat = "";
            this.dtpngaykt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaykt.Location = new System.Drawing.Point(475, 189);
            this.dtpngaykt.Name = "dtpngaykt";
            this.dtpngaykt.Size = new System.Drawing.Size(200, 29);
            this.dtpngaykt.TabIndex = 6;
            this.dtpngaykt.Value = new System.DateTime(2013, 11, 5, 8, 0, 0, 0);
            // 
            // dtpngaybt
            // 
            this.dtpngaybt.CustomFormat = "";
            this.dtpngaybt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaybt.Location = new System.Drawing.Point(475, 139);
            this.dtpngaybt.Name = "dtpngaybt";
            this.dtpngaybt.Size = new System.Drawing.Size(200, 29);
            this.dtpngaybt.TabIndex = 5;
            this.dtpngaybt.Value = new System.DateTime(2013, 11, 5, 8, 0, 0, 0);
            // 
            // dtpngaylap
            // 
            this.dtpngaylap.CustomFormat = "";
            this.dtpngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaylap.Location = new System.Drawing.Point(475, 93);
            this.dtpngaylap.Name = "dtpngaylap";
            this.dtpngaylap.Size = new System.Drawing.Size(200, 29);
            this.dtpngaylap.TabIndex = 4;
            this.dtpngaylap.Value = new System.DateTime(2013, 11, 5, 8, 0, 0, 0);
            // 
            // cbsophong
            // 
            this.cbsophong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsophong.Enabled = false;
            this.cbsophong.FormattingEnabled = true;
            this.cbsophong.Location = new System.Drawing.Point(133, 194);
            this.cbsophong.Name = "cbsophong";
            this.cbsophong.Size = new System.Drawing.Size(115, 29);
            this.cbsophong.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Số phòng :";
            // 
            // cbmasv
            // 
            this.cbmasv.BackColor = System.Drawing.SystemColors.Window;
            this.cbmasv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmasv.FormattingEnabled = true;
            this.cbmasv.Location = new System.Drawing.Point(133, 106);
            this.cbmasv.Name = "cbmasv";
            this.cbmasv.Size = new System.Drawing.Size(115, 29);
            this.cbmasv.TabIndex = 2;
            this.cbmasv.TextChanged += new System.EventHandler(this.cbmasv_TextChanged);
            this.cbmasv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbmasv_MouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(345, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ngày kết thúc :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày bắt đầu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày lập HD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sinh viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hợp đồng :";
            // 
            // btThem
            // 
            this.btThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.Blue;
            this.btThem.Image = global::QLKTXBIA.Properties.Resources.them;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(37, 318);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(95, 36);
            this.btThem.TabIndex = 39;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvDshd);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(21, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 241);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hợp đồng";
            // 
            // dgvDshd
            // 
            this.dgvDshd.AllowUserToOrderColumns = true;
            this.dgvDshd.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDshd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDshd.Location = new System.Drawing.Point(19, 30);
            this.dgvDshd.Name = "dgvDshd";
            this.dgvDshd.ReadOnly = true;
            this.dgvDshd.Size = new System.Drawing.Size(666, 193);
            this.dgvDshd.TabIndex = 12;
            this.dgvDshd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDshd_CellContentClick);
            // 
            // btSua
            // 
            this.btSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.Blue;
            this.btSua.Image = global::QLKTXBIA.Properties.Resources.xoa;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(188, 318);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(95, 36);
            this.btSua.TabIndex = 40;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btHuy
            // 
            this.btHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHuy.Enabled = false;
            this.btHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.ForeColor = System.Drawing.Color.Blue;
            this.btHuy.Image = global::QLKTXBIA.Properties.Resources.sua;
            this.btHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHuy.Location = new System.Drawing.Point(338, 318);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(95, 36);
            this.btHuy.TabIndex = 41;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QLKTXBIA.Properties.Resources.thanhtab;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(744, 53);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // tbgiahan
            // 
            this.tbgiahan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbgiahan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgiahan.ForeColor = System.Drawing.Color.Blue;
            this.tbgiahan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbgiahan.Location = new System.Drawing.Point(478, 318);
            this.tbgiahan.Name = "tbgiahan";
            this.tbgiahan.Size = new System.Drawing.Size(95, 36);
            this.tbgiahan.TabIndex = 46;
            this.tbgiahan.Text = "Gia Hạn";
            this.tbgiahan.UseVisualStyleBackColor = true;
            this.tbgiahan.Click += new System.EventHandler(this.tbgiahan_Click);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 616);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(744, 22);
            this.statusStrip1.TabIndex = 67;
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
            // FrmHopdong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKTXBIA.Properties.Resources.nen;
            this.ClientSize = new System.Drawing.Size(744, 638);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbgiahan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btHuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHopdong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hợp đồng";
            this.Load += new System.EventHandler(this.FrmHopdong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDshd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttensv;
        private System.Windows.Forms.DateTimePicker dtpngaykt;
        private System.Windows.Forms.DateTimePicker dtpngaybt;
        private System.Windows.Forms.DateTimePicker dtpngaylap;
        private System.Windows.Forms.ComboBox cbsophong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbmasv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDshd;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.ComboBox cbmahd;
        private System.Windows.Forms.Button tbgiahan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtten;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel txtquyen;
    }
}