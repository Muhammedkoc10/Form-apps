using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Örnek_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            string[] kelimeler = rtbMetin.Text.Split(' ');
            int kelimeSayisi = kelimeler.Length;
            lblKelimeSayisi.Text = kelimeSayisi.ToString();
            lblBoslukSayisi.Text = (kelimeSayisi-1).ToString();

            string[] cumleler = rtbMetin.Text.Split('.');
            int cumleSayisi = cumleler.Length-1;
            lblCumleSayisi.Text = cumleSayisi.ToString();

            int sesliHarfSayisi = 0;
            char[] sesliHarfler = { 'A', 'E', 'U', 'Ü', 'O', 'Ö', 'I', ',' };
            foreach (char item in rtbMetin.Text.ToUpper())
            {
                if (sesliHarfler.ToList().IndexOf(item) != -1)
                    sesliHarfSayisi++;
            }
            lblSesliHarfSayisi.Text = sesliHarfSayisi.ToString();
        }
    }
}
