namespace TUVANLAPTOP
{
    partial class ABOUT
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
            this.button_About_OK = new System.Windows.Forms.Button();
            this.GroupPanel_ThongTinPhanMem = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_About_OK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 42);
            this.panel1.TabIndex = 2;
            // 
            // button_About_OK
            // 
            this.button_About_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_About_OK.Location = new System.Drawing.Point(273, 6);
            this.button_About_OK.Name = "button_About_OK";
            this.button_About_OK.Size = new System.Drawing.Size(103, 29);
            this.button_About_OK.TabIndex = 0;
            this.button_About_OK.Text = "OK";
            this.button_About_OK.UseVisualStyleBackColor = true;
            this.button_About_OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // GroupPanel_ThongTinPhanMem
            // 
            this.GroupPanel_ThongTinPhanMem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupPanel_ThongTinPhanMem.BackgroundImage = global::TUVANLAPTOP.Properties.Resources.AboutContent;
            this.GroupPanel_ThongTinPhanMem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GroupPanel_ThongTinPhanMem.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupPanel_ThongTinPhanMem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupPanel_ThongTinPhanMem.Location = new System.Drawing.Point(0, 0);
            this.GroupPanel_ThongTinPhanMem.Name = "GroupPanel_ThongTinPhanMem";
            this.GroupPanel_ThongTinPhanMem.Size = new System.Drawing.Size(823, 463);
            this.GroupPanel_ThongTinPhanMem.TabIndex = 1;
            this.GroupPanel_ThongTinPhanMem.TabStop = false;
            this.GroupPanel_ThongTinPhanMem.Text = "Thông Tin Phần Mềm";
            // 
            // ABOUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 505);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GroupPanel_ThongTinPhanMem);
            this.Name = "ABOUT";
            this.Text = "ABOUT";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupPanel_ThongTinPhanMem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_About_OK;
    }
}