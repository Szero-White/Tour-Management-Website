namespace DuLich.UserControls
{
    partial class quanlylichtrinh
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
            button6 = new Button();
            panel1 = new Panel();
            hienThiLT = new DataGridView();
            label1 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hienThiLT).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Location = new Point(168, 523);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(920, 90);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức Năng";
            // 
            // button6
            // 
            button6.BackColor = Color.SeaShell;
            button6.Location = new Point(432, 36);
            button6.Name = "button6";
            button6.Size = new Size(114, 29);
            button6.TabIndex = 6;
            button6.Text = "Thanh Toán";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(hienThiLT);
            panel1.Location = new Point(168, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 325);
            panel1.TabIndex = 12;
            // 
            // hienThiLT
            // 
            hienThiLT.AllowUserToAddRows = false;
            hienThiLT.BackgroundColor = Color.FromArgb(255, 192, 128);
            hienThiLT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hienThiLT.EditMode = DataGridViewEditMode.EditOnEnter;
            hienThiLT.Location = new Point(0, 0);
            hienThiLT.Name = "hienThiLT";
            hienThiLT.RowHeadersWidth = 51;
            hienThiLT.Size = new Size(920, 325);
            hienThiLT.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(480, 48);
            label1.Name = "label1";
            label1.Size = new Size(341, 50);
            label1.TabIndex = 11;
            label1.Text = "Quản Lý Lịch Trình";
            // 
            // quanlylichtrinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "quanlylichtrinh";
            Size = new Size(1261, 805);
            Load += quanlylichtrinh_Load;
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hienThiLT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button6;
        private Panel panel1;
        private DataGridView hienThiLT;
        private Label label1;
    }
}
