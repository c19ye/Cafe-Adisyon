using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CafeAdisyon
{
    /// <summary>
    ///     Masalar.xaml etkileşim mantığı
    /// </summary>
    public partial class Masalar : Window
    {
        public static string _masaisim;
        private readonly Connect _connect = new Connect();
        private Connect Connect = new Connect();
        private readonly Urun urun = new Urun();

        public Masalar()
        {
            InitializeComponent();
        }


        #region Kapat Tuşu

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var mainSelections = new MainSelections();
            Close();
            mainSelections.Show();
        }

        #endregion

        #region Sipariş Girme Sayfasını Getirme

        private void wsiparisac()
        {
            var _wSiparisGir = new wSiparisGir();
            _wSiparisGir.Owner = this;
            _wSiparisGir.ShowDialog();


            //string getir = "Select durum from masalar where ID = '1'";
            //var sqlConnection = new SqlConnection(_connect.connect);
            //var sqlCommand = new SqlCommand();
            //sqlCommand.Connection = sqlConnection;
            //sqlCommand.CommandText = getir;
            //if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
            //var dataReader = sqlCommand.ExecuteReader();
            //while (dataReader.Read())
            //{

            //    _wSiparisGir.lblmasadurum.Text = Convert.ToString(dataReader["durum"]);

            //}

            //dataReader.Close();
            //sqlConnection.Close();
        }

        #endregion

        private void Masalar_OnLoaded(object sender, RoutedEventArgs e)
        {
            yenile();
        }

        private void yenile()
        {
            for (var i = 1; i <= 21; i++)
            {
                Image[] ims =
                {
                    ims1, ims2, ims3, ims4, ims5, ims6, ims7, ims8, ims9, ims10, ims11, ims12, ims13, ims14, ims15,
                    ims16, ims17, ims18, ims19, ims20, ims21
                };
                TextBlock[] tms =
                {
                    tms1, tms2, tms3, tms4, tms5, tms6, tms7, tms8, tms9, tms10, tms11, tms12, tms13, tms14, tms15,
                    tms16, tms17, tms18, tms19, tms20, tms21
                };
                var getir = "Select durum from masalar where ID = '" + i + "'";

                var sqlConnection = new SqlConnection(_connect.connect);
                var sqlCommand = new SqlCommand(getir, sqlConnection);

                if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
                var dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read()) urun.durum = Convert.ToInt32(dataReader["durum"]);
                dataReader.Close();
                sqlConnection.Close();
                if (urun.durum == 1)
                {
                    ims[i - 1].Source = new BitmapImage(new Uri("Images/Kmasasonsonpng.png", UriKind.Relative));
                    tms[i - 1].Foreground = new SolidColorBrush((Color) ColorConverter.ConvertFromString("#E46860"));
                }
                else
                {
                    ims[i - 1].Source = new BitmapImage(new Uri("Images/smasa.png", UriKind.Relative));
                    tms[i - 1].Foreground = new SolidColorBrush((Color) ColorConverter.ConvertFromString("#EFC517"));
                }
            }
        }

        #region Masaya Tıklayınca Sipariş Girme Ekranının Gelmesi

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _masaisim = " Masa1";

            wsiparisac();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            _masaisim = " Masa2";
            wsiparisac();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            _masaisim = " Masa3";
            wsiparisac();
        }

        private void Button_Click_31(object sender, RoutedEventArgs e)
        {
            _masaisim = " Masa4";
            wsiparisac();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            _masaisim = " Masa5";
            wsiparisac();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            _masaisim = " Masa6";
            wsiparisac();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            _masaisim = " Masa7";
            wsiparisac();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            _masaisim = " Masa8";
            wsiparisac();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            _masaisim = " Masa9";
            wsiparisac();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            _masaisim = " Masa10";
            wsiparisac();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            _masaisim = " Masa11";
            wsiparisac();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            _masaisim = " Masa12";
            wsiparisac();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            _masaisim = " Masa13";
            wsiparisac();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            _masaisim = " Masa14";
            wsiparisac();
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)

        {
            _masaisim = " Masa15";
            wsiparisac();
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            _masaisim = " Masa16";
            wsiparisac();
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            _masaisim = " Masa17";
            wsiparisac();
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            _masaisim = " Masa18";
            wsiparisac();
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            _masaisim = " Masa19";
            wsiparisac();
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            _masaisim = " Masa20";
            wsiparisac();
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            _masaisim = " Masa21";
            wsiparisac();
        }

        #endregion

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            yenile();
        }
    }
}