using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace DuLich.UserControls
{
    public partial class thongke : UserControl
    {
        private string connectionString = @"Data Source=NguyenCongToan\SQLEXPRESS;Initial Catalog=DuLich;Integrated Security=True;TrustServerCertificate=True";

        public thongke()
        {
            InitializeComponent();
        }
        private void thongke_Load(object sender, EventArgs e)
        {
            numericUpDownNam.Minimum = 2000;
            numericUpDownNam.Maximum = 2100;
            numericUpDownNam.Value = 2025;

            numericUpDownThang.Minimum = -1;
            numericUpDownThang.Maximum = 12;
            numericUpDownThang.Value = 0;

            var chart1 = new Chart();
            chart1.Dock = DockStyle.Fill;

            var chartArea = new ChartArea("MainArea");
            chart1.ChartAreas.Add(chartArea);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    t.LoaiTour, 
                    SUM(qlt.SoNguoi) AS SoLuongNguoi, 
                    SUM(ISNULL(t.GiaTour, 0) * ISNULL(qlt.SoNguoi, 0)) AS TongTien
                FROM 
                    Tour t
                JOIN 
                    QuanLyLichTrinh qlt ON t.MaTour = qlt.MaTour
                WHERE 
                    YEAR(t.NgayDi) = 2025
                    AND qlt.TrangThaiTour = N'Đã thanh toán'
                GROUP BY 
                    t.LoaiTour
                ORDER BY 
                    TongTien DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    var seriesDoanhThu = new Series("Doanh thu");
                    seriesDoanhThu.ChartType = SeriesChartType.Column;
                    seriesDoanhThu.Color = System.Drawing.Color.PeachPuff;

                    var seriesSoNguoi = new Series("Số Người");
                    seriesSoNguoi.ChartType = SeriesChartType.Line;
                    seriesSoNguoi.Color = System.Drawing.Color.Red;
                    seriesSoNguoi.YAxisType = AxisType.Secondary;
                    seriesSoNguoi.BorderWidth = 3;

                    foreach (DataRow row in dt.Rows)
                    {
                        string loaiTour = row["LoaiTour"].ToString();
                        decimal tongTien = Convert.ToDecimal(row["TongTien"]);
                        int soNguoi = Convert.ToInt32(row["SoLuongNguoi"]);

                        seriesDoanhThu.Points.AddXY(loaiTour, tongTien);
                        seriesSoNguoi.Points.AddXY(loaiTour, soNguoi);
                    }

                    chart1.Series.Add(seriesDoanhThu);
                    chart1.Series.Add(seriesSoNguoi);

                    chart1.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;
                    chart1.ChartAreas[0].AxisY2.Title = "Số Người";

                    System.Windows.Forms.DataVisualization.Charting.Legend legend = new System.Windows.Forms.DataVisualization.Charting.Legend("Legend");
                    legend.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
                    chart1.Legends.Add(legend);
                    seriesDoanhThu.Legend = "Legend";
                    seriesSoNguoi.Legend = "Legend";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            panel1.Controls.Clear();
            panel1.Controls.Add(chart1);
        }

        private void LoadTourRevenueData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT 
                                t.LoaiTour, 
                                SUM(qlt.SoNguoi) AS SoLuongNguoi, 
                                SUM(t.GiaTour * qlt.SoNguoi) AS TongTien
                            FROM 
                                Tour t
                            JOIN 
                                QuanLyLichTrinh qlt ON t.MaTour = qlt.MaTour
                            WHERE 
                                qlt.TrangThaiTour = N'Đã thanh toán' -- Chỉ lấy các tour đã thanh toán
                            GROUP BY 
                                t.LoaiTour
                            ORDER BY 
                                TongTien DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.Columns.Clear();

                    DataGridViewTextBoxColumn colLoaiTour = new DataGridViewTextBoxColumn();
                    colLoaiTour.DataPropertyName = "LoaiTour";
                    colLoaiTour.HeaderText = "Loại Tour";
                    colLoaiTour.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridView1.Columns.Add(colLoaiTour);

                    DataGridViewTextBoxColumn colSoLuongNguoi = new DataGridViewTextBoxColumn();
                    colSoLuongNguoi.DataPropertyName = "SoLuongNguoi";
                    colSoLuongNguoi.HeaderText = "Số Lượng Người";
                    colSoLuongNguoi.Width = 120;
                    dataGridView1.Columns.Add(colSoLuongNguoi);

                    DataGridViewTextBoxColumn colTongTien = new DataGridViewTextBoxColumn();
                    colTongTien.DataPropertyName = "TongTien";
                    colTongTien.HeaderText = "Tổng Tiền ($)";
                    colTongTien.DefaultCellStyle.Format = "N0";
                    colTongTien.Width = 150;
                    dataGridView1.Columns.Add(colTongTien);

                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void bctk_xacNhan_Click(object sender, EventArgs e)
        {
            int thang = (int)numericUpDownThang.Value;
            int nam = (int)numericUpDownNam.Value;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
            SELECT 
                t.LoaiTour, 
                SUM(qlt.SoNguoi) AS SoLuongNguoi, 
                SUM(ISNULL(t.GiaTour, 0) * ISNULL(qlt.SoNguoi, 0)) AS TongTien
            FROM 
                Tour t
            JOIN 
                QuanLyLichTrinh qlt ON t.MaTour = qlt.MaTour
            WHERE 
                (@Thang = 0 OR MONTH(t.NgayDi) = @Thang)
                AND (@Nam = 0 OR YEAR(t.NgayDi) = @Nam)
                AND qlt.TrangThaiTour = N'Đã thanh toán' -- Chỉ lấy các tour đã thanh toán
            GROUP BY 
                t.LoaiTour
            ORDER BY 
                TongTien DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Thang", thang);
                cmd.Parameters.AddWithValue("@Nam", nam);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu phù hợp với tháng/năm đã chọn!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel1.Controls.Clear();
                    dataGridView1.DataSource = null;
                    return;
                }

                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns.Clear();

                DataGridViewTextBoxColumn colLoaiTour = new DataGridViewTextBoxColumn();
                colLoaiTour.DataPropertyName = "LoaiTour";
                colLoaiTour.HeaderText = "Loại Tour";
                colLoaiTour.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns.Add(colLoaiTour);

                DataGridViewTextBoxColumn colSoLuongNguoi = new DataGridViewTextBoxColumn();
                colSoLuongNguoi.DataPropertyName = "SoLuongNguoi";
                colSoLuongNguoi.HeaderText = "Số Lượng Người";
                colSoLuongNguoi.Width = 120;
                dataGridView1.Columns.Add(colSoLuongNguoi);

                DataGridViewTextBoxColumn colTongTien = new DataGridViewTextBoxColumn();
                colTongTien.DataPropertyName = "TongTien";
                colTongTien.HeaderText = "Tổng Tiền";
                colTongTien.DefaultCellStyle.Format = "N0";
                colTongTien.Width = 150;
                dataGridView1.Columns.Add(colTongTien);

                dataGridView1.DataSource = dt;

                Chart chart1 = new Chart();
                chart1.Dock = DockStyle.Fill;

                ChartArea chartArea = new ChartArea("MainArea");
                chart1.ChartAreas.Add(chartArea);

                Series seriesDoanhThu = new Series("Doanh thu");
                seriesDoanhThu.ChartType = SeriesChartType.Column;
                seriesDoanhThu.Color = System.Drawing.Color.PeachPuff;

                Series seriesSoNguoi = new Series("Số Người");
                seriesSoNguoi.ChartType = SeriesChartType.Line;
                seriesSoNguoi.Color = System.Drawing.Color.Red;
                seriesSoNguoi.YAxisType = AxisType.Secondary;
                seriesSoNguoi.BorderWidth = 3;

                foreach (DataRow row in dt.Rows)
                {
                    string loaiTour = row["LoaiTour"].ToString();
                    decimal tongTien = Convert.ToDecimal(row["TongTien"]);
                    int soNguoi = Convert.ToInt32(row["SoLuongNguoi"]);

                    seriesDoanhThu.Points.AddXY(loaiTour, tongTien);
                    seriesSoNguoi.Points.AddXY(loaiTour, soNguoi);
                }

                chart1.Series.Add(seriesDoanhThu);
                chart1.Series.Add(seriesSoNguoi);

                chart1.ChartAreas[0].AxisY2.Enabled = AxisEnabled.True;
                chart1.ChartAreas[0].AxisY2.Title = "Số Người";

                System.Windows.Forms.DataVisualization.Charting.Legend legend = new System.Windows.Forms.DataVisualization.Charting.Legend("Legend");
                legend.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
                chart1.Legends.Add(legend);
                seriesDoanhThu.Legend = "Legend";
                seriesSoNguoi.Legend = "Legend";

                panel1.Controls.Clear();
                panel1.Controls.Add(chart1);
            }
        }
    }

}

