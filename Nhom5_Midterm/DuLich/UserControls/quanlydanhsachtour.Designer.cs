namespace DuLich.UserControls
{
    partial class quanlydanhsachtour
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanlydanhsachtour));
            label1 = new Label();
            panel1 = new Panel();
            dst_hienThiTour = new DataGridView();
            groupBox1 = new GroupBox();
            dst_nhapExel = new Button();
            dst_timKiem = new Button();
            dst_luu = new Button();
            dst_xoa = new Button();
            dst_them = new Button();
            tenTour = new TextBox();
            giaTour = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            phuongTien = new ComboBox();
            loaiTour = new ComboBox();
            ngayDi = new DateTimePicker();
            ngayKetThuc = new DateTimePicker();
            picHinhAnh1 = new PictureBox();
            picHinhAnh2 = new PictureBox();
            chonAnh1 = new Button();
            chonAnh2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dst_hienThiTour).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(426, 0);
            label1.Name = "label1";
            label1.Size = new Size(443, 50);
            label1.TabIndex = 1;
            label1.Text = "Quản Lý Danh Sách Tour";
            // 
            // panel1
            // 
            panel1.Controls.Add(dst_hienThiTour);
            panel1.Location = new Point(170, 68);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 278);
            panel1.TabIndex = 2;
            // 
            // dst_hienThiTour
            // 
            dst_hienThiTour.AllowUserToAddRows = false;
            dst_hienThiTour.BackgroundColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dst_hienThiTour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dst_hienThiTour.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dst_hienThiTour.EditMode = DataGridViewEditMode.EditOnEnter;
            dst_hienThiTour.Location = new Point(0, 0);
            dst_hienThiTour.Name = "dst_hienThiTour";
            dst_hienThiTour.RowHeadersWidth = 51;
            dst_hienThiTour.Size = new Size(920, 278);
            dst_hienThiTour.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dst_nhapExel);
            groupBox1.Controls.Add(dst_timKiem);
            groupBox1.Controls.Add(dst_luu);
            groupBox1.Controls.Add(dst_xoa);
            groupBox1.Controls.Add(dst_them);
            groupBox1.Location = new Point(170, 377);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(920, 90);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức Năng";
            // 
            // dst_nhapExel
            // 
            dst_nhapExel.BackColor = Color.SeaShell;
            dst_nhapExel.Location = new Point(744, 31);
            dst_nhapExel.Name = "dst_nhapExel";
            dst_nhapExel.Size = new Size(123, 29);
            dst_nhapExel.TabIndex = 5;
            dst_nhapExel.Text = "Nhập File Excel";
            dst_nhapExel.UseVisualStyleBackColor = false;
            dst_nhapExel.Click += dst_nhapExel_Click;
            // 
            // dst_timKiem
            // 
            dst_timKiem.BackColor = Color.SeaShell;
            dst_timKiem.Location = new Point(580, 31);
            dst_timKiem.Name = "dst_timKiem";
            dst_timKiem.Size = new Size(94, 29);
            dst_timKiem.TabIndex = 4;
            dst_timKiem.Text = "Tìm Kiếm";
            dst_timKiem.UseVisualStyleBackColor = false;
            dst_timKiem.Click += dst_timKiem_Click;
            // 
            // dst_luu
            // 
            dst_luu.BackColor = Color.SeaShell;
            dst_luu.Location = new Point(406, 31);
            dst_luu.Name = "dst_luu";
            dst_luu.Size = new Size(94, 29);
            dst_luu.TabIndex = 3;
            dst_luu.Text = "Lưu";
            dst_luu.UseVisualStyleBackColor = false;
            dst_luu.Click += dst_luu_Click;
            // 
            // dst_xoa
            // 
            dst_xoa.BackColor = Color.SeaShell;
            dst_xoa.Location = new Point(231, 31);
            dst_xoa.Name = "dst_xoa";
            dst_xoa.Size = new Size(94, 29);
            dst_xoa.TabIndex = 1;
            dst_xoa.Text = "Xóa";
            dst_xoa.UseVisualStyleBackColor = false;
            dst_xoa.Click += dst_xoa_Click;
            // 
            // dst_them
            // 
            dst_them.BackColor = Color.SeaShell;
            dst_them.Location = new Point(63, 31);
            dst_them.Name = "dst_them";
            dst_them.Size = new Size(94, 29);
            dst_them.TabIndex = 0;
            dst_them.Text = "Thêm";
            dst_them.UseVisualStyleBackColor = false;
            dst_them.Click += dst_them_Click;
            // 
            // tenTour
            // 
            tenTour.Location = new Point(311, 504);
            tenTour.Name = "tenTour";
            tenTour.Size = new Size(250, 27);
            tenTour.TabIndex = 15;
            // 
            // giaTour
            // 
            giaTour.Location = new Point(311, 572);
            giaTour.Name = "giaTour";
            giaTour.Size = new Size(250, 27);
            giaTour.TabIndex = 14;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(170, 572);
            label4.Name = "label4";
            label4.Size = new Size(119, 27);
            label4.TabIndex = 12;
            label4.Text = "Giá Tour";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(170, 503);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 11;
            label3.Text = "Tên Tour";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Location = new Point(699, 503);
            label5.Name = "label5";
            label5.Size = new Size(119, 28);
            label5.TabIndex = 16;
            label5.Text = "Loại Tour";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(170, 633);
            label6.Name = "label6";
            label6.Size = new Size(119, 30);
            label6.TabIndex = 17;
            label6.Text = "Phương Tiện";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Location = new Point(699, 570);
            label8.Name = "label8";
            label8.Size = new Size(119, 27);
            label8.TabIndex = 19;
            label8.Text = "Ngày Đi";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Location = new Point(699, 633);
            label9.Name = "label9";
            label9.Size = new Size(119, 27);
            label9.TabIndex = 20;
            label9.Text = "Ngày Kết Thúc";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Location = new Point(699, 687);
            label10.Name = "label10";
            label10.Size = new Size(119, 27);
            label10.TabIndex = 21;
            label10.Text = "Chọn Ảnh";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // phuongTien
            // 
            phuongTien.FormattingEnabled = true;
            phuongTien.Items.AddRange(new object[] { "Xe", "Máy Bay" });
            phuongTien.Location = new Point(311, 635);
            phuongTien.Name = "phuongTien";
            phuongTien.Size = new Size(250, 28);
            phuongTien.TabIndex = 22;
            // 
            // loaiTour
            // 
            loaiTour.FormattingEnabled = true;
            loaiTour.Items.AddRange(new object[] { "Cao Cấp", "Tiêu Chuẩn", "Tiết Kiệm" });
            loaiTour.Location = new Point(840, 503);
            loaiTour.Name = "loaiTour";
            loaiTour.Size = new Size(250, 28);
            loaiTour.TabIndex = 24;
            // 
            // ngayDi
            // 
            ngayDi.Location = new Point(840, 570);
            ngayDi.Name = "ngayDi";
            ngayDi.Size = new Size(250, 27);
            ngayDi.TabIndex = 25;
            // 
            // ngayKetThuc
            // 
            ngayKetThuc.Location = new Point(840, 633);
            ngayKetThuc.Name = "ngayKetThuc";
            ngayKetThuc.Size = new Size(250, 27);
            ngayKetThuc.TabIndex = 26;
            // 
            // picHinhAnh1
            // 
            picHinhAnh1.Image = (Image)resources.GetObject("picHinhAnh1.Image");
            picHinhAnh1.Location = new Point(840, 687);
            picHinhAnh1.Name = "picHinhAnh1";
            picHinhAnh1.Size = new Size(117, 76);
            picHinhAnh1.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh1.TabIndex = 27;
            picHinhAnh1.TabStop = false;
            // 
            // picHinhAnh2
            // 
            picHinhAnh2.Image = (Image)resources.GetObject("picHinhAnh2.Image");
            picHinhAnh2.Location = new Point(975, 687);
            picHinhAnh2.Name = "picHinhAnh2";
            picHinhAnh2.Size = new Size(117, 76);
            picHinhAnh2.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh2.TabIndex = 28;
            picHinhAnh2.TabStop = false;
            // 
            // chonAnh1
            // 
            chonAnh1.BackColor = Color.SeaShell;
            chonAnh1.Location = new Point(840, 770);
            chonAnh1.Name = "chonAnh1";
            chonAnh1.Size = new Size(117, 31);
            chonAnh1.TabIndex = 29;
            chonAnh1.Text = "Chọn Ảnh 1";
            chonAnh1.UseVisualStyleBackColor = false;
            chonAnh1.Click += chonAnh1_Click;
            // 
            // chonAnh2
            // 
            chonAnh2.BackColor = Color.SeaShell;
            chonAnh2.Location = new Point(975, 770);
            chonAnh2.Name = "chonAnh2";
            chonAnh2.Size = new Size(117, 31);
            chonAnh2.TabIndex = 30;
            chonAnh2.Text = "Chọn Ảnh 2";
            chonAnh2.UseVisualStyleBackColor = false;
            chonAnh2.Click += chonAnh2_Click;
            // 
            // quanlydanhsachtour
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(chonAnh2);
            Controls.Add(chonAnh1);
            Controls.Add(picHinhAnh2);
            Controls.Add(picHinhAnh1);
            Controls.Add(ngayKetThuc);
            Controls.Add(ngayDi);
            Controls.Add(loaiTour);
            Controls.Add(phuongTien);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tenTour);
            Controls.Add(giaTour);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "quanlydanhsachtour";
            Size = new Size(1261, 805);
            Load += quanlydanhsachtour_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dst_hienThiTour).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picHinhAnh1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dst_hienThiTour;
        private GroupBox groupBox1;
        private Button dst_luu;
        private Button dst_xoa;
        private Button dst_them;
        private TextBox tenTour;
        private TextBox giaTour;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox phuongTien;
        private ComboBox loaiTour;
        private DateTimePicker ngayDi;
        private DateTimePicker ngayKetThuc;
        private PictureBox picHinhAnh1;
        private PictureBox picHinhAnh2;
        private Button chonAnh1;
        private Button chonAnh2;
        private Button dst_timKiem;
        private Button dst_nhapExel;
    }
}
