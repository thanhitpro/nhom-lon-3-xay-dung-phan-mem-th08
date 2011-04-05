namespace TUVANLAPTOP
{
    partial class SANPHAMTUVAN
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Title_ThongTinLapTop = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_ChonSanPham = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GroupPanel_ThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.GroupPanel_ListSanPham = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_Title_ThongTinLapTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 60);
            this.panel1.TabIndex = 7;
            // 
            // label_Title_ThongTinLapTop
            // 
            this.label_Title_ThongTinLapTop.AutoSize = true;
            this.label_Title_ThongTinLapTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title_ThongTinLapTop.ForeColor = System.Drawing.Color.Indigo;
            this.label_Title_ThongTinLapTop.Location = new System.Drawing.Point(198, 17);
            this.label_Title_ThongTinLapTop.Name = "label_Title_ThongTinLapTop";
            this.label_Title_ThongTinLapTop.Size = new System.Drawing.Size(354, 26);
            this.label_Title_ThongTinLapTop.TabIndex = 8;
            this.label_Title_ThongTinLapTop.Text = "THÔNG TIN LAPTOP NÊN MUA";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_Back);
            this.panel2.Controls.Add(this.button_ChonSanPham);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 493);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(772, 88);
            this.panel2.TabIndex = 8;
            // 
            // button_Back
            // 
            this.button_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Back.Location = new System.Drawing.Point(382, 25);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(170, 43);
            this.button_Back.TabIndex = 2;
            this.button_Back.Text = "BACK";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_ChonSanPham
            // 
            this.button_ChonSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_ChonSanPham.Location = new System.Drawing.Point(147, 25);
            this.button_ChonSanPham.Name = "button_ChonSanPham";
            this.button_ChonSanPham.Size = new System.Drawing.Size(169, 43);
            this.button_ChonSanPham.TabIndex = 1;
            this.button_ChonSanPham.Text = "Chọn Sản Phẩm";
            this.button_ChonSanPham.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.GroupPanel_ThongTinChiTiet);
            this.panel3.Controls.Add(this.GroupPanel_ListSanPham);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(772, 433);
            this.panel3.TabIndex = 9;
            // 
            // GroupPanel_ThongTinChiTiet
            // 
            this.GroupPanel_ThongTinChiTiet.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GroupPanel_ThongTinChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupPanel_ThongTinChiTiet.Location = new System.Drawing.Point(249, 0);
            this.GroupPanel_ThongTinChiTiet.Name = "GroupPanel_ThongTinChiTiet";
            this.GroupPanel_ThongTinChiTiet.Size = new System.Drawing.Size(523, 433);
            this.GroupPanel_ThongTinChiTiet.TabIndex = 1;
            this.GroupPanel_ThongTinChiTiet.TabStop = false;
            this.GroupPanel_ThongTinChiTiet.Text = "Thông Tin Chi Tiết";
            // 
            // GroupPanel_ListSanPham
            // 
            this.GroupPanel_ListSanPham.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GroupPanel_ListSanPham.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupPanel_ListSanPham.Location = new System.Drawing.Point(0, 0);
            this.GroupPanel_ListSanPham.Name = "GroupPanel_ListSanPham";
            this.GroupPanel_ListSanPham.Size = new System.Drawing.Size(249, 433);
            this.GroupPanel_ListSanPham.TabIndex = 0;
            this.GroupPanel_ListSanPham.TabStop = false;
            this.GroupPanel_ListSanPham.Text = "List Sản Phẩm";
            // 
            // SANPHAMTUVAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 581);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SANPHAMTUVAN";
            this.Text = "Sản Phẩm Tư Vấn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Title_ThongTinLapTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox GroupPanel_ThongTinChiTiet;
        private System.Windows.Forms.GroupBox GroupPanel_ListSanPham;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_ChonSanPham;
    }
}