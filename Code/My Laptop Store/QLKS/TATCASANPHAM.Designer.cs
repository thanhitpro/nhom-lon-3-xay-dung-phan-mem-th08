namespace QLKS
{
    partial class TATCASP
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
            aForm = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TATCASP));
            this.flp_TatCaSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flp_TatCaSanPham
            // 
            this.flp_TatCaSanPham.AutoScroll = true;
            this.flp_TatCaSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_TatCaSanPham.Location = new System.Drawing.Point(0, 0);
            this.flp_TatCaSanPham.Name = "flp_TatCaSanPham";
            this.flp_TatCaSanPham.Size = new System.Drawing.Size(894, 535);
            this.flp_TatCaSanPham.TabIndex = 0;
            // 
            // TATCASP
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(894, 535);
            this.Controls.Add(this.flp_TatCaSanPham);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "TATCASP";
            this.Text = "TẤT CẢ CÁC SẢN PHẨM TRONG ESTORE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TATCASP_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_TatCaSanPham;


    }
}