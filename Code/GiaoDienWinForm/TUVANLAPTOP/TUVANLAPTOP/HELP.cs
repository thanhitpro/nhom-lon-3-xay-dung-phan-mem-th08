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
    public partial class HELP : Form
    {
        private static HELP aForm = null;
        public static HELP Instance()
        {
            if (aForm == null)
            {
                aForm = new HELP();
            }
            return aForm;
        }
        private HELP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
