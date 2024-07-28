using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyDonHangMKM.CongTy
{
    public partial class DanhSachTrai : Form
    {
        private string connectionString = "Data Source=DC-LAPTOP\\SQLEXPRESS;Initial Catalog=QuanLyDonDatHang;Integrated Security=True";
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private bool buttonsEnabled = false;

        public DanhSachTrai()
        {
            InitializeComponent();
            InitializeListView();
            SetButtonsEnabled(false);
            LoadTraiList();
            LoadCongTyList();
            cbTenCongTy.SelectedIndexChanged += cbTenCongTy_SelectedIndexChanged;
        }

        private void SetButtonsEnabled(bool enabled)
        {
            bntXoa.Enabled = enabled;
            bntSua.Enabled = enabled;
            bntThem.Enabled = enabled;
        }

        private void InitializeListView()
        {
            listTrai.Columns.Add("Mã Trại", 100);
            listTrai.Columns.Add("Tên Trại", 200);
            listTrai.Columns.Add("Địa Chỉ", 300);
            listTrai.Columns.Add("Mã Công Ty", 100);
            listTrai.Columns.Add("Tên Công Ty", 200);
        }

        private void LoadCongTyList()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MaCongTy, TenCongTy FROM CongTy";
                command = new SqlCommand(query, connection);
                adapter = new SqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                cbTenCongTy.DataSource = dataTable;
                cbTenCongTy.DisplayMember = "TenCongTy";
                cbTenCongTy.ValueMember = "MaCongTy";

                // Đặt SelectedIndex = -1 để không có mục nào được chọn ban đầu
                cbTenCongTy.SelectedIndex = -1;
            }
        }

        private void LoadTraiList(string maCongTy = null)
        {
            listTrai.Items.Clear();
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT t.MaTrai, t.TenTrai, t.DiaChi, t.MaCongTy, c.TenCongTy FROM Trai t INNER JOIN CongTy c ON t.MaCongTy = c.MaCongTy";

                if (!string.IsNullOrEmpty(maCongTy))
                {
                    query += " WHERE t.MaCongTy = @MaCongTy";
                }

                command = new SqlCommand(query, connection);

                if (!string.IsNullOrEmpty(maCongTy))
                {
                    command.Parameters.AddWithValue("@MaCongTy", maCongTy);
                }

                adapter = new SqlDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["MaTrai"].ToString());
                    item.SubItems.Add(row["TenTrai"].ToString());
                    item.SubItems.Add(row["DiaChi"].ToString());
                    item.SubItems.Add(row["MaCongTy"].ToString());
                    item.SubItems.Add(row["TenCongTy"].ToString());
                    listTrai.Items.Add(item);
                }
            }
            UpdateTongTrai();
        }

        private void UpdateTongTrai()
        {
            txtTongTrai.Text = listTrai.Items.Count.ToString();
        }

        private void ClearFields()
        {
            txtMaTrai.Clear();
            txtTenTrai.Clear();
            txtDiaChiTrai.Clear();
            cbTenCongTy.SelectedIndex = -1;
            txtMaCongTy.Clear();
        }

        private void cbTenCongTy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTenCongTy.SelectedValue != null)
            {
                string maCongTy = cbTenCongTy.SelectedValue.ToString();
                txtMaCongTy.Text = maCongTy;
                LoadTraiList(maCongTy);
            }
            else
            {
                txtMaCongTy.Text = string.Empty;
                LoadTraiList(); // Load tất cả trại nếu không có công ty nào được chọn
            }
        }

        private void listTrai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listTrai.SelectedItems.Count > 0)
            {
                ListViewItem item = listTrai.SelectedItems[0];
                txtMaTrai.Text = item.SubItems[0].Text;
                txtTenTrai.Text = item.SubItems[1].Text;
                txtDiaChiTrai.Text = item.SubItems[2].Text;
                txtMaCongTy.Text = item.SubItems[3].Text;
                cbTenCongTy.Text = item.SubItems[4].Text;
            }
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenTrai.Text) || string.IsNullOrWhiteSpace(txtDiaChiTrai.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Trai (TenTrai, DiaChi, MaCongTy) VALUES (@TenTrai, @DiaChi, @MaCongTy)";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TenTrai", txtTenTrai.Text);
                command.Parameters.AddWithValue("@DiaChi", txtDiaChiTrai.Text);
                command.Parameters.AddWithValue("@MaCongTy", cbTenCongTy.SelectedValue);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Thêm trại thành công!");
                    LoadTraiList();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Thêm trại thất bại!");
                }
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            if (listTrai.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn trại cần sửa!");
                return;
            }

            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Trai SET TenTrai = @TenTrai, DiaChi = @DiaChi, MaCongTy = @MaCongTy WHERE MaTrai = @MaTrai";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaTrai", txtMaTrai.Text);
                command.Parameters.AddWithValue("@TenTrai", txtTenTrai.Text);
                command.Parameters.AddWithValue("@DiaChi", txtDiaChiTrai.Text);
                command.Parameters.AddWithValue("@MaCongTy", cbTenCongTy.SelectedValue);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Sửa thông tin trại thành công!");
                    LoadTraiList();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Sửa thông tin trại thất bại!");
                }
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            if (listTrai.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn trại cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa trại này?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Trai WHERE MaTrai = @MaTrai";
                    command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaTrai", txtMaTrai.Text);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Xóa trại thành công!");
                        LoadTraiList();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Xóa trại thất bại!");
                    }
                }
            }
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

        private void bntLamMoi_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadTraiList();
        }

    }
}