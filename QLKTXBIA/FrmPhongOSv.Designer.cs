namespace QLKTXBIA
{
    partial class FrmPhongOSv
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
            this.components = new System.ComponentModel.Container();
            this.txtTinhtrang = new System.Windows.Forms.TextBox();
            this.btHuy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btsua = new System.Windows.Forms.Button();
            this.cbmakhu = new System.Windows.Forms.ComboBox();
            this.btxoa = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.cbthoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSogiuong = new System.Windows.Forms.TextBox();
            this.txtsotang = new System.Windows.Forms.TextBox();
            this.lbgiuong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbmaphong = new System.Windows.Forms.ComboBox();
            this.txtsoquat = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtten = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtquyen = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTinhtrang
            // 
            this.txtTinhtrang.Location = new System.Drawing.Point(488, 113);
            this.txtTinhtrang.Name = "txtTinhtrang";
            this.txtTinhtrang.ReadOnly = true;
            this.txtTinhtrang.Size = new System.Drawing.Size(201, 29);
            this.txtTinhtrang.TabIndex = 4;
            this.txtTinhtrang.TextChanged += new System.EventHandler(this.txtTinhtrang_TextChanged);
            this.txtTinhtrang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTinhtrang_KeyPress);
            // 
            // btHuy
            // 
            this.btHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHuy.Enabled = false;
            this.btHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.ForeColor = System.Drawing.Color.Blue;
            this.btHuy.Image = global::QLKTXBIA.Properties.Resources.huy;
            this.btHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHuy.Location = new System.Drawing.Point(440, 262);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(95, 36);
            this.btHuy.TabIndex = 42;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.cbhuy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Số sinh viên :";
            // 
            // btsua
            // 
            this.btsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua.ForeColor = System.Drawing.Color.Blue;
            this.btsua.Image = global::QLKTXBIA.Properties.Resources.sua;
            this.btsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsua.Location = new System.Drawing.Point(299, 262);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(95, 36);
            this.btsua.TabIndex = 41;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // cbmakhu
            // 
            this.cbmakhu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmakhu.FormattingEnabled = true;
            this.cbmakhu.Location = new System.Drawing.Point(200, 73);
            this.cbmakhu.Name = "cbmakhu";
            this.cbmakhu.Size = new System.Drawing.Size(96, 29);
            this.cbmakhu.TabIndex = 2;
            this.cbmakhu.TextChanged += new System.EventHandler(this.cbmakhu_TextChanged);
            this.cbmakhu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbmakhu_MouseClick);
            // 
            // btxoa
            // 
            this.btxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btxoa.Enabled = false;
            this.btxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.ForeColor = System.Drawing.Color.Blue;
            this.btxoa.Image = global::QLKTXBIA.Properties.Resources.xoa;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(171, 262);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(95, 36);
            this.btxoa.TabIndex = 40;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btthem
            // 
            this.btthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btthem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem.ForeColor = System.Drawing.Color.Blue;
            this.btthem.Image = global::QLKTXBIA.Properties.Resources.them;
            this.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthem.Location = new System.Drawing.Point(35, 262);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(95, 36);
            this.btthem.TabIndex = 39;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // cbthoat
            // 
            this.cbthoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbthoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbthoat.ForeColor = System.Drawing.Color.Blue;
            this.cbthoat.Image = global::QLKTXBIA.Properties.Resources.exit;
            this.cbthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbthoat.Location = new System.Drawing.Point(581, 262);
            this.cbthoat.Name = "cbthoat";
            this.cbthoat.Size = new System.Drawing.Size(95, 36);
            this.cbthoat.TabIndex = 43;
            this.cbthoat.Text = "Thoát";
            this.cbthoat.UseVisualStyleBackColor = true;
            this.cbthoat.Click += new System.EventHandler(this.cbthoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Image = global::QLKTXBIA.Properties.Resources.thanhtab;
            this.label1.Location = new System.Drawing.Point(201, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 27);
            this.label1.TabIndex = 46;
            this.label1.Text = "QUẢN LÝ PHÒNG Ở SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txttang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSogiuong);
            this.groupBox1.Controls.Add(this.txtsotang);
            this.groupBox1.Controls.Add(this.lbgiuong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTinhtrang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbmakhu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbmaphong);
            this.groupBox1.Controls.Add(this.txtsoquat);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 178);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // txttang
            // 
            this.txttang.Location = new System.Drawing.Point(200, 105);
            this.txttang.Name = "txttang";
            this.txttang.ReadOnly = true;
            this.txttang.Size = new System.Drawing.Size(96, 29);
            this.txttang.TabIndex = 27;
            this.toolTip1.SetToolTip(this.txttang, "Số tầng");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 26;
            this.label5.Text = "Số Tầng:";
            // 
            // txtSogiuong
            // 
            this.txtSogiuong.Location = new System.Drawing.Point(488, 27);
            this.txtSogiuong.Name = "txtSogiuong";
            this.txtSogiuong.Size = new System.Drawing.Size(201, 29);
            this.txtSogiuong.TabIndex = 25;
            this.toolTip1.SetToolTip(this.txtSogiuong, "Chỉ nhập số");
            this.txtSogiuong.TextChanged += new System.EventHandler(this.txtSogiuong_TextChanged);
            this.txtSogiuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSogiuong_KeyPress);
            // 
            // txtsotang
            // 
            this.txtsotang.Location = new System.Drawing.Point(200, 143);
            this.txtsotang.Name = "txtsotang";
            this.txtsotang.Size = new System.Drawing.Size(96, 29);
            this.txtsotang.TabIndex = 24;
            this.toolTip1.SetToolTip(this.txtsotang, "Phòng ở tầng số mấy");
            this.txtsotang.TextChanged += new System.EventHandler(this.txtsotang_TextChanged);
            this.txtsotang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsotang_KeyPress);
            // 
            // lbgiuong
            // 
            this.lbgiuong.AutoSize = true;
            this.lbgiuong.Location = new System.Drawing.Point(324, 35);
            this.lbgiuong.Name = "lbgiuong";
            this.lbgiuong.Size = new System.Drawing.Size(96, 21);
            this.lbgiuong.TabIndex = 23;
            this.lbgiuong.Text = "Số giường :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ở Tầng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã khu :";
            // 
            // cbmaphong
            // 
            this.cbmaphong.FormattingEnabled = true;
            this.cbmaphong.Location = new System.Drawing.Point(200, 32);
            this.cbmaphong.Name = "cbmaphong";
            this.cbmaphong.Size = new System.Drawing.Size(96, 29);
            this.cbmaphong.TabIndex = 1;
            this.cbmaphong.TextChanged += new System.EventHandler(this.cbmaphong_TextChanged);
            this.cbmaphong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbmaphong_MouseClick);
            // 
            // txtsoquat
            // 
            this.txtsoquat.Location = new System.Drawing.Point(488, 73);
            this.txtsoquat.Name = "txtsoquat";
            this.txtsoquat.Size = new System.Drawing.Size(201, 29);
            this.txtsoquat.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtsoquat, "Chỉ nhập số");
            this.txtsoquat.TextChanged += new System.EventHandler(this.txtsoquat_TextChanged);
            this.txtsoquat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoquat_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(78, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Mã phòng :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(324, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Số quạt :";
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToOrderColumns = true;
            this.dgvPhong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(23, 32);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.Size = new System.Drawing.Size(641, 135);
            this.dgvPhong.TabIndex = 11;
            this.dgvPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvPhong);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(12, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 186);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Phòng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::QLKTXBIA.Properties.Resources.thanhtab;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(729, 49);
            this.pictureBox1.TabIndex = 45;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(729, 22);
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
            // FrmPhongOSv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKTXBIA.Properties.Resources.nen;
            this.ClientSize = new System.Drawing.Size(729, 531);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.cbthoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPhongOSv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng ở sinh viên";
            this.Load += new System.EventHandler(this.FrmPhongOSv_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTinhtrang;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.ComboBox cbmakhu;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button cbthoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbmaphong;
        private System.Windows.Forms.TextBox txtsoquat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbgiuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSogiuong;
        private System.Windows.Forms.TextBox txtsotang;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtten;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel txtquyen;
        private System.Windows.Forms.TextBox txttang;
        private System.Windows.Forms.Label label5;
    }
}