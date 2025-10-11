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
using ScottPlot.Colormaps;
using ScottPlot.Palettes;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DuLich.UserControls
{
    public partial class dattourdulich : UserControl
    {
        string tenKhachHang = "";
        string soDienThoai = "";
        int maTour = 0;
        string tenTour = "";
        int soNguoi = 0;
        DateTime thoiGianDat;

        string connectionString = @"Data Source=NguyenCongToan\SQLEXPRESS;Initial Catalog=DuLich;Integrated Security=True;TrustServerCertificate=True";
        public dattourdulich()
        {
            InitializeComponent();
            LoadData();
            dataGridView2.CellClick += dataGridView2_CellClick;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
            }
        }
        private void LoadData()
        {

            string query = "SELECT MaTour, TenTour, NgayDi, NgayKetThuc, LoaiTour, GiaTour, PhuongTien, HinhAnh1, HinhAnh2 FROM Tour";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    hienThiTour.DataSource = dt;

                    hienThiTour.Columns["MaTour"].HeaderText = "Mã Tour";
                    hienThiTour.Columns["TenTour"].HeaderText = "Tên Tour";
                    hienThiTour.Columns["GiaTour"].HeaderText = "Giá Tour($)";
                    hienThiTour.Columns["PhuongTien"].HeaderText = "Phương Tiện";
                    hienThiTour.Columns["LoaiTour"].HeaderText = "Loại Tour";
                    hienThiTour.Columns["NgayDi"].HeaderText = "Ngày Đi";
                    hienThiTour.Columns["NgayKetThuc"].HeaderText = "Ngày Kết Thúc";
                    hienThiTour.Columns["HinhAnh1"].Visible = false;
                    hienThiTour.Columns["HinhAnh2"].Visible = false;

                }

                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void SaveDatagridView2()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction transaction = conn.BeginTransaction())
                {
                    try
                    {

                        string queryLichTrinh = @"
                            INSERT INTO QuanLyLichTrinh 
                            (SoDienThoai, TenKhachHang, MaTour, TenTour, SoNguoi, ThoiGianDat, TrangThaiTour) 
                            VALUES (@SoDienThoai, @TenKhachHang, @MaTour, @TenTour, @SoNguoi, @ThoiGianDat, @TrangThaiTour)";

                        SqlCommand cmdLichTrinh = new SqlCommand(queryLichTrinh, conn, transaction);
                        cmdLichTrinh.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                        cmdLichTrinh.Parameters.AddWithValue("@TenKhachHang", tenKhachHang);
                        cmdLichTrinh.Parameters.AddWithValue("@MaTour", maTour);
                        cmdLichTrinh.Parameters.AddWithValue("@TenTour", tenTour);
                        cmdLichTrinh.Parameters.AddWithValue("@SoNguoi", soNguoi);
                        cmdLichTrinh.Parameters.AddWithValue("@ThoiGianDat", thoiGianDat);
                        cmdLichTrinh.Parameters.AddWithValue("@TrangThaiTour", "Chờ xác nhận");
                        cmdLichTrinh.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Đặt tour và lưu thông tin khách hàng thành công!");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
        }



        private void hienThiTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string query = "SELECT MaTour, TenTour, NgayDi, NgayKetThuc, LoaiTour, GiaTour, PhuongTien, HinhAnh1, HinhAnh2 FROM Tour";
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = hienThiTour.Rows[e.RowIndex];

                string imagePath1 = row.Cells["HinhAnh1"].Value.ToString();
                string imagePath2 = row.Cells["HinhAnh2"].Value.ToString();

                picImage1.Image = LoadImage(imagePath1);
                picImage2.Image = LoadImage(imagePath2);
            }
        }

        private Image LoadImage(string path)
        {
            if (File.Exists(path))
            {
                return Image.FromFile(path);
            }
            else
            {
                return null;
            }
        }

        private void locKQ_Click(object sender, EventArgs e)
        {
            string query = "SELECT MaTour, TenTour, NgayDi, NgayKetThuc, LoaiTour, GiaTour, PhuongTien, HinhAnh1, HinhAnh2 FROM Tour where 1=1";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                if (phuongTien.SelectedItem != null && phuongTien.SelectedItem.ToString() != "")
                {
                    query += " AND PhuongTien = @PhuongTien";
                    cmd.Parameters.AddWithValue("@PhuongTien", phuongTien.SelectedItem.ToString());
                }


                if (loaiTour.SelectedItem != null && loaiTour.SelectedItem.ToString() != "")
                {
                    string selectedLoaiTour = loaiTour.SelectedItem.ToString();
                    query += " AND LoaiTour = @LoaiTour";
                    cmd.Parameters.AddWithValue("@LoaiTour", selectedLoaiTour);

                    // Áp dụng điều kiện về Giá Tour theo loại tour
                    switch (selectedLoaiTour)
                    {
                        case "Cao Cấp":
                            query += " AND GiaTour > @GiaTourMin";
                            cmd.Parameters.AddWithValue("@GiaTourMin", 400);
                            break;
                        case "Tiêu Chuẩn":
                            query += " AND GiaTour BETWEEN @GiaTourMin AND @GiaTourMax";
                            cmd.Parameters.AddWithValue("@GiaTourMin", 200);
                            cmd.Parameters.AddWithValue("@GiaTourMax", 400);
                            break;
                        case "Tiết Kiệm":
                            query += " AND GiaTour < @GiaTourMax";
                            cmd.Parameters.AddWithValue("@GiaTourMax", 200);
                            break;
                    }
                }


                cmd.CommandText = query;

                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    hienThiTour.DataSource = dt;

                    hienThiTour.Columns["MaTour"].HeaderText = "Mã Tour";
                    hienThiTour.Columns["TenTour"].HeaderText = "Tên Tour";
                    hienThiTour.Columns["GiaTour"].HeaderText = "Giá Tour($)";
                    hienThiTour.Columns["PhuongTien"].HeaderText = "Phương Tiện";
                    hienThiTour.Columns["LoaiTour"].HeaderText = "Loại Tour";
                    hienThiTour.Columns["NgayDi"].HeaderText = "Ngày Đi";
                    hienThiTour.Columns["NgayKetThuc"].HeaderText = "Ngày Kết Thúc";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        private bool KiemTraTrungSoDienThoai(string soDienThoai, int maTour)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM QuanLyLichTrinh WHERE SoDienThoai = @SoDienThoai AND MaTour = @MaTour";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                cmd.Parameters.AddWithValue("@MaTour", maTour);

                try
                {
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi kiểm tra số điện thoại: " + ex.Message);
                    return true;
                }
            }
        }

        private void dtdl_datTour_Click(object sender, EventArgs e)
        {
            string tenKhachHang = txtTenKhachHang.Text;
            string soDienThoai = txtSoDienThoai.Text;
            int maTour;
            int soNguoi;

            if (!int.TryParse(cboMaTour.Text, out maTour) || !int.TryParse(numSoNguoi.Text, out soNguoi))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng mã tour và số người!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (soNguoi <= 0)
            {
                MessageBox.Show("Vui lòng nhập số người lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenTour = GetTourNameFromDatabase(maTour);

            if (string.IsNullOrEmpty(tenTour))
            {
                MessageBox.Show("Mã tour không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string thoiGianDat = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            if (KiemTraTrungSoDienThoai(soDienThoai, maTour))
            {
                MessageBox.Show("Số điện thoại này đã đặt tour này rồi!\nVui lòng kiểm tra lại hoặc chọn số khác.",
                               "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveDatagridView2();
            LoadDataToDataGridView();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM KhachHang WHERE SoDienThoai = @SoDienThoai";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);

                int count = (int)checkCmd.ExecuteScalar();

                if (count == 0)
                {
                    string insertQuery = "INSERT INTO KhachHang (SoDienThoai, TenKhachHang) VALUES (@SoDienThoai, @TenKhachHang)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    insertCmd.Parameters.AddWithValue("@TenKhachHang", tenKhachHang);
                    insertCmd.ExecuteNonQuery();
                }
                conn.Close();
            }

            txtTenKhachHang.Clear();
            txtSoDienThoai.Clear();
            cboMaTour.Text = "";
            numSoNguoi.Value = 0;
            txtTenKhachHang.Focus();
        }

        private string GetTourNameFromDatabase(int maTour)
        {
            string tenTour = string.Empty;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT TenTour FROM Tour WHERE MaTour = @MaTour";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaTour", maTour);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    tenTour = result.ToString();
                }
            }
            return tenTour;
        }

        private void loaiTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (loaiTour.SelectedItem != null)
            {
                string selectedLoaiTour = loaiTour.SelectedItem.ToString();
                switch (selectedLoaiTour)
                {
                    case "Cao Cấp":
                        giaTour.SelectedItem = "Trên $400";
                        break;
                    case "Tiêu Chuẩn":
                        giaTour.SelectedItem = "Từ $200 đến $400";
                        break;
                    case "Tiết Kiệm":
                        giaTour.SelectedItem = "Dưới $200";
                        break;
                }
            }
        }


        private void giaTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (giaTour.SelectedItem != null)
            {
                string selectedGiaTour = giaTour.SelectedItem.ToString();

                switch (selectedGiaTour)
                {
                    case "Trên $400":
                        loaiTour.SelectedItem = "Cao Cấp";
                        break;
                    case "Từ $200 đến $400":
                        loaiTour.SelectedItem = "Tiêu Chuẩn";
                        break;
                    case "Dưới $200":
                        loaiTour.SelectedItem = "Tiết Kiệm";
                        break;
                }
            }
        }

        private void txtTenKhachHang_TextChanged(object sender, EventArgs e)
        {
            tenKhachHang = txtTenKhachHang.Text.Trim();
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            soDienThoai = txtSoDienThoai.Text.Trim();
        }



        private void cboMaTour_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cboMaTour.Text, out maTour))
            {
                foreach (DataGridViewRow row in hienThiTour.Rows)
                {
                    if (row.Cells["MaTour"].Value != null && (int)row.Cells["MaTour"].Value == maTour)
                    {
                        tenTour = row.Cells["TenTour"].Value.ToString();
                        break;
                    }
                }
                thoiGianDat = DateTime.Now;
            }
        }


        private void numSoNguoi_ValueChanged(object sender, EventArgs e)
        {
            soNguoi = (int)numSoNguoi.Value;
        }

        private int selectedRowIndex = -1;


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
            }
            LoadDataToDataGridView();
        }
        private void LoadDataToDataGridView()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT * FROM QuanLyLichTrinh ORDER BY ThoiGianDat DESC";  
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView2.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void huyVe_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex < 0 || selectedRowIndex >= dataGridView2.Rows.Count)
            {
                MessageBox.Show("Vui lòng chọn tour cần hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dataGridView2.Rows[selectedRowIndex];
            string soDienThoai = selectedRow.Cells[0].Value?.ToString();
            int maTour = Convert.ToInt32(selectedRow.Cells[2].Value);


            if (!CanCancelTour(soDienThoai, maTour))
            {
                MessageBox.Show("Không thể hủy tour này vì tour đã được xác nhận hoặc đang xử lý!",
                               "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy tour này?", "Xác nhận",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                if (DeleteFromDatabase(soDienThoai, maTour))
                {

                    dataGridView2.Rows.RemoveAt(selectedRowIndex);
                    MessageBox.Show("Đã hủy tour thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool CanCancelTour(string soDienThoai, int maTour)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT TrangThaiTour FROM QuanLyLichTrinh WHERE SoDienThoai = @SoDienThoai AND MaTour = @MaTour";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                cmd.Parameters.AddWithValue("@MaTour", maTour);

                try
                {
                    conn.Open();
                    string trangThai = cmd.ExecuteScalar()?.ToString();
                    return trangThai == "Chờ xác nhận";
                }
                catch
                {
                    return false;
                }
            }
        }

        private bool DeleteFromDatabase(string soDienThoai, int maTour)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM QuanLyLichTrinh WHERE SoDienThoai = @SoDienThoai AND MaTour = @MaTour";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                cmd.Parameters.AddWithValue("@MaTour", maTour);

                try
                {
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void dattourdulich_Load(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
        }
    }
}
