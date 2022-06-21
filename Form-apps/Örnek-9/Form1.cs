using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Örnek_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                cmbBirdenOnaKadar.Items.Add(i);
            }
        }
        private void cmbBirdenOnaKadar_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < cmbBirdenOnaKadar.SelectedIndex + 1; i++)
            {
                lbRastgeleSayilar.Items.Add(rnd.Next(101));
            }
        }

        private void btnSag_Click(object sender, EventArgs e)
        {
            foreach (var item in lbRastgeleSayilar.SelectedItems)
            {
                lbSag.Items.Add(item);
                
            }
            for (int i = 0; i < 11; i++)
            {
                lbRastgeleSayilar.Items.Remove(lbRastgeleSayilar.SelectedItem);
            }
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            foreach (var item in lbSag.SelectedItems)
            {
                lbRastgeleSayilar.Items.Add(item);

            }
           
            for (int i = 0; i <11; i++)
            {
                lbSag.Items.Remove(lbSag.SelectedItem);
            }
            
           
        }

        private void lbRastgeleSayilar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
