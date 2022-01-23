namespace PENGARSIPAN
{
    partial class pengarsipan_keluar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtkode = new System.Windows.Forms.TextBox();
            this.txtnosurat = new System.Windows.Forms.TextBox();
            this.txtpengirim = new System.Windows.Forms.TextBox();
            this.txtperihal = new System.Windows.Forms.TextBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.maindisplay = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dtptgl = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.maindisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id.Surat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kode Surat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "No Surat";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "simpen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(294, 285);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(75, 23);
            this.btnrefresh.TabIndex = 5;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tanggal Surat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pengiriman";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Perihal";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(133, 35);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(124, 20);
            this.txtid.TabIndex = 9;
            // 
            // txtkode
            // 
            this.txtkode.Location = new System.Drawing.Point(133, 69);
            this.txtkode.Name = "txtkode";
            this.txtkode.Size = new System.Drawing.Size(124, 20);
            this.txtkode.TabIndex = 10;
            // 
            // txtnosurat
            // 
            this.txtnosurat.Location = new System.Drawing.Point(133, 105);
            this.txtnosurat.Name = "txtnosurat";
            this.txtnosurat.Size = new System.Drawing.Size(124, 20);
            this.txtnosurat.TabIndex = 11;
            // 
            // txtpengirim
            // 
            this.txtpengirim.Location = new System.Drawing.Point(133, 189);
            this.txtpengirim.Name = "txtpengirim";
            this.txtpengirim.Size = new System.Drawing.Size(124, 20);
            this.txtpengirim.TabIndex = 13;
            // 
            // txtperihal
            // 
            this.txtperihal.Location = new System.Drawing.Point(133, 228);
            this.txtperihal.Name = "txtperihal";
            this.txtperihal.Size = new System.Drawing.Size(124, 20);
            this.txtperihal.TabIndex = 14;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(399, 285);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 15;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // maindisplay
            // 
            this.maindisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maindisplay.Location = new System.Drawing.Point(322, 51);
            this.maindisplay.Name = "maindisplay";
            this.maindisplay.Size = new System.Drawing.Size(272, 193);
            this.maindisplay.TabIndex = 16;
            this.maindisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.maindisplay_CellClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dtptgl
            // 
            this.dtptgl.Location = new System.Drawing.Point(133, 150);
            this.dtptgl.Name = "dtptgl";
            this.dtptgl.Size = new System.Drawing.Size(124, 20);
            this.dtptgl.TabIndex = 18;
            // 
            // pengarsipan_keluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 380);
            this.Controls.Add(this.dtptgl);
            this.Controls.Add(this.maindisplay);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.txtperihal);
            this.Controls.Add(this.txtpengirim);
            this.Controls.Add(this.txtnosurat);
            this.Controls.Add(this.txtkode);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "pengarsipan_keluar";
            this.Text = "pengarsipan_keluar";
            this.Load += new System.EventHandler(this.pengarsipan_keluar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maindisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtkode;
        private System.Windows.Forms.TextBox txtnosurat;
        private System.Windows.Forms.TextBox txtpengirim;
        private System.Windows.Forms.TextBox txtperihal;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.DataGridView maindisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dtptgl;
    }
}