
namespace HamburgerProject
{
    partial class SiparisOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparisOlustur));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMenu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flpBoyut = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.flpExtraMalzeme = new System.Windows.Forms.FlowLayoutPanel();
            this.NumUpDownAdet = new System.Windows.Forms.NumericUpDown();
            this.btnSiparisEkle = new System.Windows.Forms.Button();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.btnSiparisOk = new System.Windows.Forms.Button();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menü Seçin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbMenu
            // 
            this.cbMenu.FormattingEnabled = true;
            this.cbMenu.Location = new System.Drawing.Point(31, 176);
            this.cbMenu.Name = "cbMenu";
            this.cbMenu.Size = new System.Drawing.Size(268, 23);
            this.cbMenu.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Boyut Seçin";
            // 
            // flpBoyut
            // 
            this.flpBoyut.Location = new System.Drawing.Point(31, 229);
            this.flpBoyut.Name = "flpBoyut";
            this.flpBoyut.Size = new System.Drawing.Size(268, 53);
            this.flpBoyut.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Extra Malzemeler";
            // 
            // flpExtraMalzeme
            // 
            this.flpExtraMalzeme.Location = new System.Drawing.Point(31, 303);
            this.flpExtraMalzeme.Name = "flpExtraMalzeme";
            this.flpExtraMalzeme.Size = new System.Drawing.Size(268, 53);
            this.flpExtraMalzeme.TabIndex = 6;
            // 
            // NumUpDownAdet
            // 
            this.NumUpDownAdet.Location = new System.Drawing.Point(69, 368);
            this.NumUpDownAdet.Name = "NumUpDownAdet";
            this.NumUpDownAdet.Size = new System.Drawing.Size(120, 23);
            this.NumUpDownAdet.TabIndex = 7;
            this.NumUpDownAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSiparisEkle
            // 
            this.btnSiparisEkle.Location = new System.Drawing.Point(31, 402);
            this.btnSiparisEkle.Name = "btnSiparisEkle";
            this.btnSiparisEkle.Size = new System.Drawing.Size(268, 23);
            this.btnSiparisEkle.TabIndex = 9;
            this.btnSiparisEkle.Text = "Sipariş Ekle";
            this.btnSiparisEkle.UseVisualStyleBackColor = true;
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.ItemHeight = 15;
            this.lstSiparisler.Location = new System.Drawing.Point(305, 12);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(397, 349);
            this.lstSiparisler.TabIndex = 10;
            // 
            // btnSiparisOk
            // 
            this.btnSiparisOk.Location = new System.Drawing.Point(381, 402);
            this.btnSiparisOk.Name = "btnSiparisOk";
            this.btnSiparisOk.Size = new System.Drawing.Size(268, 23);
            this.btnSiparisOk.TabIndex = 11;
            this.btnSiparisOk.Text = "Siparis Tamamla";
            this.btnSiparisOk.UseVisualStyleBackColor = true;
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(31, 370);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(32, 15);
            this.lblAdet.TabIndex = 12;
            this.lblAdet.Text = "Adet";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(305, 376);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(82, 15);
            this.lbl4.TabIndex = 13;
            this.lbl4.Text = "Toplam Tutar :";
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(393, 376);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(13, 15);
            this.lblToplamTutar.TabIndex = 14;
            this.lblToplamTutar.Text = "0";
            // 
            // SiparisOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.btnSiparisOk);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.btnSiparisEkle);
            this.Controls.Add(this.NumUpDownAdet);
            this.Controls.Add(this.flpExtraMalzeme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flpBoyut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SiparisOlustur";
            this.Text = "FrmSiparisOlustur";
            this.Load += new System.EventHandler(this.SiparisOlustur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDownAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flpBoyut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flpExtraMalzeme;
        private System.Windows.Forms.NumericUpDown NumUpDownAdet;
        private System.Windows.Forms.Button btnSiparisEkle;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.Button btnSiparisOk;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lblToplamTutar;
    }
}