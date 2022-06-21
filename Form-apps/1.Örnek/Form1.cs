using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.Örnek
{
    public partial class Form1 : Form
    {

        //  TIMER  
        /*   Timer sınıfıdır. Belirli zaman aralıklarında  kodların çalışmasını sağlar. 
         *   Örneğin her 10 saniyede  veritabanı kontrolü yapar. Temel olarak Start() ve Stop() metotları kullanılır. Bunlar zamanlayıcının durmasını ve çalışmasını sağlar. Interval özelliği zamanlayıcının hangi zaman aralığında çalışacacağını milisaniye cinsinden belirler.
         *   Interval özelliğine 1000 yazılırsa 1 saniye aralığında çalışacaktır.
         * 
         */
        public Form1()
        {
            InitializeComponent();
        }
        int sayac;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            lblZaman.Text = sayac.ToString();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            sayac = 0;
            lblZaman.Text = "0";
            timer1.Stop();
        }
    }
}
