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
        private List<myChiTietKichThuocManHinhDTO> m_lKichThuocManHinh = new List<myChiTietKichThuocManHinhDTO>();
        private List<myChiTietBoNhoRamDTO> m_lBoNhoRAM = new List<myChiTietBoNhoRamDTO>();
        private List<myChiTietCongNgheRamDTO> m_lCongNgheRAM = new List<myChiTietCongNgheRamDTO>();

        public THEMDACTINHSANPHAM()
        {
            InitializeComponent();

            setEventTextChanged();
        }

        public void setEventTextChanged()
        {
            cB_CongNghe.TextChanged += new EventHandler(cB_TextChanged);
            cB_Xung.TextChanged += new EventHandler(cB_TextChanged);
            cB_Cached.TextChanged += new EventHandler(cB_TextChanged);
        }

        void cB_TextChanged(object sender, EventArgs e)
        {
            txt_FullName.Text = string.Format("Intel {0} - {1} ({2})", cB_CongNghe.Text.Trim(), cB_Xung.Text.Trim(), cB_Cached.Text.Trim());
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
                m_lBoNhoRAM = myChiTietBoNhoRamBUS.LayChiTietBoNhoRam();
                m_lCongNgheRAM = myChiTietCongNgheRamBUS.LayChiTietCongNgheRam();

                if (m_lBoNhoRAM.Count > 0)
                {
                    txt_BoNhoHienCo.Text = "";
                    foreach (myChiTietBoNhoRamDTO bn in m_lBoNhoRAM)
                    {
                        txt_BoNhoHienCo.Text += bn.STenChiTietBoNhoRam + ";  ";
                    }
                }

                if (m_lCongNgheRAM.Count > 0)
                {
                    txt_CongNgheHienCo.Text = "";
                    foreach (myChiTietCongNgheRamDTO cn in m_lCongNgheRAM)
                    {
                        txt_CongNgheHienCo.Text += cn.STenCongNgheRam + ";  ";
                    }
                }
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
    }
}
