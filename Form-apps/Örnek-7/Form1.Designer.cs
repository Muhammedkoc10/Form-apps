
namespace Örnek_7
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
            this.txtAranacakMetin = new System.Windows.Forms.TextBox();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.rtbMetin = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtAranacakMetin
            // 
            this.txtAranacakMetin.Location = new System.Drawing.Point(159, 84);
            this.txtAranacakMetin.Name = "txtAranacakMetin";
            this.txtAranacakMetin.Size = new System.Drawing.Size(184, 20);
            this.txtAranacakMetin.TabIndex = 0;
            // 
            // btnSonraki
            // 
            this.btnSonraki.Location = new System.Drawing.Point(356, 150);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(121, 51);
            this.btnSonraki.TabIndex = 1;
            this.btnSonraki.Text = "Sonrakini Bul";
            this.btnSonraki.UseVisualStyleBackColor = true;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(25, 150);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(121, 51);
            this.btnBul.TabIndex = 1;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // rtbMetin
            // 
            this.rtbMetin.Location = new System.Drawing.Point(25, 235);
            this.rtbMetin.Name = "rtbMetin";
            this.rtbMetin.Size = new System.Drawing.Size(452, 275);
            this.rtbMetin.TabIndex = 2;
            this.rtbMetin.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 566);
            this.Controls.Add(this.rtbMetin);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.txtAranacakMetin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAranacakMetin;
        private System.Windows.Forms.Button btnSonraki;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.RichTextBox rtbMetin;
    }
}

