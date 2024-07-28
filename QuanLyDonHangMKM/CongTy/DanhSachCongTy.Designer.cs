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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachCongTy));
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
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Name = "label5";
            // 
            // txtMaCongTy
            // 
            resources.ApplyResources(txtMaCongTy, "txtMaCongTy");
            txtMaCongTy.Name = "txtMaCongTy";
            // 
            // txtMaSoThue
            // 
            resources.ApplyResources(txtMaSoThue, "txtMaSoThue");
            txtMaSoThue.Name = "txtMaSoThue";
            // 
            // txtTenCongTy
            // 
            resources.ApplyResources(txtTenCongTy, "txtTenCongTy");
            txtTenCongTy.Name = "txtTenCongTy";
            // 
            // txtDiaChiCongTy
            // 
            resources.ApplyResources(txtDiaChiCongTy, "txtDiaChiCongTy");
            txtDiaChiCongTy.Name = "txtDiaChiCongTy";
            // 
            // listCongTy
            // 
            listCongTy.BackColor = Color.MistyRose;
            listCongTy.FullRowSelect = true;
            listCongTy.GridLines = true;
            resources.ApplyResources(listCongTy, "listCongTy");
            listCongTy.Name = "listCongTy";
            listCongTy.UseCompatibleStateImageBehavior = false;
            listCongTy.View = View.Details;
            // 
            // bntThem
            // 
            bntThem.BackColor = Color.MediumSpringGreen;
            resources.ApplyResources(bntThem, "bntThem");
            bntThem.Name = "bntThem";
            bntThem.UseVisualStyleBackColor = false;
            bntThem.Click += bntThem_Click;
            // 
            // bntXoa
            // 
            bntXoa.BackColor = Color.HotPink;
            resources.ApplyResources(bntXoa, "bntXoa");
            bntXoa.Name = "bntXoa";
            bntXoa.UseVisualStyleBackColor = false;
            bntXoa.Click += bntXoa_Click;
            // 
            // bntSua
            // 
            bntSua.BackColor = Color.Yellow;
            resources.ApplyResources(bntSua, "bntSua");
            bntSua.Name = "bntSua";
            bntSua.UseVisualStyleBackColor = false;
            bntSua.Click += bntSua_Click;
            // 
            // bntQuayLai
            // 
            resources.ApplyResources(bntQuayLai, "bntQuayLai");
            bntQuayLai.Name = "bntQuayLai";
            bntQuayLai.UseVisualStyleBackColor = true;
            bntQuayLai.Click += bntQuayLai_Click;
            // 
            // bntLamMoi
            // 
            resources.ApplyResources(bntLamMoi, "bntLamMoi");
            bntLamMoi.Name = "bntLamMoi";
            bntLamMoi.UseVisualStyleBackColor = true;
            bntLamMoi.Click += bntLamMoi_Click;
            // 
            // bntMoKhoa
            // 
            bntMoKhoa.BackColor = Color.Cyan;
            resources.ApplyResources(bntMoKhoa, "bntMoKhoa");
            bntMoKhoa.Name = "bntMoKhoa";
            bntMoKhoa.UseVisualStyleBackColor = false;
            bntMoKhoa.Click += bntMoKhoa_Click;
            // 
            // DanhSachCongTy
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
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