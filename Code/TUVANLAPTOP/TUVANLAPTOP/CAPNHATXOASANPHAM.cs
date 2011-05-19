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
        private static CAPNHATXOASANPHAM m_stForm = null;

        public static CAPNHATXOASANPHAM Instance()
        {
            if (m_stForm == null)
            {
                m_stForm = new CAPNHATXOASANPHAM();
            }
            return m_stForm;
        }

        public CAPNHATXOASANPHAM()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            ResetDataGridView();
        }

        /// <summary>
        /// Ham xu ly khi có su thay doi o CheckBox Check All
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAll.Checked == true)
            {
                foreach (DataGridViewRow row in dataGridXoaSanPham.Rows)
                {
                    ((DataGridViewCheckBoxCell)row.Cells[0]).Value = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridXoaSanPham.Rows)
                {
                    ((DataGridViewCheckBoxCell)row.Cells[0]).Value = false;
                }
            }
        }

        bool IsCheckLoadFinished = false;

        private void CAPNHATXOASANPHAM_Load(object sender, EventArgs e)
        {
            ResetDataGridView();
        }

        /// <summary>
        /// Ham khoi tao lai DataGirdViewXoaSanPham
        /// </summary>
        private void ResetDataGridView()
        {
            int soLuongLaptop = 0;
            int soLuongLaptopDaXoa = 0;
            IsCheckLoadFinished = false;
            this.dataGridXoaSanPham.Rows.Clear();
            try
            {
                List<myChiTietDongLaptopDTO> danhSachChiTietDongLapTop = myChiTietDongLaptopBUS.LayDanhSachChiTietDongLaptop();
                foreach (myChiTietDongLaptopDTO chiTietDongLaptop in danhSachChiTietDongLapTop)
                {
                    soLuongLaptop++;
                    string sFingerprintReader;
                    string sLoa;
                    string sHDMI;

                    if (chiTietDongLaptop.BDeleted)
                    {
                        soLuongLaptopDaXoa++;
                        continue;
                    }

                    if (chiTietDongLaptop.BFingerprintReader == 1)
                        sFingerprintReader = "Có";
                    else
                        sFingerprintReader = "Không";
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
                        chiTietDongLaptop.SMauSac, sFingerprintReader, sHDMI,
                        chiTietDongLaptop.ISoLuongCongUSB.ToString() + " cổng",
                        chiTietDongLaptop.NhaSanXuat.STenNhaSanXuat,
                        chiTietDongLaptop.DanhGia.ITongDiem.ToString() + " điểm",
                        chiTietDongLaptop.FGiaBanHienHanh.ToString(),
                        chiTietDongLaptop.ISoLuongNhap.ToString(),
                        chiTietDongLaptop.ISoLuongConLai.ToString(),
                        chiTietDongLaptop.IThoiGianBaoHanh.ToString() + " tháng");
                }
                if (soLuongLaptopDaXoa == soLuongLaptop)
                    checkAll.Checked = true;
                else checkAll.Checked = false;
                IsCheckLoadFinished = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice");
            }
        }

        /// <summary>
        /// Ham lay danh sach MaDongLaptop de xoa
        /// </summary>
        /// <returns> mang cac so nguyen</returns>
        private List<int> LayDanhSachMaDongLaptop()
        {
            List<int> danhSachMaDongLaptop = new List<int>();

            try
            {
                foreach (DataGridViewRow row in dataGridXoaSanPham.Rows)
                {
                    bool checkDaXoaChua = Convert.ToBoolean(((DataGridViewCheckBoxCell)row.Cells["ChangedState"]).Value);
                    if (checkDaXoaChua)
                        danhSachMaDongLaptop.Add(Int32.Parse(row.Cells["MaDongLaptop"].Value.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice");
            }
            return danhSachMaDongLaptop;
        }

        /// <summary>
        /// Ham xu ly khi click vao button OK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OK_Click(object sender, EventArgs e)
        {
            List<int> danhSachMaLaptopXoa = LayDanhSachMaDongLaptop();
            if (0 == danhSachMaLaptopXoa.Count)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm.");
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa/bỏ xóa những sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            try
            {
                bool bKetQua = myChiTietDongLaptopBUS.CapNhatXoaChiTietDongLaptop(danhSachMaLaptopXoa);
                if (bKetQua)
                {
                    MessageBox.Show("Cập nhật thành công");
                    ResetDataGridView();
                }
                else
                    MessageBox.Show("Cập nhật thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice");
            }
        }    

        /// <summary>
        /// Ham xu ly khi click vao button Search
        /// </summary>
        int maChiTietDongLaptop;
        private void btn_search_Click(object sender, EventArgs e)
        {
            IsCheckLoadFinished = false;

            if (textBox_MaSanPham.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm", "Thông báo");
            }
            else
            {
                this.dataGridXoaSanPham.Rows.Clear();
                try
                {
                    maChiTietDongLaptop = int.Parse(textBox_MaSanPham.Text);
                    myChiTietDongLaptopDTO chiTietDongLaptop = myChiTietDongLaptopBUS.LayChiTietDongLaptop(maChiTietDongLaptop);
                    if (chiTietDongLaptop != null)
                    {
                        string sFingerprintReader;
                        string sLoa;
                        string sHDMI;
                        if (chiTietDongLaptop.BFingerprintReader == 1)
                            sFingerprintReader = "Có";
                        else
                            sFingerprintReader = "Không";
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
                            chiTietDongLaptop.SMauSac, sFingerprintReader, sHDMI,
                            chiTietDongLaptop.ISoLuongCongUSB.ToString() + " cổng",
                            chiTietDongLaptop.NhaSanXuat.STenNhaSanXuat,
                            chiTietDongLaptop.DanhGia.ITongDiem.ToString() + " điểm",
                            chiTietDongLaptop.FGiaBanHienHanh.ToString(),
                            chiTietDongLaptop.ISoLuongNhap.ToString(),
                            chiTietDongLaptop.ISoLuongConLai.ToString(),
                            chiTietDongLaptop.IThoiGianBaoHanh.ToString() + " tháng");
                    }
                    IsCheckLoadFinished = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Notice");
                }
            }
        }

        /// <summary>
        /// Ham dung de goi dataGridXoaSanPham_CellValueChanged ngay lap tuc khi cell thay doi
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

        /// <summary>
        /// Ham xu ly su thay doi gia tri tren CheckBox DeletedState
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridXoaSanPham_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Xet de de tranh voi luc' load form len
            if (!IsCheckLoadFinished)
                return;

            //Neu thay doi cot "DeletedState" moi xet
            if (dataGridXoaSanPham.Columns[e.ColumnIndex].Name != "DeletedState")
                return;

            bool changed = (bool)((DataGridViewCheckBoxCell)dataGridXoaSanPham.Rows[e.RowIndex].Cells["ChangedState"]).Value;
            changed = !changed;
            ((DataGridViewCheckBoxCell)dataGridXoaSanPham.Rows[e.RowIndex].Cells["ChangedState"]).Value = changed;
        }

        /// <summary>
        /// Ham xu ly khi click vao button HienTatCa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            IsCheckLoadFinished = false;
            this.dataGridXoaSanPham.Rows.Clear();
            try
            {
                List<myChiTietDongLaptopDTO> danhSachChiTietDongLaptop = myChiTietDongLaptopBUS.LayDanhSachChiTietDongLaptop();
                foreach (myChiTietDongLaptopDTO chiTietDongLaptop in danhSachChiTietDongLaptop)
                {
                    string sFingerprintReader;
                    string sLoa;
                    string sHDMI;

                    if (chiTietDongLaptop.BFingerprintReader == 1)
                        sFingerprintReader = "Có";
                    else
                        sFingerprintReader = "Không";
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
                        chiTietDongLaptop.SMauSac, sFingerprintReader, sHDMI,
                        chiTietDongLaptop.ISoLuongCongUSB.ToString() + " cổng",
                        chiTietDongLaptop.NhaSanXuat.STenNhaSanXuat,
                        chiTietDongLaptop.DanhGia.ITongDiem.ToString() + " điểm",
                        chiTietDongLaptop.FGiaBanHienHanh.ToString(),
                        chiTietDongLaptop.ISoLuongNhap.ToString(),
                        chiTietDongLaptop.ISoLuongConLai.ToString(),
                        chiTietDongLaptop.IThoiGianBaoHanh.ToString() + " tháng");
                }

                IsCheckLoadFinished = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_MaSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            CAPNHATDULIEUKHACHHANG frm = new CAPNHATDULIEUKHACHHANG();
            frm.ShowDialog();
        }
    }
}
