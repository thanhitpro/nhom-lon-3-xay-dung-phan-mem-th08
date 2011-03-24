using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EStoreDTO;
using EStoreBUS;

namespace QLKS
{
    public partial class Form1 : Form
    {
        private myDongLaptopBUS m_dDongLaptopBus = new myDongLaptopBUS();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewX1.DataSource = m_dDongLaptopBus.LayDSDongLaptop();
        }
    }
}
