using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DuLich
{
    public partial class QR : Form
    {
        private string connectionString = @"Data Source=NguyenCongToan\SQLEXPRESS;Initial Catalog=DuLich;Integrated Security=True;TrustServerCertificate=True";
        private string soDienThoai;

        public QR(string soDienThoai)
        {
            InitializeComponent();
            this.soDienThoai = soDienThoai;

            button1.Click += button1_Click;
            pictureBox1.Click += pictureBox1_Click;
        }


        public QR(string soDienThoai, string tenKhachHang, string tenTour, decimal giaTour, int soNguoi)
        {
            InitializeComponent();
            this.soDienThoai = soDienThoai;

            tenkhachhang.Text = tenKhachHang;
            tentour.Text = tenTour;

            decimal tongTien = giaTour * soNguoi;
            thanhtien.Text = tongTien.ToString("N0") + " $";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE QuanLyLichTrinh 
                           SET TrangThaiTour = N'Đã thanh toán' 
                           WHERE SoDienThoai = @SoDienThoai";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                        cmd.ExecuteNonQuery();
                    }
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật trạng thái: " + ex.Message, "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            XacNhanThanhToan();
        }

        private void XacNhanThanhToan()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE QuanLyLichTrinh 
                                   SET TrangThaiTour = N'Đã thanh toán' 
                                   WHERE SoDienThoai = @SoDienThoai";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thanh toán thành công!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK; 
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin đặt tour!", "Cảnh báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật trạng thái: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QR_Load(object sender, EventArgs e)
        {

        }
    }
}