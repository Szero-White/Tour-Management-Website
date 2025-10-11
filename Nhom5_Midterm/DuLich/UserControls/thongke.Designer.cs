namespace DuLich.UserControls
{
    partial class thongke
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            numericUpDownThang = new NumericUpDown();
            label9 = new Label();
            numericUpDownNam = new NumericUpDown();
            label2 = new Label();
            bctk_xacNhan = new Label();
            panel1 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownThang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNam).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(423, 30);
            label1.Name = "label1";
            label1.Size = new Size(393, 50);
            label1.TabIndex = 4;
            label1.Text = "Báo Cáo Và Thống Kê";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 192, 128);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(652, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(568, 415);
            dataGridView1.TabIndex = 6;
            // 
            // numericUpDownThang
            // 
            numericUpDownThang.Location = new Point(249, 679);
            numericUpDownThang.Name = "numericUpDownThang";
            numericUpDownThang.Size = new Size(121, 27);
            numericUpDownThang.TabIndex = 27;
            // 
            // label9
            // 
            label9.BorderStyle = BorderStyle.FixedSingle;
            label9.Location = new Point(108, 679);
            label9.Name = "label9";
            label9.Size = new Size(119, 27);
            label9.TabIndex = 26;
            label9.Text = "Tháng ";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numericUpDownNam
            // 
            numericUpDownNam.Location = new Point(630, 681);
            numericUpDownNam.Name = "numericUpDownNam";
            numericUpDownNam.Size = new Size(121, 27);
            numericUpDownNam.TabIndex = 29;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(489, 681);
            label2.Name = "label2";
            label2.Size = new Size(119, 27);
            label2.TabIndex = 28;
            label2.Text = "Năm";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bctk_xacNhan
            // 
            bctk_xacNhan.BackColor = Color.DarkSalmon;
            bctk_xacNhan.BorderStyle = BorderStyle.FixedSingle;
            bctk_xacNhan.Location = new Point(876, 680);
            bctk_xacNhan.Name = "bctk_xacNhan";
            bctk_xacNhan.Size = new Size(119, 27);
            bctk_xacNhan.TabIndex = 30;
            bctk_xacNhan.Text = "Xác Nhận";
            bctk_xacNhan.TextAlign = ContentAlignment.MiddleCenter;
            bctk_xacNhan.Click += bctk_xacNhan_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(3, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(643, 539);
            panel1.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(226, 745);
            label3.Name = "label3";
            label3.Size = new Size(769, 25);
            label3.TabIndex = 32;
            label3.Text = "Biểu Đồ Thống Kê Doanh Thu Và Số Lượng Tham Gia Theo Các Loại Tour Du Lịch Đã Thanh Toán";
            // 
            // thongke
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(bctk_xacNhan);
            Controls.Add(numericUpDownNam);
            Controls.Add(label2);
            Controls.Add(numericUpDownThang);
            Controls.Add(label9);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "thongke";
            Size = new Size(1261, 805);
            Load += thongke_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownThang).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNam).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;

        private DataGridView dataGridView1;
        private NumericUpDown numericUpDownThang;
        private Label label9;
        private NumericUpDown numericUpDownNam;
        private Label label2;
        private Label bctk_xacNhan;
        private Panel panel1;
        private Label label3;
    }
}
