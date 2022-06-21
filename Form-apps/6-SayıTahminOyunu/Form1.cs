using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_SayıTahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int rastgeleSayi;
        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 60; // ProgressBar'ın max değeri 60 olacak. Çünkü oyun süresi 60 sn olsun istiyoruz.
            btnTahminEt.Enabled = false; // Oyunu başlatmadan önce tahmin et butonu pasif olacak
        }

        private void btnOyunuBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start(); // timer'ı başlat. Timer , property'lerinden interval değeri süresinde bir Tick eventi tetiklenen kontroldür.
            rastgeleSayi = rnd.Next(1, 101);
            progressBar1.Value = progressBar1.Maximum; // ProgressBar'ın değeri, Load'da ayarlanan max değere eşit olsun(60 brm)
            btnTahminEt.Enabled = true;
            lblBilgi.Text=""; // Label'in içi boş olsun
            lblKullaniciMesaj.Text = string.Empty; // Label'in içi boş olsun
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            progressBar1.Value--; // Her tetiklenmede, progressBarın değerini 1 azalt.
            btnTahminEt.Text = "TAHMİN ET (" + progressBar1.Value + ")";

            switch (progressBar1.Value)
            {
                case 50:
                    lblKullaniciMesaj.Text = "Galiba kaybedeceksin :)";
                    break;
                case 30:
                    lblKullaniciMesaj.Text = "Sen kaybetmek için yarışıyorsun:) :)";
                    break;
                case 20:
                    lblKullaniciMesaj.Text = "Bu işi yapamıyorsun bırak bence :D";
                    break;
                case 10:
                    lblKullaniciMesaj.Text = "Süre de doluyor artık!";
                    break;
                case 0:
                    lblKullaniciMesaj.Text = "Ne demiştim ben sana :) Artık bir daha ki sefere dostum :)";
                    timer1.Stop(); // Timer'ı durduruyoruz
                    btnTahminEt.Enabled = false; // Süre dolduğu için tahmin edemesin.
                    break;
                
            }
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            int sayi = 0;

            try
            {
                sayi = int.Parse(txtGirilenSayi.Text);
            }
            catch 
            {
                MessageBox.Show("Sayı girmeyi unuttun dostum!");
            }
            lblBilgi.Text = sayi.ToString();

            if (sayi < rastgeleSayi)
                lblBilgi.Text += "=> Küçük sayı girdin!";
            else if (sayi > rastgeleSayi)
                lblBilgi.Text += "=> Büyük sayı girdin!";
            else
            {
                lblBilgi.Text = "Tebrikler! Bildinizz...";
                int kacSaniyedeBildi = Math.Abs(progressBar1.Value - 60); // Kaç saniyede bildiğini tespit ettik.

                if (kacSaniyedeBildi > 50 && kacSaniyedeBildi <= 60)
                    lblKullaniciMesaj.Text = "Son saniyede!!";
                else if(kacSaniyedeBildi > 40 && kacSaniyedeBildi <= 50)
                    lblKullaniciMesaj.Text = "Ucundan yakaladın!";
                else if (kacSaniyedeBildi > 30 && kacSaniyedeBildi <= 40)
                    lblKullaniciMesaj.Text = "Helal olsun!";
                else if (kacSaniyedeBildi > 20 && kacSaniyedeBildi <= 30)
                    lblKullaniciMesaj.Text = "Eh işte!";
                else if (kacSaniyedeBildi > 10 && kacSaniyedeBildi <= 20)
                    lblKullaniciMesaj.Text = "Gayet güzel!";
                else if (kacSaniyedeBildi > 0 && kacSaniyedeBildi <= 10)
                    lblKullaniciMesaj.Text = "Süper!";

                timer1.Stop();
                btnTahminEt.Enabled = false;
            }
            txtGirilenSayi.Text = ""; // Her tahmin girilip butona basıldığında içerisindeki metini temizlesin.
        }
    }
}
