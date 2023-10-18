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
    public partial class Kelime_Bulma : Form
    {
        //veritabanı tanımlandı
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= KellEzbAcs.mdb");

        private string gelenKelime = ""; //gelenKelime diye bir değişken
        private string gelenKelimeAnlami = "";//gelenKelimeAnlami diye bir değişken daha

        private int oyunBaslamaSuresi = 25; /*oyunBaslamaSuresi değişkenine 10 değeri atandı 
                                             -> oyun form açılınca hemen başlamasın diye*/

        private int puan = 0; //puan değişkenine 0 değeri atandı
        private int oyunSoruSaniyesi = 50; // oyunSoruSaniyesi değişkeni
        private int oyunSoruSayisi = 10; // oyunSoruSayisi değişkeni

        public Kelime_Bulma()
        {
            InitializeComponent();
        }

        private void Karıstır(char[] array) //harfleri karıştırmak için
        {
            Random rng = new Random(); //rastgele sayı üretilmesi için
            int n = array.Length; //sayının uzunluğunu n değişkenine atandı

            while (n > 1) //n birden büyük olduğu müddetçe çalışan bir döngü ile
            {
                int k = rng.Next(n); //n kadar rastgele bir sayı üretti k değişkenine atandı
                n--; //her seferinde n bir azaltıldı
                char temp = array[n]; //dizi de ki n inci karakteri temp diye geçici bir karaktere atandı.
                array[n] = array[k]; //dizi de ki k değişkenini az önce rastgele üretilen harfi n ye atandı
                array[k] = temp; //k ya geçici karakter atandı
            }
        }

        private void soruGetir()
        {
            label_cevap.Visible = true; //label gösterildi
            textBox1.Focus(); //soru geldiğinde textboxa focus olması için
            if (oyunSoruSayisi > 0) /*eğer oyunSoruSayısı 0 dan büyükse 
                                    -> yani oyun soru sayısı değikeni kaç tane soru sorulacağını belirliyor*/
            {
                label_cevap.Text = "Kelimeyi yazıp enter'a basınız!"; //gerekli uyarı labelı
                oyunSoruSaniyesi = Convert.ToInt32(numericvalue.Value); //50; //sorunun saniyesini 50 saniye yapıldı
                label_harfKarısık.Text = textBox1.Text = ""; //labellar ve textboxlar temizlendi

                Random r = new Random(); //rastgele bi kelime id si getirtmek için

                baglantı.Open(); //burda veritabanındaki sütun sayısını bulmak için veri tabanı bağlantısı açıldı
                OleDbCommand komut1 = new OleDbCommand("select count(*) from Sozluk", baglantı);
                int n = Convert.ToInt32(komut1.ExecuteScalar());
                baglantı.Close();

                baglantı.Open(); //veritabanından rastgele veri çekebilmek için veri tabanı bağlantısı açıldı
                OleDbCommand komut2 = new OleDbCommand();
                komut2.Connection = baglantı;
                komut2.CommandText = "select * from Sozluk where id=" + r.Next(1,n);
                OleDbDataReader oku = komut2.ExecuteReader();

                while (oku.Read()) //veritabanından labellara sırayla veri alınması için
                {
                    gelenKelime = oku["English"].ToString();
                    gelenKelimeAnlami = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(oku["Turkce"].ToString());
                }
                baglantı.Close();

                char[] harfler = new char[gelenKelime.Length]; //harfler diye bir dizi oluşturuldu gelenKelimenin uzunluğunca 
                int j = 0; //harfler dizisinde index = 0'dan başlaması için

                //gelenKelime'deki harfleri sırayla harfler dizisine atmak için
                foreach (char karakter in gelenKelime) //kelimedeki harfleri harfler dizisinin içine atıldı
                {
                    harfler[j] = karakter;
                    j++;
                }

                Karıstır(harfler); //kelime harflerini karıştırmak için -> yani harfler dizisindeki elemanlar rastgele sıralanmış oldu

                for (int i = 0; i < harfler.Length; i++) //sonra harfleri teker teker labela yazdırmak için
                {
                    label_harfKarısık.Text += harfler[i];
                }
                label_tranlam.Text = gelenKelimeAnlami;
                timer_baslama.Start(); //timer_baslama başlatıldı
            }
            if(oyunSoruSayisi == 0) //oyun sonu toplam puanın gözükmesi için
            {
                label6.Visible = label_puan.Visible = true;
                label_puan.Text = puan.ToString();
            }
        }

        private void Kelime_Bulma_Load(object sender, EventArgs e) //form açıldığında timer_hazırlık'ın başlaması için
        {
            timer_hazırlık.Start();
            timer_hazırlık_Tick(this.timer_hazırlık, e);
        }

        private void oyunuBitir() //oyun bitirmek için
        {
            label6.Visible = label_puan.Visible = true; //oyun bitirildiğinde toplam puanın gözükmesi için
            label_puan.Text = puan.ToString();
            label_oyunSayaci.Text = "_"; //oyun bitirildiğinde sayacında sıfırlanması için
            timer_hazırlık.Stop(); //hazırlık timerı durduruldu
            timer_baslama.Stop(); //timer_baslama durduruldu
        }

        private void timer_hazırlık_Tick(object sender, EventArgs e)
        {
            oyunBaslamaSuresi--; //oyunBaslamaSuresini geriye doğru saydırmak için
            label_snybaslama.Text = "Oyun " + oyunBaslamaSuresi.ToString() + " saniye sonra başlayacak."; //ekranda gösterilip kullanıcının bilgilendirilmesi için
            if (oyunBaslamaSuresi == 0) //oyunBaslamaSuresi sıfırlandıysa oyunu başlatılıyor 
            {
                timer_hazırlık.Stop(); //timer_hazırlık durduruldu
                label_snybaslama.Visible = false; //label gizlendi
                timer_baslama.Start(); // timer_baslama başlattıldı
                soruGetir(); //metot çağrıldı
            }
        }

        private void timer_baslama_Tick(object sender, EventArgs e)
        {
            label_oyunSayaci.Text = oyunSoruSaniyesi.ToString(); //labela sorunun saniyesini yazdırıldı

            if (oyunSoruSaniyesi == 0) //soru saniyesi 0 sa
            {
                oyunSoruSayisi--; //soru sayısını 1 düşürüldü -> yani diğer soruya geçildi
                label_cevap.Text = "Üzgünüm doğru cevap : " + gelenKelime; //saniye sıfırsa soru bilinememiştir
                timer_baslama.Stop(); //timer_baslama durduruldu
                MessageBox.Show("Puanınız değişmedi : " + puan.ToString() + "\nYeni soruya hazır mısın ?", "Bilemediniz."); //saniye sıfırsa bilememiştir.
                soruGetir(); //yeni soru getirildi
            }
            oyunSoruSaniyesi--; //sorunun saniyesini bir bir azaltıldı
        }

        private void t_oyuncuKelimesi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //eğer cevap için entera basıldıysa
            {
                oyunSoruSayisi--; //oyun soru sayısını bir azaltıldı eğer cevap verildiyse
                timer_baslama.Stop(); //timer_baslama durduruldu
                string t = textBox1.Text; //textBox'a yazılan yazı alındı
                textBox1.Text = ""; //textbox sıfırlandı

                if (t == gelenKelime) //eğer textBox'a yazılan gelen kelimeye eşitse bilinmiştir
                {
                    timer_baslama.Stop(); //timer_baslama durduruldu
                    puan += 20; //puana 20 eklendi
                    //kullanıcının bilgilendirilmesi için
                    label_cevap.Text = "Tebrikler doğru cevap : " + gelenKelime + "\nYeni soru hazırlanıyor.";
                    MessageBox.Show("Şimdiki puanınız : " + puan.ToString() + "\nYeni soruya hazır mısın ?", "Bildiniz.");
                    soruGetir(); //soruGetir metodu çağrıldı
                }

                else //eğer doğru değilse puan verilmiyor
                {
                    //kullanıcının bilgilendirilmesi için
                    label_cevap.Text = "Üzgünüm doğru cevap : " + gelenKelime + "\nYeni soru hazırlanıyor.";
                    MessageBox.Show("Puanınız değişmedi : " + puan.ToString() + "\nYeni soruya hazır mısın ?", "Bilemediniz.");
                    soruGetir(); //soruGetir metodu çağrıldı
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) //oyunun bitirilmesi için
        {
            oyunuBitir();
        }

        private void button2_Click(object sender, EventArgs e) //oyunun tekrar oynanması için
        {            
            soruGetir(); //soruGetir metodu çağrıldı

            label_cevap.Visible = false; //lable gizlendi
            int sayac = 0; //değişken tanımlandı
            int artis = Convert.ToInt32(numericvalue.Value); //numericUpDowna göre artış değişkeni tanımşandı
            sayac += artis; //numericUpDowna göre sayac değeri değiştirildi
            label_oyunSayaci.Text = sayac.ToString(); //labela sayac değeri string olarak atandı
            oyunSoruSayisi = 10; //oyunSoruSayisi sıfırlandı

            puan = 0; //puan sıfırladık        
            label6.Visible = label_puan.Visible = false; //labelların gözükmemesi için
            
            label_tranlam.Text = "_";
            label_harfKarısık.Text = "_";

            timer_baslama.Start();            
        }

        private void numericvalue_ValueChanged(object sender, EventArgs e)
        {
            int sayac = 0; //değişken tanımlandı
            int artis = Convert.ToInt32(numericvalue.Value); //numericUpDowna göre artış değişkeni tanımşandı
            sayac += artis; //numericUpDowna göre sayac değeri değiştirildi
            label_oyunSayaci.Text = sayac.ToString(); //labela sayac değeri string olarak atandı
        }
    }
}
