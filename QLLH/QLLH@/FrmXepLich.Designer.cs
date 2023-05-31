namespace QLLH_
{
    partial class FrmXepLich
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXepLich = new FontAwesome.Sharp.IconButton();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvXL = new System.Windows.Forms.DataGridView();
            this.Malophocphan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenGiangVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monhoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Macahoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKiemTra = new FontAwesome.Sharp.IconButton();
            this.btnXepLichLai = new FontAwesome.Sharp.IconButton();
            this.btnReset = new FontAwesome.Sharp.IconButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnInLich = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXL)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(46, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tuần";
            // 
            // btnXepLich
            // 
            this.btnXepLich.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btnXepLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXepLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXepLich.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnXepLich.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnXepLich.IconColor = System.Drawing.SystemColors.Highlight;
            this.btnXepLich.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXepLich.IconSize = 32;
            this.btnXepLich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXepLich.Location = new System.Drawing.Point(659, 87);
            this.btnXepLich.Name = "btnXepLich";
            this.btnXepLich.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnXepLich.Size = new System.Drawing.Size(151, 46);
            this.btnXepLich.TabIndex = 38;
            this.btnXepLich.Text = "Xếp Lịch";
            this.btnXepLich.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXepLich.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXepLich.UseVisualStyleBackColor = true;
            this.btnXepLich.Click += new System.EventHandler(this.btnXepLich_Click);
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 4;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(541, 233);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(240, 150);
            this.guna2DataGridView1.TabIndex = 39;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dgvXL
            // 
            this.dgvXL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXL.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvXL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Malophocphan,
            this.HoTenGiangVien,
            this.Monhoc,
            this.Macahoc,
            this.Column1,
            this.Ngay,
            this.Maphong,
            this.Column2});
            this.dgvXL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvXL.Location = new System.Drawing.Point(0, 220);
            this.dgvXL.Name = "dgvXL";
            this.dgvXL.RowHeadersWidth = 51;
            this.dgvXL.RowTemplate.Height = 24;
            this.dgvXL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXL.Size = new System.Drawing.Size(1018, 398);
            this.dgvXL.TabIndex = 40;
            // 
            // Malophocphan
            // 
            this.Malophocphan.DataPropertyName = "Lopdanhnghia";
            this.Malophocphan.HeaderText = "Tên Lớp";
            this.Malophocphan.MinimumWidth = 6;
            this.Malophocphan.Name = "Malophocphan";
            // 
            // HoTenGiangVien
            // 
            this.HoTenGiangVien.DataPropertyName = "HoTenGiangVien";
            this.HoTenGiangVien.HeaderText = "Giảng Viên";
            this.HoTenGiangVien.MinimumWidth = 6;
            this.HoTenGiangVien.Name = "HoTenGiangVien";
            // 
            // Monhoc
            // 
            this.Monhoc.DataPropertyName = "Monhoc";
            this.Monhoc.HeaderText = "Môn Học";
            this.Monhoc.MinimumWidth = 6;
            this.Monhoc.Name = "Monhoc";
            // 
            // Macahoc
            // 
            this.Macahoc.DataPropertyName = "Tenthu";
            this.Macahoc.HeaderText = "Thứ";
            this.Macahoc.MinimumWidth = 6;
            this.Macahoc.Name = "Macahoc";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Tiethoc";
            this.Column1.HeaderText = "Tiết";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            // 
            // Maphong
            // 
            this.Maphong.DataPropertyName = "Tenphong";
            this.Maphong.HeaderText = "Tên Phòng";
            this.Maphong.MinimumWidth = 6;
            this.Maphong.Name = "Maphong";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Diachiphong";
            this.Column2.HeaderText = "Địa Chỉ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btnKiemTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiemTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKiemTra.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnKiemTra.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnKiemTra.IconColor = System.Drawing.SystemColors.Highlight;
            this.btnKiemTra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKiemTra.IconSize = 32;
            this.btnKiemTra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKiemTra.Location = new System.Drawing.Point(502, 89);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnKiemTra.Size = new System.Drawing.Size(151, 46);
            this.btnKiemTra.TabIndex = 41;
            this.btnKiemTra.Text = "Kiểm Tra";
            this.btnKiemTra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKiemTra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // btnXepLichLai
            // 
            this.btnXepLichLai.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btnXepLichLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXepLichLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXepLichLai.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnXepLichLai.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnXepLichLai.IconColor = System.Drawing.SystemColors.Highlight;
            this.btnXepLichLai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXepLichLai.IconSize = 32;
            this.btnXepLichLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXepLichLai.Location = new System.Drawing.Point(659, 86);
            this.btnXepLichLai.Name = "btnXepLichLai";
            this.btnXepLichLai.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnXepLichLai.Size = new System.Drawing.Size(184, 49);
            this.btnXepLichLai.TabIndex = 42;
            this.btnXepLichLai.Text = "Xếp Lại Lịch";
            this.btnXepLichLai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXepLichLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXepLichLai.UseVisualStyleBackColor = true;
            this.btnXepLichLai.Click += new System.EventHandler(this.btnXepLichLai_Click);
            // 
            // btnReset
            // 
            this.btnReset.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnReset.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnReset.IconColor = System.Drawing.SystemColors.Highlight;
            this.btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReset.IconSize = 32;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(502, 155);
            this.btnReset.Name = "btnReset";
            this.btnReset.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnReset.Size = new System.Drawing.Size(126, 46);
            this.btnReset.TabIndex = 43;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(164, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(276, 22);
            this.dateTimePicker1.TabIndex = 44;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnInLich
            // 
            this.btnInLich.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btnInLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInLich.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnInLich.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnInLich.IconColor = System.Drawing.SystemColors.Highlight;
            this.btnInLich.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInLich.IconSize = 32;
            this.btnInLich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInLich.Location = new System.Drawing.Point(659, 155);
            this.btnInLich.Name = "btnInLich";
            this.btnInLich.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnInLich.Size = new System.Drawing.Size(151, 46);
            this.btnInLich.TabIndex = 45;
            this.btnInLich.Text = "In Lịch";
            this.btnInLich.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInLich.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInLich.UseVisualStyleBackColor = true;
            this.btnInLich.Click += new System.EventHandler(this.btnInLich_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(446, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 35;
            this.label2.Text = "XẾP LỊCH";
            // 
            // FrmXepLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 618);
            this.Controls.Add(this.btnInLich);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnXepLichLai);
            this.Controls.Add(this.btnKiemTra);
            this.Controls.Add(this.dgvXL);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.btnXepLich);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmXepLich";
            this.Text = "FrmXepLich";
            this.Load += new System.EventHandler(this.FrmXepLich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnXepLich;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridView dgvXL;
        private FontAwesome.Sharp.IconButton btnKiemTra;
        private FontAwesome.Sharp.IconButton btnXepLichLai;
        private FontAwesome.Sharp.IconButton btnReset;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconButton btnInLich;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malophocphan;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenGiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monhoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Macahoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label2;
    }
}