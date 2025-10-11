namespace DuLich.UserControls
{
    partial class quanlynhanvien
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
            groupBox1 = new GroupBox();
            luuNV = new Button();
            xoaNV = new Button();
            themNV = new Button();
            tenNV = new TextBox();
            matKhauNhanVien = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            hienThiTKNhanVien = new DataGridView();
            label1 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hienThiTKNhanVien).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(luuNV);
            groupBox1.Controls.Add(xoaNV);
            groupBox1.Controls.Add(themNV);
            groupBox1.Location = new Point(176, 519);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(920, 90);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức Năng";
            // 
            // luuNV
            // 
            luuNV.BackColor = Color.SeaShell;
            luuNV.Location = new Point(717, 31);
            luuNV.Name = "luuNV";
            luuNV.Size = new Size(94, 29);
            luuNV.TabIndex = 3;
            luuNV.Text = "Lưu";
            luuNV.UseVisualStyleBackColor = false;
            luuNV.Click += luuNV_Click;
            // 
            // xoaNV
            // 
            xoaNV.BackColor = Color.SeaShell;
            xoaNV.Location = new Point(406, 31);
            xoaNV.Name = "xoaNV";
            xoaNV.Size = new Size(94, 29);
            xoaNV.TabIndex = 1;
            xoaNV.Text = "Xóa";
            xoaNV.UseVisualStyleBackColor = false;
            xoaNV.Click += xoaNV_Click;
            // 
            // themNV
            // 
            themNV.BackColor = Color.SeaShell;
            themNV.Location = new Point(109, 31);
            themNV.Name = "themNV";
            themNV.Size = new Size(94, 29);
            themNV.TabIndex = 0;
            themNV.Text = "Thêm";
            themNV.UseVisualStyleBackColor = false;
            themNV.Click += themNV_Click;
            // 
            // tenNV
            // 
            tenNV.Location = new Point(324, 689);
            tenNV.Name = "tenNV";
            tenNV.Size = new Size(234, 27);
            tenNV.TabIndex = 16;
            // 
            // matKhauNhanVien
            // 
            matKhauNhanVien.Location = new Point(855, 689);
            matKhauNhanVien.Name = "matKhauNhanVien";
            matKhauNhanVien.Size = new Size(234, 27);
            matKhauNhanVien.TabIndex = 15;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(687, 689);
            label4.Name = "label4";
            label4.Size = new Size(119, 29);
            label4.TabIndex = 14;
            label4.Text = "Mật Khẩu";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(176, 689);
            label3.Name = "label3";
            label3.Size = new Size(119, 27);
            label3.TabIndex = 13;
            label3.Text = "Tên Đăng Nhập";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(hienThiTKNhanVien);
            panel1.Location = new Point(176, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 325);
            panel1.TabIndex = 12;
            // 
            // hienThiTKNhanVien
            // 
            hienThiTKNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hienThiTKNhanVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            hienThiTKNhanVien.BackgroundColor = Color.FromArgb(255, 192, 128);
            hienThiTKNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hienThiTKNhanVien.Location = new Point(0, 0);
            hienThiTKNhanVien.Name = "hienThiTKNhanVien";
            hienThiTKNhanVien.RowHeadersWidth = 51;
            hienThiTKNhanVien.Size = new Size(920, 325);
            hienThiTKNhanVien.TabIndex = 0;
            hienThiTKNhanVien.CellContentClick += hienThiTKNhanVien_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(383, 41);
            label1.Name = "label1";
            label1.Size = new Size(545, 50);
            label1.TabIndex = 11;
            label1.Text = "Quản Lý Danh Sách Nhân Viên";
            // 
            // quanlynhanvien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(tenNV);
            Controls.Add(matKhauNhanVien);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "quanlynhanvien";
            Size = new Size(1261, 805);
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hienThiTKNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button luuNV;
        private Button xoaNV;
        private Button themNV;
        private TextBox tenNV;
        private TextBox matKhauNhanVien;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private DataGridView hienThiTKNhanVien;
        private Label label1;
    }
}
