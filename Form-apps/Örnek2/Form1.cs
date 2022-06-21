using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Örnek2
{
    public partial class Form1 : Form
    {

        //PROGRESS BAR
        /*  Forma ProgressBar eklendiğinde timer sınıfı ile birlikte kullanılabilir. Zaman ilerledikçe dolan çubuklar yapabiliriz. Progressbarı kontrol etmek için Value özelliğini kullanabiliriz. Int tipinde değerler alır. ProgressBar  en az 0 en çok 100 değerini alabilir.
         * 
         */

        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 20;
            if (progressBar1.Value==100)
            {
                timer1.Stop();
            }
        }
    }
}
