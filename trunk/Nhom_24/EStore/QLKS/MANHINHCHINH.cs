using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using EStoreBUS;
using EStoreDTO;

namespace QLKS
{
    public partial class MANHINHCHINH : DevComponents.DotNetBar.Office2007RibbonForm
    {
        private myNhaSXBUS m_nSXBus = new myNhaSXBUS();
        private myDongLaptopBUS m_dLaptopBus = new myDongLaptopBUS();

        public MANHINHCHINH()
        {
            InitializeComponent();
        }

        ///<summary>
        /// Hàm thêm mới một ExpandablePanel có tiêu đề là _sTieuDe, và chứa các item là các dòng Laptop
        ///</summary>
        private void ThemMoiExpandablePanel(string _sTieuDe, List<myDongLaptop> _mdDSDongLaptop)
        {
            ExpandablePanel newExPanel = new ExpandablePanel();

            // Khởi tạo các giá trị cho Expanel:
            newExPanel.AutoScroll = true;
            newExPanel.CanvasColor = System.Drawing.SystemColors.Control;
            newExPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            newExPanel.Dock = System.Windows.Forms.DockStyle.Top;
            newExPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            newExPanel.Location = new System.Drawing.Point(1, 368);
            newExPanel.Size = new System.Drawing.Size(230, 171);
            newExPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            newExPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            newExPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            newExPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            newExPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            newExPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            newExPanel.Style.GradientAngle = 90;
            newExPanel.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            newExPanel.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            newExPanel.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            newExPanel.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            newExPanel.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            newExPanel.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            newExPanel.TitleStyle.GradientAngle = 90;
            newExPanel.TitleText = _sTieuDe + " (" + _mdDSDongLaptop.Count.ToString() + ")"; 
            newExPanel.Expanded = false;

            //Thêm một itemPanel trong ExPanel:
            ItemPanel itemPanel = new ItemPanel();
            itemPanel.AutoScroll = true;
            itemPanel.BackgroundStyle.BackColor = System.Drawing.Color.White;
            itemPanel.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            itemPanel.BackgroundStyle.BorderBottomWidth = 1;
            itemPanel.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            itemPanel.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            itemPanel.BackgroundStyle.BorderLeftWidth = 1;
            itemPanel.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            itemPanel.BackgroundStyle.BorderRightWidth = 1;
            itemPanel.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            itemPanel.BackgroundStyle.BorderTopWidth = 1;
            itemPanel.BackgroundStyle.PaddingBottom = 1;
            itemPanel.BackgroundStyle.PaddingLeft = 1;
            itemPanel.BackgroundStyle.PaddingRight = 1;
            itemPanel.BackgroundStyle.PaddingTop = 1;
            itemPanel.ContainerControlProcessDialogKey = true;
            itemPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            itemPanel.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            itemPanel.Location = new System.Drawing.Point(0, 26);
            itemPanel.Size = new System.Drawing.Size(230, 145);

            //Thêm các button là tên các dòng laptop cho từng Expanel:
            if (_mdDSDongLaptop.Count > 0)
            {
                foreach (myDongLaptop mdDong in _mdDSDongLaptop)
                {
                    ButtonItem btItem = new ButtonItem();
                    btItem.Text = mdDong.STenDong;
                    btItem.Name = mdDong.IMaDong.ToString();
                    btItem.Tag = mdDong;
                    itemPanel.Items.Add(btItem);
                }
            }

            newExPanel.Controls.Add(itemPanel);
            tabControlPanel1.Controls.Add(newExPanel);
        }

        private void buttonItem41_Click(object sender, EventArgs e)
        {
            DANHMUCSANPHAM frm = new DANHMUCSANPHAM();            
            frm.MdiParent = this;
            frm.Parent = panelWelcome;
            frm.Show();
        }

        private void buttonItem40_Click(object sender, EventArgs e)
        {            
            THEMKHACHHANG frm = new THEMKHACHHANG();            
            frm.MdiParent = this;
            frm.Parent = panelWelcome;
            frm.Show();
        }   
     
        /// <summary>
        /// Hàm xử lý sự kiện Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void MANHINHCHINH_Load(object sender, EventArgs e)
        {
            List<myNhaSX> dsNhaSX = m_nSXBus.LayDSNhaSX();
            foreach (myNhaSX nhaSX in dsNhaSX)
            {
                List<myDongLaptop> dsDongLT = m_dLaptopBus.LayDSDongLaptop(nhaSX.IMaNhaSX);
                ThemMoiExpandablePanel(nhaSX.STenNhaSX, dsDongLT);
            }

            //Load form Tất cả sản phẩm
            TATCASP frmTatCaSP = new TATCASP();
            frmTatCaSP.MdiParent = this;
            frmTatCaSP.Parent = panelWelcome;
            frmTatCaSP.Size = panelWelcome.Size;
            frmTatCaSP.Show();
       }

        /// <summary>
        /// Hàm xử lý sự kiện panelWelcome resize
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelWelcome_Resize(object sender, EventArgs e)
        {
           
        }
    }
}