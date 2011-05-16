namespace TUVANLAPTOP
{
    partial class CAPNHATDULIEUKHACHHANG
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CAPNHATDULIEUKHACHHANG));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timerRunProgressBar = new System.Windows.Forms.Timer(this.components);
            this.timerShowResult = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT DỮ LIỆU KHÁCH HÀNG";
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Update.Image = ((System.Drawing.Image)(resources.GetObject("btn_Update.Image")));
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(91, 70);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(149, 57);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "CẬP NHẬT";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(17, 149);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(339, 43);
            this.progressBar.TabIndex = 2;
            // 
            // timerRunProgressBar
            // 
            this.timerRunProgressBar.Tick += new System.EventHandler(this.timerRunProgressBar_Tick);
            // 
            // timerShowResult
            // 
            this.timerShowResult.Tick += new System.EventHandler(this.timerShowResult_Tick);
            // 
            // CAPNHATDULIEUKHACHHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 214);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CAPNHATDULIEUKHACHHANG";
            this.Text = "CAPNHATDULIEUKHACHHANG";
            this.Load += new System.EventHandler(this.CAPNHATDULIEUKHACHHANG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timerRunProgressBar;
        private System.Windows.Forms.Timer timerShowResult;
    }
}