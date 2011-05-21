using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EStoreBUS;
using EStoreDTO;
using System.Threading;

namespace TUVANLAPTOP
{
    public partial class CAPNHATDULIEUKHACHHANG : Form
    {
        bool m_bFinish;
        bool m_bFlag;
        int m_iMaxProcess;

        public CAPNHATDULIEUKHACHHANG()
        {
            InitializeComponent();
        }

        private void CAPNHATDULIEUKHACHHANG_Load(object sender, EventArgs e)
        {
            m_bFinish = false;
            m_bFlag = false;
            m_iMaxProcess = 50;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (false == m_bFlag)
            {
                m_bFlag = true;
                timerRunProgressBar.Start();
                timerShowResult.Start();
                ThreadStart threadStart = new ThreadStart(CapNhat);
                Thread thread = new Thread(threadStart);
                thread.Start();
            }
        }

        private void CapNhat()
        {
            AlgorithmNavasBayes NavasBayes = new AlgorithmNavasBayes();
            NavasBayes.AnalyseData();
            m_bFinish = true;
        }

        private void timerRunProgressBar_Tick(object sender, EventArgs e)
        {
            if (this.m_iMaxProcess > progressBar.Value)
                progressBar.Value += 1;
            else
            {
                this.m_iMaxProcess += (100 - this.m_iMaxProcess - 15) / 2;
                timerRunProgressBar.Interval *= 2;
            }
        }

        private void timerShowResult_Tick(object sender, EventArgs e)
        {
            if (true == m_bFinish)
            {
                m_bFlag = false;
                progressBar.Value = 100;
                timerShowResult.Stop();
                timerRunProgressBar.Stop();
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                this.Close();
            }
        }
    }
}
