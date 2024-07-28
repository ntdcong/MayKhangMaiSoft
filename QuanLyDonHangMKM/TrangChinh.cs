using QuanLyDonHangMKM.CongTy;

namespace QuanLyDonHangMKM
{
    public partial class TrangChinh : Form
    {
        public TrangChinh()
        {
            InitializeComponent();
        }

        private void TrangChinh_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DanhSachCongTy formDanhSachCongTy = new DanhSachCongTy();
            formDanhSachCongTy.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DanhSachTrai formDanhSachTrai = new DanhSachTrai();
            formDanhSachTrai.ShowDialog();
        }
    }
}
