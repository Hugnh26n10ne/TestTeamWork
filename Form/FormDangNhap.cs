using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyDiemSinhVien
{
    public partial class FormDangNhap : Form
    {
        public SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public FormDangNhap()
        {
            InitializeComponent();
        }
        public void AuthoLogin()
        {
            try
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_AuthoLogin";
                cmd.Parameters.AddWithValue("@tai_khoan", tbx_TaiKhoan.Text);
                cmd.Parameters.AddWithValue("@mat_khau", tbx_MatKhau.Text);
                cmd.Connection = conn;

                object kq = cmd.ExecuteScalar();
                int ketqua = Convert.ToInt32(kq);

                if (ketqua == 0)
                {
                    MessageBox.Show($"Chào mừng User: {tbx_TaiKhoan.Text} đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (ketqua == 1)
                {
                    MessageBox.Show($"Chào mừng Giáo viên: {tbx_TaiKhoan.Text} đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (ketqua == 2)
                {
                    MessageBox.Show("Chào mừng Admin đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (ketqua == 3)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbx_TaiKhoan.Text = "";
                    tbx_MatKhau.Text = "";
                    tbx_TaiKhoan.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbx_TaiKhoan.Text = "";
                    tbx_MatKhau.Text = "";
                    tbx_TaiKhoan.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
        
        public int GetLevel(string tai_khoan)
        {
            int ketQua = 0;

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = "SELECT idPer FROM [73DCTT23_QLDiemSV].[dbo].[User] WHERE [tai_khoan] = @tai_khoan";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tai_khoan", tai_khoan);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Di chuyển con trỏ đến hàng đầu tiên
                        {
                            // Đọc giá trị từ cột "idPer"
                            ketQua = reader.GetInt32(reader.GetOrdinal("idPer"));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Đảm bảo rằng kết nối được đóng dù có lỗi hay không
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return ketQua;
        }

        private void ReadSettings()
        {
            if (Properties.Settings.Default.remember == true)
            {
                tbx_TaiKhoan.Text = Properties.Settings.Default.tai_khoan;
                tbx_MatKhau.Text = Properties.Settings.Default.mat_khau;
                cbx_GhiNho.Checked = true;
            }
            else
            {
                tbx_TaiKhoan.Text = "";
                tbx_MatKhau.Text = "";
                cbx_GhiNho.Checked = false;
            }

        }
        private void SaveSettings(int level)
        {
            if (cbx_GhiNho.Checked)
            {
                Properties.Settings.Default.tai_khoan = tbx_TaiKhoan.Text;
                Properties.Settings.Default.mat_khau = tbx_MatKhau.Text;
                Properties.Settings.Default.remember = true;
                Properties.Settings.Default.level = level;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.tai_khoan = tbx_TaiKhoan.Text;
                Properties.Settings.Default.mat_khau = "";
                Properties.Settings.Default.remember = false;
                Properties.Settings.Default.level = level;
                Properties.Settings.Default.Save();
            }

        }


        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbx_TaiKhoan.Text))
            {
                MessageBox.Show("Không được để trống!");
                tbx_TaiKhoan.Focus();
            }
            if (string.IsNullOrEmpty(tbx_MatKhau.Text))
            {
                MessageBox.Show("Không được để trống!");
                tbx_MatKhau.Focus();
            }
            AuthoLogin();

            SaveSettings(GetLevel(tbx_TaiKhoan.Text));

        }

        private void pbx_Show_Click(object sender, EventArgs e)
        {
            pbx_Show.Hide();
            pbx_Hide.Show();
            tbx_MatKhau.UseSystemPasswordChar = true;
        }

        private void pbx_Hide_Click(object sender, EventArgs e)
        {
            pbx_Hide.Hide();
            pbx_Show.Show();
            tbx_MatKhau.UseSystemPasswordChar = false;
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            ReadSettings();
        }

        private void pbx_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy gọi theo số 09xxxxxx90 hoặc nhắn tin zalo theo số 09xxxxxx90 để được hỗ trợ!");
        }

        private void tbx_TaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
            tbx_TaiKhoan.SelectAll();
        }

        private void tbx_MatKhau_MouseClick(object sender, MouseEventArgs e)
        {
            tbx_MatKhau.SelectAll();
        }

        private void lb_DangKi_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangKi fdk = new FormDangKi();
            fdk.Show();
        }

        private void lb_QuenMK_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuenMK fqmk = new FormQuenMK();
            fqmk.Show();
        }
    }
}
