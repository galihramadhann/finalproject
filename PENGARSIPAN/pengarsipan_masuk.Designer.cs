namespace PENGARSIPAN
{
    partial class pengarsipan_masuk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pengarsipan_masuk));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnreser = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtkode = new System.Windows.Forms.TextBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.txtpengirim = new System.Windows.Forms.TextBox();
            this.txtperihal = new System.Windows.Forms.TextBox();
            this.dgvmasuk = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtcaridata = new System.Windows.Forms.ToolStripTextBox();
            this.btncari = new System.Windows.Forms.ToolStripButton();
            this.btninsert = new System.Windows.Forms.Button();
            this.dtptanggal = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmasuk)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM SURAT MASUK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id. Surat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kode Surat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "No. Surat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tanggal Surat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pengirim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Perihal";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(572, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "DATA SURAT MASUK";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(188, 385);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(69, 21);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndel
            // 
            this.btndel.Location = new System.Drawing.Point(303, 385);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(69, 21);
            this.btndel.TabIndex = 11;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnreser
            // 
            this.btnreser.Location = new System.Drawing.Point(510, 385);
            this.btnreser.Name = "btnreser";
            this.btnreser.Size = new System.Drawing.Size(69, 21);
            this.btnreser.TabIndex = 12;
            this.btnreser.Text = "reset data";
            this.btnreser.UseVisualStyleBackColor = true;
            this.btnreser.Click += new System.EventHandler(this.btnreser_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(143, 119);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(128, 20);
            this.txtid.TabIndex = 14;
            // 
            // txtkode
            // 
            this.txtkode.Location = new System.Drawing.Point(143, 164);
            this.txtkode.Name = "txtkode";
            this.txtkode.Size = new System.Drawing.Size(128, 20);
            this.txtkode.TabIndex = 15;
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(143, 204);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(128, 20);
            this.txtno.TabIndex = 16;
            // 
            // txtpengirim
            // 
            this.txtpengirim.Location = new System.Drawing.Point(143, 286);
            this.txtpengirim.Name = "txtpengirim";
            this.txtpengirim.Size = new System.Drawing.Size(128, 20);
            this.txtpengirim.TabIndex = 18;
            // 
            // txtperihal
            // 
            this.txtperihal.Location = new System.Drawing.Point(143, 323);
            this.txtperihal.Name = "txtperihal";
            this.txtperihal.Size = new System.Drawing.Size(128, 20);
            this.txtperihal.TabIndex = 19;
            // 
            // dgvmasuk
            // 
            this.dgvmasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmasuk.Location = new System.Drawing.Point(395, 49);
            this.dgvmasuk.Name = "dgvmasuk";
            this.dgvmasuk.Size = new System.Drawing.Size(462, 243);
            this.dgvmasuk.TabIndex = 21;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtcaridata,
            this.btncari});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(857, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "Pencarian Data";
            // 
            // txtcaridata
            // 
            this.txtcaridata.Name = "txtcaridata";
            this.txtcaridata.Size = new System.Drawing.Size(100, 25);
            // 
            // btncari
            // 
            this.btncari.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btncari.Image = ((System.Drawing.Image)(resources.GetObject("btncari.Image")));
            this.btncari.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btncari.Name = "btncari";
            this.btncari.Size = new System.Drawing.Size(23, 22);
            this.btncari.Text = "toolStripButton1";
            this.btncari.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(68, 383);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 23;
            this.btninsert.Text = "insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // dtptanggal
            // 
            this.dtptanggal.Location = new System.Drawing.Point(143, 243);
            this.dtptanggal.Name = "dtptanggal";
            this.dtptanggal.Size = new System.Drawing.Size(128, 20);
            this.dtptanggal.TabIndex = 24;
            // 
            // pengarsipan_masuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 453);
            this.Controls.Add(this.dtptanggal);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvmasuk);
            this.Controls.Add(this.txtperihal);
            this.Controls.Add(this.txtpengirim);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.txtkode);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnreser);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "pengarsipan_masuk";
            this.Text = "pengarsipan_masuk";
            this.Load += new System.EventHandler(this.pengarsipan_masuk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmasuk)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnreser;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtkode;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.TextBox txtpengirim;
        private System.Windows.Forms.TextBox txtperihal;
        private System.Windows.Forms.DataGridView dgvmasuk;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtcaridata;
        private System.Windows.Forms.ToolStripButton btncari;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.DateTimePicker dtptanggal;
    }
}