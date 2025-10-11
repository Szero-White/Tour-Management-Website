using DuLich.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace DuLich
{
    public partial class trangchu : Form
    {
        public static string loggedInUser = ""; // Biến lưu tài khoản đăng nhập
        public trangchu()
        {
            InitializeComponent();
            this.Load += trangchu_Load;
        }

        string connectionString = @"Data Source=NguyenCongToan\SQLEXPRESS;Initial Catalog=DuLich;Integrated Security=True;TrustServerCertificate=True";

        public Button currentButton = null;

        public void HighlightButton(Button btn)
        {
            if (currentButton != null)
            {
                currentButton.FlatAppearance.BorderSize = 0;
            }

            currentButton = btn;
            currentButton.FlatAppearance.BorderSize = 2;
            currentButton.FlatAppearance.BorderColor = Color.Blue;
        }


        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            main.Controls.Clear();
            main.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void tc_Click(object sender, EventArgs e)
        {
            trangchinh trangChinh = new trangchinh();
            addUserControl(trangChinh);
        }

        private void qlkh_Click(object sender, EventArgs e)
        {
            quanlykhachhang khachHang = new quanlykhachhang();
            addUserControl(khachHang);

        }

        private void pllt_Click(object sender, EventArgs e)
        {
            quanlylichtrinh lichTrinh = new quanlylichtrinh();
            addUserControl(lichTrinh);
        }

        private void bcvtk_Click(object sender, EventArgs e)
        {
            thongke thongKe = new thongke();
            addUserControl(thongKe);
        }

        private void plnv_Click(object sender, EventArgs e)
        {
            quanlynhanvien nhanVien = new quanlynhanvien();
            addUserControl(nhanVien);
        }

        private void qldst_Click(object sender, EventArgs e)
        {
            quanlydanhsachtour danhSachTour = new quanlydanhsachtour();
            addUserControl(danhSachTour);
        }

        private void dattour_Click_1(object sender, EventArgs e)
        {
            dattourdulich datTour = new dattourdulich();
            addUserControl(datTour);
        }

        private void trangchu_Load(object sender, EventArgs e)
        {
            if (loggedInUser != "admin")
            {
                plnv.Visible = false;
                qldst.Visible = false;
            }

            userName.Text = loggedInUser;
        }

        private void dangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                loggedInUser = "";

                this.Hide();

                dangnhap loginForm = new dangnhap();
                loginForm.ShowDialog();

                this.Close();
            }
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
