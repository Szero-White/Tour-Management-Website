using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ScottPlot.Palettes;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace DuLich
{
    public partial class dangnhap : Form
    {
        SqlConnection sqlcon = null;
        public dangnhap()
        {
            InitializeComponent();
            mKhau.UseSystemPasswordChar = false;
            mKhau.KeyDown += mKhau_KeyDown;

        }


        private void dNhap_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=NguyenCongToan\SQLEXPRESS;Initial Catalog=DuLich;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlcon.Open();

                    string tk = tdn.Text.Trim();
                    string mk = mKhau.Text.Trim();

                    string query = "SELECT TaiKhoan FROM TaiKhoanDuLich WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau";
                    using (SqlCommand sqlcmd = new SqlCommand(query, sqlcon))
                    {
                        sqlcmd.Parameters.AddWithValue("@TaiKhoan", tk);
                        sqlcmd.Parameters.AddWithValue("@MatKhau", mk);

                        using (SqlDataReader reader = sqlcmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string role = reader["TaiKhoan"].ToString().Trim();

                                MessageBox.Show("Đăng Nhập Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                trangchu.loggedInUser = role.ToLower();

                                trangchu mainForm = new trangchu();
                                this.Hide();
                                mainForm.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                tdn.Text = "";
                                mKhau.Text = "";
                                tdn.Focus();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                mKhau.UseSystemPasswordChar = true;
            }
            else
            {
                mKhau.UseSystemPasswordChar = false;
            }
        }

        private void mKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dNhap.PerformClick();
            }
        }
    }
}
