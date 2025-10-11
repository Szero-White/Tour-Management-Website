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
    public partial class quanlynhanvien : UserControl
    {
        string connectionString = @"Data Source=NguyenCongToan\SQLEXPRESS;Initial Catalog=DuLich;Integrated Security=True;TrustServerCertificate=True";
        public quanlynhanvien()
        {
            InitializeComponent();
            LoadTaiKhoanNhanVien();
        }

        private void LoadTaiKhoanNhanVien()
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TaiKhoan, MatKhau FROM TaiKhoanDuLich";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

            // Thêm cột ẩn để lưu TaiKhoan gốc
            dataTable.Columns.Add("TaiKhoanGoc", typeof(string));
            foreach (DataRow row in dataTable.Rows)
            {
                row["TaiKhoanGoc"] = row["TaiKhoan"]; 
            }

            hienThiTKNhanVien.DataSource = dataTable;
            hienThiTKNhanVien.Columns["TaiKhoan"].HeaderText = "Tên Đăng Nhập";
            hienThiTKNhanVien.Columns["MatKhau"].HeaderText = "Mật Khẩu";
            hienThiTKNhanVien.Columns["TaiKhoanGoc"].Visible = false; 
        }

        private void hienThiTKNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = hienThiTKNhanVien.Rows[e.RowIndex];
                string taiKhoan = row.Cells["TaiKhoan"].Value.ToString();
                string matKhau = row.Cells["MatKhau"].Value.ToString();

                MessageBox.Show($"Tài khoản: {taiKhoan}\nMật khẩu: {matKhau}", "Thông tin tài khoản");
            }
        }

        private void themNV_Click(object sender, EventArgs e)
        {
            string taiKhoanMoi = tenNV.Text.Trim();
            string matKhauMoi = matKhauNhanVien.Text.Trim();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO TaiKhoanDuLich (TaiKhoan, MatKhau) VALUES (@TaiKhoan, @MatKhau)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (string.IsNullOrEmpty(taiKhoanMoi) || string.IsNullOrEmpty(matKhauMoi))
                    {
                        MessageBox.Show("Vui lòng nhập cả tài khoản và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    command.Parameters.AddWithValue("@TaiKhoan", taiKhoanMoi);
                    command.Parameters.AddWithValue("@MatKhau", matKhauMoi);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    connection.Close();

                    tenNV.Text = "";
                    matKhauNhanVien.Text = "";
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTaiKhoanNhanVien(); 
                    }
                    else
                    {
                        MessageBox.Show("Thêm tài khoản thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void xoaNV_Click(object sender, EventArgs e)
        {
            if (hienThiTKNhanVien.CurrentRow != null) 
            {
                string taiKhoan = hienThiTKNhanVien.CurrentRow.Cells["TaiKhoan"].Value.ToString();

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản '{taiKhoan}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM TaiKhoanDuLich WHERE TaiKhoan = @TaiKhoan";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);

                            connection.Open();
                            int rowsAffected = command.ExecuteNonQuery();
                            connection.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadTaiKhoanNhanVien(); 
                            }
                            else
                            {
                                MessageBox.Show("Không thể xóa tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void luuNV_Click(object sender, EventArgs e)
        {
            hienThiTKNhanVien.EndEdit();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    foreach (DataGridViewRow row in hienThiTKNhanVien.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string taiKhoanMoi = row.Cells["TaiKhoan"].Value?.ToString();
                        string matKhauMoi = row.Cells["MatKhau"].Value?.ToString();
                        string taiKhoanCu = row.Cells["TaiKhoanGoc"].Value?.ToString(); 

                        if (!string.IsNullOrEmpty(taiKhoanMoi) && !string.IsNullOrEmpty(matKhauMoi))
                        {
                            if (taiKhoanMoi != taiKhoanCu)
                            {
                                string deleteQuery = "DELETE FROM TaiKhoanDuLich WHERE TaiKhoan = @TaiKhoanCu";
                                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn))
                                {
                                    deleteCmd.Parameters.AddWithValue("@TaiKhoanCu", taiKhoanCu);
                                    deleteCmd.ExecuteNonQuery();
                                }

                                string insertQuery = "INSERT INTO TaiKhoanDuLich (TaiKhoan, MatKhau) VALUES (@TaiKhoan, @MatKhau)";
                                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                                {
                                    insertCmd.Parameters.AddWithValue("@TaiKhoan", taiKhoanMoi);
                                    insertCmd.Parameters.AddWithValue("@MatKhau", matKhauMoi);
                                    insertCmd.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                string updateQuery = "UPDATE TaiKhoanDuLich SET MatKhau = @MatKhau WHERE TaiKhoan = @TaiKhoan";
                                using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                                {
                                    updateCmd.Parameters.AddWithValue("@TaiKhoan", taiKhoanMoi);
                                    updateCmd.Parameters.AddWithValue("@MatKhau", matKhauMoi);
                                    updateCmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    MessageBox.Show("Lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadTaiKhoanNhanVien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi: {ex.Message}\nStack Trace: {ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
