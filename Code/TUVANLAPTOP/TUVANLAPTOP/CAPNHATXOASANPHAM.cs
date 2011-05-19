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
        bool m_bLoadFinished = false;

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

        /// <summary>
        /// Ham xu ly khi click vao button Quay lai
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Back_Click(object sender, EventArgs e)
        {
            ResetDataGridView();
        }

        /// <summary>
        /// Ham gan gia tri cho cac CheckBoxCell
        /// </summary>
        /// <param name="_bState">true:check - false:uncheck</param>
        public bool AssignValueToCheckBoxCell(bool _bState)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridXoaSanPham.Rows)
                    ((DataGridViewCheckBoxCell)row.Cells[0]).Value = _bState;
            }
            catch
            {
                MessageBox.Show("Lỗi khi gán giá trị cho check box cell", "Thông báo");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Ham xu ly khi có su thay doi o CheckBox Check All
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkAll.Checked == true)
                AssignValueToCheckBoxCell(true);
            else
                AssignValueToCheckBoxCell(false);
        }

        /// <summary>
        /// Ham khoi tao khi load form CAPNHATXOASANPHAM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CAPNHATXOASANPHAM_Load(object sender, EventArgs e)
        {
            ResetDataGridView();
        }

        /// <summary>
        /// Ham them du lieu chi tiet dong laptop vao DataGirdView
        /// </summary>
        /// <param name="chiTietDongLaptop"></param>
        public bool AddDataIntoDataGridView(myChiTietDongLaptopDTO chiTietDongLaptop)
        {
            try
            {
                string fingerPrintReader;
                string loa;
                string hDMI;

                if (chiTietDongLaptop.BFingerprintReader == 1)
                    fingerPrintReader = "Có";
                else
                    fingerPrintReader = "Không";
                //HDMI:
                if (chiTietDongLaptop.BHDMI == 1)
                    hDMI = "Có";
                else
                    hDMI = "Không";

                //Loa:
                if (chiTietDongLaptop.ChiTietDongLoa.BCoMicro == 1)
                    loa = chiTietDongLaptop.ChiTietDongLoa.STenDongLoa + " (có Micro)";
                else
                    loa = chiTietDongLaptop.ChiTietDongLoa.STenDongLoa + " (không có Micro)";

                this.dataGridXoaSanPham.Rows.Add(chiTietDongLaptop.BDeleted, false,
                    chiTietDongLaptop.IMaDongLaptop.ToString(),
                    chiTietDongLaptop.STenChiTietDongLapTop,
                    chiTietDongLaptop.ChiTietDongRam.STenDongRAM,
                    chiTietDongLaptop.ChiTietDongCPU.STenDongCPU,
                    chiTietDongLaptop.ChiTietDongManHinh.STenDongManHinh,
                    chiTietDongLaptop.ChiTietDongCacDoHoa.STenDongCardDoHoa + "  " + chiTietDongLaptop.ChiTietDongCacDoHoa.ChiTietBoNhoCardDoHoa.STenChiTietCardDoHoa,
                    loa,
                    chiTietDongLaptop.ChiTietDongODiaQuang.STenDongODiaQuang,
                    chiTietDongLaptop.ChiTietDongCardMang.ChiTietLoaiKetNoiMang.STenLoaiKetNoiCardMang,
                    chiTietDongLaptop.ChiTietDongCardReader.ChiTietCongNgheCardReader.STenCongNgheCardReader,
                    " độ phân giải " + chiTietDongLaptop.ChiTietDongWebCam.FDoPhanGiai.ToString("0.00") + "MG pixel",
                    chiTietDongLaptop.ChiTietDongPin.ChiTietThoiLuongPin.STenThoiLuongPin,
                    chiTietDongLaptop.ChiTietHeDieuHanh.STenHeDieuHanh,
                    chiTietDongLaptop.ChiTietTrongLuong.FGiaTriTrongLuong.ToString("0.00") + " kg",
                    chiTietDongLaptop.SMauSac, fingerPrintReader, hDMI,
                    chiTietDongLaptop.ISoLuongCongUSB.ToString() + " cổng",
                    chiTietDongLaptop.NhaSanXuat.STenNhaSanXuat,
                    chiTietDongLaptop.DanhGia.ITongDiem.ToString() + " điểm",
                    chiTietDongLaptop.FGiaBanHienHanh.ToString(),
                    chiTietDongLaptop.ISoLuongNhap.ToString(),
                    chiTietDongLaptop.ISoLuongConLai.ToString(),
                    chiTietDongLaptop.IThoiGianBaoHanh.ToString() + " tháng");
            }
            catch
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu vào data grid view", "Thông báo");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Ham khoi tao lai DataGirdViewXoaSanPham
        /// </summary>
        public bool ResetDataGridView()
        {
            int soLuongLaptop = 0;
            int soLuongLaptopDaXoa = 0;
            m_bLoadFinished = false;
            this.dataGridXoaSanPham.Rows.Clear();
            try
            {
                List<myChiTietDongLaptopDTO> danhSachChiTietDongLapTop = myChiTietDongLaptopBUS.LayDanhSachChiTietDongLaptop();
                foreach (myChiTietDongLaptopDTO chiTietDongLaptop in danhSachChiTietDongLapTop)
                {
                    soLuongLaptop++;
                    if (chiTietDongLaptop.BDeleted)
                    {
                        soLuongLaptopDaXoa++;
                        continue;
                    }

                    AddDataIntoDataGridView(chiTietDongLaptop);
                }
                if (soLuongLaptopDaXoa == soLuongLaptop)
                    checkAll.Checked = true;
                else checkAll.Checked = false;
                m_bLoadFinished = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Ham lay danh sach MaDongLaptop de xoa
        /// </summary>
        /// <returns> mang cac so nguyen</returns>
        public List<int> LayDanhSachMaDongLaptop()
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
            try
            {
            List<int> danhSachMaLaptopXoa = LayDanhSachMaDongLaptop();
            if (0 == danhSachMaLaptopXoa.Count)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm.");
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa/bỏ xóa những sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
          
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
        private void btn_search_Click(object sender, EventArgs e)
        {
            int maChiTietDongLaptop = 0;
            m_bLoadFinished = false;

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
                        AddDataIntoDataGridView(chiTietDongLaptop);
 
                    m_bLoadFinished = true;
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
            if (!m_bLoadFinished)
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
            m_bLoadFinished = false;
            this.dataGridXoaSanPham.Rows.Clear();
            try
            {
                List<myChiTietDongLaptopDTO> danhSachChiTietDongLaptop = myChiTietDongLaptopBUS.LayDanhSachChiTietDongLaptop();
                foreach (myChiTietDongLaptopDTO chiTietDongLaptop in danhSachChiTietDongLaptop)
                    AddDataIntoDataGridView(chiTietDongLaptop);

                m_bLoadFinished = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice");
            }
        }

        /// <summary>
        /// Ham xu ly khi click vao button Thoat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Ham xu ly khong cho nhap ky tu la chu cai vao textBox_MaSanPham
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_MaSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
