using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Örnek_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        Point pt = new Point();
        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int arabaBirYol = rnd.Next(10);
            int arabaİkiYol = rnd.Next(10);

            araba1.Location = new Point(araba1.Location.X + arabaBirYol, araba1.Location.Y);
            araba2.Location = new Point(araba2.Location.X + arabaİkiYol, araba2.Location.Y);
            if (araba1.Location.X + araba1.Width>=pnlVaris.Location.X )
            {
                this.Text = "Mavi araba kazandı";
                timer1.Stop();
            }
            else if(araba2.Location.X + araba2.Width >= pnlVaris.Location.X)
            {
                this.Text = "Beyaz araba kazandı";
                timer1.Stop();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
