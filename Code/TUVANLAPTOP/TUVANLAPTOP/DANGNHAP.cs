﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EStoreBUS;
using EStoreDTO;

namespace TUVANLAPTOP
{
    public partial class DANGNHAP : Form
    {
        public DANGNHAP()
        {
            InitializeComponent();
        }

        private void DANGNHAP_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Ham xu ly khi click vao button Dang Nhap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (CMyNguoiDungBUS.KiemTraNguoiDungTonTai(textBox_username.Text, textBox_password.Text))
                {
                    this.Hide();
                    if (0 == MANHINHCHINH.m_iStaticFormDuocChon)
                    {
                        ADMIN frm = new ADMIN();
                        frm.ShowDialog();
                    }
                }
                else
                    MessageBox.Show("Username hay Password không chính xác \n Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notice");
            }
        }

        /// <summary>
        /// Ham xu ly khi click vao button Thoat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
