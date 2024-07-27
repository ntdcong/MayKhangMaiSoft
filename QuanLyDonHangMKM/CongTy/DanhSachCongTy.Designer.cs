namespace QuanLyDonHangMKM.CongTy
{
    partial class DanhSachCongTy
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaCongTy = new TextBox();
            txtMaSoThue = new TextBox();
            txtTenCongTy = new TextBox();
            txtDiaChiCongTy = new TextBox();
            listCongTy = new ListView();
            bntThem = new Button();
            bntXoa = new Button();
            bntSua = new Button();
            bntQuayLai = new Button();
            bntLamMoi = new Button();
            bntMoKhoa = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 88);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 0;
            label1.Text = "Mã Công Ty:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(16, 150);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 1;
            label2.Text = "Mã Số Thuế:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(47, 290);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 2;
            label3.Text = "Địa Chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 203);
            label4.Name = "label4";
            label4.Size = new Size(105, 21);
            label4.TabIndex = 3;
            label4.Text = "Tên Công Ty:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(538, 23);
            label5.Name = "label5";
            label5.Size = new Size(424, 40);
            label5.TabIndex = 4;
            label5.Text = "DANH SÁCH CÔNG TY";
            // 
            // txtMaCongTy
            // 
            txtMaCongTy.Location = new Point(123, 85);
            txtMaCongTy.Name = "txtMaCongTy";
            txtMaCongTy.ReadOnly = true;
            txtMaCongTy.Size = new Size(130, 27);
            txtMaCongTy.TabIndex = 5;
            // 
            // txtMaSoThue
            // 
            txtMaSoThue.Location = new Point(123, 144);
            txtMaSoThue.Name = "txtMaSoThue";
            txtMaSoThue.Size = new Size(130, 27);
            txtMaSoThue.TabIndex = 6;
            // 
            // txtTenCongTy
            // 
            txtTenCongTy.Location = new Point(123, 203);
            txtTenCongTy.Multiline = true;
            txtTenCongTy.Name = "txtTenCongTy";
            txtTenCongTy.Size = new Size(266, 52);
            txtTenCongTy.TabIndex = 7;
            // 
            // txtDiaChiCongTy
            // 
            txtDiaChiCongTy.Location = new Point(123, 287);
            txtDiaChiCongTy.Multiline = true;
            txtDiaChiCongTy.Name = "txtDiaChiCongTy";
            txtDiaChiCongTy.Size = new Size(266, 127);
            txtDiaChiCongTy.TabIndex = 8;
            // 
            // listCongTy
            // 
            listCongTy.BackColor = Color.MistyRose;
            listCongTy.FullRowSelect = true;
            listCongTy.GridLines = true;
            listCongTy.Location = new Point(415, 85);
            listCongTy.Name = "listCongTy";
            listCongTy.Size = new Size(654, 329);
            listCongTy.TabIndex = 9;
            listCongTy.UseCompatibleStateImageBehavior = false;
            listCongTy.View = View.Details;
            // 
            // bntThem
            // 
            bntThem.BackColor = Color.MediumSpringGreen;
            bntThem.Location = new Point(59, 445);
            bntThem.Name = "bntThem";
            bntThem.Size = new Size(95, 33);
            bntThem.TabIndex = 10;
            bntThem.Text = "THÊM";
            bntThem.UseVisualStyleBackColor = false;
            bntThem.Click += bntThem_Click;
            // 
            // bntXoa
            // 
            bntXoa.BackColor = Color.HotPink;
            bntXoa.Location = new Point(348, 445);
            bntXoa.Name = "bntXoa";
            bntXoa.Size = new Size(95, 33);
            bntXoa.TabIndex = 11;
            bntXoa.Text = "XÓA";
            bntXoa.UseVisualStyleBackColor = false;
            bntXoa.Click += bntXoa_Click;
            // 
            // bntSua
            // 
            bntSua.BackColor = Color.Yellow;
            bntSua.Location = new Point(210, 445);
            bntSua.Name = "bntSua";
            bntSua.Size = new Size(95, 33);
            bntSua.TabIndex = 12;
            bntSua.Text = "SỬA";
            bntSua.UseVisualStyleBackColor = false;
            bntSua.Click += bntSua_Click;
            // 
            // bntQuayLai
            // 
            bntQuayLai.Location = new Point(974, 445);
            bntQuayLai.Name = "bntQuayLai";
            bntQuayLai.Size = new Size(95, 33);
            bntQuayLai.TabIndex = 13;
            bntQuayLai.Text = "QUAY LẠI";
            bntQuayLai.UseVisualStyleBackColor = true;
            bntQuayLai.Click += bntQuayLai_Click;
            // 
            // bntLamMoi
            // 
            bntLamMoi.Location = new Point(849, 445);
            bntLamMoi.Name = "bntLamMoi";
            bntLamMoi.Size = new Size(95, 33);
            bntLamMoi.TabIndex = 14;
            bntLamMoi.Text = "LÀM MỚI";
            bntLamMoi.UseVisualStyleBackColor = true;
            bntLamMoi.Click += bntLamMoi_Click;
            // 
            // bntMoKhoa
            // 
            bntMoKhoa.BackColor = Color.Cyan;
            bntMoKhoa.Location = new Point(508, 445);
            bntMoKhoa.Name = "bntMoKhoa";
            bntMoKhoa.Size = new Size(140, 33);
            bntMoKhoa.TabIndex = 15;
            bntMoKhoa.Text = "MỞ KHÓA NÚT";
            bntMoKhoa.UseVisualStyleBackColor = false;
            bntMoKhoa.Click += bntMoKhoa_Click;
            // 
            // DanhSachCongTy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1099, 519);
            Controls.Add(bntMoKhoa);
            Controls.Add(bntLamMoi);
            Controls.Add(bntQuayLai);
            Controls.Add(bntSua);
            Controls.Add(bntXoa);
            Controls.Add(bntThem);
            Controls.Add(listCongTy);
            Controls.Add(txtDiaChiCongTy);
            Controls.Add(txtTenCongTy);
            Controls.Add(txtMaSoThue);
            Controls.Add(txtMaCongTy);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DanhSachCongTy";
            Text = "Danh Sách Công Ty";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaCongTy;
        private TextBox txtMaSoThue;
        private TextBox txtTenCongTy;
        private TextBox txtDiaChiCongTy;
        private ListView listCongTy;
        private Button bntThem;
        private Button bntXoa;
        private Button bntSua;
        private Button bntQuayLai;
        private Button bntLamMoi;
        private Button bntMoKhoa;
    }
}