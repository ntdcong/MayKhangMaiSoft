using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyDonHangMKM.CongTy
{
    public partial class DanhSachCongTy : Form
    {
        private string connectionString = "Data Source=DC-LAPTOP\\SQLEXPRESS;Initial Catalog=QuanLyDonDatHang;Integrated Security=True";
        private bool buttonsEnabled = false;

        public DanhSachCongTy()
        {
            InitializeComponent();
            InitializeListView();  // Thêm phương thức khởi tạo cột cho ListView
            LoadCongTyList();
            SetButtonsEnabled(false);
            listCongTy.SelectedIndexChanged += new EventHandler(listCongTy_SelectedIndexChanged);  // Gán sự kiện
        }

        private void SetButtonsEnabled(bool enabled)
        {
            bntXoa.Enabled = enabled;
            bntSua.Enabled = enabled;
            bntThem.Enabled = enabled;
        }

        private void InitializeListView()
        {
            listCongTy.Columns.Add("Mã", 50);
            listCongTy.Columns.Add("Mã Số Thuế", 100);
            listCongTy.Columns.Add("Tên Công Ty", 200);
            listCongTy.Columns.Add("Địa Chỉ", 300);
        }

        private void LoadCongTyList()
        {
            listCongTy.Items.Clear();  // Sử dụng Items.Clear để xóa các mục hiện tại

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM CongTy";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["MaCongTy"].ToString());
                            item.SubItems.Add(reader["MaSoThue"].ToString());
                            item.SubItems.Add(reader["TenCongTy"].ToString());
                            item.SubItems.Add(reader["DiaChi"].ToString());
                            listCongTy.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSoThue.Text) || string.IsNullOrEmpty(txtTenCongTy.Text) || string.IsNullOrEmpty(txtDiaChiCongTy.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin công ty.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO CongTy (MaSoThue, TenCongTy, DiaChi) VALUES (@MaSoThue, @TenCongTy, @DiaChi)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaSoThue", txtMaSoThue.Text);
                    cmd.Parameters.AddWithValue("@TenCongTy", txtTenCongTy.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChiCongTy.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Thêm công ty thành công!");
            LoadCongTyList();
            ClearInputFields();
        }

        private void ClearInputFields()
        {
            txtMaCongTy.Clear();
            txtMaSoThue.Clear();
            txtTenCongTy.Clear();
            txtDiaChiCongTy.Clear();
        }

        private void listCongTy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listCongTy.SelectedItems.Count > 0)
            {
                ListViewItem item = listCongTy.SelectedItems[0];
                txtMaCongTy.Text = item.SubItems[0].Text;
                txtMaSoThue.Text = item.SubItems[1].Text;
                txtTenCongTy.Text = item.SubItems[2].Text;
                txtDiaChiCongTy.Text = item.SubItems[3].Text;
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            if (listCongTy.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một công ty để sửa.");
                return;
            }

            int maCongTy = int.Parse(listCongTy.SelectedItems[0].Text);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE CongTy SET MaSoThue = @MaSoThue, TenCongTy = @TenCongTy, DiaChi = @DiaChi WHERE MaCongTy = @MaCongTy";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaCongTy", maCongTy);
                    cmd.Parameters.AddWithValue("@MaSoThue", txtMaSoThue.Text);
                    cmd.Parameters.AddWithValue("@TenCongTy", txtTenCongTy.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChiCongTy.Text);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Cập nhật công ty thành công!");
            LoadCongTyList();
            ClearInputFields();
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            if (listCongTy.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một công ty để xóa.");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa công ty này?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int maCongTy = int.Parse(listCongTy.SelectedItems[0].Text);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM CongTy WHERE MaCongTy = @MaCongTy";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaCongTy", maCongTy);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Xóa công ty thành công!");
                LoadCongTyList();
                ClearInputFields();
            }
        }

        private void bntLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputFields();
            LoadCongTyList();
        }

        private void bntQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntMoKhoa_Click(object sender, EventArgs e)
        {
            buttonsEnabled = !buttonsEnabled;
            SetButtonsEnabled(buttonsEnabled);
        }
    }
}
