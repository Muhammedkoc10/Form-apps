
namespace Örnek_9
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
            this.cmbBirdenOnaKadar = new System.Windows.Forms.ComboBox();
            this.lbRastgeleSayilar = new System.Windows.Forms.ListBox();
            this.lbSag = new System.Windows.Forms.ListBox();
            this.btnSag = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBirdenOnaKadar
            // 
            this.cmbBirdenOnaKadar.FormattingEnabled = true;
            this.cmbBirdenOnaKadar.Location = new System.Drawing.Point(273, 29);
            this.cmbBirdenOnaKadar.Name = "cmbBirdenOnaKadar";
            this.cmbBirdenOnaKadar.Size = new System.Drawing.Size(222, 21);
            this.cmbBirdenOnaKadar.TabIndex = 0;
            this.cmbBirdenOnaKadar.SelectedIndexChanged += new System.EventHandler(this.cmbBirdenOnaKadar_SelectedIndexChanged);
            // 
            // lbRastgeleSayilar
            // 
            this.lbRastgeleSayilar.FormattingEnabled = true;
            this.lbRastgeleSayilar.Location = new System.Drawing.Point(46, 81);
            this.lbRastgeleSayilar.Name = "lbRastgeleSayilar";
            this.lbRastgeleSayilar.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbRastgeleSayilar.Size = new System.Drawing.Size(228, 342);
            this.lbRastgeleSayilar.TabIndex = 1;
            this.lbRastgeleSayilar.SelectedIndexChanged += new System.EventHandler(this.lbRastgeleSayilar_SelectedIndexChanged);
            // 
            // lbSag
            // 
            this.lbSag.FormattingEnabled = true;
            this.lbSag.Location = new System.Drawing.Point(495, 81);
            this.lbSag.Name = "lbSag";
            this.lbSag.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbSag.Size = new System.Drawing.Size(228, 342);
            this.lbSag.TabIndex = 1;
            // 
            // btnSag
            // 
            this.btnSag.Location = new System.Drawing.Point(315, 146);
            this.btnSag.Name = "btnSag";
            this.btnSag.Size = new System.Drawing.Size(145, 49);
            this.btnSag.TabIndex = 2;
            this.btnSag.Text = ">>";
            this.btnSag.UseVisualStyleBackColor = true;
            this.btnSag.Click += new System.EventHandler(this.btnSag_Click);
            // 
            // btnSol
            // 
            this.btnSol.Location = new System.Drawing.Point(315, 286);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(145, 49);
            this.btnSol.TabIndex = 2;
            this.btnSol.Text = "<<";
            this.btnSol.UseVisualStyleBackColor = true;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSol);
            this.Controls.Add(this.btnSag);
            this.Controls.Add(this.lbSag);
            this.Controls.Add(this.lbRastgeleSayilar);
            this.Controls.Add(this.cmbBirdenOnaKadar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBirdenOnaKadar;
        private System.Windows.Forms.ListBox lbRastgeleSayilar;
        private System.Windows.Forms.ListBox lbSag;
        private System.Windows.Forms.Button btnSag;
        private System.Windows.Forms.Button btnSol;
    }
}

