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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.lb_Updating = new System.Windows.Forms.Label();
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
            this.btn_Update.Location = new System.Drawing.Point(91, 95);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(169, 41);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "CẬP NHẬT";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lb_Updating
            // 
            this.lb_Updating.AutoSize = true;
            this.lb_Updating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Updating.ForeColor = System.Drawing.Color.Red;
            this.lb_Updating.Location = new System.Drawing.Point(69, 162);
            this.lb_Updating.Name = "lb_Updating";
            this.lb_Updating.Size = new System.Drawing.Size(229, 20);
            this.lb_Updating.TabIndex = 2;
            this.lb_Updating.Text = "Đang cập nhật cơ sở dữ liệu...";
            // 
            // CAPNHATDULIEUKHACHHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 201);
            this.Controls.Add(this.lb_Updating);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.label1);
            this.Name = "CAPNHATDULIEUKHACHHANG";
            this.Text = "CAPNHATDULIEUKHACHHANG";
            this.Load += new System.EventHandler(this.CAPNHATDULIEUKHACHHANG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lb_Updating;
    }
}