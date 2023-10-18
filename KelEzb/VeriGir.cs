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

namespace KelEzb
{
   
    public partial class VeriGir : Form
    {
        //veri tabanı tanımlandı
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= KellEzbAcs.mdb");
        public VeriGir()
        {
            InitializeComponent();
        }

        private void veriler() //listView'de verilerin belirlenen sıraya göre seçilip yerleşmesi için
        {
            listView1.Items.Clear();
            baglantı.Open();
            OleDbCommand komut = new OleDbCommand();
            komut.Connection = baglantı;
            komut.CommandText = "Select * From Sozluk";
            OleDbDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem(); //verilerin listView'de sırayla yerleşmesi için
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["English"].ToString());
                ekle.SubItems.Add(oku["Okunusu"].ToString());
                ekle.SubItems.Add(oku["Turkce"].ToString());
                listView1.Items.Add(ekle);
            }
            baglantı.Close();
        }
        /*private void geri_Click(object sender, EventArgs e)
        {
            
        }*/

        /*private void ileri_Click(object sender, EventArgs e)
        {

        }*/

        private void kaydet_Click(object sender, EventArgs e) //veri tabanına veri kaydedebilmek için 
        {
            baglantı.Open();
            //testBox'lara yazılanların kaydet butonuna tıklandığında veri tabanına sırayla kaydedilmesi için
            OleDbCommand komut = new OleDbCommand("insert into Sozluk (id,English,Okunusu,Turkce) values ('" + textBox1.Text.ToString() + "','" + textBox2.Text.ToString() + "','" + textBox3.Text.ToString() + "','" + textBox4.Text.ToString()+"')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            veriler();
        }

        private void sil_Click(object sender, EventArgs e) //veri tabanına veri silebilmek için 
        {
            string sorgu = "delete from Sozluk where id =" + textBox1.Text + ""; //id'ye göre veri silmek için
            OleDbCommand komut = new OleDbCommand(sorgu,baglantı);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            veriler();
        }

        private void temizle_Click(object sender, EventArgs e) //textBox'ta yazılanları silmek için
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void goruntule_Click(object sender, EventArgs e) //görüntüle butonuna tıklandığında listView'de verilerin gözükmesi için
        {
            veriler();
        }

        /*private void button1_Click(object sender, EventArgs e)
       {
           baglantı.Open();
           OleDbCommand komut = new OleDbCommand();
           komut.Connection = baglantı;
           komut.CommandText = "UPDATE Sozluk SET English='" + textBox2.Text + "',Okunusu='" + textBox3.Text + "',Turkce='" + textBox4.Text + "' WHERE id='" + textBox1.Text + "'";
           komut.ExecuteNonQuery();
           baglantı.Close();
           veriler();
       }*/
    }
}
