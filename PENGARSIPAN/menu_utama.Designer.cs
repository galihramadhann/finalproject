namespace PENGARSIPAN
{
    partial class menu_utama
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
			this.button1 = new System.Windows.Forms.Button();
			this.btnkeluar = new System.Windows.Forms.Button();
			this.btnlogout = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(249, 55);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "MENU ARSIP SURAT";
			// 
			// button1
			// 
			this.button1.Image = global::PENGARSIPAN.Properties.Resources._1455554327_line_12_icon_icons_com_53320;
			this.button1.Location = new System.Drawing.Point(99, 152);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(224, 33);
			this.button1.TabIndex = 4;
			this.button1.Text = "MASUK";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btnkeluar
			// 
			this.btnkeluar.Image = global::PENGARSIPAN.Properties.Resources._1455554327_line_12_icon_icons_com_53320;
			this.btnkeluar.Location = new System.Drawing.Point(99, 102);
			this.btnkeluar.Margin = new System.Windows.Forms.Padding(4);
			this.btnkeluar.Name = "btnkeluar";
			this.btnkeluar.Size = new System.Drawing.Size(224, 28);
			this.btnkeluar.TabIndex = 3;
			this.btnkeluar.Text = "SURAT KELUAR";
			this.btnkeluar.UseVisualStyleBackColor = true;
			this.btnkeluar.Click += new System.EventHandler(this.btnkeluar_Click);
			// 
			// btnlogout
			// 
			this.btnlogout.Image = global::PENGARSIPAN.Properties.Resources._1455554327_line_12_icon_icons_com_53320;
			this.btnlogout.Location = new System.Drawing.Point(99, 218);
			this.btnlogout.Margin = new System.Windows.Forms.Padding(4);
			this.btnlogout.Name = "btnlogout";
			this.btnlogout.Size = new System.Drawing.Size(100, 28);
			this.btnlogout.TabIndex = 1;
			this.btnlogout.Text = "LOGOUT";
			this.btnlogout.UseVisualStyleBackColor = true;
			this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
			// 
			// menu_utama
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlueViolet;
			this.ClientSize = new System.Drawing.Size(580, 321);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnkeluar);
			this.Controls.Add(this.btnlogout);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "menu_utama";
			this.Text = "Menu Utama";
			this.Load += new System.EventHandler(this.menu_utama_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnkeluar;
		private System.Windows.Forms.Button button1;
	}
}