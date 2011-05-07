namespace TUVANLAPTOP
{
    partial class ADMIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADMIN));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.ThemMoiSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemDacTinhSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.ThayDoiThongTinSP = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyXoaSP = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TUVANLAPTOP.Properties.Resources.admin_form;
            this.pictureBox1.Location = new System.Drawing.Point(437, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 287);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.MainMenu.AutoSize = false;
            this.MainMenu.BackColor = System.Drawing.Color.Gainsboro;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemMoiSanPham,
            this.ThemDacTinhSanPham,
            this.ThayDoiThongTinSP,
            this.QuanLyXoaSP});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(918, 76);
            this.MainMenu.TabIndex = 8;
            this.MainMenu.Text = "menuStrip1";
            // 
            // ThemMoiSanPham
            // 
            this.ThemMoiSanPham.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ThemMoiSanPham.Image = global::TUVANLAPTOP.Properties.Resources.ThemSP;
            this.ThemMoiSanPham.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ThemMoiSanPham.Name = "ThemMoiSanPham";
            this.ThemMoiSanPham.Size = new System.Drawing.Size(199, 72);
            this.ThemMoiSanPham.Text = "Thêm mới sản phẩm";
            this.ThemMoiSanPham.Click += new System.EventHandler(this.ThemMoiSanPham_Click);
            // 
            // ThemDacTinhSanPham
            // 
            this.ThemDacTinhSanPham.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ThemDacTinhSanPham.Image = global::TUVANLAPTOP.Properties.Resources.ThemThongTin;
            this.ThemDacTinhSanPham.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ThemDacTinhSanPham.Name = "ThemDacTinhSanPham";
            this.ThemDacTinhSanPham.Size = new System.Drawing.Size(238, 72);
            this.ThemDacTinhSanPham.Text = "Thêm đặc tính sản phẩm";
            this.ThemDacTinhSanPham.Click += new System.EventHandler(this.ThemDacTinhSanPham_Click);
            // 
            // ThayDoiThongTinSP
            // 
            this.ThayDoiThongTinSP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ThayDoiThongTinSP.Image = global::TUVANLAPTOP.Properties.Resources.edit;
            this.ThayDoiThongTinSP.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ThayDoiThongTinSP.Name = "ThayDoiThongTinSP";
            this.ThayDoiThongTinSP.Size = new System.Drawing.Size(257, 72);
            this.ThayDoiThongTinSP.Text = "Thay đổi thông tin sản phẩm";
            this.ThayDoiThongTinSP.Click += new System.EventHandler(this.ThayDoiThongTinSP_Click);
            // 
            // QuanLyXoaSP
            // 
            this.QuanLyXoaSP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.QuanLyXoaSP.Image = global::TUVANLAPTOP.Properties.Resources.Delete;
            this.QuanLyXoaSP.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.QuanLyXoaSP.Name = "QuanLyXoaSP";
            this.QuanLyXoaSP.Size = new System.Drawing.Size(210, 72);
            this.QuanLyXoaSP.Text = "Quản lý xóa sản phẩm";
            this.QuanLyXoaSP.Click += new System.EventHandler(this.QuanLyXoaSP_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(143, 139);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(170, 57);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Cập nhật csdl";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 417);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.btn_Update);
            this.MaximizeBox = false;
            this.Name = "ADMIN";
            this.Text = "ADMIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem ThemMoiSanPham;
        private System.Windows.Forms.ToolStripMenuItem ThemDacTinhSanPham;
        private System.Windows.Forms.ToolStripMenuItem ThayDoiThongTinSP;
        private System.Windows.Forms.ToolStripMenuItem QuanLyXoaSP;
        private System.Windows.Forms.Button btn_Update;
    }
}