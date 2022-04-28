using System;
using System.Collections.Generic;
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
    /// uruneklemenu.xaml etkileşim mantığı
    /// </summary>
    public partial class uruneklemenu : Window
    {
        Connect connect = new Connect();
        public uruneklemenu()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Cmbx_UrunKategori.Items.Add("Soguk icecek");
            Cmbx_UrunKategori.Items.Add("Sicak icecek");
            Cmbx_UrunKategori.Items.Add("Yiyecek");
            Cmbx_UrunKategori.Items.Add("Tatli");
            Cmbx_UrunKategori.Items.Add("Aperatif");
            Cmbx_UrunKategori.Items.Add("Ekstra");
            
           

            Urun urun=new Urun();
            urun.ürüngetirlb(UListBox);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Urun urun = (Urun)UListBox.SelectedItem;
            urun.ürüngetir();
            
            tbUrun.Text =urun.Urunadi;
            tbFiyat.Text =Convert.ToString(urun.Fiyat);
            textbid.Text = Convert.ToString(urun.Urunid);
            //if (urun.Kategoriid==Cmbx_UrunKategori.SelectedIndex+1)
           // {
            //    Cmbx_UrunKategori.selec
            //}

            Cmbx_UrunKategori.SelectedIndex = urun.Kategoriid - 1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Urun urun = (Urun)UListBox.SelectedItem;
            urun.ürüngetir();

            tbUrun.Text = urun.Urunadi;
            tbFiyat.Text = Convert.ToString(urun.Fiyat);
            textbid.Text = Convert.ToString(urun.Urunid);

            Connect _connect = new Connect();
            string kayit =
                "delete ürünler where ID=@ID ";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = _connect.connect;

            sqlConnection.Open();


            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = kayit;
            sqlCommand.Connection = sqlConnection;
            sqlCommand.Parameters.AddWithValue("@urunadi", tbUrun.Text);
            sqlCommand.Parameters.AddWithValue("@fiyat", tbFiyat.Text);
            


            sqlCommand.Parameters.AddWithValue("@ID", Convert.ToInt32(textbid.Text));


            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            urun.ürüngetirlb(UListBox);

            MessageBox.Show("Silme Başarılı");
            UListBox.Items.Refresh();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (textbid.Text == "")
            {
                MessageBox.Show("Boş Kayıt Güncellenemez");
            }
            else
            {
                if (tbUrun.Text == "" && tbFiyat.Text == "")
                {
                    MessageBox.Show("Boş Kayıt Güncellenemez");
                }
                else
                {
                    Connect _connect = new Connect();
                    string kayit =
                        "update ürünler set urunadi=@urunadi,fiyat=@fiyat,kategoriid=@kategoriid where ID=@ID ";
                    SqlConnection sqlConnection = new SqlConnection();
                    sqlConnection.ConnectionString = _connect.connect;

                    sqlConnection.Open();


                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = kayit;
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.Parameters.AddWithValue("@urunadi", tbUrun.Text);
                    sqlCommand.Parameters.AddWithValue("@fiyat", tbFiyat.Text);
                    sqlCommand.Parameters.AddWithValue("@kategoriid", Cmbx_UrunKategori.SelectedIndex + 1);
                    sqlCommand.Parameters.AddWithValue("@ID", Convert.ToInt32(textbid.Text));


                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();
                    Urun urun = new Urun();
                    urun.ürüngetirlb(UListBox);

                    MessageBox.Show("Güncelleme Başarılı");
                    UListBox.Items.Refresh();
                }
                
            }
            tbUrun.Clear();
            tbFiyat.Clear();
            textbid.Clear();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            tbUrun.Clear();
            tbFiyat.Clear();
            textbid.Clear();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (textbid.Text == ""  )
            {
                if (tbUrun.Text == ""  && tbFiyat.Text == "")
                {
                    MessageBox.Show("Boş Kayıt Girilemez");
                }
                else
                {
                    Connect _connect = new Connect();
                    string kayit =
                        "Insert Into ürünler (urunadi,fiyat,kategoriid) values (@urunadi,@fiyat,@kategoriid)";
                    SqlConnection sqlConnection = new SqlConnection();
                    sqlConnection.ConnectionString = _connect.connect;

                    sqlConnection.Open();


                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.CommandText = kayit;
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.Parameters.AddWithValue("@urunadi", tbUrun.Text);
                    sqlCommand.Parameters.AddWithValue("@fiyat", tbFiyat.Text);
                    sqlCommand.Parameters.AddWithValue("@kategoriid", Cmbx_UrunKategori.SelectedIndex + 1);


                    //sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(textbid.Text));


                    sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();
                    Urun urun = new Urun();
                    urun.ürüngetirlb(UListBox);


                    MessageBox.Show("Kayıt Başarılı");
                    UListBox.Items.Refresh();

                }
                
            }
            else
            {
                MessageBox.Show("Lütfen Yeni Kayıt Giriniz.");
            }
            tbUrun.Clear();
            tbFiyat.Clear();
            textbid.Clear();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
