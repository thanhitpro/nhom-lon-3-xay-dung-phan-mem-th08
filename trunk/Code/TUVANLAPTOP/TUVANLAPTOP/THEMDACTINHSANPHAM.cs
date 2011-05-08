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
        private List<myChiTietKichThuocManHinhDTO> m_lKichThuocManHinh = null;
        private List<myChiTietBoNhoRamDTO> m_lBoNhoRAM = null;
        private List<myChiTietCongNgheRamDTO> m_lCongNgheRAM = null;
        private List<myChiTietDungLuongOCungDTO> m_lDungLuongOCung = null;
        private List<myChiTietVongQuayOCungDTO> m_lVongQuayOCung = null;
        private List<myChiTietBoNhoCardDoHoaDTO> m_lBoNhoCardMH = null;
        private List<myChiTietHeDieuHanhDTO> m_lHeDieuHanh = null;

        public THEMDACTINHSANPHAM()
        {
            InitializeComponent();

            SetEventTextChanged();
        }

        public void SetEventTextChanged()
        {
            cB_CongNghe.TextChanged += new EventHandler(cB_TextChanged);
            cB_Xung.TextChanged += new EventHandler(cB_TextChanged);
            cB_Cached.TextChanged += new EventHandler(cB_TextChanged);
        }

        void cB_TextChanged(object sender, EventArgs e)
        {
            txt_FullName.Text = string.Format("Intel {0} - {1} ({2})", cB_CongNghe.Text.Trim(), cB_Xung.Text.Trim(), cB_Cached.Text.Trim());
        }

        void LoadDungLuong()
        {
            m_lDungLuongOCung = myChiTietDungLuongOCungBUS.LayChiTietDungLuongOCung();
            if (m_lDungLuongOCung.Count > 0)
            {
                txt_DungLuongHienCo.Text = "";
                foreach (myChiTietDungLuongOCungDTO dl in m_lDungLuongOCung)
                {
                    txt_DungLuongHienCo.AppendText(" + " + dl.STenChiTietDungLuongOCung + '\n');
                }
            }
        }

        void LoadVongQuay()
        {
            m_lVongQuayOCung = myChiTietVongQuayOCungBUS.LayChiTietVongQuayOCung();

            if (m_lVongQuayOCung.Count > 0)
            {
                txt_VongXoayHienCo.Text = "";
                foreach (myChiTietVongQuayOCungDTO vq in m_lVongQuayOCung)
                {
                    txt_VongXoayHienCo.AppendText(" + " + vq.STenChiTietVongQuayOCung + '\n');
                }
            }
        }

        void LoadDLRAM()
        {
            m_lBoNhoRAM = myChiTietBoNhoRamBUS.LayChiTietBoNhoRam();          
            if (m_lBoNhoRAM.Count > 0)
            {
                txt_BoNhoHienCo.Text = "";
                foreach (myChiTietBoNhoRamDTO bn in m_lBoNhoRAM)
                {
                    txt_BoNhoHienCo.Text += bn.STenChiTietBoNhoRam + ";  ";
                }
            }            
        }

        void LoadCNRAM()
        {
            m_lCongNgheRAM = myChiTietCongNgheRamBUS.LayChiTietCongNgheRam();
            if (m_lCongNgheRAM.Count > 0)
            {
                txt_CongNgheHienCo.Text = "";
                foreach (myChiTietCongNgheRamDTO cn in m_lCongNgheRAM)
                {
                    txt_CongNgheHienCo.Text += cn.STenCongNgheRam + ";  ";
                }
            }
        }

        void LoadManHinh()
        {
            m_lKichThuocManHinh = myChiTietKichThuocManHinhBUS.LayDSKichThuocManHinh();

            if (m_lKichThuocManHinh != null && m_lKichThuocManHinh.Count > 0)
            {
                rTxt_KichThuocDaCo.Text = "";
                foreach (myChiTietKichThuocManHinhDTO ctManHinh in m_lKichThuocManHinh)
                {
                    rTxt_KichThuocDaCo.AppendText(" +   " + ctManHinh.STenChiTietKichThuocManHinh + '\n');
                }
            }
        }

        void LoadBoNhoCardMH()
        {
            m_lBoNhoCardMH = myChiTietBoNhoCardDoHoaBUS.LayChiTietBoNhoCarMH();

            if (m_lBoNhoCardMH != null && m_lBoNhoCardMH.Count > 0)
            {
                rText_BoNhoCardMHHienCo.Text = "";
                foreach (myChiTietBoNhoCardDoHoaDTO ctBoNhoCardMH in m_lBoNhoCardMH)
                {
                    rText_BoNhoCardMHHienCo.AppendText(" +   " + ctBoNhoCardMH.STenChiTietCardDoHoa + '\n');
                }
            }
        }

        void LoadHDH()
        {
            m_lHeDieuHanh = myChiTietHeDieuHanhBUS.LayDSHeDieuHanh();

            if (m_lHeDieuHanh != null && m_lHeDieuHanh.Count > 0)
            {
                rText_HDHHienCo.Text = "";
                foreach (myChiTietHeDieuHanhDTO ctHDH in m_lHeDieuHanh)
                {
                    rText_HDHHienCo.AppendText(" +   " + ctHDH.STenHeDieuHanh + '\n');
                }
            }
        }

        private void tab_CPU_Enter(object sender, EventArgs e)
        {
            List<myChiTietCongNgheCPUDTO> dsCongNghe = myChiTietCongNgheCPUBUS.LayDSCongNgheCPU();
            if (dsCongNghe != null && dsCongNghe.Count > 0)
            {
                cB_CongNghe.DataSource = dsCongNghe;
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (cB_CongNghe.Text.Trim() == "")
            {
                MessageBox.Show("Thông tin Công nghệ CPU không để trống !", "Thông báo");
                return;
            }

            if (cB_Xung.Text.Trim() == "")
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
                    List<myChiTietCongNgheCPUDTO> dsCongNghe = (List<myChiTietCongNgheCPUDTO>)cB_CongNghe.DataSource;
                    myChiTietCongNgheCPUDTO cn = new myChiTietCongNgheCPUDTO();
                    cn.STenChiTietCongNgheCPU = cB_CongNghe.Text.Trim();
                    cn.FHeSo = (float)1.0;

                    myChiTietDongCPUDTO dongCPU = new myChiTietDongCPUDTO();
                    dongCPU.STenDongCPU = txt_FullName.Text;

                    if (dsCongNghe.Exists(CN => CN.STenChiTietCongNgheCPU == cB_CongNghe.Text.Trim()) == false)
                    {
                        //Nếu không tồn tại công nghệ CPU thì thêm mới vào:
                        cn.IMaChiTietCN = myChiTietCongNgheCPUBUS.ThemCongNgheCPU(cn);
                        dongCPU.ChiTietCongNgheCPU = cn;
                    }
                    else
                    {
                        //Nếu đã có dòng công nghệ chỉ thêm Tên dòng CPU mới:
                        dongCPU.ChiTietCongNgheCPU = dsCongNghe[cB_CongNghe.SelectedIndex];
                    }

                    if (myChiTietDongCPUBUS.ThemDongCPU(dongCPU))
                        MessageBox.Show("Thêm mới thành công dòng CPU: " + txt_FullName.Text, "Thông báo");
                    else
                        MessageBox.Show("Thêm mới thất bại !", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            cB_CongNghe.Text = "";
            cB_Cached.Text = "";
            cB_Xung.Text = "";
            txt_FullName.Text = "";

            cB_CongNghe.Focus();
        }

        private void tab_ManHinh_Enter(object sender, EventArgs e)
        {
            try
            {
                LoadManHinh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Thông báo");
            }
        }

        private void btn_ThemMoiMH_Click(object sender, EventArgs e)
        {
            if (txt_KichThuocMoi.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập kích thước mới muốn thêm !", "Thông báo");
                txt_KichThuocMoi.Focus();
                return;
            }

            try
            {
                if (m_lKichThuocManHinh.Exists(kt => kt.STenChiTietKichThuocManHinh == txt_KichThuocMoi.Text.Trim()))
                {
                    MessageBox.Show("Kích thước bạn muốn thêm đã tồn tại", "Thông báo");
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn thêm kích thước màn hình mới: " + txt_KichThuocMoi.Text.Trim() + " hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    myChiTietKichThuocManHinhDTO ctKichThuoc = new myChiTietKichThuocManHinhDTO();
                    ctKichThuoc.STenChiTietKichThuocManHinh = txt_KichThuocMoi.Text.Trim();
                    ctKichThuoc.FHeSo = (float)2.0;

                    if (myChiTietKichThuocManHinhBUS.ThemMoiKichThuocMH(ctKichThuoc) == true)
                    {
                        MessageBox.Show("Thêm mới kích thước: " + txt_KichThuocMoi.Text.Trim() + " thành công !", "Thông báo");
                        LoadManHinh();
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
            txt_KichThuocMoi.Text = "";
            txt_KichThuocMoi.Focus();
        }

        private void tab_Ram_Enter(object sender, EventArgs e)
        {
            try
            {
                LoadDLRAM();
                LoadCNRAM();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Mem_Click(object sender, EventArgs e)
        {
            if (txt_BoNhoRAMNew.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải thêm vào bộ nhớ RAM mới muốn thêm !", "Thông báo");
                txt_BoNhoRAMNew.Focus();
                return;
            }

            try
            {
                if (m_lBoNhoRAM.Exists(bn => bn.STenChiTietBoNhoRam == txt_BoNhoRAMNew.Text.Trim()))
                {
                    MessageBox.Show("Bộ nhớ RAM muốn thêm đã tồn tại", "Thông báo");
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn thêm bộ nhớ RAM mới : " + txt_BoNhoRAMNew.Text.Trim() + " hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    myChiTietBoNhoRamDTO bnRAM = new myChiTietBoNhoRamDTO();
                    bnRAM.STenChiTietBoNhoRam = txt_BoNhoRAMNew.Text.Trim();
                    bnRAM.FHeSo = (float)2.0;

                    if (myChiTietBoNhoRamBUS.ThemBoNhoRAM(bnRAM) == true)
                    {
                        MessageBox.Show("Thêm mới bộ nhớ RAM: " + txt_BoNhoRAMNew.Text.Trim() + " thành công !", "Thông báo");
                        LoadDLRAM();
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
            if (txt_CongNgheRAMNew.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải thêm vào công nghệ RAM mới muốn thêm !", "Thông báo");
                txt_CongNgheRAMNew.Focus();
                return;
            }

            try
            {
                if (m_lCongNgheRAM.Exists(cn => cn.STenCongNgheRam == txt_CongNgheRAMNew.Text.Trim()))
                {
                    MessageBox.Show("Công nghệ RAM muốn thêm đã tồn tại", "Thông báo");
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn thêm công nghệ RAM mới : " + txt_CongNgheRAMNew.Text.Trim() + " hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    myChiTietCongNgheRamDTO cnRAM = new myChiTietCongNgheRamDTO();
                    cnRAM.STenCongNgheRam = txt_CongNgheRAMNew.Text.Trim();
                    cnRAM.FHeSo = (float)2.0;

                    if (myChiTietCongNgheRamBUS.ThemCongNgheRAM(cnRAM) == true)
                    {
                        MessageBox.Show("Thêm mới công nghệ RAM: " + txt_CongNgheRAMNew.Text.Trim() + " thành công !", "Thông báo");
                        LoadCNRAM();
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
            txt_CongNgheRAMNew.Text = "";
            txt_BoNhoRAMNew.Text = "";
        }

        private void tab_OCung_Enter(object sender, EventArgs e)
        {
            try
            {
                LoadDungLuong();
                LoadVongQuay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ThemDungLuong_Click(object sender, EventArgs e)
        {
            if (txt_DungLuongNew.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập dung lượng mới muốn thêm !", "Thông báo");
                txt_DungLuongNew.Focus();
                return;
            }

            try
            {
                if (m_lDungLuongOCung.Exists(dl => dl.STenChiTietDungLuongOCung == txt_DungLuongNew.Text.Trim()))
                {
                    MessageBox.Show("Dung lượng bạn muốn thêm đã tồn tại", "Thông báo");
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn thêm dung lượng ổ cứng mới: " + txt_DungLuongNew.Text.Trim() + " hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    myChiTietDungLuongOCungDTO ctDungLuong = new myChiTietDungLuongOCungDTO();
                    ctDungLuong.STenChiTietDungLuongOCung = txt_DungLuongNew.Text.Trim();
                    ctDungLuong.FHeSo = (float)2.0;

                    if (myChiTietDungLuongOCungBUS.ThemDungLuongOCung(ctDungLuong) == true)
                    {
                        MessageBox.Show("Thêm mới dung lượng ổ cứng: " + txt_DungLuongNew.Text.Trim() + " thành công !", "Thông báo");
                        LoadDungLuong();
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
            if (txt_VongXoayNew.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập vòng xoay ổ cứng mới muốn thêm !", "Thông báo");
                txt_VongXoayNew.Focus();
                return;
            }

            try
            {
                if (m_lVongQuayOCung.Exists(vq => vq.STenChiTietVongQuayOCung == txt_VongXoayNew.Text.Trim()))
                {
                    MessageBox.Show("Vòng quay ổ cứng mới bạn muốn thêm đã tồn tại", "Thông báo");
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn thêm vòng quay ổ cứng mới: " + txt_VongXoayNew.Text.Trim() + " hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    myChiTietVongQuayOCungDTO ctVongQuay = new myChiTietVongQuayOCungDTO();
                    ctVongQuay.STenChiTietVongQuayOCung = txt_VongXoayNew.Text.Trim();
                    ctVongQuay.FHeSo = (float)2.0;

                    if (myChiTietVongQuayOCungBUS.ThemVongQuayOCung(ctVongQuay) == true)
                    {
                        MessageBox.Show("Thêm mới vòng quay ổ cứng: " + txt_VongXoayNew.Text.Trim() + " thành công !", "Thông báo");
                        LoadVongQuay();
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
                LoadBoNhoCardMH();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btn_ThemMoiCardMH_Click(object sender, EventArgs e)
        {
            if (txt_BoNhoCardMHNew.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập bộ nhớ card đồ họa mới muốn thêm !", "Thông báo");
                txt_BoNhoCardMHNew.Focus();
                return;
            }

            try
            {
                if (m_lBoNhoCardMH.Exists(bn => bn.STenChiTietCardDoHoa == txt_BoNhoCardMHNew.Text.Trim()))
                {
                    MessageBox.Show("Bộ nhớ Card đồ họa bạn muốn thêm đã tồn tại", "Thông báo");
                    txt_BoNhoCardMHNew.Focus();
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn thêm bộ nhớ card đồ hoạ mới: " + txt_BoNhoCardMHNew.Text.Trim() + " hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    myChiTietBoNhoCardDoHoaDTO ctBoNhoCardMH = new myChiTietBoNhoCardDoHoaDTO();
                    ctBoNhoCardMH.STenChiTietCardDoHoa = txt_BoNhoCardMHNew.Text.Trim();
                    ctBoNhoCardMH.FHeSo = (float)2.0;

                    if (myChiTietBoNhoCardDoHoaBUS.ThemBoNhoCardMH(ctBoNhoCardMH) == true)
                    {
                        MessageBox.Show("Thêm mới bộ nhớ card đồ họa: " + txt_BoNhoCardMHNew.Text.Trim() + " thành công !", "Thông báo");
                        LoadBoNhoCardMH();
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
            txt_BoNhoCardMHNew.Text = "";
            txt_BoNhoCardMHNew.Focus();
        }

        private void btn_HuyOCung_Click(object sender, EventArgs e)
        {
            txt_DungLuongNew.Text = "";
            txt_DungLuongNew.Focus();
            txt_VongXoayNew.Text = "";
        }

        private void tab_HeDieuHanh_Enter(object sender, EventArgs e)
        {
            try
            {
                LoadHDH();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo");
            }
        }

        private void btn_ThemHDH_Click(object sender, EventArgs e)
        {
            if (txt_HDHNew.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên Hệ Điều Hành mới muốn thêm !", "Thông báo");
                txt_HDHNew.Focus();
                return;
            }

            try
            {
                if (m_lHeDieuHanh.Exists(dhd => dhd.STenHeDieuHanh == txt_HDHNew.Text.Trim()))
                {
                    MessageBox.Show("Hệ điều hành bạn muốn thêm đã tồn tại", "Thông báo");
                    txt_HDHNew.Focus();
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn thêm Hệ Điều Hành mới: " + txt_HDHNew.Text.Trim() + " hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    myChiTietHeDieuHanhDTO ctHDH = new myChiTietHeDieuHanhDTO();
                    ctHDH.STenHeDieuHanh = txt_HDHNew.Text.Trim();
                    ctHDH.FHeSo = (float)2.0;

                    if (myChiTietHeDieuHanhBUS.ThemMoiHDH(ctHDH) == true)
                    {
                        MessageBox.Show("Thêm mới Hệ Điều Hành: " + txt_HDHNew.Text.Trim() + " thành công !", "Thông báo");
                        LoadHDH();
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
            txt_HDHNew.Text = "";
            txt_HDHNew.Focus();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
