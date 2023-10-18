using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelEzb
{
    public partial class MainForm_KelEzb : Form
    {
        public MainForm_KelEzb()
        {
            InitializeComponent();
        }

        private void verigirisi_Click(object sender, EventArgs e) //veri girişi formuna gitmek için
        {
            VeriGir syf1 = new VeriGir();
            syf1.Show();
        }

        private void kelimetekrari_Click(object sender, EventArgs e) //kelime tekrarı formuna gitmek için
        {
            Kelime_Tekrari syf3 = new Kelime_Tekrari();
            syf3.Show();
        }

        private void kelimebulma_Click(object sender, EventArgs e) //kelime bulma formuna gitmek için 
        {
            Kelime_Bulma syf4 = new Kelime_Bulma();
            syf4.Show();
        }

        private void cikis_Click(object sender, EventArgs e) //Uygulamayı kapatmak için
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) //kelime seçme formuna gitmek için
        {
            KelimeSecme syf5 = new KelimeSecme();
            syf5.Show();
        }

        private void hazırlayanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hazırlayan syf6 = new Hazırlayan();
            syf6.Show();
        }
    }
}
