
namespace _6_SayıTahminOyunu
{
    partial class Form1
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
            this.btnOyunuBaslat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.txtGirilenSayi = new System.Windows.Forms.TextBox();
            this.btnTahminEt = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblKullaniciMesaj = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnOyunuBaslat
            // 
            this.btnOyunuBaslat.Location = new System.Drawing.Point(68, 27);
            this.btnOyunuBaslat.Name = "btnOyunuBaslat";
            this.btnOyunuBaslat.Size = new System.Drawing.Size(301, 76);
            this.btnOyunuBaslat.TabIndex = 0;
            this.btnOyunuBaslat.Text = "OYUNU BAŞLAT";
            this.btnOyunuBaslat.UseVisualStyleBackColor = true;
            this.btnOyunuBaslat.Click += new System.EventHandler(this.btnOyunuBaslat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(65, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "1-100 arasında bir sayı giriniz:";
            // 
            // lblBilgi
            // 
            this.lblBilgi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBilgi.Location = new System.Drawing.Point(65, 240);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(304, 32);
            this.lblBilgi.TabIndex = 2;
            // 
            // txtGirilenSayi
            // 
            this.txtGirilenSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGirilenSayi.Location = new System.Drawing.Point(269, 128);
            this.txtGirilenSayi.Name = "txtGirilenSayi";
            this.txtGirilenSayi.Size = new System.Drawing.Size(100, 23);
            this.txtGirilenSayi.TabIndex = 3;
            // 
            // btnTahminEt
            // 
            this.btnTahminEt.Location = new System.Drawing.Point(68, 170);
            this.btnTahminEt.Name = "btnTahminEt";
            this.btnTahminEt.Size = new System.Drawing.Size(301, 51);
            this.btnTahminEt.TabIndex = 0;
            this.btnTahminEt.Text = "TAHMİN ET";
            this.btnTahminEt.UseVisualStyleBackColor = true;
            this.btnTahminEt.Click += new System.EventHandler(this.btnTahminEt_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(65, 284);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(304, 23);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 100;
            // 
            // lblKullaniciMesaj
            // 
            this.lblKullaniciMesaj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKullaniciMesaj.Location = new System.Drawing.Point(65, 322);
            this.lblKullaniciMesaj.Name = "lblKullaniciMesaj";
            this.lblKullaniciMesaj.Size = new System.Drawing.Size(304, 66);
            this.lblKullaniciMesaj.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 426);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.txtGirilenSayi);
            this.Controls.Add(this.lblKullaniciMesaj);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTahminEt);
            this.Controls.Add(this.btnOyunuBaslat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOyunuBaslat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.TextBox txtGirilenSayi;
        private System.Windows.Forms.Button btnTahminEt;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblKullaniciMesaj;
        private System.Windows.Forms.Timer timer1;
    }
}

