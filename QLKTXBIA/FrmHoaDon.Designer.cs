namespace QLKTXBIA
{
    partial class FrmHoaDon
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
            this.btSua = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvDshd = new System.Windows.Forms.DataGridView();
            this.btXoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTiendien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.txtCSDC = new System.Windows.Forms.TextBox();
            this.btHuy = new System.Windows.Forms.Button();
            this.txtmaCTD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCSDD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpngayghi = new System.Windows.Forms.DateTimePicker();
            this.dtpngaylap = new System.Windows.Forms.DateTimePicker();
            this.txtsoSv = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txttiennuoc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbSoPhong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSohd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtten = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtquyen = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDshd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSua
            // 
            this.btSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.Blue;
            this.btSua.Image = global::QLKTXBIA.Properties.Resources.sua;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSua.Location = new System.Drawing.Point(386, 365);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(95, 37);
            this.btSua.TabIndex = 31;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
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
            this.pictureBox1.Size = new System.Drawing.Size(856, 43);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // dgvDshd
            // 
            this.dgvDshd.AllowUserToOrderColumns = true;
            this.dgvDshd.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDshd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDshd.Location = new System.Drawing.Point(10, 28);
            this.dgvDshd.Name = "dgvDshd";
            this.dgvDshd.ReadOnly = true;
            this.dgvDshd.Size = new System.Drawing.Size(781, 179);
            this.dgvDshd.TabIndex = 35;
            this.dgvDshd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDshd_CellContentClick);
            // 
            // btXoa
            // 
            this.btXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXoa.Enabled = false;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.Blue;
            this.btXoa.Image = global::QLKTXBIA.Properties.Resources.xoa;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(239, 365);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(95, 37);
            this.btXoa.TabIndex = 30;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvDshd);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(25, 413);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(817, 218);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn";
            // 
            // txtTiendien
            // 
            this.txtTiendien.Location = new System.Drawing.Point(550, 165);
            this.txtTiendien.Name = "txtTiendien";
            this.txtTiendien.Size = new System.Drawing.Size(198, 29);
            this.txtTiendien.TabIndex = 10;
            this.txtTiendien.TextChanged += new System.EventHandler(this.txtTiendien_TextChanged);
            this.txtTiendien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTiendien_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "Tiền điện/1kwh :\r\n";
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(550, 259);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(198, 29);
            this.txtTongTien.TabIndex = 12;
            // 
            // btThem
            // 
            this.btThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.Blue;
            this.btThem.Image = global::QLKTXBIA.Properties.Resources.them;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThem.Location = new System.Drawing.Point(95, 365);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(95, 37);
            this.btThem.TabIndex = 29;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtCSDC
            // 
            this.txtCSDC.Location = new System.Drawing.Point(153, 260);
            this.txtCSDC.Name = "txtCSDC";
            this.txtCSDC.Size = new System.Drawing.Size(198, 29);
            this.txtCSDC.TabIndex = 6;
            this.txtCSDC.TextChanged += new System.EventHandler(this.txtCSDC_TextChanged);
            this.txtCSDC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCSDC_KeyPress);
            // 
            // btHuy
            // 
            this.btHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHuy.Enabled = false;
            this.btHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHuy.ForeColor = System.Drawing.Color.Blue;
            this.btHuy.Image = global::QLKTXBIA.Properties.Resources.huy;
            this.btHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btHuy.Location = new System.Drawing.Point(535, 365);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(95, 37);
            this.btHuy.TabIndex = 32;
            this.btHuy.Text = "Hủy";
            this.toolTip1.SetToolTip(this.btHuy, "Xóa các text ở trên");
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // txtmaCTD
            // 
            this.txtmaCTD.Location = new System.Drawing.Point(153, 186);
            this.txtmaCTD.Name = "txtmaCTD";
            this.txtmaCTD.Size = new System.Drawing.Size(198, 29);
            this.txtmaCTD.TabIndex = 4;
            this.txtmaCTD.TextChanged += new System.EventHandler(this.txtmaCTD_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Chỉ số điện cuối :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ngày ghi chỉ số :";
            // 
            // txtCSDD
            // 
            this.txtCSDD.Location = new System.Drawing.Point(153, 221);
            this.txtCSDD.Name = "txtCSDD";
            this.txtCSDD.Size = new System.Drawing.Size(198, 29);
            this.txtCSDD.TabIndex = 5;
            this.txtCSDD.TextChanged += new System.EventHandler(this.txtCSDD_TextChanged);
            this.txtCSDD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCSDD_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã công tơ điện :";
            // 
            // btThoat
            // 
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.Blue;
            this.btThoat.Image = global::QLKTXBIA.Properties.Resources.exit;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(669, 365);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(95, 37);
            this.btThoat.TabIndex = 33;
            this.btThoat.Text = "Thoát";
            this.toolTip1.SetToolTip(this.btThoat, "Thoát khỏi Form Hóa đơn");
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chỉ số điện đầu :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(403, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Tổng tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày lập HD :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtpngayghi);
            this.groupBox1.Controls.Add(this.dtpngaylap);
            this.groupBox1.Controls.Add(this.txtsoSv);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txttiennuoc);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtTiendien);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.txtCSDC);
            this.groupBox1.Controls.Add(this.txtmaCTD);
            this.groupBox1.Controls.Add(this.cbSoPhong);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCSDD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbSohd);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(25, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 303);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // dtpngayghi
            // 
            this.dtpngayghi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngayghi.Location = new System.Drawing.Point(546, 216);
            this.dtpngayghi.Name = "dtpngayghi";
            this.dtpngayghi.Size = new System.Drawing.Size(200, 29);
            this.dtpngayghi.TabIndex = 31;
            this.dtpngayghi.Value = new System.DateTime(2013, 12, 4, 0, 0, 0, 0);
            // 
            // dtpngaylap
            // 
            this.dtpngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaylap.Location = new System.Drawing.Point(151, 140);
            this.dtpngaylap.Name = "dtpngaylap";
            this.dtpngaylap.Size = new System.Drawing.Size(200, 29);
            this.dtpngaylap.TabIndex = 30;
            this.dtpngaylap.Value = new System.DateTime(2013, 12, 4, 0, 0, 0, 0);
            // 
            // txtsoSv
            // 
            this.txtsoSv.Location = new System.Drawing.Point(550, 119);
            this.txtsoSv.Name = "txtsoSv";
            this.txtsoSv.ReadOnly = true;
            this.txtsoSv.Size = new System.Drawing.Size(198, 29);
            this.txtsoSv.TabIndex = 9;
            this.txtsoSv.TextChanged += new System.EventHandler(this.txtsoSv_TextChanged);
            this.txtsoSv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsoSv_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(403, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 21);
            this.label11.TabIndex = 29;
            this.label11.Text = "Số Lượng SV:";
            // 
            // txttiennuoc
            // 
            this.txttiennuoc.Location = new System.Drawing.Point(550, 80);
            this.txttiennuoc.Name = "txttiennuoc";
            this.txttiennuoc.Size = new System.Drawing.Size(198, 29);
            this.txttiennuoc.TabIndex = 8;
            this.txttiennuoc.TextChanged += new System.EventHandler(this.txttiennuoc_TextChanged);
            this.txttiennuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttiennuoc_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(403, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 21);
            this.label12.TabIndex = 27;
            this.label12.Text = "Tiền nước/tháng :";
            // 
            // cbSoPhong
            // 
            this.cbSoPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSoPhong.FormattingEnabled = true;
            this.cbSoPhong.Location = new System.Drawing.Point(153, 99);
            this.cbSoPhong.Name = "cbSoPhong";
            this.cbSoPhong.Size = new System.Drawing.Size(93, 29);
            this.cbSoPhong.TabIndex = 2;
            this.cbSoPhong.TextChanged += new System.EventHandler(this.cbSoPhong_TextChanged);
            this.cbSoPhong.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbSoPhong_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số phòng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số hóa đơn :";
            // 
            // cbSohd
            // 
            this.cbSohd.FormattingEnabled = true;
            this.cbSohd.Location = new System.Drawing.Point(153, 46);
            this.cbSohd.Name = "cbSohd";
            this.cbSohd.Size = new System.Drawing.Size(93, 29);
            this.cbSohd.TabIndex = 1;
            this.cbSohd.TextChanged += new System.EventHandler(this.cbSohd_TextChanged);
            this.cbSohd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbSohd_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Image = global::QLKTXBIA.Properties.Resources.thanhtab;
            this.label1.Location = new System.Drawing.Point(308, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 27);
            this.label1.TabIndex = 37;
            this.label1.Text = "QUẢN LÝ HÓA ĐƠN";
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 637);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(856, 22);
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
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKTXBIA.Properties.Resources.nen;
            this.ClientSize = new System.Drawing.Size(856, 659);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Hóa đơn";
            this.Load += new System.EventHandler(this.FrmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDshd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvDshd;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTiendien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtCSDC;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtmaCTD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCSDD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSoPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSohd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsoSv;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttiennuoc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpngaylap;
        private System.Windows.Forms.DateTimePicker dtpngayghi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtten;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel txtquyen;
    }
}