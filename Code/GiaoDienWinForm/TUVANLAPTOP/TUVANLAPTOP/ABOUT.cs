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
    public partial class ABOUT : Form
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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
