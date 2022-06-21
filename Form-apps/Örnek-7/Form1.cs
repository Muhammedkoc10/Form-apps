using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Örnek_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int index = 0;
        
        private void btnBul_Click(object sender, EventArgs e)
        {
            index = rtbMetin.Text.IndexOf(txtAranacakMetin.Text, 0);

            if (index != -1)
            {
                rtbMetin.SelectionStart = index;
                rtbMetin.SelectionColor = Color.DodgerBlue;
                rtbMetin.SelectionLength = txtAranacakMetin.Text.Length;
            }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
           

            index = rtbMetin.Text.IndexOf(txtAranacakMetin.Text, index+1);

            if (index != -1)
            {
                rtbMetin.SelectionStart = index;
                rtbMetin.SelectionColor = Color.DodgerBlue;
                rtbMetin.SelectionLength = txtAranacakMetin.Text.Length;
                
            }
            
        }
    }
}
