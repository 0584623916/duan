namespace QLLH_
{
    partial class frmDangKyLich
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDangKy = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTenGiangVien = new System.Windows.Forms.Label();
            this.cbbMaHocPhan = new System.Windows.Forms.ComboBox();
            this.txtSLC = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new FontAwesome.Sharp.IconButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtTuKhoa = new Guna.UI2.WinForms.Guna2TextBox();
            this.button1 = new FontAwesome.Sharp.IconButton();
            this.button2 = new FontAwesome.Sharp.IconButton();
            this.btnChonLichHoc = new FontAwesome.Sharp.IconButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKy)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(7, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Học Phần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(80, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tuần";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(85, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Năm";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(10, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số Lượng Ca";
            this.label4.Visible = false;
            // 
            // dgvDangKy
            // 
            this.dgvDangKy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDangKy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDangKy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvDangKy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDangKy.Location = new System.Drawing.Point(0, 404);
            this.dgvDangKy.Name = "dgvDangKy";
            this.dgvDangKy.RowHeadersWidth = 51;
            this.dgvDangKy.RowTemplate.Height = 24;
            this.dgvDangKy.Size = new System.Drawing.Size(978, 292);
            this.dgvDangKy.TabIndex = 4;
            this.dgvDangKy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDangKy_MouseClick);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ID";
            this.Column5.HeaderText = "ID";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Malophocphan";
            this.Column1.HeaderText = "Mã Học Phần";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "HoTenGiangVien";
            this.Column6.HeaderText = "Tên Giảng Viên";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Tuan";
            this.Column2.HeaderText = "Tuần";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoluongCa";
            this.Column3.HeaderText = "Số Lượng Ca";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Nam";
            this.Column4.HeaderText = "Năm";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(48, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Giảng Viên:";
            // 
            // lbTenGiangVien
            // 
            this.lbTenGiangVien.AutoSize = true;
            this.lbTenGiangVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenGiangVien.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTenGiangVien.Location = new System.Drawing.Point(169, 63);
            this.lbTenGiangVien.Name = "lbTenGiangVien";
            this.lbTenGiangVien.Size = new System.Drawing.Size(17, 25);
            this.lbTenGiangVien.TabIndex = 7;
            this.lbTenGiangVien.Text = ".";
            // 
            // cbbMaHocPhan
            // 
            this.cbbMaHocPhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaHocPhan.FormattingEnabled = true;
            this.cbbMaHocPhan.Location = new System.Drawing.Point(163, 149);
            this.cbbMaHocPhan.Name = "cbbMaHocPhan";
            this.cbbMaHocPhan.Size = new System.Drawing.Size(317, 33);
            this.cbbMaHocPhan.TabIndex = 8;
            // 
            // txtSLC
            // 
            this.txtSLC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLC.Location = new System.Drawing.Point(163, 248);
            this.txtSLC.Name = "txtSLC";
            this.txtSLC.Size = new System.Drawing.Size(317, 30);
            this.txtSLC.TabIndex = 10;
            this.txtSLC.Text = "1";
            this.txtSLC.Visible = false;
            this.txtSLC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLC_KeyPress);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(163, 103);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(317, 30);
            this.txtID.TabIndex = 18;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(107, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "ID";
            // 
            // button3
            // 
            this.button3.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.button3.IconColor = System.Drawing.SystemColors.Highlight;
            this.button3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button3.Location = new System.Drawing.Point(24, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 19;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2GroupBox1.Controls.Add(this.txtTuKhoa);
            this.guna2GroupBox1.Controls.Add(this.button3);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(520, 131);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(431, 200);
            this.guna2GroupBox1.TabIndex = 20;
            this.guna2GroupBox1.Text = "Tìm kiếm";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtTuKhoa.BorderRadius = 20;
            this.txtTuKhoa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTuKhoa.DefaultText = "";
            this.txtTuKhoa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTuKhoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTuKhoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTuKhoa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTuKhoa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTuKhoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTuKhoa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTuKhoa.Location = new System.Drawing.Point(114, 101);
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.PasswordChar = '\0';
            this.txtTuKhoa.PlaceholderText = "";
            this.txtTuKhoa.SelectedText = "";
            this.txtTuKhoa.Size = new System.Drawing.Size(290, 36);
            this.txtTuKhoa.TabIndex = 39;
            this.txtTuKhoa.TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged_1);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.button1.IconColor = System.Drawing.SystemColors.Highlight;
            this.button1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button1.IconSize = 32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(520, 73);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.button1.Size = new System.Drawing.Size(123, 50);
            this.button1.TabIndex = 21;
            this.button1.Text = "Thêm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.button2.IconColor = System.Drawing.SystemColors.Highlight;
            this.button2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.button2.IconSize = 32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(675, 73);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.button2.Size = new System.Drawing.Size(123, 50);
            this.button2.TabIndex = 22;
            this.button2.Text = "Xóa";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnChonLichHoc
            // 
            this.btnChonLichHoc.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btnChonLichHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonLichHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonLichHoc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnChonLichHoc.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnChonLichHoc.IconColor = System.Drawing.SystemColors.Highlight;
            this.btnChonLichHoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChonLichHoc.IconSize = 32;
            this.btnChonLichHoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonLichHoc.Location = new System.Drawing.Point(193, 337);
            this.btnChonLichHoc.Name = "btnChonLichHoc";
            this.btnChonLichHoc.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnChonLichHoc.Size = new System.Drawing.Size(287, 50);
            this.btnChonLichHoc.TabIndex = 23;
            this.btnChonLichHoc.Text = "Chọn Lịch Học";
            this.btnChonLichHoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonLichHoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChonLichHoc.UseVisualStyleBackColor = true;
            this.btnChonLichHoc.Click += new System.EventHandler(this.btnChonLichHoc_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 205);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(317, 22);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.comboBox1.Location = new System.Drawing.Point(163, 297);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(317, 24);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.Text = "2023";
            this.comboBox1.Visible = false;
            // 
            // iconButton1
            // 
            this.iconButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.SystemColors.Highlight;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(520, 73);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(123, 50);
            this.iconButton1.TabIndex = 21;
            this.iconButton1.Text = "Thêm";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // iconButton2
            // 
            this.iconButton2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iconButton2.IconColor = System.Drawing.SystemColors.Highlight;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(675, 73);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton2.Size = new System.Drawing.Size(123, 50);
            this.iconButton2.TabIndex = 22;
            this.iconButton2.Text = "Xóa";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(398, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "ĐĂNG KÝ LỊCH ";
            // 
            // frmDangKyLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(978, 696);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnChonLichHoc);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSLC);
            this.Controls.Add(this.cbbMaHocPhan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTenGiangVien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvDangKy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDangKyLich";
            this.Text = "frmDangKyLich";
            this.Load += new System.EventHandler(this.frmDangKyLich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDangKy)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDangKy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTenGiangVien;
        private System.Windows.Forms.ComboBox cbbMaHocPhan;
        private System.Windows.Forms.TextBox txtSLC;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private FontAwesome.Sharp.IconButton button3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private FontAwesome.Sharp.IconButton button1;
        private FontAwesome.Sharp.IconButton button2;
        private Guna.UI2.WinForms.Guna2TextBox txtTuKhoa;
        private FontAwesome.Sharp.IconButton btnChonLichHoc;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label label5;
    }
}