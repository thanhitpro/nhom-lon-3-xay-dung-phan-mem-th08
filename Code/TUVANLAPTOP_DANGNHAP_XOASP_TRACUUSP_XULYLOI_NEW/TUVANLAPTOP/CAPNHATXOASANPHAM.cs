using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EStoreBUS;
using EStoreDTO;

namespace TUVANLAPTOP
{
    public partial class CAPNHATXOASANPHAM : Form
    {
        private static CAPNHATXOASANPHAM aForm = null;

        public static CAPNHATXOASANPHAM Instance()
        {
            if (aForm == null)
            {
                aForm = new CAPNHATXOASANPHAM();
            }
            return aForm;
        }
        public CAPNHATXOASANPHAM()
        {
            InitializeComponent();
        }

        private void button_Back_XoaSanPham_Click(object sender, EventArgs e)
        {
            Close();
            DANGNHAP.m_bIsLogin = false;
        }

        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAll.Checked == true)
            {
                foreach (DataGridViewRow row in dataGridXoaSanPham.Rows)
                {
                    ((DataGridViewCheckBoxCell)row.Cells["DeletedState"]).Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridXoaSanPham.Rows)
                {
                    ((DataGridViewCheckBoxCell)row.Cells["DeletedState"]).Value = false;
                }
            }
        }
        bool checkLoadFished = false;
        private void CAPNHATXOASANPHAM_Load(object sender, EventArgs e)
        {
            resetTable();
        }

        private void resetTable()
        {
            checkLoadFished = false;

            this.dataGridXoaSanPham.Rows.Clear();
            List<myChiTietDongLaptopDTO> danhSachChiTietDongLapTop = myChiTietDongLaptopBUS.LayChiTietDongLaptop();
            foreach (myChiTietDongLaptopDTO chiTietDongLaptop in danhSachChiTietDongLapTop)
            {
                string bFingerprintReader;
                string sLoa;
                string sHDMI;
                if (chiTietDongLaptop.BFingerprintReader == 1)
                    bFingerprintReader = "Có";
                else
                    bFingerprintReader = "Không";
                //HDMI:
                if (chiTietDongLaptop.BHDMI == 1)
                    sHDMI = "Có";
                else
                    sHDMI = "Không";

                //Loa:
                if (chiTietDongLaptop.ChiTietDongLoa.BCoMicro == 1)
                    sLoa = chiTietDongLaptop.ChiTietDongLoa.STenDongLoa + " (có Micro)";
                else
                    sLoa = chiTietDongLaptop.ChiTietDongLoa.STenDongLoa + " (không có Micro)";

                this.dataGridXoaSanPham.Rows.Add(chiTietDongLaptop.BDeleted, false,
                    chiTietDongLaptop.IMaDongLaptop.ToString(),
                    chiTietDongLaptop.STenChiTietDongLapTop,
                    chiTietDongLaptop.ChiTietDongRam.STenDongRAM,
                    chiTietDongLaptop.ChiTietDongCPU.STenDongCPU,
                    chiTietDongLaptop.ChiTietDongManHinh.STenDongManHinh,
                    chiTietDongLaptop.ChiTietDongCacDoHoa.STenDongCardDoHoa + "  " + chiTietDongLaptop.ChiTietDongCacDoHoa.ChiTietBoNhoCardDoHoa.STenChiTietCardDoHoa,
                    sLoa,
                    chiTietDongLaptop.ChiTietDongODiaQuang.STenDongODiaQuang,
                    chiTietDongLaptop.ChiTietDongCardMang.ChiTietLoaiKetNoiMang.STenLoaiKetNoiCardMang,
                    chiTietDongLaptop.ChiTietDongCardReader.ChiTietCongNgheCardReader.STenCongNgheCardReader,
                    " độ phân giải " + chiTietDongLaptop.ChiTietDongWebCam.FDoPhanGiai.ToString("0.00") + "MG pixel",
                    chiTietDongLaptop.ChiTietDongPin.ChiTietThoiLuongPin.STenThoiLuongPin,
                    chiTietDongLaptop.ChiTietHeDieuHanh.STenHeDieuHanh,
                    chiTietDongLaptop.ChiTietTrongLuong.FGiaTriTrongLuong.ToString("0.00") + " kg",
                    chiTietDongLaptop.SMauSac, bFingerprintReader, sHDMI,
                    chiTietDongLaptop.ISoLuongCongUSB.ToString() + " cổng",
                    chiTietDongLaptop.NhaSanXuat.STenNhaSanXuat,
                    chiTietDongLaptop.DanhGia.ITongDiem.ToString() + " điểm",
                    chiTietDongLaptop.FGiaBanHienHanh.ToString(),
                    chiTietDongLaptop.ISoLuongNhap.ToString(),
                    chiTietDongLaptop.ISoLuongConLai.ToString(),
                    chiTietDongLaptop.IThoiGianBaoHanh.ToString() + " tháng");
            }

            checkLoadFished = true;
        }

        /// <summary>
        /// Lay danh sach MaDongLaptop de xoa
        /// </summary>
        /// <returns> mang cac so nguyen</returns>
        private List<int> LayMaDongLaptopCapnhat()
        {
            List<int> maDongLapTops = new List<int>();

            foreach (DataGridViewRow row in dataGridXoaSanPham.Rows)
            {
                bool checkDaXoaChua = Convert.ToBoolean(((DataGridViewCheckBoxCell)row.Cells["ChangedState"]).Value);
                if (checkDaXoaChua)
                    maDongLapTops.Add(Int32.Parse(row.Cells["MaDongLaptop"].Value.ToString()));
            }

            return maDongLapTops;
        }

        private void button_OK_XoaSanPham_Click(object sender, EventArgs e)
        {
            List<int> dsMaLapopsXoa = LayMaDongLaptopCapnhat();
            if (0 == dsMaLapopsXoa.Count)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm.");
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa/bỏ xóa những sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            bool bKetQua = myChiTietDongLaptopBUS.CapNhatXoaChiTietDongLaptop(dsMaLapopsXoa);
            if (bKetQua)
            {
                MessageBox.Show("Cập nhật thành công");
                resetTable();
            }
            else
                MessageBox.Show("Cập nhật thất bại");
        }

        int maChiTietDongLapTop;

        private void button_search_Click(object sender, EventArgs e)
        {
            checkLoadFished = false;

            if (textBox_MaSanPham.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm", "Thông báo");   
            }
            else
            {
                this.dataGridXoaSanPham.Rows.Clear();
                try
                {
                    maChiTietDongLapTop = int.Parse(textBox_MaSanPham.Text);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thong bao loi");
                }

                myChiTietDongLaptopDTO chiTietDongLaptop = myChiTietDongLaptopBUS.LayChiTietDongLaptop(maChiTietDongLapTop);
                if (chiTietDongLaptop != null)
                {
                    string bFingerprintReader;
                    string sLoa;
                    string sHDMI;
                    if (chiTietDongLaptop.BFingerprintReader == 1)
                        bFingerprintReader = "Có";
                    else
                        bFingerprintReader = "Không";
                    //HDMI:
                    if (chiTietDongLaptop.BHDMI == 1)
                        sHDMI = "Có";
                    else
                        sHDMI = "Không";

                    //Loa:
                    if (chiTietDongLaptop.ChiTietDongLoa.BCoMicro == 1)
                        sLoa = chiTietDongLaptop.ChiTietDongLoa.STenDongLoa + " (có Micro)";
                    else
                        sLoa = chiTietDongLaptop.ChiTietDongLoa.STenDongLoa + " (không có Micro)";

                    this.dataGridXoaSanPham.Rows.Add(chiTietDongLaptop.BDeleted,false,
                        chiTietDongLaptop.IMaDongLaptop.ToString(),
                        chiTietDongLaptop.STenChiTietDongLapTop,
                        chiTietDongLaptop.ChiTietDongRam.STenDongRAM,
                        chiTietDongLaptop.ChiTietDongCPU.STenDongCPU,
                        chiTietDongLaptop.ChiTietDongManHinh.STenDongManHinh,
                        chiTietDongLaptop.ChiTietDongCacDoHoa.STenDongCardDoHoa + "  " + chiTietDongLaptop.ChiTietDongCacDoHoa.ChiTietBoNhoCardDoHoa.STenChiTietCardDoHoa,
                        sLoa,
                        chiTietDongLaptop.ChiTietDongODiaQuang.STenDongODiaQuang,
                        chiTietDongLaptop.ChiTietDongCardMang.ChiTietLoaiKetNoiMang.STenLoaiKetNoiCardMang,
                        chiTietDongLaptop.ChiTietDongCardReader.ChiTietCongNgheCardReader.STenCongNgheCardReader,
                        " độ phân giải " + chiTietDongLaptop.ChiTietDongWebCam.FDoPhanGiai.ToString("0.00") + "MG pixel",
                        chiTietDongLaptop.ChiTietDongPin.ChiTietThoiLuongPin.STenThoiLuongPin,
                        chiTietDongLaptop.ChiTietHeDieuHanh.STenHeDieuHanh,
                        chiTietDongLaptop.ChiTietTrongLuong.FGiaTriTrongLuong.ToString("0.00") + " kg",
                        chiTietDongLaptop.SMauSac, bFingerprintReader, sHDMI,
                        chiTietDongLaptop.ISoLuongCongUSB.ToString() + " cổng",
                        chiTietDongLaptop.NhaSanXuat.STenNhaSanXuat,
                        chiTietDongLaptop.DanhGia.ITongDiem.ToString() + " điểm",
                        chiTietDongLaptop.FGiaBanHienHanh.ToString(),
                        chiTietDongLaptop.ISoLuongNhap.ToString(),
                        chiTietDongLaptop.ISoLuongConLai.ToString(),
                        chiTietDongLaptop.IThoiGianBaoHanh.ToString() + " tháng");
                }
            }
            checkLoadFished = true;
        }

        private void CAPNHATXOASANPHAM_FormClosing(object sender, FormClosingEventArgs e)
        {
            DANGNHAP.m_bIsLogin = false;
        }

        /// <summary>
        /// De goi dataGridXoaSanPham_CellValueChanged ngay lap tuc khi cell thay doi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridXoaSanPham_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridXoaSanPham.IsCurrentCellDirty)
            {
                dataGridXoaSanPham.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridXoaSanPham_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Xet de de tranh voi luc' load form len
            if (!checkLoadFished)
                return;

            //Neu thay doi cot "DeletedState" moi xet
            if (dataGridXoaSanPham.Columns[e.ColumnIndex].Name != "DeletedState")
                return;

            bool changed = (bool)((DataGridViewCheckBoxCell)dataGridXoaSanPham.Rows[e.RowIndex].Cells["ChangedState"]).Value;
            changed = !changed;
            ((DataGridViewCheckBoxCell)dataGridXoaSanPham.Rows[e.RowIndex].Cells["ChangedState"]).Value = changed;
        }
    }
}
