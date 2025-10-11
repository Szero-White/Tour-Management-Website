namespace DuLich.UserControls
{
    partial class dattourdulich
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dattourdulich));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            hienThiTour = new DataGridView();
            label1 = new Label();
            groupBox1 = new GroupBox();
            locKQ = new Button();
            phuongTien = new ComboBox();
            giaTour = new ComboBox();
            loaiTour = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            picImage1 = new PictureBox();
            picImage2 = new PictureBox();
            txtSoDienThoai = new TextBox();
            txtTenKhachHang = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dtdl_datTour = new Button();
            label4 = new Label();
            numSoNguoi = new NumericUpDown();
            label9 = new Label();
            panel2 = new Panel();
            dataGridView2 = new DataGridView();
            label5 = new Label();
            huyVe = new Button();
            cboMaTour = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hienThiTour).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picImage1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picImage2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSoNguoi).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(hienThiTour);
            panel1.Location = new Point(40, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 252);
            panel1.TabIndex = 2;
            // 
            // hienThiTour
            // 
            hienThiTour.AllowUserToAddRows = false;
            hienThiTour.BackgroundColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            hienThiTour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            hienThiTour.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            hienThiTour.DefaultCellStyle = dataGridViewCellStyle2;
            hienThiTour.EditMode = DataGridViewEditMode.EditOnEnter;
            hienThiTour.Location = new Point(0, 0);
            hienThiTour.Name = "hienThiTour";
            hienThiTour.RowHeadersWidth = 51;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            hienThiTour.RowsDefaultCellStyle = dataGridViewCellStyle3;
            hienThiTour.Size = new Size(920, 252);
            hienThiTour.TabIndex = 0;
            hienThiTour.CellContentClick += hienThiTour_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(387, 0);
            label1.Name = "label1";
            label1.Size = new Size(240, 50);
            label1.TabIndex = 3;
            label1.Text = "Tour Du Lịch";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(locKQ);
            groupBox1.Controls.Add(phuongTien);
            groupBox1.Controls.Add(giaTour);
            groupBox1.Controls.Add(loaiTour);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(995, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 430);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lọc Kết Quả";
            // 
            // locKQ
            // 
            locKQ.BackColor = Color.PeachPuff;
            locKQ.Location = new Point(77, 365);
            locKQ.Name = "locKQ";
            locKQ.Size = new Size(122, 29);
            locKQ.TabIndex = 14;
            locKQ.Text = "Lọc Kết Quả";
            locKQ.UseVisualStyleBackColor = false;
            locKQ.Click += locKQ_Click;
            // 
            // phuongTien
            // 
            phuongTien.FormattingEnabled = true;
            phuongTien.Items.AddRange(new object[] { "Xe", "Máy Bay" });
            phuongTien.Location = new Point(0, 292);
            phuongTien.Name = "phuongTien";
            phuongTien.Size = new Size(264, 28);
            phuongTien.TabIndex = 13;
            // 
            // giaTour
            // 
            giaTour.FormattingEnabled = true;
            giaTour.Items.AddRange(new object[] { "Dưới $200", "Từ $200 đến $400", "Trên $400" });
            giaTour.Location = new Point(0, 194);
            giaTour.Name = "giaTour";
            giaTour.Size = new Size(264, 28);
            giaTour.TabIndex = 12;
            giaTour.SelectedIndexChanged += giaTour_SelectedIndexChanged;
            // 
            // loaiTour
            // 
            loaiTour.FormattingEnabled = true;
            loaiTour.Items.AddRange(new object[] { "Cao Cấp", "Tiêu Chuẩn", "Tiết Kiệm" });
            loaiTour.Location = new Point(0, 96);
            loaiTour.Name = "loaiTour";
            loaiTour.Size = new Size(264, 28);
            loaiTour.TabIndex = 11;
            loaiTour.SelectedIndexChanged += loaiTour_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 256);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 10;
            label8.Text = "Phương Tiện";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 60);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 9;
            label7.Text = "Loại Tour";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 158);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 8;
            label6.Text = "Giá Tour";
            // 
            // picImage1
            // 
            picImage1.Image = (Image)resources.GetObject("picImage1.Image");
            picImage1.Location = new Point(483, 358);
            picImage1.Name = "picImage1";
            picImage1.Size = new Size(229, 139);
            picImage1.SizeMode = PictureBoxSizeMode.StretchImage;
            picImage1.TabIndex = 5;
            picImage1.TabStop = false;
            // 
            // picImage2
            // 
            picImage2.Image = (Image)resources.GetObject("picImage2.Image");
            picImage2.Location = new Point(731, 358);
            picImage2.Name = "picImage2";
            picImage2.Size = new Size(229, 139);
            picImage2.SizeMode = PictureBoxSizeMode.StretchImage;
            picImage2.TabIndex = 6;
            picImage2.TabStop = false;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(181, 396);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(296, 27);
            txtSoDienThoai.TabIndex = 19;
            txtSoDienThoai.TextChanged += txtSoDienThoai_TextChanged;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Location = new Point(181, 358);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(296, 27);
            txtTenKhachHang.TabIndex = 18;
            txtTenKhachHang.TextChanged += txtTenKhachHang_TextChanged;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Location = new Point(40, 397);
            label3.Name = "label3";
            label3.Size = new Size(119, 26);
            label3.TabIndex = 17;
            label3.Text = "Số Điện thoại";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.Window;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(40, 358);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 16;
            label2.Text = "Tên Khách Hàng";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtdl_datTour
            // 
            dtdl_datTour.BackColor = Color.PeachPuff;
            dtdl_datTour.Location = new Point(181, 512);
            dtdl_datTour.Name = "dtdl_datTour";
            dtdl_datTour.Size = new Size(122, 29);
            dtdl_datTour.TabIndex = 20;
            dtdl_datTour.Text = "Đặt Tour";
            dtdl_datTour.UseVisualStyleBackColor = false;
            dtdl_datTour.Click += dtdl_datTour_Click;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(40, 433);
            label4.Name = "label4";
            label4.Size = new Size(119, 28);
            label4.TabIndex = 21;
            label4.Text = "Nhập Mã Tour";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numSoNguoi
            // 
            numSoNguoi.Location = new Point(181, 470);
            numSoNguoi.Name = "numSoNguoi";
            numSoNguoi.Size = new Size(296, 27);
            numSoNguoi.TabIndex = 25;
            numSoNguoi.ValueChanged += numSoNguoi_ValueChanged;
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Location = new Point(40, 470);
            label9.Name = "label9";
            label9.Size = new Size(119, 27);
            label9.TabIndex = 24;
            label9.Text = "Số Người ";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView2);
            panel2.Location = new Point(40, 604);
            panel2.Name = "panel2";
            panel2.Size = new Size(920, 198);
            panel2.TabIndex = 26;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.BackgroundColor = Color.FromArgb(255, 192, 128);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.Size = new Size(920, 198);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(396, 557);
            label5.Name = "label5";
            label5.Size = new Size(219, 28);
            label5.TabIndex = 27;
            label5.Text = "Chi Tiết Đơn Đặt Tour";
            // 
            // huyVe
            // 
            huyVe.BackColor = Color.PeachPuff;
            huyVe.Location = new Point(1072, 703);
            huyVe.Name = "huyVe";
            huyVe.Size = new Size(122, 29);
            huyVe.TabIndex = 28;
            huyVe.Text = "Hủy Vé";
            huyVe.UseVisualStyleBackColor = false;
            huyVe.Click += huyVe_Click;
            // 
            // cboMaTour
            // 
            cboMaTour.Location = new Point(181, 437);
            cboMaTour.Name = "cboMaTour";
            cboMaTour.Size = new Size(296, 27);
            cboMaTour.TabIndex = 29;
            cboMaTour.TextChanged += cboMaTour_TextChanged;
            // 
            // dattourdulich
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(cboMaTour);
            Controls.Add(huyVe);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(numSoNguoi);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(dtdl_datTour);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtTenKhachHang);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(picImage2);
            Controls.Add(picImage1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "dattourdulich";
            Size = new Size(1261, 805);
            Load += dattourdulich_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hienThiTour).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picImage1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picImage2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSoNguoi).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView hienThiTour;
        private Label label1;
        private GroupBox groupBox1;
        private PictureBox picImage1;
        private PictureBox picImage2;
        private ComboBox giaTour;
        private ComboBox loaiTour;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button locKQ;
        private ComboBox phuongTien;
        private TextBox txtSoDienThoai;
        private TextBox txtTenKhachHang;
        private Label label3;
        private Label label2;
        private Button dtdl_datTour;
        private Label label4;
        private NumericUpDown numSoNguoi;
        private Label label9;
        private Panel panel2;
        private DataGridView dataGridView2;
        private Label label5;
        private Button huyVe;
        private TextBox cboMaTour;
    }
}
