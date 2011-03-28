using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EStoreDTO;
using EStoreBUS;

namespace QLKS
{
    public partial class DANHMUCSANPHAM : DevComponents.DotNetBar.Office2007Form
    {
        private static DANHMUCSANPHAM aForm = null;
        private myDongLaptopBUS m_dLaptopBus = new myDongLaptopBUS();

        /// <summary>
        /// Hàm lấy thông tin các sản phẩm của danh mục tương ứng
        /// </summary>
        /// <param name="_dtg"></param>
        /// <param name="_iMaNhaSX"></param>
        private void LayDSDongLaptop(DataGridView _dtg, int _iMaNhaSX)
        {
            List<myDongLaptop> dsLaptop = m_dLaptopBus.LayDSDongLaptop(_iMaNhaSX);
            _dtg.Rows.Clear();
            for (int i = 0; i < dsLaptop.Count; i++)
            {
                _dtg.Rows.Add
                    (
                    dsLaptop[i].IMaDong, 
                    dsLaptop[i].STenDong,  
                    dsLaptop[i].SMauSac, 
                    dsLaptop[i].SMoTaThem, 
                    dsLaptop[i].FGiaBanHienHanh + " triệu", 
                    dsLaptop[i].IThoiGianBaoHanh + " tháng"
                    );
            }
        }

        private DANHMUCSANPHAM()
        {
            InitializeComponent();            
            tabItemAcer.Visible = true;
            tabItemAsus.Visible = false;
            tabItemDell.Visible = false;
            tabItemHp.Visible = false;
        }       
        
        public static DANHMUCSANPHAM Instance()
        {
            if (aForm == null)
            {
                aForm = new DANHMUCSANPHAM();
            }
            return aForm;
        }

        private void btn_Acer_Click(object sender, ClickEventArgs e)
        {
            LayDSDongLaptop(dataGridViewAcer, 6);
            tabItemAcer.Visible = true;
            tabItemAsus.Visible = false;
            tabItemDell.Visible = false;
            tabItemHp.Visible = false;
        }

        private void btn_Asus_Click(object sender, ClickEventArgs e)
        {
            LayDSDongLaptop(dataGridViewAsus, 10);
            tabItemAcer.Visible = false;
            tabItemAsus.Visible = true;
            tabItemDell.Visible = false;
            tabItemHp.Visible = false;
        }

        private void btn_Dell_Click(object sender, ClickEventArgs e)
        {
            LayDSDongLaptop(dataGridViewDell, 13);
            tabItemAcer.Visible = false;
            tabItemAsus.Visible = false;
            tabItemDell.Visible = true;
            tabItemHp.Visible = false;
        }

        private void btn_Hp_Click(object sender, ClickEventArgs e)
        {
            LayDSDongLaptop(dataGridViewHp, 12);
            tabItemAcer.Visible = false;
            tabItemAsus.Visible = false;
            tabItemDell.Visible = false;
            tabItemHp.Visible = true;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DANHMUCSANPHAM_Load(object sender, EventArgs e)
        {
           LayDSDongLaptop(dataGridViewAcer, 6);
        }        
    }
}