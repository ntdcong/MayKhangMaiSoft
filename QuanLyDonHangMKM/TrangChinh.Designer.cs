namespace QuanLyDonHangMKM
{
    partial class TrangChinh
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            monthCalendar1 = new MonthCalendar();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(492, 92);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(59, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 378);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "CHỨC NĂNG";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button3
            // 
            button3.Location = new Point(84, 261);
            button3.Name = "button3";
            button3.Size = new Size(195, 65);
            button3.TabIndex = 2;
            button3.Text = "Thống Kê";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(87, 157);
            button2.Name = "button2";
            button2.Size = new Size(195, 65);
            button2.TabIndex = 1;
            button2.Text = "Danh Sách Công Ty";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(84, 61);
            button1.Name = "button1";
            button1.Size = new Size(195, 65);
            button1.TabIndex = 0;
            button1.Text = "Danh Sách Đơn Hàng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TrangChinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(monthCalendar1);
            Name = "TrangChinh";
            Text = "Trang Chính";
            Load += TrangChinh_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
