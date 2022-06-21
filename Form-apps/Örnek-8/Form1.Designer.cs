
namespace Örnek_8
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
            this.rtbMetin = new System.Windows.Forms.RichTextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCumleSayisi = new System.Windows.Forms.Label();
            this.lblKelimeSayisi = new System.Windows.Forms.Label();
            this.lblBoslukSayisi = new System.Windows.Forms.Label();
            this.lblSesliHarfSayisi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtbMetin
            // 
            this.rtbMetin.Location = new System.Drawing.Point(42, 29);
            this.rtbMetin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbMetin.Name = "rtbMetin";
            this.rtbMetin.Size = new System.Drawing.Size(712, 421);
            this.rtbMetin.TabIndex = 0;
            this.rtbMetin.Text = "";
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(885, 389);
            this.btnBul.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(200, 61);
            this.btnBul.TabIndex = 1;
            this.btnBul.Text = "BUL";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(801, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cümle Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(801, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kelime Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(801, 324);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Boşluk Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(801, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sesli Harf Sayısı:";
            // 
            // lblCumleSayisi
            // 
            this.lblCumleSayisi.AutoSize = true;
            this.lblCumleSayisi.Location = new System.Drawing.Point(975, 83);
            this.lblCumleSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCumleSayisi.Name = "lblCumleSayisi";
            this.lblCumleSayisi.Size = new System.Drawing.Size(23, 18);
            this.lblCumleSayisi.TabIndex = 2;
            this.lblCumleSayisi.Text = "---";
            // 
            // lblKelimeSayisi
            // 
            this.lblKelimeSayisi.AutoSize = true;
            this.lblKelimeSayisi.Location = new System.Drawing.Point(975, 163);
            this.lblKelimeSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKelimeSayisi.Name = "lblKelimeSayisi";
            this.lblKelimeSayisi.Size = new System.Drawing.Size(23, 18);
            this.lblKelimeSayisi.TabIndex = 2;
            this.lblKelimeSayisi.Text = "---";
            // 
            // lblBoslukSayisi
            // 
            this.lblBoslukSayisi.AutoSize = true;
            this.lblBoslukSayisi.Location = new System.Drawing.Point(975, 324);
            this.lblBoslukSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBoslukSayisi.Name = "lblBoslukSayisi";
            this.lblBoslukSayisi.Size = new System.Drawing.Size(23, 18);
            this.lblBoslukSayisi.TabIndex = 2;
            this.lblBoslukSayisi.Text = "---";
            // 
            // lblSesliHarfSayisi
            // 
            this.lblSesliHarfSayisi.AutoSize = true;
            this.lblSesliHarfSayisi.Location = new System.Drawing.Point(975, 244);
            this.lblSesliHarfSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSesliHarfSayisi.Name = "lblSesliHarfSayisi";
            this.lblSesliHarfSayisi.Size = new System.Drawing.Size(23, 18);
            this.lblSesliHarfSayisi.TabIndex = 2;
            this.lblSesliHarfSayisi.Text = "---";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 514);
            this.Controls.Add(this.lblSesliHarfSayisi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblBoslukSayisi);
            this.Controls.Add(this.lblKelimeSayisi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCumleSayisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.rtbMetin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMetin;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCumleSayisi;
        private System.Windows.Forms.Label lblKelimeSayisi;
        private System.Windows.Forms.Label lblBoslukSayisi;
        private System.Windows.Forms.Label lblSesliHarfSayisi;
    }
}

