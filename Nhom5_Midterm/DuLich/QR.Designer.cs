namespace DuLich
{
    partial class QR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QR));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            tentour = new Label();
            tenkhachhang = new Label();
            label10 = new Label();
            label4 = new Label();
            thanhtien = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImageLocation = "";
            pictureBox1.InitialImage = Properties.Resources.QRs;
            pictureBox1.Location = new Point(96, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 460);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(531, 382);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Xác nhận";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tentour
            // 
            tentour.AutoSize = true;
            tentour.Location = new Point(670, 170);
            tentour.Name = "tentour";
            tentour.Size = new Size(17, 20);
            tentour.TabIndex = 21;
            tentour.Text = "h";
            // 
            // tenkhachhang
            // 
            tenkhachhang.AutoSize = true;
            tenkhachhang.Location = new Point(670, 225);
            tenkhachhang.Name = "tenkhachhang";
            tenkhachhang.Size = new Size(17, 20);
            tenkhachhang.TabIndex = 20;
            tenkhachhang.Text = "h";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(531, 225);
            label10.Name = "label10";
            label10.Size = new Size(116, 20);
            label10.TabIndex = 19;
            label10.Text = "Tên Khách Hàng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(531, 170);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 18;
            label4.Text = "Tên Tour";
            // 
            // thanhtien
            // 
            thanhtien.AutoSize = true;
            thanhtien.Location = new Point(665, 291);
            thanhtien.Name = "thanhtien";
            thanhtien.Size = new Size(17, 20);
            thanhtien.TabIndex = 23;
            thanhtien.Text = "h";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(531, 291);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 22;
            label8.Text = "Thành tiền:";
            // 
            // QR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 584);
            Controls.Add(thanhtien);
            Controls.Add(label8);
            Controls.Add(tentour);
            Controls.Add(tenkhachhang);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "QR";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += QR_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label tentour;
        private Label tenkhachhang;
        private Label label10;
        private Label label4;
        private Label thanhtien;
        private Label label8;
    }
}