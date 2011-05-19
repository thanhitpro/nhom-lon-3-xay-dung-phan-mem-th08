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
    public partial class THEMDACTINHSANPHAM : Form
    {
        private List<myChiTietKichThuocManHinhDTO> danhsachKichThuocManHinh = null;
        private List<myChiTietBoNhoRamDTO> danhsachBoNhoRAM = null;
        private List<myChiTietCongNgheRamDTO> danhsachCongNgheRAM = null;
        private List<myChiTietDungLuongOCungDTO> danhsachDungLuongOCung = null;
        private List<myChiTietVongQuayOCungDTO> danhsachVongQuayOCung = null;
        private List<myChiTietBoNhoCardDoHoaDTO> danhsachBoNhoCardMH = null;
        private List<myChiTietHeDieuHanhDTO> danhsachHeDieuHanh = null;

        public THEMDACTINHSANPHAM()
        {
            InitializeComponent();

            this.SetEventTextChanged();
        }

        public void SetEventTextChanged()
        {
            cB_CongNghe.TextChanged += new EventHandler(this.cB_TextChanged);
            cB_Xung.TextChanged += new EventHandler(this.cB_TextChanged);
            cB_Cached.TextChanged += new EventHandler(this.cB_TextChanged);
        }

        void cB_TextChanged(object sender, EventArgs e)
        {
            txt_FullName.Text = string.Format("Intel {0} - {1} ({2})", cB_CongNghe.Text.Trim(), cB_Xung.Text.Trim(), cB_Cached.Text.Trim());
        }

        void LoadDungLuong()
        {
            this.danhsachDungLuongOCung = myChiTietDungLuongOCungBUS.LayChiTietDungLuongOCung();
            if (this.danhsachDungLuongOCung.Count > 0)
            {
                txt_DungLuongHienCo.Text = string.Empty;
                foreach (myChiTietDungLuongOCungDTO dl in this.danhsachDungLuongOCung)
                {
                    txt_DungLuongHienCo.AppendText(" + " + dl.STenChiTietDungLuongOCung + '\n');
                }
            }
        }

        void LoadVongQuay()
        {
            this.danhsachVongQuayOCung = myChiTietVongQuayOCungBUS.LayDanhSachChiTietVongQuayOCung();

            if (this.danhsachVongQuayOCung.Count > 0)
            {
                txt_VongXoayHienCo.Text = string.Empty;
                foreach (myChiTietVongQuayOCungDTO vq in this.danhsachVongQuayOCung)
                {
                    txt_VongXoayHienCo.AppendText(" + " + vq.STenChiTietVongQuayOCung + '\n');
                }
            }
        }

        void LoadDLRAM()
        {
            this.danhsachBoNhoRAM = myChiTietBoNhoRamBUS.LayChiTietBoNhoRam();          
            if (this.danhsachBoNhoRAM.Count > 0)
            {
                txt_BoNhoHienCo.Text = string.Empty;
                foreach (myChiTietBoNhoRamDTO bn in this.danhsachBoNhoRAM)
                {
                    txt_BoNhoHienCo.Text += bn.STenChiTietBoNhoRam + ";  ";
                }
            }            
        }

        void LoadCNRAM()
        {
            this.danhsachCongNgheRAM = myChiTietCongNgheRamBUS.LayChiTietCongNgheRam();
            if (this.danhsachCongNgheRAM.Count > 0)
            {
                txt_CongNgheHienCo.Text = string.Empty;
                foreach (myChiTietCongNgheRamDTO cn in this.danhsachCongNgheRAM)
                {
                    txt_CongNgheHienCo.Text += cn.STenCongNgheRam + ";  ";
                }
            }
        }

        void LoadManHinh()
        {
            this.danhsachKichThuocManHinh = myChiTietKichThuocManHinhBUS.LayDSKichThuocManHinh();

            if (this.danhsachKichThuocManHinh != null && this.danhsachKichThuocManHinh.Count > 0)
            {
                rTxt_KichThuocDaCo.Text = string.Empty;
                foreach (myChiTietKichThuocManHinhDTO chitietManHinh in this.danhsachKichThuocManHinh)
                {
                    rTxt_KichThuocDaCo.AppendText(" +   " + chitietManHinh.STenChiTietKichThuocManHinh + '\n');
                }
            }
        }

        void LoadBoNhoCardMH()
        {
            this.danhsachBoNhoCardMH = myChiTietBoNhoCardDoHoaBUS.LayDanhSachChiTietBoNhoCardMH();

            if (this.danhsachBoNhoCardMH != null && this.danhsachBoNhoCardMH.Count > 0)
            {
                rText_BoNhoCardMHHienCo.Text = string.Empty;
                foreach (myChiTietBoNhoCardDoHoaDTO chitietBoNhoCardMH in this.danhsachBoNhoCardMH)
                {
                    rText_BoNhoCardMHHienCo.AppendText(" +   " + chitietBoNhoCardMH.STenChiTietCardDoHoa + '\n');
                }
            }
        }

        void LoadHDH()
        {
            this.danhsachHeDieuHanh = myChiTietHeDieuHanhBUS.LayDSHeDieuHanh();

            if (this.danhsachHeDieuHanh != null && this.danhsachHeDieuHanh.Count > 0)
            {
                rText_HDHHienCo.Text = string.Empty;
                foreach (myChiTietHeDieuHanhDTO chitietHDH in this.danhsachHeDieuHanh)
                {
                    rText_HDHHienCo.AppendText(" +   " + chitietHDH.STenHeDieuHanh + '\n');
                }
            }
        }

        private void tab_CPU_Enter(object sender, EventArgs e)
        {
            List<myChiTietCongNgheCPUDTO> danhsachCongNghe = myChiTietCongNgheCPUBUS.LayDSCongNgheCPU();
            if (danhsachCongNghe != null && danhsachCongNghe.Count > 0)
            {
                cB_CongNghe.DataSource = danhsachCongNghe;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (cB_CongNghe.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Thông tin Công nghệ CPU không để trống !", "Thông báo");
                return;
            }

            if (cB_Xung.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Thông tin Tốc độ xung không để trống !", "Thông báo");
                return;
            }

            try
            {
                if (myChiTietDongCPUBUS.KiemTraTonTaiDongCPU(txt_FullName.Text))
                {
                    MessageBox.Show("Dòng CPU " + txt_FullName.Text + " đã tồn tại ! ", "Thông báo");
                    return;
                }

                if (MessageBox.Show("Bạn có muốn thêm dòng CPU mới: " + txt_FullName.Text + " hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    List<myChiTietCongNgheCPUDTO> danhsachCongNghe = (List<myChiTietCongNgheCPUDTO>)cB_CongNghe.DataSource;
                    myChiTietCongNgheCPUDTO cn = new myChiTietCongNgheCPUDTO();
                    cn.STenChiTietCongNgheCPU = cB_CongNghe.Text.Trim();
                    cn.FHeSo = (float)1.0;

                    myChiTietDongCPUDTO dongCPU = new myChiTietDongCPUDTO();
                    dongCPU.STenDongCPU = txt_FullName.Text;

                    if (danhsachCongNghe.Exists(CN => CN.STenChiTietCongNgheCPU == cB_CongNghe.Text.Trim()) == false)
                    {
                        // Nếu không tồn tại công nghệ CPU thì thêm mới vào:
                        cn.IMaChiTietCN = myChiTietCongNgheCPUBUS.ThemCongNgheCPU(cn);
                        dongCPU.ChiTietCongNgheCPU = cn;
                    }
                    else
                    {
                        // Nếu đã có dòng công nghệ chỉ thêm Tên dòng CPU mới:
                        dongCPU.ChiTietCongNgheCPU = danhsachCongNghe[cB_CongNghe.SelectedIndex];
                    }

                    if (myChiTietDongCPUBUS.ThemDongCPU(dongCPU))
                    {
                        MessageBox.Show("Thêm mới thành công dòng CPU: " + txt_FullName.Text, "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thất bại !", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            cB_CongNghe.Text = string.Empty;
            cB_Cached.Text = string.Empty;
            cB_Xung.Text = string.Empty;
            txt_FullName.Text = string.Empty;

            cB_CongNghe.Focus();
        }

        private void tab_ManHinh_Enter(object sender, EventArgs e)
        {
            try
            {
                this.LoadManHinh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Thông báo");
            }
        }

        private void btn_ThemMoiMH_Click(object sender, EventArgs e)
        {
            if (txt_KichThuocMoi.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập kích thước mới muốn thêm !", "Thông báo");
                txt_KichThuocMoi.Focus();
                return;
            }

            try
            {
                if (this.danhsachKichThuocManHinh.Exists(kt => kt.STenChiTietKichThuocManHinh == txt_KichThuocMoi.Text.Trim()))
                {
                    MessageBox.Show("Kích thước bạn muốn thêm đã tồn tại", "Thông báo");
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn thêm kích thước màn hình mới: " + txt_KichThuocMoi.Text.Trim() + " hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    myChiTietKichThuocManHinhDTO chitietKichThuoc = new myChiTietKichThuocManHinhDTO();
                    chitietKichThuoc.STenChiTietKichThuocManHinh = txt_KichThuocMoi.Text.Trim();
                    chitietKichThuoc.FHeSo = (float)2.0;

                    if (myChiTietKichThuocManHinhBUS.ThemMoiKichThuocMH(chitietKichThuoc) == true)
                    {
                        MessageBox.Show("Thêm mới kích thước: " + txt_KichThuocMoi.Text.Trim() + " thành công !", "Thông báo");
                        this.LoadManHinh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btn_HuyBoMH_Click(object sender, EventArgs e)
        {
            txt_KichThuocMoi.Text = string.Empty;
            txt_KichThuocMoi.Focus();
        }

        private void tab_Ram_Enter(object sender, EventArgs e)
        {
            try
            {
                this.LoadDLRAM();
                this.LoadCNRAM();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Mem_Click(object sender, EventArgs e)
        {
            if (txt_BoNhoRAMNew.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn phải thêm vào bộ nhớ RAM mới muốn thêm !", "Thông báo");
                txt_BoNhoRAMNew.Focus();
                return;
            }

            try
            {
                if (this.danhsachBoNhoRAM.Exists(bn => bn.STenChiTietBoNhoRam == txt_BoNhoRAMNew.Text.Trim()))
                {
                    MessageBox.Show("Bộ nhớ RAM muốn thêm đã tồn tại", "Thông báo");
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn thêm bộ nhớ RAM mới : " + txt_BoNhoRAMNew.Text.Trim() + " hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    myChiTietBoNhoRamDTO bonhoRAM = new myChiTietBoNhoRamDTO();
                    bonhoRAM.STenChiTietBoNhoRam = txt_BoNhoRAMNew.Text.Trim();
                    bonhoRAM.FHeSo = (float)2.0;

                    if (myChiTietBoNhoRamBUS.ThemBoNhoRAM(bonhoRAM) == true)
                    {
                        MessageBox.Show("Thêm mới bộ nhớ RAM: " + txt_BoNhoRAMNew.Text.Trim() + " thành công !", "Thông báo");
                        this.LoadDLRAM();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btn_Tech_Click(object sender, EventArgs e)
        {
            if (txt_CongNgheRAMNew.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn phải thêm vào công nghệ RAM mới muốn thêm !", "Thông báo");
                txt_CongNgheRAMNew.Focus();
                return;
            }

            try
            {
                if (this.danhsachCongNgheRAM.Exists(cn => cn.STenCongNgheRam == txt_CongNgheRAMNew.Text.Trim()))
                {
                    MessageBox.Show("Công nghệ RAM muốn thêm đã tồn tại", "Thông báo");
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn thêm công nghệ RAM mới : " + txt_CongNgheRAMNew.Text.Trim() + " hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    myChiTietCongNgheRamDTO congngheRAM = new myChiTietCongNgheRamDTO();
                    congngheRAM.STenCongNgheRam = txt_CongNgheRAMNew.Text.Trim();
                    congngheRAM.FHeSo = (float)2.0;

                    if (myChiTietCongNgheRamBUS.ThemCongNgheRAM(congngheRAM) == true)
                    {
                        MessageBox.Show("Thêm mới công nghệ RAM: " + txt_CongNgheRAMNew.Text.Trim() + " thành công !", "Thông báo");
                        this.LoadCNRAM();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_CongNgheRAMNew.Text = string.Empty;
            txt_BoNhoRAMNew.Text = string.Empty;
        }

        private void tab_OCung_Enter(object sender, EventArgs e)
        {
            try
            {
                this.LoadDungLuong();
                this.LoadVongQuay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ThemDungLuong_Click(object sender, EventArgs e)
        {
            if (txt_DungLuongNew.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập dung lượng mới muốn thêm !", "Thông báo");
                txt_DungLuongNew.Focus();
                return;
            }

            try
            {
                if (this.danhsachDungLuongOCung.Exists(dl => dl.STenChiTietDungLuongOCung == txt_DungLuongNew.Text.Trim()))
                {
                    MessageBox.Show("Dung lượng bạn muốn thêm đã tồn tại", "Thông báo");
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn thêm dung lượng ổ cứng mới: " + txt_DungLuongNew.Text.Trim() + " hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    myChiTietDungLuongOCungDTO chitietDungLuong = new myChiTietDungLuongOCungDTO();
                    chitietDungLuong.STenChiTietDungLuongOCung = txt_DungLuongNew.Text.Trim();
                    chitietDungLuong.FHeSo = (float)2.0;

                    if (myChiTietDungLuongOCungBUS.ThemDungLuongOCung(chitietDungLuong) == true)
                    {
                        MessageBox.Show("Thêm mới dung lượng ổ cứng: " + txt_DungLuongNew.Text.Trim() + " thành công !", "Thông báo");
                        this.LoadDungLuong();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_VongXoayNew.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập vòng xoay ổ cứng mới muốn thêm !", "Thông báo");
                txt_VongXoayNew.Focus();
                return;
            }

            try
            {
                if (this.danhsachVongQuayOCung.Exists(vq => vq.STenChiTietVongQuayOCung == txt_VongXoayNew.Text.Trim()))
                {
                    MessageBox.Show("Vòng quay ổ cứng mới bạn muốn thêm đã tồn tại", "Thông báo");
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn thêm vòng quay ổ cứng mới: " + txt_VongXoayNew.Text.Trim() + " hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    myChiTietVongQuayOCungDTO chitietVongQuay = new myChiTietVongQuayOCungDTO();
                    chitietVongQuay.STenChiTietVongQuayOCung = txt_VongXoayNew.Text.Trim();
                    chitietVongQuay.FHeSo = (float)2.0;

                    if (myChiTietVongQuayOCungBUS.ThemVongQuayOCung(chitietVongQuay) == true)
                    {
                        MessageBox.Show("Thêm mới vòng quay ổ cứng: " + txt_VongXoayNew.Text.Trim() + " thành công !", "Thông báo");
                        this.LoadVongQuay();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void tab_CardMH_Enter(object sender, EventArgs e)
        {
            try
            {
                this.LoadBoNhoCardMH();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btn_ThemMoiCardMH_Click(object sender, EventArgs e)
        {
            if (txt_BoNhoCardMHNew.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập bộ nhớ card đồ họa mới muốn thêm !", "Thông báo");
                txt_BoNhoCardMHNew.Focus();
                return;
            }

            try
            {
                if (this.danhsachBoNhoCardMH.Exists(bn => bn.STenChiTietCardDoHoa == txt_BoNhoCardMHNew.Text.Trim()))
                {
                    MessageBox.Show("Bộ nhớ Card đồ họa bạn muốn thêm đã tồn tại", "Thông báo");
                    txt_BoNhoCardMHNew.Focus();
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn thêm bộ nhớ card đồ hoạ mới: " + txt_BoNhoCardMHNew.Text.Trim() + " hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    myChiTietBoNhoCardDoHoaDTO chitietBoNhoCardMH = new myChiTietBoNhoCardDoHoaDTO();
                    chitietBoNhoCardMH.STenChiTietCardDoHoa = txt_BoNhoCardMHNew.Text.Trim();
                    chitietBoNhoCardMH.FHeSo = (float)2.0;

                    if (myChiTietBoNhoCardDoHoaBUS.ThemBoNhoCardMH(chitietBoNhoCardMH) == true)
                    {
                        MessageBox.Show("Thêm mới bộ nhớ card đồ họa: " + txt_BoNhoCardMHNew.Text.Trim() + " thành công !", "Thông báo");
                        this.LoadBoNhoCardMH();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btn_HuyCardMH_Click(object sender, EventArgs e)
        {
            txt_BoNhoCardMHNew.Text = string.Empty;
            txt_BoNhoCardMHNew.Focus();
        }

        private void btn_HuyOCung_Click(object sender, EventArgs e)
        {
            txt_DungLuongNew.Text = string.Empty;
            txt_DungLuongNew.Focus();
            txt_VongXoayNew.Text = string.Empty;
        }

        private void tab_HeDieuHanh_Enter(object sender, EventArgs e)
        {
            try
            {
                this.LoadHDH();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btn_ThemHDH_Click(object sender, EventArgs e)
        {
            if (txt_HDHNew.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Bạn phải nhập tên Hệ Điều Hành mới muốn thêm !", "Thông báo");
                txt_HDHNew.Focus();
                return;
            }

            try
            {
                if (this.danhsachHeDieuHanh.Exists(dhd => dhd.STenHeDieuHanh == txt_HDHNew.Text.Trim()))
                {
                    MessageBox.Show("Hệ điều hành bạn muốn thêm đã tồn tại", "Thông báo");
                    txt_HDHNew.Focus();
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn thêm Hệ Điều Hành mới: " + txt_HDHNew.Text.Trim() + " hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    myChiTietHeDieuHanhDTO chitietHDH = new myChiTietHeDieuHanhDTO();
                    chitietHDH.STenHeDieuHanh = txt_HDHNew.Text.Trim();
                    chitietHDH.FHeSo = (float)2.0;

                    if (myChiTietHeDieuHanhBUS.ThemMoiHDH(chitietHDH) == true)
                    {
                        MessageBox.Show("Thêm mới Hệ Điều Hành: " + txt_HDHNew.Text.Trim() + " thành công !", "Thông báo");
                        this.LoadHDH();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btn_HuyHDH_Click(object sender, EventArgs e)
        {
            txt_HDHNew.Text = String.Empty;
            txt_HDHNew.Focus();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
