namespace QuanLyDonHangMKM.CongTy
{
    partial class DanhSachTrai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bntMoKhoa = new Button();
            bntLamMoi = new Button();
            bntQuayLai = new Button();
            bntSua = new Button();
            bntXoa = new Button();
            bntThem = new Button();
            listTrai = new ListView();
            txtDiaChiTrai = new TextBox();
            txtTenTrai = new TextBox();
            txtMaTrai = new TextBox();
            txtMaCongTy = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbTenCongTy = new ComboBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            txtTongTrai = new TextBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // bntMoKhoa
            // 
            bntMoKhoa.BackColor = Color.Cyan;
            bntMoKhoa.ImeMode = ImeMode.NoControl;
            bntMoKhoa.Location = new Point(436, 317);
            bntMoKhoa.Name = "bntMoKhoa";
            bntMoKhoa.Size = new Size(140, 33);
            bntMoKhoa.TabIndex = 31;
            bntMoKhoa.Text = "MỞ KHÓA NÚT";
            bntMoKhoa.UseVisualStyleBackColor = false;
            bntMoKhoa.Click += bntMoKhoa_Click;
            // 
            // bntLamMoi
            // 
            bntLamMoi.ImeMode = ImeMode.NoControl;
            bntLamMoi.Location = new Point(860, 317);
            bntLamMoi.Name = "bntLamMoi";
            bntLamMoi.Size = new Size(95, 33);
            bntLamMoi.TabIndex = 30;
            bntLamMoi.Text = "LÀM MỚI";
            bntLamMoi.UseVisualStyleBackColor = true;
            bntLamMoi.Click += bntLamMoi_Click;
            // 
            // bntQuayLai
            // 
            bntQuayLai.ImeMode = ImeMode.NoControl;
            bntQuayLai.Location = new Point(989, 317);
            bntQuayLai.Name = "bntQuayLai";
            bntQuayLai.Size = new Size(95, 33);
            bntQuayLai.TabIndex = 29;
            bntQuayLai.Text = "QUAY LẠI";
            bntQuayLai.UseVisualStyleBackColor = true;
            bntQuayLai.Click += bntQuayLai_Click;
            // 
            // bntSua
            // 
            bntSua.BackColor = Color.Yellow;
            bntSua.ImeMode = ImeMode.NoControl;
            bntSua.Location = new Point(174, 317);
            bntSua.Name = "bntSua";
            bntSua.Size = new Size(95, 33);
            bntSua.TabIndex = 28;
            bntSua.Text = "SỬA";
            bntSua.UseVisualStyleBackColor = false;
            bntSua.Click += bntSua_Click;
            // 
            // bntXoa
            // 
            bntXoa.BackColor = Color.HotPink;
            bntXoa.ImeMode = ImeMode.NoControl;
            bntXoa.Location = new Point(303, 317);
            bntXoa.Name = "bntXoa";
            bntXoa.Size = new Size(95, 33);
            bntXoa.TabIndex = 27;
            bntXoa.Text = "XÓA";
            bntXoa.UseVisualStyleBackColor = false;
            bntXoa.Click += bntXoa_Click;
            // 
            // bntThem
            // 
            bntThem.BackColor = Color.MediumSpringGreen;
            bntThem.ImeMode = ImeMode.NoControl;
            bntThem.Location = new Point(42, 317);
            bntThem.Name = "bntThem";
            bntThem.Size = new Size(95, 33);
            bntThem.TabIndex = 26;
            bntThem.Text = "THÊM";
            bntThem.UseVisualStyleBackColor = false;
            bntThem.Click += bntThem_Click;
            // 
            // listTrai
            // 
            listTrai.BackColor = Color.MistyRose;
            listTrai.FullRowSelect = true;
            listTrai.GridLines = true;
            listTrai.Location = new Point(42, 359);
            listTrai.Name = "listTrai";
            listTrai.Size = new Size(1042, 278);
            listTrai.TabIndex = 25;
            listTrai.UseCompatibleStateImageBehavior = false;
            listTrai.View = View.Details;
            listTrai.SelectedIndexChanged += listTrai_SelectedIndexChanged;
            // 
            // txtDiaChiTrai
            // 
            txtDiaChiTrai.BackColor = Color.AntiqueWhite;
            txtDiaChiTrai.Location = new Point(711, 51);
            txtDiaChiTrai.Multiline = true;
            txtDiaChiTrai.Name = "txtDiaChiTrai";
            txtDiaChiTrai.Size = new Size(331, 88);
            txtDiaChiTrai.TabIndex = 24;
            // 
            // txtTenTrai
            // 
            txtTenTrai.BackColor = Color.AntiqueWhite;
            txtTenTrai.Location = new Point(155, 179);
            txtTenTrai.Multiline = true;
            txtTenTrai.Name = "txtTenTrai";
            txtTenTrai.Size = new Size(369, 31);
            txtTenTrai.TabIndex = 23;
            // 
            // txtMaTrai
            // 
            txtMaTrai.Location = new Point(394, 51);
            txtMaTrai.Name = "txtMaTrai";
            txtMaTrai.ReadOnly = true;
            txtMaTrai.Size = new Size(130, 27);
            txtMaTrai.TabIndex = 22;
            // 
            // txtMaCongTy
            // 
            txtMaCongTy.Location = new Point(155, 51);
            txtMaCongTy.Name = "txtMaCongTy";
            txtMaCongTy.ReadOnly = true;
            txtMaCongTy.Size = new Size(130, 27);
            txtMaCongTy.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(436, 9);
            label5.Name = "label5";
            label5.Size = new Size(273, 40);
            label5.TabIndex = 20;
            label5.Text = "DANH SÁCH TRẠI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(75, 179);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 19;
            label4.Text = "Tên Trại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(635, 54);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 18;
            label3.Text = "Địa Chỉ:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(318, 51);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 17;
            label2.Text = "Mã Trại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(48, 51);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 16;
            label1.Text = "Mã Công Ty:";
            // 
            // cbTenCongTy
            // 
            cbTenCongTy.BackColor = Color.AntiqueWhite;
            cbTenCongTy.FormattingEnabled = true;
            cbTenCongTy.Location = new Point(155, 115);
            cbTenCongTy.Name = "cbTenCongTy";
            cbTenCongTy.Size = new Size(369, 28);
            cbTenCongTy.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(44, 118);
            label6.Name = "label6";
            label6.Size = new Size(105, 21);
            label6.TabIndex = 33;
            label6.Text = "Tên Công Ty:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTongTrai);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cbTenCongTy);
            groupBox1.Controls.Add(txtDiaChiTrai);
            groupBox1.Controls.Add(txtTenTrai);
            groupBox1.Controls.Add(txtMaTrai);
            groupBox1.Controls.Add(txtMaCongTy);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(42, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1060, 253);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Trại";
            // 
            // txtTongTrai
            // 
            txtTongTrai.Location = new Point(711, 179);
            txtTongTrai.Multiline = true;
            txtTongTrai.Name = "txtTongTrai";
            txtTongTrai.ReadOnly = true;
            txtTongTrai.Size = new Size(136, 31);
            txtTongTrai.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ImeMode = ImeMode.NoControl;
            label7.Location = new Point(604, 179);
            label7.Name = "label7";
            label7.Size = new Size(101, 21);
            label7.TabIndex = 34;
            label7.Text = "Tổng số trại:";
            // 
            // DanhSachTrai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1127, 649);
            Controls.Add(groupBox1);
            Controls.Add(bntMoKhoa);
            Controls.Add(bntLamMoi);
            Controls.Add(bntQuayLai);
            Controls.Add(bntSua);
            Controls.Add(bntXoa);
            Controls.Add(bntThem);
            Controls.Add(listTrai);
            Controls.Add(label5);
            Name = "DanhSachTrai";
            Text = "DanhSachTrai";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntMoKhoa;
        private Button bntLamMoi;
        private Button bntQuayLai;
        private Button bntSua;
        private Button bntXoa;
        private Button bntThem;
        private ListView listTrai;
        private TextBox txtDiaChiTrai;
        private TextBox txtTenTrai;
        private TextBox txtMaTrai;
        private TextBox txtMaCongTy;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cbTenCongTy;
        private Label label6;
        private GroupBox groupBox1;
        private TextBox txtTongTrai;
        private Label label7;
    }
}