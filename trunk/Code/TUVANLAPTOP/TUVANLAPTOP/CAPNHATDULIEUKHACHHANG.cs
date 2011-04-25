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

namespace TUVANLAPTOP
{
    public partial class CAPNHATDULIEUKHACHHANG : Form
    {
        public CAPNHATDULIEUKHACHHANG()
        {
            InitializeComponent();
        }

        private void CAPNHATDULIEUKHACHHANG_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            this.lb_Updating.Visible = false;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            lb_Updating.Text = "Đang cập nhật cơ sở dữ liệu...";
            lb_Updating.Visible = true;
            this.Update();
            try
            {
                AlgorithmNavasBayes.AnalyseData();
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại", "Thông báo");
            }
            finally
            {
                lb_Updating.Visible = false;
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                this.Close();
            }
        }
    }
}
