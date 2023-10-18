using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Globalization;

namespace KelEzb
{
    public partial class Kelime_Tekrari : Form
    {
        //veri tabanı tanımlandı
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= KellEzbAcs.mdb");
        public Kelime_Tekrari()
        {
            InitializeComponent();
        }

        private int i = 1; //i değişkenine 1 değeri atandı -> 1 verilmesinin sebebi veri tabanından ilk elemanı almak için 
        private int j = 20; //j değişkenine 20 değeri atandı

        private void sıralı() //veritabanından sırayla elemanları çağırmak için gerekli metot
        {
            j--; //timer'da bu metot her çağrıldığında j'nin değeri 1 azalması için

            baglantı.Open(); //burda veri tabanındaki sütun sayısını bulmak için veri tabanı bağlantısı açıldı
            OleDbCommand komut1 = new OleDbCommand("select count(*) from Sozluk", baglantı);
            int n = Convert.ToInt32(komut1.ExecuteScalar()); //veri tabanındaki sütun sayıs n değişkenine atandı
            baglantı.Close();

            baglantı.Open(); //burda veri tabanından id numarasına göre veri alabilmek için için veri tabanı bağlantısı açıldı 
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText = "select top 1 * from Sozluk order By id=" + i; 
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read()) //veri tabanından labellara sırayla veri alınması için
            {
                label_ıd.Text = (oku["id"].ToString());
                label_ıngılızce.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((oku["English"].ToString()));
                label_okunusu.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((oku["Okunusu"].ToString()));
                label_turkce.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((oku["Turkce"].ToString()));
            }
            baglantı.Close();

            if (j == 0) /*burda bu metot her çağrıldığında j değeri 0 olduğunda metodun bir sonraki çağrılışında
                         veri tabanından gelen bir önceki değerden sonraki veriyi almak için koşul yazıldı*/
            {
                if (i == n) /*eğer i değeri veri tabanındaki sütun sayısına eşit olursa tekrar veri tabanın
                             başından veri alması için i = 1'e eşitlendi*/
                {
                    i = 1;
                }
                else
                {
                    i += 1; //i nin değeri bir artırılıyor
                    //?sıralı();
                }
                j = Convert.ToInt32(numericUpDown1.Value); //yukardaki koşul her seferinde tekrarlanması için j değerinide tekrar j nin ilk değerine eşitlenmiştir.
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true) //eğer checkBox işaretliyse 
            {
                sıralı(); //timer boyunca sıralı() metodu getirilsin                
            }

            else //checkBox işaretli değilse -> kelimelerin karışıl gelmesi için
            {
                i = 1;
                baglantı.Open(); //veri tabanından rastgele veri çekebilmek için veri tabanı bağlantısı açıldı
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglantı;
                komut.CommandText = "select * from Sozluk order by rnd(-id * time())"; /*id 'ye göre veri alınmasının sebebi id 'nin 
                                                                              veritabanındaki karşılığı sayısal bir değer olduğu için*/
                OleDbDataReader oku = komut.ExecuteReader();

                while (oku.Read()) //veri tabanından labellara sırayla veri alınması için
                {
                    label_ıd.Text = (oku["id"].ToString());
                    label_ıngılızce.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((oku["English"].ToString()));
                    label_okunusu.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((oku["Okunusu"].ToString()));
                    label_turkce.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase((oku["Turkce"].ToString()));
                }
                baglantı.Close();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) //numericUpDown'a göre timer süresinin değiştirilmesi için 
        {
            timer1.Stop(); 
            timer1.Interval = Convert.ToInt32(100 * numericUpDown1.Value);
            timer1.Start();
            timer1_Tick(this.timer1, e);
        }

        private void Kelime_Tekrari_Load(object sender, EventArgs e) //form çalıştırıldığında timer'ında çalışması için
        {
            timer1.Interval = 20;
            timer1.Start();
            timer1_Tick(this.timer1, e);
        }
    }

}
