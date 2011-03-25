using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace QLKS
{
    public partial class DANHMUCSANPHAM : DevComponents.DotNetBar.Office2007Form
    {
        public DANHMUCSANPHAM()
        {
            InitializeComponent();
            tabItemAcer.Visible = true;
            tabItemAssus.Visible = false;
            tabItemDell.Visible = false;
            tabItemHp.Visible = false;
        }
        
        private void bubbleButton1_Click(object sender, ClickEventArgs e)
        {            
            tabItemAcer.Visible = true;
            tabItemAssus.Visible = false;
            tabItemDell.Visible = false;
            tabItemHp.Visible = false;
        }

        private void bubbleButton2_Click(object sender, ClickEventArgs e)
        {
            tabItemAcer.Visible = false;
            tabItemAssus.Visible = true;
            tabItemDell.Visible = false;
            tabItemHp.Visible = false;
        }

        private void bubbleButton3_Click(object sender, ClickEventArgs e)
        {
            tabItemAcer.Visible = false;
            tabItemAssus.Visible = false;
            tabItemDell.Visible = true;
            tabItemHp.Visible = false;
        }

        private void bubbleButton4_Click(object sender, ClickEventArgs e)
        {
            tabItemAcer.Visible = false;
            tabItemAssus.Visible = false;
            tabItemDell.Visible = false;
            tabItemHp.Visible = true;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}