namespace QLKTXBIA
{
    partial class FrmChuyenPhong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGioitinh = new System.Windows.Forms.ComboBox();
            this.txtSosv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttangso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btaddphong = new System.Windows.Forms.Button();
            this.dtngaychuyen = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPhongchuyenden = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtchuyenphong = new System.Windows.Forms.TextBox();
            this.txtphongdango = new System.Windows.Forms.TextBox();
            this.cbmasv = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTensv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbchuyenphong = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDssv = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtten = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtquyen = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDssv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtGioitinh);
            this.groupBox1.Controls.Add(this.txtSosv);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txttangso);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btaddphong);
            this.groupBox1.Controls.Add(this.dtngaychuyen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbPhongchuyenden);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtchuyenphong);
            this.groupBox1.Controls.Add(this.txtphongdango);
            this.groupBox1.Controls.Add(this.cbmasv);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTensv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(0, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(814, 235);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGioitinh.FormattingEnabled = true;
            this.txtGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txtGioitinh.Location = new System.Drawing.Point(176, 157);
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.Size = new System.Drawing.Size(121, 29);
            this.txtGioitinh.TabIndex = 35;
            // 
            // txtSosv
            // 
            this.txtSosv.Location = new System.Drawing.Point(737, 121);
            this.txtSosv.Name = "txtSosv";
            this.txtSosv.ReadOnly = true;
            this.txtSosv.Size = new System.Drawing.Size(33, 29);
            this.txtSosv.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(621, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 21);
            this.label9.TabIndex = 33;
            this.label9.Text = "Số sinh viên :";
            // 
            // txttangso
            // 
            this.txttangso.Location = new System.Drawing.Point(572, 121);
            this.txttangso.Name = "txttangso";
            this.txttangso.ReadOnly = true;
            this.txttangso.Size = new System.Drawing.Size(34, 29);
            this.txttangso.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tầng Số :";
            // 
            // btaddphong
            // 
            this.btaddphong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btaddphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btaddphong.ForeColor = System.Drawing.Color.Blue;
            this.btaddphong.Image = global::QLKTXBIA.Properties.Resources.edit_add;
            this.btaddphong.Location = new System.Drawing.Point(737, 85);
            this.btaddphong.Name = "btaddphong";
            this.btaddphong.Size = new System.Drawing.Size(31, 29);
            this.btaddphong.TabIndex = 30;
            this.toolTip1.SetToolTip(this.btaddphong, "Nhấn thêm để cập nhật Phòng");
            this.btaddphong.UseVisualStyleBackColor = true;
            this.btaddphong.Click += new System.EventHandler(this.btaddphong_Click);
            // 
            // dtngaychuyen
            // 
            this.dtngaychuyen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtngaychuyen.Location = new System.Drawing.Point(572, 165);
            this.dtngaychuyen.Name = "dtngaychuyen";
            this.dtngaychuyen.Size = new System.Drawing.Size(200, 29);
            this.dtngaychuyen.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Ngày Chuyển :";
            // 
            // cbPhongchuyenden
            // 
            this.cbPhongchuyenden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhongchuyenden.FormattingEnabled = true;
            this.cbPhongchuyenden.Location = new System.Drawing.Point(572, 86);
            this.cbPhongchuyenden.Name = "cbPhongchuyenden";
            this.cbPhongchuyenden.Size = new System.Drawing.Size(159, 29);
            this.cbPhongchuyenden.TabIndex = 27;
            this.cbPhongchuyenden.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbPhongchuyenden_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Phòng chuyển đến:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 21);
            this.label8.TabIndex = 25;
            this.label8.Text = "Mã Chuyển phòng:";
            // 
            // txtchuyenphong
            // 
            this.txtchuyenphong.Location = new System.Drawing.Point(176, 37);
            this.txtchuyenphong.Name = "txtchuyenphong";
            this.txtchuyenphong.ReadOnly = true;
            this.txtchuyenphong.Size = new System.Drawing.Size(212, 29);
            this.txtchuyenphong.TabIndex = 24;
            // 
            // txtphongdango
            // 
            this.txtphongdango.Location = new System.Drawing.Point(572, 40);
            this.txtphongdango.Name = "txtphongdango";
            this.txtphongdango.ReadOnly = true;
            this.txtphongdango.Size = new System.Drawing.Size(159, 29);
            this.txtphongdango.TabIndex = 23;
            // 
            // cbmasv
            // 
            this.cbmasv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmasv.FormattingEnabled = true;
            this.cbmasv.Location = new System.Drawing.Point(176, 75);
            this.cbmasv.Name = "cbmasv";
            this.cbmasv.Size = new System.Drawing.Size(121, 29);
            this.cbmasv.TabIndex = 1;
            this.cbmasv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbmasv_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(407, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Phòng đang ở:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giới tính";
            // 
            // txtTensv
            // 
            this.txtTensv.Location = new System.Drawing.Point(177, 114);
            this.txtTensv.Name = "txtTensv";
            this.txtTensv.ReadOnly = true;
            this.txtTensv.Size = new System.Drawing.Size(212, 29);
            this.txtTensv.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên SV :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã SV:";
            // 
            // btThoat
            // 
            this.btThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.ForeColor = System.Drawing.Color.Blue;
            this.btThoat.Image = global::QLKTXBIA.Properties.Resources.exit;
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(411, 288);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(95, 34);
            this.btThoat.TabIndex = 40;
            this.btThoat.Text = "Thoát";
            this.toolTip1.SetToolTip(this.btThoat, "Thoát khỏi form QLSV");
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Image = global::QLKTXBIA.Properties.Resources.thanhtab;
            this.label1.Location = new System.Drawing.Point(272, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 26);
            this.label1.TabIndex = 37;
            this.label1.Text = "QUẢN LÝ CHUYỂN PHÒNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbchuyenphong
            // 
            this.cbchuyenphong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbchuyenphong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbchuyenphong.ForeColor = System.Drawing.Color.Blue;
            this.cbchuyenphong.Location = new System.Drawing.Point(258, 289);
            this.cbchuyenphong.Name = "cbchuyenphong";
            this.cbchuyenphong.Size = new System.Drawing.Size(90, 34);
            this.cbchuyenphong.TabIndex = 39;
            this.cbchuyenphong.Text = "Chuyển \r";
            this.toolTip1.SetToolTip(this.cbchuyenphong, "Chuyển phòng");
            this.cbchuyenphong.UseVisualStyleBackColor = true;
            this.cbchuyenphong.Click += new System.EventHandler(this.cbchuyenphong_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvDssv);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(0, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 204);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh dách sinh viên đang ở";
            // 
            // dgvDssv
            // 
            this.dgvDssv.AllowUserToOrderColumns = true;
            this.dgvDssv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDssv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDssv.Location = new System.Drawing.Point(12, 28);
            this.dgvDssv.Name = "dgvDssv";
            this.dgvDssv.ReadOnly = true;
            this.dgvDssv.Size = new System.Drawing.Size(774, 166);
            this.dgvDssv.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QLKTXBIA.Properties.Resources.thanhtab;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(820, 45);
            this.pictureBox1.TabIndex = 36;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 543);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(820, 22);
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
            // FrmChuyenPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLKTXBIA.Properties.Resources.nen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 565);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbchuyenphong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChuyenPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển Phòng";
            this.Load += new System.EventHandler(this.FrmChuyenPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDssv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtchuyenphong;
        private System.Windows.Forms.TextBox txtphongdango;
        private System.Windows.Forms.ComboBox cbmasv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTensv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cbchuyenphong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDssv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbPhongchuyenden;
        private System.Windows.Forms.DateTimePicker dtngaychuyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btaddphong;
        private System.Windows.Forms.TextBox txttangso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSosv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtten;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel txtquyen;
        private System.Windows.Forms.ComboBox txtGioitinh;
    }
}