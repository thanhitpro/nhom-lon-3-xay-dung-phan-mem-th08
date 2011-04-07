namespace TUVANLAPTOP
{
    partial class HELP
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
            aForm = null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Help_OK = new System.Windows.Forms.Button();
            this.GroupPanel_HuongDanSuDung = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.button_Help_OK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 449);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 49);
            this.panel1.TabIndex = 3;
            // 
            // button_Help_OK
            // 
            this.button_Help_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Help_OK.Location = new System.Drawing.Point(260, 6);
            this.button_Help_OK.Name = "button_Help_OK";
            this.button_Help_OK.Size = new System.Drawing.Size(103, 31);
            this.button_Help_OK.TabIndex = 0;
            this.button_Help_OK.Text = "OK";
            this.button_Help_OK.UseVisualStyleBackColor = true;
            this.button_Help_OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // GroupPanel_HuongDanSuDung
            // 
            this.GroupPanel_HuongDanSuDung.BackgroundImage = global::TUVANLAPTOP.Properties.Resources.HelpContent;
            this.GroupPanel_HuongDanSuDung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GroupPanel_HuongDanSuDung.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupPanel_HuongDanSuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupPanel_HuongDanSuDung.Location = new System.Drawing.Point(0, 0);
            this.GroupPanel_HuongDanSuDung.Name = "GroupPanel_HuongDanSuDung";
            this.GroupPanel_HuongDanSuDung.Size = new System.Drawing.Size(822, 449);
            this.GroupPanel_HuongDanSuDung.TabIndex = 0;
            this.GroupPanel_HuongDanSuDung.TabStop = false;
            this.GroupPanel_HuongDanSuDung.Text = "Hướng Dẫn Sử Dụng";
            // 
            // HELP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(822, 498);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GroupPanel_HuongDanSuDung);
            this.Name = "HELP";
            this.Text = "HELP";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupPanel_HuongDanSuDung;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Help_OK;
    }
}