namespace DuLich
{
    partial class dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dangnhap));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            dNhap = new Button();
            showPass = new CheckBox();
            mKhau = new TextBox();
            tdn = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 134);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(615, 614);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dNhap);
            panel1.Controls.Add(showPass);
            panel1.Controls.Add(mKhau);
            panel1.Controls.Add(tdn);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(610, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(535, 614);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(95, 320);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 8;
            label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(95, 227);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 7;
            label2.Text = "Tên Đăng Nhập:";
            // 
            // dNhap
            // 
            dNhap.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dNhap.ForeColor = Color.Red;
            dNhap.Location = new Point(133, 434);
            dNhap.Name = "dNhap";
            dNhap.Size = new Size(259, 60);
            dNhap.TabIndex = 6;
            dNhap.Text = "Đăng Nhập";
            dNhap.UseVisualStyleBackColor = true;
            dNhap.Click += dNhap_Click;
            // 
            // showPass
            // 
            showPass.AutoSize = true;
            showPass.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPass.Location = new Point(265, 357);
            showPass.Name = "showPass";
            showPass.Size = new Size(122, 21);
            showPass.TabIndex = 5;
            showPass.Text = "Hiện Mật Khẩu";
            showPass.UseVisualStyleBackColor = true;
            showPass.CheckedChanged += showPass_CheckedChanged;
            // 
            // mKhau
            // 
            mKhau.Location = new Point(265, 313);
            mKhau.Multiline = true;
            mKhau.Name = "mKhau";
            mKhau.PasswordChar = '*';
            mKhau.Size = new Size(172, 27);
            mKhau.TabIndex = 4;
            // 
            // tdn
            // 
            tdn.Location = new Point(265, 220);
            tdn.Multiline = true;
            tdn.Name = "tdn";
            tdn.Size = new Size(172, 27);
            tdn.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(159, 97);
            label1.Name = "label1";
            label1.Size = new Size(200, 46);
            label1.TabIndex = 0;
            label1.Text = "Đăng Nhập";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dangnhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 867);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "dangnhap";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private CheckBox showPass;
        private TextBox mKhau;
        private TextBox tdn;
        private Label label1;
        private Button dNhap;
        private Label label2;
        private Label label3;
    }
}