namespace DuLich
{
    partial class trangchu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trangchu));
            panel1 = new Panel();
            label2 = new Label();
            dangXuat = new Button();
            userName = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tc = new Button();
            dattour = new Button();
            qlkh = new Button();
            pllt = new Button();
            bcvtk = new Button();
            plnv = new Button();
            qldst = new Button();
            main = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dangXuat);
            panel1.Controls.Add(userName);
            panel1.Location = new Point(259, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1261, 62);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Location = new Point(830, 13);
            label2.Name = "label2";
            label2.Size = new Size(73, 34);
            label2.TabIndex = 2;
            label2.Text = "Xin Chào: ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dangXuat
            // 
            dangXuat.Image = (Image)resources.GetObject("dangXuat.Image");
            dangXuat.ImageAlign = ContentAlignment.MiddleLeft;
            dangXuat.Location = new Point(1096, 13);
            dangXuat.Name = "dangXuat";
            dangXuat.Size = new Size(131, 37);
            dangXuat.TabIndex = 1;
            dangXuat.Text = "    Đăng Xuất";
            dangXuat.UseVisualStyleBackColor = true;
            dangXuat.Click += dangXuat_Click;
            // 
            // userName
            // 
            userName.BackColor = Color.SeaShell;
            userName.Location = new Point(909, 14);
            userName.Name = "userName";
            userName.Size = new Size(172, 34);
            userName.TabIndex = 0;
            userName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(259, 867);
            panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(tc);
            flowLayoutPanel1.Controls.Add(dattour);
            flowLayoutPanel1.Controls.Add(qlkh);
            flowLayoutPanel1.Controls.Add(pllt);
            flowLayoutPanel1.Controls.Add(bcvtk);
            flowLayoutPanel1.Controls.Add(plnv);
            flowLayoutPanel1.Controls.Add(qldst);
            flowLayoutPanel1.Location = new Point(0, 224);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(258, 643);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // tc
            // 
            tc.Image = (Image)resources.GetObject("tc.Image");
            tc.ImageAlign = ContentAlignment.MiddleLeft;
            tc.Location = new Point(0, 20);
            tc.Margin = new Padding(0, 20, 0, 20);
            tc.Name = "tc";
            tc.Size = new Size(258, 37);
            tc.TabIndex = 2;
            tc.Text = "Trang Chủ";
            tc.UseVisualStyleBackColor = true;
            tc.Click += tc_Click;
            // 
            // dattour
            // 
            dattour.Location = new Point(0, 97);
            dattour.Margin = new Padding(0, 20, 0, 20);
            dattour.Name = "dattour";
            dattour.Size = new Size(258, 37);
            dattour.TabIndex = 3;
            dattour.Text = "Đặt Tour";
            dattour.UseVisualStyleBackColor = true;
            dattour.Click += dattour_Click_1;
            // 
            // qlkh
            // 
            qlkh.Location = new Point(0, 174);
            qlkh.Margin = new Padding(0, 20, 0, 20);
            qlkh.Name = "qlkh";
            qlkh.Size = new Size(258, 37);
            qlkh.TabIndex = 9;
            qlkh.Text = "Quản Lý Khách Hàng";
            qlkh.UseVisualStyleBackColor = true;
            qlkh.Click += qlkh_Click;
            // 
            // pllt
            // 
            pllt.Location = new Point(0, 251);
            pllt.Margin = new Padding(0, 20, 0, 20);
            pllt.Name = "pllt";
            pllt.Size = new Size(258, 37);
            pllt.TabIndex = 8;
            pllt.Text = "Quản Lý Lịch Trình";
            pllt.UseVisualStyleBackColor = true;
            pllt.Click += pllt_Click;
            // 
            // bcvtk
            // 
            bcvtk.Location = new Point(0, 328);
            bcvtk.Margin = new Padding(0, 20, 0, 20);
            bcvtk.Name = "bcvtk";
            bcvtk.Size = new Size(258, 37);
            bcvtk.TabIndex = 7;
            bcvtk.Text = "Báo Cáo Và Thống Kê";
            bcvtk.UseVisualStyleBackColor = true;
            bcvtk.Click += bcvtk_Click;
            // 
            // plnv
            // 
            plnv.Location = new Point(0, 405);
            plnv.Margin = new Padding(0, 20, 0, 20);
            plnv.Name = "plnv";
            plnv.Size = new Size(258, 37);
            plnv.TabIndex = 10;
            plnv.Text = "Quản Lý Nhân Viên";
            plnv.UseVisualStyleBackColor = true;
            plnv.Click += plnv_Click;
            // 
            // qldst
            // 
            qldst.Location = new Point(0, 482);
            qldst.Margin = new Padding(0, 20, 0, 20);
            qldst.Name = "qldst";
            qldst.Size = new Size(258, 37);
            qldst.TabIndex = 11;
            qldst.Text = "Quản Lý Danh Sách Tour";
            qldst.UseVisualStyleBackColor = true;
            qldst.Click += qldst_Click;
            // 
            // main
            // 
            main.Controls.Add(pictureBox4);
            main.Controls.Add(pictureBox3);
            main.Controls.Add(pictureBox2);
            main.Location = new Point(259, 62);
            main.Name = "main";
            main.Size = new Size(1261, 805);
            main.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(58, 490);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1151, 264);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(58, 162);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1151, 264);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(532, 16);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(251, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // trangchu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1524, 871);
            Controls.Add(main);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "trangchu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "trangchu";
            Load += trangchu_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button tc;
        private Button dattour;
        private Button bcvtk;
        private Label userName;
        private Button dangXuat;
        private Panel main;
        private Label label2;
        private Button pllt;
        private Button qlkh;
        private Button qldst;
        private Button plnv;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}