
namespace Örnek_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.araba1 = new System.Windows.Forms.PictureBox();
            this.araba2 = new System.Windows.Forms.PictureBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.pnlVaris = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).BeginInit();
            this.SuspendLayout();
            // 
            // araba1
            // 
            this.araba1.Image = ((System.Drawing.Image)(resources.GetObject("araba1.Image")));
            this.araba1.Location = new System.Drawing.Point(50, 47);
            this.araba1.Name = "araba1";
            this.araba1.Size = new System.Drawing.Size(129, 68);
            this.araba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araba1.TabIndex = 0;
            this.araba1.TabStop = false;
            // 
            // araba2
            // 
            this.araba2.Image = ((System.Drawing.Image)(resources.GetObject("araba2.Image")));
            this.araba2.Location = new System.Drawing.Point(50, 304);
            this.araba2.Name = "araba2";
            this.araba2.Size = new System.Drawing.Size(129, 68);
            this.araba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.araba2.TabIndex = 0;
            this.araba2.TabStop = false;
            this.araba2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBasla.Location = new System.Drawing.Point(50, 391);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(128, 31);
            this.btnBasla.TabIndex = 1;
            this.btnBasla.Text = "Başlat";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // pnlVaris
            // 
            this.pnlVaris.BackColor = System.Drawing.Color.Moccasin;
            this.pnlVaris.ForeColor = System.Drawing.Color.IndianRed;
            this.pnlVaris.Location = new System.Drawing.Point(732, 12);
            this.pnlVaris.Name = "pnlVaris";
            this.pnlVaris.Size = new System.Drawing.Size(56, 426);
            this.pnlVaris.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlVaris);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.araba2);
            this.Controls.Add(this.araba1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.araba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.araba2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox araba1;
        private System.Windows.Forms.PictureBox araba2;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Panel pnlVaris;
        private System.Windows.Forms.Timer timer1;
    }
}

