using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CafeAdisyon
{
    /// <summary>
    /// PersonelKayit.xaml etkileşim mantığı
    /// </summary>
    public partial class PersonelKayit : Window
    {
        Connect connect = new Connect();
        public PersonelKayit()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Cmbx_PersonelGorev.Items.Add("Yönetici");
            Cmbx_PersonelGorev.Items.Add("Kasiyer");
            Cmbx_PersonelGorev.Items.Add("Garson");
            Personel personel = new Personel();
            personel.personelgetirlb(PListBox);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {/*
            Personel personel = (Personel)ListBox.SelectedItem;
            connect.personelId = personel.Personelid;
            connect.personelgörevId = personel.Personelgörevid;
            */

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Personel personel = (Personel)PListBox.SelectedItem;
            personel.personelgetir();
            connect.personelId = personel.Personelid;
            connect.personelgörevId = personel.Personelgörevid;
            tbAd.Text = personel.Personelad;
            tbSoyad.Text = personel.Personelsoyad;
            Cmbx_PersonelGorev.SelectedIndex = personel.Personelgörevid - 4;
            tbKadi.Text = personel.Personelkadi;
            tbParola.Text = Convert.ToString(personel.Personelsifre);
            textbid.Text = Convert.ToString(personel.Personelid);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textbid.Text == "")
            {
                Connect _connect = new Connect();
                string kayit =
                    "Insert Into personeller (ad,soyad,gorevid,parola,kullaniciadi) values (@ad,@soyad,@gorevid,@parola,@kullaniciadi)";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = _connect.connect;
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = kayit;
                sqlCommand.Parameters.AddWithValue("@ad", tbAd.Text);
                sqlCommand.Parameters.AddWithValue("@soyad", tbSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@gorevid", Cmbx_PersonelGorev.SelectedIndex + 4);
                sqlCommand.Parameters.AddWithValue("@parola", tbParola.Text);
                sqlCommand.Parameters.AddWithValue("@kullaniciadi", tbKadi.Text);

                //sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(textbid.Text));


                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
                Personel personel = new Personel();
                personel.personelgetirlb(PListBox);

                MessageBox.Show("Kayıt Başarılı");
                PListBox.Items.Refresh();
            }
            else
            {
                MessageBox.Show("Lütfen Yeni Kayıt Giriniz.");
            }
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Personel personel = (Personel)PListBox.SelectedItem;
            personel.personelgetir();
            connect.personelId = personel.Personelid;
            connect.personelgörevId = personel.Personelgörevid;
            tbAd.Text = personel.Personelad;
            tbSoyad.Text = personel.Personelsoyad;
            tbKadi.Text = personel.Personelkadi;
            tbParola.Text = Convert.ToString(personel.Personelsifre);
            textbid.Text = Convert.ToString(personel.Personelid);

            Connect _connect = new Connect();
            string kayit =
                "delete personeller where id=@id ";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = _connect.connect;

            sqlConnection.Open();


            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = kayit;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@ad", tbAd.Text);
            sqlCommand.Parameters.AddWithValue("@soyad", tbSoyad.Text);
            sqlCommand.Parameters.AddWithValue("@parola", tbParola.Text);
            sqlCommand.Parameters.AddWithValue("@kullaniciadi", tbKadi.Text);

            sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(textbid.Text));


            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            
            personel.personelgetirlb(PListBox);

            MessageBox.Show("Silme Başarılı");
            PListBox.Items.Refresh();

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (textbid.Text == "")
            {
                MessageBox.Show("Boş Kayıt Güncellenemez");
            }
            else
            {
                Connect _connect = new Connect();
                string kayit =
                    "update personeller set ad=@ad,soyad=@soyad,gorevid=@gorevid,parola=@parola,kullaniciadi=@kullaniciadi where id=@id ";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = _connect.connect;

                sqlConnection.Open();


                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = kayit;
                sqlCommand.Connection = sqlConnection;
                sqlCommand.Parameters.AddWithValue("@ad", tbAd.Text);
                sqlCommand.Parameters.AddWithValue("@soyad", tbSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@gorevid", Cmbx_PersonelGorev.SelectedIndex + 4);
                sqlCommand.Parameters.AddWithValue("@parola", tbParola.Text);
                sqlCommand.Parameters.AddWithValue("@kullaniciadi", tbKadi.Text);

                sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(textbid.Text));


                sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
                Personel personel = new Personel();
                personel.personelgetirlb(PListBox);

                MessageBox.Show("Güncelleme Başarılı");
                PListBox.Items.Refresh();
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            tbAd.Clear();
            tbKadi.Clear();
            tbParola.Clear();
            tbSoyad.Clear();
            textbid.Clear();
        }

        private void Cmbx_PersonelGorev_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
