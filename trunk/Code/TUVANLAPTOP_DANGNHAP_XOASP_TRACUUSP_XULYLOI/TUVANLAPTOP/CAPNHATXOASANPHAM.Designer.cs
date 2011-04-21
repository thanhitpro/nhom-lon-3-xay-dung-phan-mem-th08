namespace TUVANLAPTOP
{
    partial class CAPNHATXOASANPHAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAPNHATXOASANPHAM));
            this.groupBox_TitleXoaSanPham = new System.Windows.Forms.GroupBox();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_MaSanPham = new System.Windows.Forms.TextBox();
            this.label_MaSanPham = new System.Windows.Forms.Label();
            this.label_Title_NhapTrongTin = new System.Windows.Forms.Label();
            this.groupBox_DanhSachSanPham = new System.Windows.Forms.GroupBox();
            this.checkAll = new System.Windows.Forms.CheckBox();
            this.dataGridXoaSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox_ThaoTac = new System.Windows.Forms.GroupBox();
            this.button_Back_XoaSanPham = new System.Windows.Forms.Button();
            this.button_OK_XoaSanPham = new System.Windows.Forms.Button();
            this.DeletedState = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ChangedState = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaDongLapTop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDongLapTop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VideoCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardMang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardReader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Webcam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeDieuHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanDangVanTay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDMI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongCongUSB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaSanXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanhGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_TitleXoaSanPham.SuspendLayout();
            this.groupBox_DanhSachSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridXoaSanPham)).BeginInit();
            this.groupBox_ThaoTac.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_TitleXoaSanPham
            // 
            this.groupBox_TitleXoaSanPham.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox_TitleXoaSanPham.Controls.Add(this.button_search);
            this.groupBox_TitleXoaSanPham.Controls.Add(this.textBox_MaSanPham);
            this.groupBox_TitleXoaSanPham.Controls.Add(this.label_MaSanPham);
            this.groupBox_TitleXoaSanPham.Controls.Add(this.label_Title_NhapTrongTin);
            this.groupBox_TitleXoaSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_TitleXoaSanPham.Location = new System.Drawing.Point(0, 0);
            this.groupBox_TitleXoaSanPham.Name = "groupBox_TitleXoaSanPham";
            this.groupBox_TitleXoaSanPham.Size = new System.Drawing.Size(1064, 127);
            this.groupBox_TitleXoaSanPham.TabIndex = 1;
            this.groupBox_TitleXoaSanPham.TabStop = false;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(709, 81);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 11;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_MaSanPham
            // 
            this.textBox_MaSanPham.Location = new System.Drawing.Point(504, 84);
            this.textBox_MaSanPham.Name = "textBox_MaSanPham";
            this.textBox_MaSanPham.Size = new System.Drawing.Size(156, 20);
            this.textBox_MaSanPham.TabIndex = 10;
            // 
            // label_MaSanPham
            // 
            this.label_MaSanPham.AutoSize = true;
            this.label_MaSanPham.Location = new System.Drawing.Point(392, 87);
            this.label_MaSanPham.Name = "label_MaSanPham";
            this.label_MaSanPham.Size = new System.Drawing.Size(74, 13);
            this.label_MaSanPham.TabIndex = 9;
            this.label_MaSanPham.Text = "Mã Sản Phẩm";
            // 
            // label_Title_NhapTrongTin
            // 
            this.label_Title_NhapTrongTin.AutoSize = true;
            this.label_Title_NhapTrongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title_NhapTrongTin.ForeColor = System.Drawing.Color.Indigo;
            this.label_Title_NhapTrongTin.Location = new System.Drawing.Point(270, 33);
            this.label_Title_NhapTrongTin.Name = "label_Title_NhapTrongTin";
            this.label_Title_NhapTrongTin.Size = new System.Drawing.Size(525, 26);
            this.label_Title_NhapTrongTin.TabIndex = 8;
            this.label_Title_NhapTrongTin.Text = "CẬP NHẬT TÌNH TRẠNG XÓA CỦA SẢN PHẨM";
            // 
            // groupBox_DanhSachSanPham
            // 
            this.groupBox_DanhSachSanPham.Controls.Add(this.checkAll);
            this.groupBox_DanhSachSanPham.Controls.Add(this.dataGridXoaSanPham);
            this.groupBox_DanhSachSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_DanhSachSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_DanhSachSanPham.Location = new System.Drawing.Point(0, 127);
            this.groupBox_DanhSachSanPham.Name = "groupBox_DanhSachSanPham";
            this.groupBox_DanhSachSanPham.Size = new System.Drawing.Size(1064, 447);
            this.groupBox_DanhSachSanPham.TabIndex = 2;
            this.groupBox_DanhSachSanPham.TabStop = false;
            this.groupBox_DanhSachSanPham.Text = "Danh Sách Sản Phẩm";
            // 
            // checkAll
            // 
            this.checkAll.AutoSize = true;
            this.checkAll.Location = new System.Drawing.Point(12, 29);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(15, 14);
            this.checkAll.TabIndex = 2;
            this.checkAll.UseVisualStyleBackColor = true;
            this.checkAll.CheckedChanged += new System.EventHandler(this.checkAll_CheckedChanged);
            // 
            // dataGridXoaSanPham
            // 
            this.dataGridXoaSanPham.AllowUserToAddRows = false;
            this.dataGridXoaSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridXoaSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeletedState,
            this.ChangedState,
            this.MaDongLapTop,
            this.TenDongLapTop,
            this.Ram,
            this.CPU,
            this.ManHinh,
            this.VideoCard,
            this.Loa,
            this.Disk,
            this.CardMang,
            this.CardReader,
            this.Webcam,
            this.Pin,
            this.HeDieuHanh,
            this.TrongLuong,
            this.MauSac,
            this.NhanDangVanTay,
            this.HDMI,
            this.SoLuongCongUSB,
            this.NhaSanXuat,
            this.DanhGia,
            this.GiaBan,
            this.SoLuongNhap,
            this.SoLuongConLai,
            this.ThoiGianBaoHanh});
            this.dataGridXoaSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridXoaSanPham.Location = new System.Drawing.Point(3, 17);
            this.dataGridXoaSanPham.Name = "dataGridXoaSanPham";
            this.dataGridXoaSanPham.Size = new System.Drawing.Size(1058, 427);
            this.dataGridXoaSanPham.TabIndex = 1;
            this.dataGridXoaSanPham.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridXoaSanPham_CellValueChanged);
            this.dataGridXoaSanPham.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridXoaSanPham_CurrentCellDirtyStateChanged);
            // 
            // groupBox_ThaoTac
            // 
            this.groupBox_ThaoTac.BackColor = System.Drawing.Color.Silver;
            this.groupBox_ThaoTac.Controls.Add(this.button_Back_XoaSanPham);
            this.groupBox_ThaoTac.Controls.Add(this.button_OK_XoaSanPham);
            this.groupBox_ThaoTac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_ThaoTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_ThaoTac.Location = new System.Drawing.Point(0, 574);
            this.groupBox_ThaoTac.Name = "groupBox_ThaoTac";
            this.groupBox_ThaoTac.Size = new System.Drawing.Size(1064, 88);
            this.groupBox_ThaoTac.TabIndex = 3;
            this.groupBox_ThaoTac.TabStop = false;
            // 
            // button_Back_XoaSanPham
            // 
            this.button_Back_XoaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_Back_XoaSanPham.Image = ((System.Drawing.Image)(resources.GetObject("button_Back_XoaSanPham.Image")));
            this.button_Back_XoaSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Back_XoaSanPham.Location = new System.Drawing.Point(588, 22);
            this.button_Back_XoaSanPham.Name = "button_Back_XoaSanPham";
            this.button_Back_XoaSanPham.Size = new System.Drawing.Size(129, 43);
            this.button_Back_XoaSanPham.TabIndex = 4;
            this.button_Back_XoaSanPham.Text = "Quay lại";
            this.button_Back_XoaSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Back_XoaSanPham.UseVisualStyleBackColor = true;
            this.button_Back_XoaSanPham.Click += new System.EventHandler(this.button_Back_XoaSanPham_Click);
            // 
            // button_OK_XoaSanPham
            // 
            this.button_OK_XoaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_OK_XoaSanPham.Image = ((System.Drawing.Image)(resources.GetObject("button_OK_XoaSanPham.Image")));
            this.button_OK_XoaSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_OK_XoaSanPham.Location = new System.Drawing.Point(334, 22);
            this.button_OK_XoaSanPham.Name = "button_OK_XoaSanPham";
            this.button_OK_XoaSanPham.Size = new System.Drawing.Size(87, 43);
            this.button_OK_XoaSanPham.TabIndex = 3;
            this.button_OK_XoaSanPham.Text = "OK";
            this.button_OK_XoaSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_OK_XoaSanPham.UseVisualStyleBackColor = true;
            this.button_OK_XoaSanPham.Click += new System.EventHandler(this.button_OK_XoaSanPham_Click);
            // 
            // DeletedState
            // 
            this.DeletedState.FillWeight = 60F;
            this.DeletedState.HeaderText = "Deleted State";
            this.DeletedState.Name = "DeletedState";
            this.DeletedState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeletedState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DeletedState.Width = 60;
            // 
            // ChangedState
            // 
            this.ChangedState.HeaderText = "Changed";
            this.ChangedState.Name = "ChangedState";
            this.ChangedState.Visible = false;
            // 
            // MaDongLapTop
            // 
            this.MaDongLapTop.HeaderText = "Mã Dòng Lap Top";
            this.MaDongLapTop.Name = "MaDongLapTop";
            // 
            // TenDongLapTop
            // 
            this.TenDongLapTop.HeaderText = "Tên Dòng Laptop";
            this.TenDongLapTop.Name = "TenDongLapTop";
            // 
            // Ram
            // 
            this.Ram.HeaderText = "Ram";
            this.Ram.Name = "Ram";
            // 
            // CPU
            // 
            this.CPU.HeaderText = "CPU";
            this.CPU.Name = "CPU";
            // 
            // ManHinh
            // 
            this.ManHinh.HeaderText = "Màn Hình";
            this.ManHinh.Name = "ManHinh";
            // 
            // VideoCard
            // 
            this.VideoCard.HeaderText = "Card Đồ Họa";
            this.VideoCard.Name = "VideoCard";
            // 
            // Loa
            // 
            this.Loa.HeaderText = "Loa";
            this.Loa.Name = "Loa";
            // 
            // Disk
            // 
            this.Disk.HeaderText = "Ổ Đĩa Quang";
            this.Disk.Name = "Disk";
            // 
            // CardMang
            // 
            this.CardMang.HeaderText = "Card Mạng";
            this.CardMang.Name = "CardMang";
            // 
            // CardReader
            // 
            this.CardReader.HeaderText = "Card Reader";
            this.CardReader.Name = "CardReader";
            // 
            // Webcam
            // 
            this.Webcam.HeaderText = "Webcam";
            this.Webcam.Name = "Webcam";
            // 
            // Pin
            // 
            this.Pin.HeaderText = "Pin";
            this.Pin.Name = "Pin";
            // 
            // HeDieuHanh
            // 
            this.HeDieuHanh.HeaderText = "Hệ Điều Hành";
            this.HeDieuHanh.Name = "HeDieuHanh";
            // 
            // TrongLuong
            // 
            this.TrongLuong.HeaderText = "Trọng Lượng";
            this.TrongLuong.Name = "TrongLuong";
            // 
            // MauSac
            // 
            this.MauSac.HeaderText = "Màu Sắc";
            this.MauSac.Name = "MauSac";
            // 
            // NhanDangVanTay
            // 
            this.NhanDangVanTay.HeaderText = "Nhận Dạng Vân Tay";
            this.NhanDangVanTay.Name = "NhanDangVanTay";
            // 
            // HDMI
            // 
            this.HDMI.HeaderText = "HDMI";
            this.HDMI.Name = "HDMI";
            // 
            // SoLuongCongUSB
            // 
            this.SoLuongCongUSB.HeaderText = "Số Lượng Cổng USB";
            this.SoLuongCongUSB.Name = "SoLuongCongUSB";
            // 
            // NhaSanXuat
            // 
            this.NhaSanXuat.HeaderText = "Nhà Sản Xuất";
            this.NhaSanXuat.Name = "NhaSanXuat";
            // 
            // DanhGia
            // 
            this.DanhGia.HeaderText = "Đánh Giá";
            this.DanhGia.Name = "DanhGia";
            // 
            // GiaBan
            // 
            this.GiaBan.HeaderText = "Giá Bán Hiện Tại";
            this.GiaBan.Name = "GiaBan";
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.HeaderText = "Số Lượng Nhập";
            this.SoLuongNhap.Name = "SoLuongNhap";
            // 
            // SoLuongConLai
            // 
            this.SoLuongConLai.HeaderText = "Số Lượng Còn lại";
            this.SoLuongConLai.Name = "SoLuongConLai";
            // 
            // ThoiGianBaoHanh
            // 
            this.ThoiGianBaoHanh.HeaderText = "Thời Gian Bảo Hành";
            this.ThoiGianBaoHanh.Name = "ThoiGianBaoHanh";
            // 
            // CAPNHATXOASANPHAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 662);
            this.Controls.Add(this.groupBox_ThaoTac);
            this.Controls.Add(this.groupBox_DanhSachSanPham);
            this.Controls.Add(this.groupBox_TitleXoaSanPham);
            this.Name = "CAPNHATXOASANPHAM";
            this.Text = "Xóa Sản Phẩm";
            this.Load += new System.EventHandler(this.CAPNHATXOASANPHAM_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CAPNHATXOASANPHAM_FormClosing);
            this.groupBox_TitleXoaSanPham.ResumeLayout(false);
            this.groupBox_TitleXoaSanPham.PerformLayout();
            this.groupBox_DanhSachSanPham.ResumeLayout(false);
            this.groupBox_DanhSachSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridXoaSanPham)).EndInit();
            this.groupBox_ThaoTac.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_TitleXoaSanPham;
        private System.Windows.Forms.GroupBox groupBox_DanhSachSanPham;
        private System.Windows.Forms.DataGridView dataGridXoaSanPham;
        private System.Windows.Forms.GroupBox groupBox_ThaoTac;
        private System.Windows.Forms.Label label_Title_NhapTrongTin;
        private System.Windows.Forms.Button button_Back_XoaSanPham;
        private System.Windows.Forms.Button button_OK_XoaSanPham;
        private System.Windows.Forms.TextBox textBox_MaSanPham;
        private System.Windows.Forms.Label label_MaSanPham;
        private System.Windows.Forms.CheckBox checkAll;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DeletedState;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ChangedState;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDongLapTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDongLapTop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ram;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn VideoCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disk;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardMang;
        private System.Windows.Forms.DataGridViewTextBoxColumn CardReader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Webcam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pin;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeDieuHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrongLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanDangVanTay;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDMI;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongCongUSB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaSanXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanhGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongConLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBaoHanh;

    }
}