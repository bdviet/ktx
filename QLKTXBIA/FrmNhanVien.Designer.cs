namespace QLKTXBIA
{
    partial class FrmNhanVien
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
            this.txttencv = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btaddphong = new System.Windows.Forms.Button();
            this.btaddkhu = new System.Windows.Forms.Button();
            this.btaddchucvu = new System.Windows.Forms.Button();
            this.txttenpban = new System.Windows.Forms.TextBox();
            this.cbmanv = new System.Windows.Forms.ComboBox();
            this.cbmaphongban = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbgioitinh = new System.Windows.Forms.ComboBox();
            this.cbmakhu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbmacv = new System.Windows.Forms.ComboBox();
            this.txtSodt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDsnv = new System.Windows.Forms.DataGridView();
            this.btThoat = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtten = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtquyen = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsnv)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txttencv
            // 
            this.txttencv.Location = new System.Drawing.Point(660, 93);
            this.txttencv.Name = "txttencv";
            this.txttencv.ReadOnly = true;
            this.txttencv.Size = new System.Drawing.Size(152, 29);
            this.txttencv.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btaddphong);
            this.groupBox1.Controls.Add(this.btaddkhu);
            this.groupBox1.Controls.Add(this.btaddchucvu);
            this.groupBox1.Controls.Add(this.txttenpban);
            this.groupBox1.Controls.Add(this.cbmanv);
            this.groupBox1.Controls.Add(this.cbmaphongban);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txttencv);
            this.groupBox1.Controls.Add(this.cbgioitinh);
            this.groupBox1.Controls.Add(this.cbmakhu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbmacv);
            this.groupBox1.Controls.Add(this.txtSodt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 233);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý nhân viên";
            // 
            // btaddphong
            // 
            this.btaddphong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btaddphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaddphong.ForeColor = System.Drawing.Color.Blue;
            this.btaddphong.Image = global::QLKTXBIA.Properties.Resources.edit_add;
            this.btaddphong.Location = new System.Drawing.Point(810, 181);
            this.btaddphong.Name = "btaddphong";
            this.btaddphong.Size = new System.Drawing.Size(31, 29);
            this.btaddphong.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btaddphong, "Nhấn thêm để cập nhật Phòng");
            this.btaddphong.UseVisualStyleBackColor = true;
            this.btaddphong.Click += new System.EventHandler(this.btaddphong_Click);
            // 
            // btaddkhu
            // 
            this.btaddkhu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btaddkhu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaddkhu.ForeColor = System.Drawing.Color.Blue;
            this.btaddkhu.Image = global::QLKTXBIA.Properties.Resources.edit_add;
            this.btaddkhu.Location = new System.Drawing.Point(662, 140);
            this.btaddkhu.Name = "btaddkhu";
            this.btaddkhu.Size = new System.Drawing.Size(31, 29);
            this.btaddkhu.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btaddkhu, "Nhấn thêm để cập nhật Phòng");
            this.btaddkhu.UseVisualStyleBackColor = true;
            this.btaddkhu.Click += new System.EventHandler(this.btaddkhu_Click);
            // 
            // btaddchucvu
            // 
            this.btaddchucvu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btaddchucvu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaddchucvu.ForeColor = System.Drawing.Color.Blue;
            this.btaddchucvu.Image = global::QLKTXBIA.Properties.Resources.edit_add;
            this.btaddchucvu.Location = new System.Drawing.Point(810, 92);
            this.btaddchucvu.Name = "btaddchucvu";
            this.btaddchucvu.Size = new System.Drawing.Size(31, 29);
            this.btaddchucvu.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btaddchucvu, "Nhấn thêm để cập nhật Phòng");
            this.btaddchucvu.UseVisualStyleBackColor = true;
            this.btaddchucvu.Click += new System.EventHandler(this.btaddchucvu_Click);
            // 
            // txttenpban
            // 
            this.txttenpban.Location = new System.Drawing.Point(660, 183);
            this.txttenpban.Name = "txttenpban";
            this.txttenpban.ReadOnly = true;
            this.txttenpban.Size = new System.Drawing.Size(152, 29);
            this.txttenpban.TabIndex = 24;
            // 
            // cbmanv
            // 
            this.cbmanv.FormattingEnabled = true;
            this.cbmanv.Location = new System.Drawing.Point(94, 52);
            this.cbmanv.Name = "cbmanv";
            this.cbmanv.Size = new System.Drawing.Size(93, 29);
            this.cbmanv.TabIndex = 1;
            this.cbmanv.TextChanged += new System.EventHandler(this.cbmanv_TextChanged);
            this.cbmanv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbmanv_MouseClick);
            // 
            // cbmaphongban
            // 
            this.cbmaphongban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmaphongban.FormattingEnabled = true;
            this.cbmaphongban.Location = new System.Drawing.Point(563, 184);
            this.cbmaphongban.Name = "cbmaphongban";
            this.cbmaphongban.Size = new System.Drawing.Size(93, 29);
            this.cbmaphongban.TabIndex = 10;
            this.cbmaphongban.TextChanged += new System.EventHandler(this.cbmaphongban_TextChanged);
            this.cbmaphongban.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbmaphongban_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mã Phòng ban :";
            // 
            // cbgioitinh
            // 
            this.cbgioitinh.FormattingEnabled = true;
            this.cbgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbgioitinh.Location = new System.Drawing.Point(94, 141);
            this.cbgioitinh.Name = "cbgioitinh";
            this.cbgioitinh.Size = new System.Drawing.Size(93, 29);
            this.cbgioitinh.TabIndex = 4;
            this.cbgioitinh.TextChanged += new System.EventHandler(this.cbgioitinh_TextChanged);
            // 
            // cbmakhu
            // 
            this.cbmakhu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmakhu.FormattingEnabled = true;
            this.cbmakhu.Location = new System.Drawing.Point(563, 142);
            this.cbmakhu.Name = "cbmakhu";
            this.cbmakhu.Size = new System.Drawing.Size(93, 29);
            this.cbmakhu.TabIndex = 9;
            this.cbmakhu.TextChanged += new System.EventHandler(this.cbmakhu_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(429, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mã khu :";
            // 
            // cbmacv
            // 
            this.cbmacv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmacv.FormattingEnabled = true;
            this.cbmacv.Location = new System.Drawing.Point(563, 93);
            this.cbmacv.Name = "cbmacv";
            this.cbmacv.Size = new System.Drawing.Size(93, 29);
            this.cbmacv.TabIndex = 8;
            this.cbmacv.TextChanged += new System.EventHandler(this.cbmacv_TextChanged);
            this.cbmacv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbmacv_MouseClick);
            // 
            // txtSodt
            // 
            this.txtSodt.Location = new System.Drawing.Point(563, 49);
            this.txtSodt.Name = "txtSodt";
            this.txtSodt.Size = new System.Drawing.Size(249, 29);
            this.txtSodt.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtSodt, "Chỉ được phép nhập số");
            this.txtSodt.TextChanged += new System.EventHandler(this.txtSodt_TextChanged);
            this.txtSodt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSodt_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(429, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Mã chức vụ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(429, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Điện thoại :";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(94, 188);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(329, 29);
            this.txtDiachi.TabIndex = 5;
            this.txtDiachi.TextChanged += new System.EventHandler(this.txtDiachi_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Địa chỉ :";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(94, 97);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(329, 29);
            this.txtTenNV.TabIndex = 2;
            this.txtTenNV.TextChanged += new System.EventHandler(this.txtTenNV_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên NV :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã NV :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Image = global::QLKTXBIA.Properties.Resources.thanhtab;
            this.label1.Location = new System.Drawing.Point(279, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 27);
            this.label1.TabIndex = 27;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // dgvDsnv
            // 
            this.dgvDsnv.AllowUserToOrderColumns = true;
            this.dgvDsnv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDsnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsnv.Location = new System.Drawing.Point(19, 28);
            this.dgvDsnv.Name = "dgvDsnv";
            this.dgvDsnv.ReadOnly = true;
            this.dgvDsnv.Size = new System.Drawing.Size(781, 179);
            this.dgvDsnv.TabIndex = 25;
            this.dgvDsnv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsnv_CellContentClick);
            // 
            // btThoat
            // 
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.Blue;
            this.btThoat.Image = global::QLKTXBIA.Properties.Resources.exit;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(656, 318);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(95, 37);
            this.btThoat.TabIndex = 24;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btHuy
            // 
            this.btHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHuy.Enabled = false;
            this.btHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.ForeColor = System.Drawing.Color.Blue;
            this.btHuy.Image = global::QLKTXBIA.Properties.Resources.huy;
            this.btHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHuy.Location = new System.Drawing.Point(522, 318);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(95, 37);
            this.btHuy.TabIndex = 23;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvDsnv);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(12, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(817, 229);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh dách nhân viên";
            // 
            // btSua
            // 
            this.btSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.Blue;
            this.btSua.Image = global::QLKTXBIA.Properties.Resources.sua;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(373, 318);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(95, 37);
            this.btSua.TabIndex = 22;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.Blue;
            this.btThem.Image = global::QLKTXBIA.Properties.Resources.them;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(82, 313);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(95, 37);
            this.btThem.TabIndex = 20;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXoa.Enabled = false;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.Blue;
            this.btXoa.Image = global::QLKTXBIA.Properties.Resources.xoa;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(226, 313);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(95, 37);
            this.btXoa.TabIndex = 21;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QLKTXBIA.Properties.Resources.thanhtab;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(871, 48);
            this.pictureBox1.TabIndex = 26;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 601);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(871, 22);
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
            // FrmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKTXBIA.Properties.Resources.nen;
            this.ClientSize = new System.Drawing.Size(871, 623);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsnv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttencv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbgioitinh;
        private System.Windows.Forms.ComboBox cbmakhu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbmacv;
        private System.Windows.Forms.TextBox txtSodt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDsnv;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbmanv;
        private System.Windows.Forms.ComboBox cbmaphongban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttenpban;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btaddkhu;
        private System.Windows.Forms.Button btaddchucvu;
        private System.Windows.Forms.Button btaddphong;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtten;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel txtquyen;
    }
}