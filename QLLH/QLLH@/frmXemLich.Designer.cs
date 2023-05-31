namespace QLLH_
{
    partial class frmXemLich
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
            this.label8 = new System.Windows.Forms.Label();
            this.cbbLHP = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.dgvLH = new System.Windows.Forms.DataGridView();
            this.Lopdanhnghia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiethoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diachiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTenGiangVien = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLH)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(39, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Lớp Học Phần";
            // 
            // cbbLHP
            // 
            this.cbbLHP.BackColor = System.Drawing.Color.Transparent;
            this.cbbLHP.BorderRadius = 20;
            this.cbbLHP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLHP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLHP.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLHP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbLHP.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbLHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbLHP.ItemHeight = 30;
            this.cbbLHP.Location = new System.Drawing.Point(232, 175);
            this.cbbLHP.Name = "cbbLHP";
            this.cbbLHP.Size = new System.Drawing.Size(280, 36);
            this.cbbLHP.TabIndex = 31;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.Location = new System.Drawing.Point(575, 151);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(60, 60);
            this.btnTimKiem.TabIndex = 32;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvLH
            // 
            this.dgvLH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLH.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Lopdanhnghia,
            this.Monhoc,
            this.Tuan,
            this.Tenthu,
            this.Tiethoc,
            this.Tenphong,
            this.Diachiphong});
            this.dgvLH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLH.Location = new System.Drawing.Point(0, 230);
            this.dgvLH.Name = "dgvLH";
            this.dgvLH.RowHeadersWidth = 51;
            this.dgvLH.RowTemplate.Height = 24;
            this.dgvLH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLH.Size = new System.Drawing.Size(916, 371);
            this.dgvLH.TabIndex = 33;
            // 
            // Lopdanhnghia
            // 
            this.Lopdanhnghia.DataPropertyName = "Lopdanhnghia";
            this.Lopdanhnghia.HeaderText = "Tên Lớp";
            this.Lopdanhnghia.MinimumWidth = 6;
            this.Lopdanhnghia.Name = "Lopdanhnghia";
            // 
            // Monhoc
            // 
            this.Monhoc.DataPropertyName = "Monhoc";
            this.Monhoc.HeaderText = "Môn Học";
            this.Monhoc.MinimumWidth = 6;
            this.Monhoc.Name = "Monhoc";
            // 
            // Tuan
            // 
            this.Tuan.DataPropertyName = "Tuan";
            this.Tuan.HeaderText = "Tuần";
            this.Tuan.MinimumWidth = 6;
            this.Tuan.Name = "Tuan";
            // 
            // Tenthu
            // 
            this.Tenthu.DataPropertyName = "Tenthu";
            this.Tenthu.HeaderText = "Thứ";
            this.Tenthu.MinimumWidth = 6;
            this.Tenthu.Name = "Tenthu";
            // 
            // Tiethoc
            // 
            this.Tiethoc.DataPropertyName = "Tiethoc";
            this.Tiethoc.HeaderText = "Tiết học";
            this.Tiethoc.MinimumWidth = 6;
            this.Tiethoc.Name = "Tiethoc";
            // 
            // Tenphong
            // 
            this.Tenphong.DataPropertyName = "Tenphong";
            this.Tenphong.HeaderText = "Phòng";
            this.Tenphong.MinimumWidth = 6;
            this.Tenphong.Name = "Tenphong";
            // 
            // Diachiphong
            // 
            this.Diachiphong.DataPropertyName = "Diachiphong";
            this.Diachiphong.HeaderText = "Địa Chỉ Phòng";
            this.Diachiphong.MinimumWidth = 6;
            this.Diachiphong.Name = "Diachiphong";
            // 
            // lbTenGiangVien
            // 
            this.lbTenGiangVien.AutoSize = true;
            this.lbTenGiangVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenGiangVien.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTenGiangVien.Location = new System.Drawing.Point(227, 86);
            this.lbTenGiangVien.Name = "lbTenGiangVien";
            this.lbTenGiangVien.Size = new System.Drawing.Size(17, 25);
            this.lbTenGiangVien.TabIndex = 35;
            this.lbTenGiangVien.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(39, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "Giảng Viên:";
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
            this.button1.Location = new System.Drawing.Point(663, 151);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.button1.Size = new System.Drawing.Size(131, 60);
            this.button1.TabIndex = 36;
            this.button1.Text = "Reset";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.comboBox1.Location = new System.Drawing.Point(232, 128);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(280, 24);
            this.comboBox1.TabIndex = 37;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(39, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Năm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(360, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 32);
            this.label2.TabIndex = 34;
            this.label2.Text = "LỊCH THỰC HÀNH";
            // 
            // frmXemLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbTenGiangVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvLH);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.cbbLHP);
            this.Controls.Add(this.label8);
            this.Name = "frmXemLich";
            this.Text = "frmXemLich";
            this.Load += new System.EventHandler(this.frmXemLich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLHP;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private System.Windows.Forms.DataGridView dgvLH;
        private System.Windows.Forms.Label lbTenGiangVien;
        private System.Windows.Forms.Label label6;
        private FontAwesome.Sharp.IconButton button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lopdanhnghia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenthu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiethoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diachiphong;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}