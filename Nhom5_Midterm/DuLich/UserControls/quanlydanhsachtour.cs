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
using OfficeOpenXml;
using System.IO;

namespace DuLich.UserControls
{
    public partial class quanlydanhsachtour : UserControl
    {
        public quanlydanhsachtour()
        {
            InitializeComponent();
        }

        private void quanlydanhsachtour_Load(object sender, EventArgs e)
        {
            LoadTourData();
        }
        string connectionString = @"Data Source=NguyenCongToan\SQLEXPRESS;Initial Catalog=DuLich;Integrated Security=True;TrustServerCertificate=True";
        private void LoadTourData()
        {

            string query = "SELECT MaTour, TenTour, GiaTour, PhuongTien, LoaiTour, NgayDi, NgayKetThuc, hinhanh1, hinhanh2 FROM Tour";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dst_hienThiTour.DataSource = dt;

                    dst_hienThiTour.Columns["MaTour"].HeaderText = "Mã Tour";
                    dst_hienThiTour.Columns["TenTour"].HeaderText = "Tên Tour";
                    dst_hienThiTour.Columns["GiaTour"].HeaderText = "Giá Tour($)";
                    dst_hienThiTour.Columns["PhuongTien"].HeaderText = "Phương Tiện";
                    dst_hienThiTour.Columns["LoaiTour"].HeaderText = "Loại Tour";
                    dst_hienThiTour.Columns["NgayDi"].HeaderText = "Ngày Đi";
                    dst_hienThiTour.Columns["NgayKetThuc"].HeaderText = "Ngày Kết Thúc";

                    dst_hienThiTour.Columns["HinhAnh1"].HeaderText = "Hình Ảnh 1";
                    dst_hienThiTour.Columns["HinhAnh2"].HeaderText = "Hình Ảnh 2";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
        }

        private void dst_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tenTour.Text) ||
                loaiTour.SelectedItem == null ||
                string.IsNullOrWhiteSpace(giaTour.Text) ||
                string.IsNullOrWhiteSpace(phuongTien.Text) ||
                ngayDi.Value == null ||
                ngayKetThuc.Value == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Tour (TenTour, NgayDi, NgayKetThuc, LoaiTour, GiaTour, PhuongTien, HinhAnh1, HinhAnh2) " +
                                   "VALUES (@TenTour, @NgayDi, @NgayKetThuc, @LoaiTour, @GiaTour, @PhuongTien, @HinhAnh1, @HinhAnh2)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TenTour", tenTour.Text);
                        cmd.Parameters.AddWithValue("@NgayDi", ngayDi.Value.Date);
                        cmd.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc.Value.Date);
                        cmd.Parameters.AddWithValue("@LoaiTour", loaiTour.SelectedItem.ToString());


                        string giaStr = giaTour.Text.Replace(" ", "").Replace(",", "").Trim();

                        int giaTourValue;
                        if (!int.TryParse(giaStr, out giaTourValue))
                        {
                            MessageBox.Show("Giá Tour không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        cmd.Parameters.AddWithValue("@GiaTour", giaTourValue);

                        cmd.Parameters.AddWithValue("@PhuongTien", phuongTien.SelectedItem.ToString());

                        cmd.Parameters.AddWithValue("@HinhAnh1", picHinhAnh1.Tag != null ? picHinhAnh1.Tag.ToString() : DBNull.Value);
                        cmd.Parameters.AddWithValue("@HinhAnh2", picHinhAnh2.Tag != null ? picHinhAnh2.Tag.ToString() : DBNull.Value);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm tour thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadTourData();

                        ClearForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearForm()
        {
            tenTour.Text = "";
            giaTour.Text = "";

            loaiTour.SelectedIndex = -1;
            phuongTien.SelectedIndex = -1;

            ngayDi.Value = DateTime.Now;
            ngayKetThuc.Value = DateTime.Now;

            picHinhAnh1.Image = null;
            picHinhAnh2.Image = null;
            picHinhAnh1.Tag = null;
            picHinhAnh2.Tag = null;
        }


        private void chonAnh1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Hình ảnh (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg",
                Title = "Chọn ảnh 1"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh1.ImageLocation = openFileDialog.FileName; 
                picHinhAnh1.Tag = openFileDialog.FileName; 
            }
        }

        private void chonAnh2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Hình ảnh (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg",
                Title = "Chọn ảnh 2"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh2.ImageLocation = openFileDialog.FileName; 
                picHinhAnh2.Tag = openFileDialog.FileName; 
            }
        }

        private void dst_xoa_Click(object sender, EventArgs e)
        {
            if (dst_hienThiTour.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để lưu thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int maTour = Convert.ToInt32(dst_hienThiTour.CurrentRow.Cells["MaTour"].Value);

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa tour có Mã Tour = {maTour} không?",
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
                        string query = "DELETE FROM Tour WHERE MaTour = @MaTour";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaTour", maTour);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa tour thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadTourData();
                            }
                            else
                            {
                                MessageBox.Show("Không thể xóa tour!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dst_luu_Click(object sender, EventArgs e)
        {
            if (dst_hienThiTour.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để lưu thay đổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Tour SET TenTour = @TenTour, NgayDi = @NgayDi, NgayKetThuc = @NgayKetThuc, " +
                                   "LoaiTour = @LoaiTour, GiaTour = @GiaTour, PhuongTien = @PhuongTien, " +
                                   "HinhAnh1 = @HinhAnh1, HinhAnh2 = @HinhAnh2 WHERE MaTour = @MaTour";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        DataGridViewRow row = dst_hienThiTour.CurrentRow;
                        int maTour = Convert.ToInt32(row.Cells["MaTour"].Value);
                        string tenTour = row.Cells["TenTour"].Value.ToString();
                        DateTime ngayDi = Convert.ToDateTime(row.Cells["NgayDi"].Value);
                        DateTime ngayKetThuc = Convert.ToDateTime(row.Cells["NgayKetThuc"].Value);
                        string loaiTour = row.Cells["LoaiTour"].Value.ToString();
                        int giaTour = Convert.ToInt32(row.Cells["GiaTour"].Value);
                        string phuongTien = row.Cells["PhuongTien"].Value.ToString();
                        string hinhAnh1 = row.Cells["HinhAnh1"].Value != null ? row.Cells["HinhAnh1"].Value.ToString() : null;
                        string hinhAnh2 = row.Cells["HinhAnh2"].Value != null ? row.Cells["HinhAnh2"].Value.ToString() : null;

                        cmd.Parameters.AddWithValue("@MaTour", maTour);
                        cmd.Parameters.AddWithValue("@TenTour", tenTour);
                        cmd.Parameters.AddWithValue("@NgayDi", ngayDi);
                        cmd.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);
                        cmd.Parameters.AddWithValue("@LoaiTour", loaiTour);
                        cmd.Parameters.AddWithValue("@GiaTour", giaTour);
                        cmd.Parameters.AddWithValue("@PhuongTien", phuongTien);
                        cmd.Parameters.AddWithValue("@HinhAnh1", (object)hinhAnh1 ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@HinhAnh2", (object)hinhAnh2 ?? DBNull.Value);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin tour thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadTourData();
                        }
                        else
                        {
                            MessageBox.Show("Không thể cập nhật dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dst_timKiem_Click(object sender, EventArgs e)
        {
            string ten = tenTour.Text.Trim();
            string loai = loaiTour.SelectedItem?.ToString();
            string phuongTienStr = phuongTien.SelectedItem?.ToString();
            string giaStr = giaTour.Text.Trim().Replace(",", "").Replace(" ", "");

            int giaTourInt;
            bool isGiaValid = int.TryParse(giaStr, out giaTourInt);

            string query = @"SELECT MaTour, TenTour, GiaTour, PhuongTien, LoaiTour, NgayDi, NgayKetThuc, hinhanh1, hinhanh2 
                     FROM Tour 
                     WHERE 1 = 1"; 

            List<SqlParameter> parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(ten))
            {
                query += " AND TenTour LIKE @TenTour";
                parameters.Add(new SqlParameter("@TenTour", "%" + ten + "%"));
            }

            if (!string.IsNullOrEmpty(loai))
            {
                query += " AND LoaiTour = @LoaiTour";
                parameters.Add(new SqlParameter("@LoaiTour", loai));
            }

            if (!string.IsNullOrEmpty(phuongTienStr))
            {
                query += " AND PhuongTien = @PhuongTien";
                parameters.Add(new SqlParameter("@PhuongTien", phuongTienStr));
            }

            if (isGiaValid)
            {
                query += " AND GiaTour = @GiaTour";
                parameters.Add(new SqlParameter("@GiaTour", giaTourInt));
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddRange(parameters.ToArray());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy tour phù hợp!", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    dst_hienThiTour.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dst_nhapExel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;



                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                    ExcelWorksheet sheet = package.Workbook.Worksheets[0];
                    int rowCount = sheet.Dimension.End.Row;

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        for (int row = 2; row <= rowCount; row++)
                        {
                            string tenTour = sheet.Cells[row, 1].Text;
                            DateTime ngayDi = DateTime.Parse(sheet.Cells[row, 2].Text);
                            DateTime ngayKetThuc = DateTime.Parse(sheet.Cells[row, 3].Text);
                            string loaiTour = sheet.Cells[row, 4].Text;
                            int giaTour = int.Parse(sheet.Cells[row, 5].Text);
                            string phuongTien = sheet.Cells[row, 6].Text;
                            string hinh1 = sheet.Cells[row, 7].Text;
                            string hinh2 = sheet.Cells[row, 8].Text;

                            string insertQuery = @"INSERT INTO Tour 
                        (TenTour, NgayDi, NgayKetThuc, LoaiTour, GiaTour, PhuongTien, HinhAnh1, HinhAnh2)
                        VALUES (@TenTour, @NgayDi, @NgayKetThuc, @LoaiTour, @GiaTour, @PhuongTien, @Hinh1, @Hinh2)";

                            using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@TenTour", tenTour);
                                cmd.Parameters.AddWithValue("@NgayDi", ngayDi);
                                cmd.Parameters.AddWithValue("@NgayKetThuc", ngayKetThuc);
                                cmd.Parameters.AddWithValue("@LoaiTour", loaiTour);
                                cmd.Parameters.AddWithValue("@GiaTour", giaTour);
                                cmd.Parameters.AddWithValue("@PhuongTien", phuongTien);
                                cmd.Parameters.AddWithValue("@Hinh1", hinh1);
                                cmd.Parameters.AddWithValue("@Hinh2", hinh2);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Nhập dữ liệu từ Excel thành công!", "Thông báo");
                    }
                }
            }
        }

    }
}

