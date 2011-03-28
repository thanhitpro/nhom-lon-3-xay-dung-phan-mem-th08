using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKS
{
    public partial class THONGTINNHOM : Form
    {
        private THONGTINNHOM()
        {
            InitializeComponent();
        }

        private static THONGTINNHOM aForm = null;
        public static THONGTINNHOM Instance()
        {
            if (aForm == null)
            {
                aForm = new THONGTINNHOM();
            }
            return aForm;
        }
       

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
