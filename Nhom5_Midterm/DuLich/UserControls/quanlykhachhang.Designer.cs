namespace DuLich.UserControls
{
    partial class quanlykhachhang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            panel1 = new Panel();
            kh_hienThiKH = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            txtSoDienThoai = new TextBox();
            txtTenKhachHang = new TextBox();
            groupBox1 = new GroupBox();
            xuatExcel = new Button();
            dskh_timKiem = new Button();
            luuKH = new Button();
            xoaKH = new Button();
            themKH = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kh_hienThiKH).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(350, 33);
            label1.Name = "label1";
            label1.Size = new Size(573, 50);
            label1.TabIndex = 1;
            label1.Text = "Quản Lý Danh Sách Khách Hàng";
            // 
            // panel1
            // 
            panel1.Controls.Add(kh_hienThiKH);
            panel1.Location = new Point(170, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 325);
            panel1.TabIndex = 2;
            // 
            // kh_hienThiKH
            // 
            kh_hienThiKH.AllowUserToAddRows = false;
            kh_hienThiKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            kh_hienThiKH.BackgroundColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            kh_hienThiKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            kh_hienThiKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kh_hienThiKH.EditMode = DataGridViewEditMode.EditOnEnter;
            kh_hienThiKH.Location = new Point(0, 0);
            kh_hienThiKH.Name = "kh_hienThiKH";
            kh_hienThiKH.RowHeadersWidth = 51;
            kh_hienThiKH.Size = new Size(920, 325);
            kh_hienThiKH.TabIndex = 0;
            kh_hienThiKH.CellContentClick += kh_hienThiKH_CellContentClick;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(170, 656);
            label3.Name = "label3";
            label3.Size = new Size(119, 27);
            label3.TabIndex = 5;
            label3.Text = "Tên Khách Hàng";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(688, 656);
            label4.Name = "label4";
            label4.Size = new Size(119, 29);
            label4.TabIndex = 6;
            label4.Text = "Số Điện Thoại";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(856, 656);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(234, 27);
            txtSoDienThoai.TabIndex = 8;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(318, 656);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(234, 27);
            txtTenKhachHang.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(xuatExcel);
            groupBox1.Controls.Add(dskh_timKiem);
            groupBox1.Controls.Add(luuKH);
            groupBox1.Controls.Add(xoaKH);
            groupBox1.Controls.Add(themKH);
            groupBox1.Location = new Point(170, 507);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(920, 90);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức Năng";
            // 
            // xuatExcel
            // 
            xuatExcel.BackColor = Color.SeaShell;
            xuatExcel.Location = new Point(759, 31);
            xuatExcel.Name = "xuatExcel";
            xuatExcel.Size = new Size(114, 29);
            xuatExcel.TabIndex = 5;
            xuatExcel.Text = "Xuất File Excel";
            xuatExcel.UseVisualStyleBackColor = false;
            xuatExcel.Click += xuatExcel_Click;
            // 
            // dskh_timKiem
            // 
            dskh_timKiem.BackColor = Color.SeaShell;
            dskh_timKiem.Location = new Point(586, 31);
            dskh_timKiem.Name = "dskh_timKiem";
            dskh_timKiem.Size = new Size(94, 29);
            dskh_timKiem.TabIndex = 4;
            dskh_timKiem.Text = "Tìm Kiếm";
            dskh_timKiem.UseVisualStyleBackColor = false;
            dskh_timKiem.Click += dskh_timKiem_Click;
            // 
            // luuKH
            // 
            luuKH.BackColor = Color.SeaShell;
            luuKH.Location = new Point(404, 31);
            luuKH.Name = "luuKH";
            luuKH.Size = new Size(94, 29);
            luuKH.TabIndex = 3;
            luuKH.Text = "Lưu";
            luuKH.UseVisualStyleBackColor = false;
            luuKH.Click += luuKH_Click;
            // 
            // xoaKH
            // 
            xoaKH.BackColor = Color.SeaShell;
            xoaKH.Location = new Point(231, 31);
            xoaKH.Name = "xoaKH";
            xoaKH.Size = new Size(94, 29);
            xoaKH.TabIndex = 1;
            xoaKH.Text = "Xóa";
            xoaKH.UseVisualStyleBackColor = false;
            xoaKH.Click += xoaKH_Click;
            // 
            // themKH
            // 
            themKH.BackColor = Color.SeaShell;
            themKH.Location = new Point(48, 31);
            themKH.Name = "themKH";
            themKH.Size = new Size(94, 29);
            themKH.TabIndex = 0;
            themKH.Text = "Thêm";
            themKH.UseVisualStyleBackColor = false;
            themKH.Click += themKH_Click;
            // 
            // quanlykhachhang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(txtTenKhachHang);
            Controls.Add(txtSoDienThoai);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Location = new Point(170, 124);
            Name = "quanlykhachhang";
            Size = new Size(1261, 805);
            Load += quanlykhachhang_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kh_hienThiKH).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView kh_hienThiKH;
        private Label label3;
        private Label label4;
        private TextBox txtSoDienThoai;
        private TextBox txtTenKhachHang;
        private GroupBox groupBox1;
        private Button dskh_timKiem;
        private Button luuKH;
        private Button xoaKH;
        private Button themKH;
        private Button xuatExcel;
    }
}
