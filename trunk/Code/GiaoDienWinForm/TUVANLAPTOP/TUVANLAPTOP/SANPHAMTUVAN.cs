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
    public partial class SANPHAMTUVAN : Form
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
        private SANPHAMTUVAN()
        {
            InitializeComponent();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
