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

        private void buttonTuVan_Click(object sender, EventArgs e)
        {
            //Code thuật toán

            SANPHAMTUVAN frm = SANPHAMTUVAN.Instance();
            frm.MdiParent = this;
            frm.Parent = panelWelcome;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void ribbonAbout_Click(object sender, EventArgs e)
        {
            ABOUT frm = ABOUT.Instance();
            frm.MdiParent = this;
            frm.Parent = panelWelcome;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }        
    }
}