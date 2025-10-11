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
using Excel = Microsoft.Office.Interop.Excel; 
using ClosedXML.Excel;
using System.IO;
namespace DuLich.UserControls
{
    public partial class quanlykhachhang : UserControl
    {
        string connectionString = @"Data Source=NguyenCongToan\SQLEXPRESS;Initial Catalog=DuLich;Integrated Security=True;TrustServerCertificate=True";
        public quanlykhachhang()
        {
            InitializeComponent();
        }

        private void quanlykhachhang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {

            string query = "SELECT * FROM KhachHang";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    kh_hienThiKH.DataSource = dt; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void kh_hienThiKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void themKH_Click(object sender, EventArgs e)
        {
            string tenKhachHang = txtTenKhachHang.Text.Trim();
            string soDienThoai = txtSoDienThoai.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO KhachHang (SoDienThoai, TenKhachHang) VALUES (@SoDienThoai, @TenKhachHang)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                        cmd.Parameters.AddWithValue("@TenKhachHang", tenKhachHang);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); 

                            txtTenKhachHang.Text = "";
                            txtSoDienThoai.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Thêm khách hàng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void xoaKH_Click(object sender, EventArgs e)
        {
            if (kh_hienThiKH.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để lưu thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (kh_hienThiKH.CurrentRow != null) 
            {
                string soDienThoai = kh_hienThiKH.CurrentRow.Cells["SoDienThoai"].Value.ToString();

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa khách hàng có SĐT: {soDienThoai}?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM KhachHang WHERE SoDienThoai = @SoDienThoai";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadData(); 
                                }
                                else
                                {
                                    MessageBox.Show("Không thể xóa khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void luuKH_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    foreach (DataGridViewRow row in kh_hienThiKH.Rows)
                    {
                        if (row.IsNewRow) continue; 

                        string soDienThoai = row.Cells["SoDienThoai"].Value?.ToString();
                        string tenKhachHang = row.Cells["TenKhachHang"].Value?.ToString();

                        if (!string.IsNullOrEmpty(soDienThoai) && !string.IsNullOrEmpty(tenKhachHang))
                        {
                            string query = "UPDATE KhachHang SET TenKhachHang = @TenKhachHang WHERE SoDienThoai = @SoDienThoai";
                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                                cmd.Parameters.AddWithValue("@TenKhachHang", tenKhachHang);

                                cmd.ExecuteNonQuery(); 
                            }
                        }
                    }

                    MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dskh_timKiem_Click(object sender, EventArgs e)
        {
            string soDienThoai = txtSoDienThoai.Text.Trim();
            string tenKhachHang = txtTenKhachHang.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM KhachHang WHERE 1=1";

                    if (!string.IsNullOrEmpty(soDienThoai))
                    {
                        query += " AND SoDienThoai LIKE @SoDienThoai";
                    }
                    if (!string.IsNullOrEmpty(tenKhachHang))
                    {
                        query += " AND TenKhachHang LIKE @TenKhachHang";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(soDienThoai))
                        {
                            cmd.Parameters.AddWithValue("@SoDienThoai", "%" + soDienThoai + "%");
                        }
                        if (!string.IsNullOrEmpty(tenKhachHang))
                        {
                            cmd.Parameters.AddWithValue("@TenKhachHang", "%" + tenKhachHang + "%");
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        kh_hienThiKH.DataSource = dt; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void xuatExcel_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM QuanLyLichTrinh";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        var ws = wb.Worksheets.Add(dt, "QuanLyLichTrinh");

                        SaveFileDialog saveFileDialog = new SaveFileDialog
                        {
                            Filter = "Excel Files|*.xlsx",
                            Title = "Lưu file Excel",
                            FileName = "QuanLyLichTrinh.xlsx"
                        };

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            wb.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
