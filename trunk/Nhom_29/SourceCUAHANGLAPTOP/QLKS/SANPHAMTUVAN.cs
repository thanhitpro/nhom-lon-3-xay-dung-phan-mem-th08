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
    public partial class SANPHAMTUVAN : DevComponents.DotNetBar.Office2007Form
    {
        private static SANPHAMTUVAN aForm = null;
        public static SANPHAMTUVAN Instance()
        {
            if (aForm == null)
            {
                aForm = new SANPHAMTUVAN();
            }
            return aForm;
        }

        public SANPHAMTUVAN()
        {
            InitializeComponent();            
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }                
    }
}