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

namespace DuLich
{
    public partial class ThanhToan : Form
    {
        private int maTour;
        private int soNguoi;
        private string connectionString = @"Data Source=NguyenCongToan\SQLEXPRESS;Initial Catalog=DuLich;Integrated Security=True;TrustServerCertificate=True";
        public ThanhToan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        public ThanhToan(string tenTour, string tenKhachHang, int maTour, int soNguoi,
                        string thoiGianDat, string soDienThoai, string trangThai)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            tentour.Text = tenTour;
            tenkhachhang.Text = tenKhachHang;
            matour.Text = maTour.ToString();
            songuoi.Text = soNguoi.ToString();
            time.Text = thoiGianDat;
            sodienthoai.Text = soDienThoai;
            trangthai.Text = trangThai;

            this.maTour = maTour;
            this.soNguoi = soNguoi;

            TinhThanhTien();
            HienThiAnhTour();
        }
        private void TinhThanhTien()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT GiaTour FROM Tour WHERE MaTour = @MaTour";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaTour", maTour);
                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            int giaTour = Convert.ToInt32(result);
                            int tongTien = giaTour * soNguoi;

                            thanhtien.Text = $"{giaTour:N0} $ x {soNguoi} người = {tongTien:N0} $";
                        }
                        else
                        {
                            thanhtien.Text = "Không tìm thấy giá tour";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính tiền: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                thanhtien.Text = "Lỗi tính toán";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal giaTour = decimal.Parse(thanhtien.Text.Split(' ')[0].Replace(",", ""));
                int soNguoiInt = int.Parse(songuoi.Text);

                QR qrForm = new QR(
                    sodienthoai.Text,
                    tenkhachhang.Text,
                    tentour.Text,
                    giaTour,
                    soNguoiInt
                );

                if (qrForm.ShowDialog() == DialogResult.OK)
                {
                    trangthai.Text = "Đã thanh toán";
                    MessageBox.Show("Thanh toán thành công!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (FormatException)
            {
                MessageBox.Show("Dữ liệu số không hợp lệ!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HienThiAnhTour()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT HinhAnh1, HinhAnh2 FROM Tour WHERE MaTour = @MaTour";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaTour", maTour);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            string hinhAnh1 = reader["HinhAnh1"].ToString();
                            string hinhAnh2 = reader["HinhAnh2"].ToString();

                            if (!string.IsNullOrEmpty(hinhAnh1))
                            {
                                pictureBox1.Image = Image.FromFile(hinhAnh1); 
                            }

                            if (!string.IsNullOrEmpty(hinhAnh2))
                            {
                                pictureBox2.Image = Image.FromFile(hinhAnh2); 
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy ảnh cho tour này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
