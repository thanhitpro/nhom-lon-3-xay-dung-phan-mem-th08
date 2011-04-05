using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TUVANLAPTOP
{
    public partial class MANHINHCHINH : Form
    {
        public MANHINHCHINH()
        {
            InitializeComponent();
        }

        private void button_TuVanLapTop_Click(object sender, EventArgs e)
        {
            SANPHAMTUVAN frm = SANPHAMTUVAN.Instance();
            frm.MdiParent = this;
            frm.Parent = GroupPanelChinh;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void AboutUsMenuItem_Click(object sender, EventArgs e)
        {
            ABOUT frm = ABOUT.Instance();
            frm.MdiParent = this;
            frm.Parent = GroupPanelChinh;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            HELP frm = HELP.Instance();
            frm.MdiParent = this;
            frm.Parent = GroupPanelChinh;
            frm.Show();
            frm.WindowState = FormWindowState.Maximized;
        }        
    }
}
