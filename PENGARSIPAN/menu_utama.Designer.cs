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
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnmasuk = new System.Windows.Forms.Button();
            this.btnkeluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU ARSIP SURAT";
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(74, 177);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 23);
            this.btnlogout.TabIndex = 1;
            this.btnlogout.Text = "LOGOUT";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnmasuk
            // 
            this.btnmasuk.Location = new System.Drawing.Point(74, 123);
            this.btnmasuk.Name = "btnmasuk";
            this.btnmasuk.Size = new System.Drawing.Size(168, 23);
            this.btnmasuk.TabIndex = 2;
            this.btnmasuk.Text = "SURAT MASUK";
            this.btnmasuk.UseVisualStyleBackColor = true;
            this.btnmasuk.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnkeluar
            // 
            this.btnkeluar.Location = new System.Drawing.Point(74, 83);
            this.btnkeluar.Name = "btnkeluar";
            this.btnkeluar.Size = new System.Drawing.Size(168, 23);
            this.btnkeluar.TabIndex = 3;
            this.btnkeluar.Text = "SURAT KELUAR";
            this.btnkeluar.UseVisualStyleBackColor = true;
            this.btnkeluar.Click += new System.EventHandler(this.btnkeluar_Click);
            // 
            // menu_utama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 261);
            this.Controls.Add(this.btnkeluar);
            this.Controls.Add(this.btnmasuk);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.label1);
            this.Name = "menu_utama";
            this.Text = "menu_utama";
            this.Load += new System.EventHandler(this.menu_utama_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnmasuk;
        private System.Windows.Forms.Button btnkeluar;
    }
}