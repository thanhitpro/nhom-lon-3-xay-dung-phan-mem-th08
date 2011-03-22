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
    public partial class MANHINHCHINH : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public MANHINHCHINH()
        {
            InitializeComponent();
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
    }
}