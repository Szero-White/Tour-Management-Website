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

namespace DuLich.UserControls
{
    public partial class quanlylichtrinh : UserControl
    {
        string connectionString = @"Data Source=NguyenCongToan\SQLEXPRESS;Initial Catalog=DuLich;Integrated Security=True;TrustServerCertificate=True";
        public quanlylichtrinh()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            string query = @"SELECT SoDienThoai, TenKhachHang, MaTour, TenTour, SoNguoi, ThoiGianDat, TrangThaiTour FROM QuanLyLichTrinh ORDER BY ThoiGianDat DESC";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    hienThiLT.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quanlylichtrinh_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (hienThiLT.SelectedRows.Count > 0) 
                {
                    DataGridViewRow selectedRow = hienThiLT.SelectedRows[0];

                    string tenTour = selectedRow.Cells["TenTour"].Value?.ToString() ?? "";
                    string tenKhachHang = selectedRow.Cells["TenKhachHang"].Value?.ToString() ?? "";
                    string maTour = selectedRow.Cells["MaTour"].Value?.ToString() ?? "";
                    string soNguoi = selectedRow.Cells["SoNguoi"].Value?.ToString() ?? "";
                    string thoiGianDat = selectedRow.Cells["ThoiGianDat"].Value?.ToString() ?? "";
                    string soDienThoai = selectedRow.Cells["SoDienThoai"].Value?.ToString() ?? "";
                    string trangThai = selectedRow.Cells["TrangThaiTour"].Value?.ToString() ?? "";

                    int maTourInt = int.TryParse(maTour, out int m) ? m : 0;
                    int soNguoiInt = int.TryParse(soNguoi, out int s) ? s : 0;

                    ThanhToan thanhToanForm = new ThanhToan(tenTour, tenKhachHang, maTourInt, soNguoiInt, thoiGianDat, soDienThoai, trangThai);
                    if (thanhToanForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadData(); 
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một lịch trình để thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
