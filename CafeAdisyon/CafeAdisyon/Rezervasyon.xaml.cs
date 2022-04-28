using System;
using System.Collections;
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
    /// Rezervasyon.xaml etkileşim mantığı
    /// </summary>
    public partial class Rezervasyon : Window
    {
        Connect _connect=new Connect();
        public Rezervasyon()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
       //rezer aç
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
           
                string kayit =
                    "Insert Into rezervasyon (musteriadsoyad,kisisayisi,masaid,tarih) values (@ad,@kisi,@masa,@tarih)";
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = _connect.connect;
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                sqlCommand.CommandText = kayit;
            if (txtkisi.Text == "" && txtad.Text == "")
            {
                MessageBox.Show("Boş Kayıt Girilemez");
            }
            else
            {

                datagrid.Items.Clear();
                datagrid.Items.Refresh();
                cmb_masalar_Copy.Items.Clear();
                sqlCommand.Parameters.AddWithValue("@ad", txtad.Text);
                sqlCommand.Parameters.AddWithValue("@kisi", Convert.ToInt32(txtkisi.Text));
                sqlCommand.Parameters.AddWithValue("@masa", cmb_masalar.SelectedIndex + 1);
                sqlCommand.Parameters.AddWithValue("@tarih", DatePicker.SelectedDate);
            }


            //sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(textbid.Text));

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                MessageBox.Show("Boş Kayıt Girilemez");
            }



            //DateTime myDateTime = DateTime.Now;
            //string sqlFormattedDate = myDateTime.ToString();
            //DateTime zaman = DateTime.Today;
            datagrid.Items.Clear();
            datagrid.Items.Refresh();
            cmb_masalar_Copy.Items.Clear();
            sqlCommand.CommandText ="Select musteriadsoyad,kisisayisi,masaid,ID,tarih from rezervasyon";
                var dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())

                {
                    var urun = new Urun();
                    urun.musteriadi = Convert.ToString(dataReader["musteriadsoyad"]);
                    urun.kisisayisi = Convert.ToInt32(dataReader["kisisayisi"]);
                    urun.masaid = Convert.ToInt32(dataReader["masaid"]);
                    urun.tarih = Convert.ToString(dataReader["tarih"]);
                    urun.musteriid = Convert.ToInt32(dataReader["ID"]);
                    

                    datagrid.Items.Add(new
                    {
                       ad = urun.musteriadi,
                        kisi =urun.kisisayisi,
                        masa = urun.masaid,
                        tarih=urun.tarih
                    });
                    cmb_masalar_Copy.Items.Add(urun.musteriadi);

                }

                sqlConnection.Close();
                txtkisi.Clear();
                txtad.Clear();


        }

        public void datagetir()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = _connect.connect;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "Select musteriadsoyad,kisisayisi,masaid,tarih from rezervasyon";
            var dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())

            {
                var urun = new Urun();
                urun.musteriadi = Convert.ToString(dataReader["musteriadsoyad"]);
                urun.kisisayisi = Convert.ToInt32(dataReader["kisisayisi"]);
                urun.masaid = Convert.ToInt32(dataReader["masaid"]);
                urun.tarih = Convert.ToString(dataReader["tarih"]);

                datagrid.Items.Add(new
                {
                    ad = urun.musteriadi,
                    kisi = urun.kisisayisi,
                    masa = urun.masaid,
                    tarih = urun.tarih
                });
                cmb_masalar_Copy.Items.Add(urun.musteriadi);

            }

            sqlConnection.Close();
        }
        private void Rezervasyon_OnLoaded(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i < 22; i++)
            {
                cmb_masalar.Items.Add("Masa" + i);

            }

            datagetir();
        }

        private void ButtonBase_OnClickk(object sender, RoutedEventArgs e)
        {
            
            
            string kayit =
                "delete rezervasyon where musteriadsoyad=@ad ";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = _connect.connect;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;

            sqlCommand.CommandText = kayit;
            sqlCommand.Parameters.AddWithValue("@ad", cmb_masalar_Copy.SelectionBoxItem);



            //sqlCommand.Parameters.AddWithValue("@id", Convert.ToInt32(textbid.Text));

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            datagrid.Items.Refresh();
            datagrid.Items.Clear();
            cmb_masalar_Copy.Items.Clear();
            datagetir();

        }


    }
}
