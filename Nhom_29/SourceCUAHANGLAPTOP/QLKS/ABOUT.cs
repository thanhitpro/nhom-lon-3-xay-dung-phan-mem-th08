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
    public partial class ABOUT : DevComponents.DotNetBar.Office2007Form
    {
        private static ABOUT aForm = null;
        public static ABOUT Instance()
        {
            if (aForm == null)
            {
                aForm = new ABOUT();
            }
            return aForm;
        }

        private ABOUT()
        {
            InitializeComponent();
        }

        private void buttonAboutOK_Click(object sender, EventArgs e)
        {
            Close();
        }        
    }
}