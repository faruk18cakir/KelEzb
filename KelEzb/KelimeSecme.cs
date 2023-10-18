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
    public partial class KelimeSecme : Form
    {
        //veritabanı tanımlandı
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= KellEzbAcs.mdb");

        Random rnd = new Random(); //random işlem yapabilmek için

        // başta değişkenler tanımlandı
        private string dogrucvp = "_";
        private int puan = 0;
        private string a="";
        private string b="";
        private string c="";
        private string d="";
        
        public KelimeSecme()
        {
            InitializeComponent();
        }

        private void Buton1text()
        {
            baglantı.Open(); //test için teste sorulan soru ve bu sorunun anlamı değişkene ve label a atandı
            OleDbCommand komut = new OleDbCommand("select * from Sozluk where id=" + rnd.Next(1, 47), baglantı); //veritabanından rastgele veri alabilmek için
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read()) //veritabanından labellara ve değişkene sırayla veri alınması için
            {
                label_kelime.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(oku["English"].ToString());
                dogrucvp = oku["Turkce"].ToString();
                a = oku["Turkce"].ToString();
            }
            baglantı.Close();            
        }

        /*anlamı sorulan kelimenin anlamı yukarıda alındı ama 4 şıklı test hazırlandığı için geriye kalan 3 
         * değişkenede yanlış anlamlar alınması gerekmektedir bu yüzden Buton2text, Buton3text ve Buton4text'te 
         * bu değişkenlere veri tabanından veri alındı*/
        private void Buton2text()
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("select * from Sozluk where id=" + rnd.Next(1, 47), baglantı);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                b = oku["Turkce"].ToString();
            }
            baglantı.Close();            
        }
        private void Buton3text()
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("select * from Sozluk where id=" + rnd.Next(1, 47), baglantı);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                c = oku["Turkce"].ToString();
            }
            baglantı.Close();            
        }
        private void Buton4text()
        {
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand("select * from Sozluk where id=" + rnd.Next(1, 47), baglantı);
            OleDbDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                d = oku["Turkce"].ToString();
            }
            baglantı.Close();            
        }

        //yukarda veritabanından veri atanmış değişkenler buton textlerine rastgele atanması için dizi bir metot oluşturuldu
        private static T[] Karistirma<T>(ICollection<T> input) 
        {
            T[] output = new T[input.Count]; //output dizisi tanımlandı

            Random rnd = new Random(); //random tanımlaması yapılmıldı

            int outputPosition = 0; //değişken tanımlandı
            List<T> inputCopy = new List<T>(input); //liste oluşturuldu

            int index = 0; //değişken tanımlandı
            int count = inputCopy.Count; //count değişkenine input.Count değeri atandı

            while (count > 0)
            {
                index = rnd.Next(0, count--); //döngü çalıştıkça count değerine göre random aralığı değişir
                output[outputPosition++] = inputCopy[index]; /*döngü boyunca yukarda tanımlanmış olan output dizisinin her elemanıda
                                                             inputCopy listesindeki elemanlar atanır*/
                inputCopy.RemoveAt(index);
            }
            return output; //outputa geri dönüldü
        }

        private void listeli() //yukarda oluşturulan metodu kullanarak buton text lerine cevaplar rastgele yazıldı
        {
            List<string> cevaplar = new List<string>() { a, b, c, d }; //veri atanmış değişkenler listeye aktarıldı

            int[] dizi = new int[] { 0, 1, 2, 3 }; //
            int[] kardizi = Karistirma(dizi); //

            //veri atanmış değişkenler karıştırıldıktan sonra buton textlerine atandı
            cvp1.Text = cevaplar[kardizi[0]].ToString(); 
            cvp2.Text = cevaplar[kardizi[1]].ToString();
            cvp3.Text = cevaplar[kardizi[2]].ToString();
            cvp4.Text = cevaplar[kardizi[3]].ToString();
        }
        
        private void SonrakiSoru()
        {
			//ilk önce metotlar çağrıldı
			Buton1text();
			Buton2text();
			Buton3text();
			Buton4text();

			listeli();

			button_next.Text = "Sonraki"; //basla butonunun texti değiştirildi
		}

        private void button_next_Click(object sender, EventArgs e) //basla butonuna tıklandığında verilerin gelmesi için
        {
            ////ilk önce metotlar çağrıldı
            //Buton1text();
            //Buton2text();
            //Buton3text();
            //Buton4text();

            //listeli();

            //button_next.Text = "Sonraki"; //basla butonunun texti değiştirildi

            //==========
            SonrakiSoru();
        }

        private void button_cikis_Click(object sender, EventArgs e) //butona tıklandığında ekranın temzilenmesi için
        {
            puan = 0;
            button_next.Text = "Başla";
            label_puan.Text = "_";
            label_kelime.Text = "____________________________";
            cvp1.Text = "";
            cvp2.Text = "";
            cvp3.Text = "";
            cvp4.Text = "";
        }

        private void DogruCevap(Button cvp)
        {
			if (cvp.Text == dogrucvp) //cvp1'in textti dogrucvp eşitse
			{
				puan += 10; //puana 10 ekle
				label_puan.Text = puan.ToString(); //labela yaz
				SonrakiSoru();
			}
		}

        /*cevap butonlarına tıknanıldığında doğru cevapta puan alınabilmesi için cvp1_Click, cvp2_Click, cvp3_Click, cvp4_Click
         metotları oluşturuldu*/
        private void cvp1_Click(object sender, EventArgs e)
        {
            //if (cvp1.Text == dogrucvp) //cvp1'in textti dogrucvp eşitse
            //{
            //    puan += 10; //puana 10 ekle
            //    label_puan.Text = puan.ToString(); //labela yaz
            //}
            DogruCevap(cvp1);
        }

        private void cvp2_Click(object sender, EventArgs e)
        {
			//if (cvp2.Text == dogrucvp) //cvp2'nin textti dogrucvp eşitse
			//{
			//    puan += 10; //puana 10 ekle
			//    label_puan.Text = puan.ToString(); //labela yaz
			//}
			DogruCevap(cvp2);
		}

        private void cvp3_Click(object sender, EventArgs e)
        {
			//if (cvp3.Text == dogrucvp) //cvp3'ün textti dogrucvp eşitse
			//{
			//    puan += 10; //puana 10 ekle
			//    label_puan.Text = puan.ToString(); //labela yaz
			//}
			DogruCevap(cvp3);
		}

        private void cvp4_Click(object sender, EventArgs e)
        {
			//if (cvp4.Text == dogrucvp) //cvp4'ün textti dogrucvp eşitse
			//{
			//    puan += 10; //puana 10 ekle
			//    label_puan.Text = puan.ToString(); //labela yaz
			//}
			DogruCevap(cvp4);
		}
    }
}
