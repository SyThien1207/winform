namespace QuanLySieuThi
{
    partial class main2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mn_quanly = new System.Windows.Forms.ToolStripMenuItem();
            this.ql_nhanvien = new System.Windows.Forms.ToolStripMenuItem();
            this.ql_ncc = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_hethong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_quanly,
            this.mn_hethong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1460, 74);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menu";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mn_quanly
            // 
            this.mn_quanly.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ql_nhanvien,
            this.ql_ncc});
            this.mn_quanly.Name = "mn_quanly";
            this.mn_quanly.Size = new System.Drawing.Size(142, 70);
            this.mn_quanly.Text = "Quản lý ";
            // 
            // ql_nhanvien
            // 
            this.ql_nhanvien.Name = "ql_nhanvien";
            this.ql_nhanvien.Size = new System.Drawing.Size(426, 46);
            this.ql_nhanvien.Text = "- Quản lý tài khoản";
            this.ql_nhanvien.Click += new System.EventHandler(this.ql_nhanvien_Click);
            // 
            // ql_ncc
            // 
            this.ql_ncc.Name = "ql_ncc";
            this.ql_ncc.Size = new System.Drawing.Size(426, 46);
            this.ql_ncc.Text = "- Quản lý nhà cung cấp";
            this.ql_ncc.Click += new System.EventHandler(this.ql_ncc_Click);
            // 
            // mn_hethong
            // 
            this.mn_hethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.mn_hethong.Name = "mn_hethong";
            this.mn_hethong.Size = new System.Drawing.Size(177, 70);
            this.mn_hethong.Text = " Đăng xuất";
            this.mn_hethong.Click += new System.EventHandler(this.mn_hethong_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(87, 6);
            // 
            // main2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1460, 656);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "main2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý siêu thị";
            this.Load += new System.EventHandler(this.main2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem mn_hethong;
        public System.Windows.Forms.ToolStripMenuItem mn_quanly;
        public System.Windows.Forms.ToolStripMenuItem ql_ncc;
        public System.Windows.Forms.ToolStripMenuItem ql_nhanvien;
    }
}