using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu_YM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            RandevuIslemleri frm_randevu = new RandevuIslemleri();
            frm_randevu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Klinik frm_klinik = new Klinik();
            frm_klinik.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doktorlar frm_doktorlar = new Doktorlar();
            frm_doktorlar.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hastalar frm_hastalar = new Hastalar();
            frm_hastalar.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Ayarlar frm_ayarlar = new Ayarlar();
            frm_ayarlar.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GenelTakvim frm_takvim = new GenelTakvim();
            frm_takvim.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Odeme frm_odeme = new Odeme();
            frm_odeme.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çıkış Yapıldı!"); // Burası OK NO Butonu Olacak
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            HastaRaporOluşturucu frm_rapor = new HastaRaporOluşturucu();
            frm_rapor.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ReceteIslemleri frm_recete = new ReceteIslemleri();
            frm_recete.Show();
        }
    }
}
