using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Örnek5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double not1, not2, not3,ortalama;
        
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            not1 = Convert.ToDouble(txtSinav1.Text);
            not2 = Convert.ToDouble(txtSinav2.Text);
            not3 = Convert.ToDouble(txtSinav3.Text);
            ortalama = (not1 + not2 + not3) / 3;
            
            Form2 frm2 = new Form2();
            frm2.Show();
            frm2.lblAdiSoyAdi.Text = txtAdiSoyadi.Text;
            frm2.lblOrt.Text = ortalama.ToString();
            frm2.lblDurum.Text = ortalama >= 50 ? "Başarılı" : "Başarısız";
        }
    }
}
