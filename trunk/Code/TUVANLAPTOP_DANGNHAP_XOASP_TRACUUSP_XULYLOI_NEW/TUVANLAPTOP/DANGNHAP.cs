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
    public partial class DANGNHAP : Form
    {
        public static bool m_bIsLogin = false;

        public DANGNHAP()
        {
            InitializeComponent();
        }

        private void DANGNHAP_Load(object sender, EventArgs e)
        {

        }

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            if (textBox_username.Text == "admin" && textBox_password.Text == "123456")
            {
                this.Close();
                CAPNHATXOASANPHAM frm = CAPNHATXOASANPHAM.Instance();
                frm.Show();
                DANGNHAP.m_bIsLogin = true;
            }
            else if (MessageBox.Show("Username hay Password không chính xác \n Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                this.Show();
        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            DANGNHAP.m_bIsLogin = false;
        }
    }
}
