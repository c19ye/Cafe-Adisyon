using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace CafeAdisyon
{
    /// <summary>
    ///     wSiparisGir.xaml etkileşim mantığı
    /// </summary>
    public partial class wSiparisGir : Window
    {
        public static int tutar;
        private readonly Connect _connect = new Connect();
       Masalar _masalar=new Masalar();
        private readonly Urun urun = new Urun();

        public wSiparisGir()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            urun.ürüngetirlbb1(ListBoxürün);

            if (ListBoxürün.Items.Count == 8)
            {
                txtblck1.Text = ListBoxürün.Items[0].ToString();
                txtblck2.Text = ListBoxürün.Items[1].ToString();
                txtblck3.Text = ListBoxürün.Items[2].ToString();
                txtblck4.Text = ListBoxürün.Items[3].ToString();
                txtblck5.Text = ListBoxürün.Items[4].ToString();
                txtblck6.Text = ListBoxürün.Items[5].ToString();
                txtblck7.Text = ListBoxürün.Items[6].ToString();
                txtblck8.Text = ListBoxürün.Items[7].ToString();
            }
            else if (ListBoxürün.Items.Count == 7)
            {
                txtblck1.Text = ListBoxürün.Items[0].ToString();
                txtblck2.Text = ListBoxürün.Items[1].ToString();
                txtblck3.Text = ListBoxürün.Items[2].ToString();
                txtblck4.Text = ListBoxürün.Items[3].ToString();
                txtblck5.Text = ListBoxürün.Items[4].ToString();
                txtblck6.Text = ListBoxürün.Items[5].ToString();
                txtblck7.Text = ListBoxürün.Items[6].ToString();
                txtblck8.Text = "Urun";
            }
            else
            {
                MessageBox.Show("Eksik Ürün! Lütfen Yeni Ürün Ekleyin");
            }
        }

        //ödeme yapma butonu
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            tutar = 0;
            if (MainWindow.kullaniciid == 4 || MainWindow.kullaniciid == 5)
            {
                SqlConnection sqlConnection = new SqlConnection();
                sqlConnection.ConnectionString = _connect.connect;
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand();
                switch (txtmasaisim.Text)
                {
                    case " Masa1":

                        sqlCommand.CommandText = "update masasip set ödemetur='" +cm_ödemeturu.SelectedValue + "' where masaid=1 update masasip set masaid='0' where masaid=1 update masalar set durum ='0' where ID=1";
                        (this.Owner as Masalar).ims1.Source = new BitmapImage(new Uri("Images/smasa.png", UriKind.Relative));
                        (this.Owner as Masalar).tms1.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#EFC517"));
                        break;

                    case " Masa2":
                        sqlCommand.CommandText = "update masasip set ödemetur='" + cm_ödemeturu.SelectedValue + "' where masaid=2 update masasip set masaid='0' where masaid=2 update masalar set durum ='0' where ID=2";


                        (this.Owner as Masalar).ims2.Source = new BitmapImage(new Uri("Images/smasa.png", UriKind.Relative));
                        (this.Owner as Masalar).tms2.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#EFC517"));

                        break;
                    case " Masa3":
                        sqlCommand.CommandText = "update masasip set ödemetur='" + cm_ödemeturu.SelectedValue + "' where masaid=3 update masasip set masaid='0' where masaid=3 update masalar set durum ='0' where ID=3";

                        (this.Owner as Masalar).ims3.Source = new BitmapImage(new Uri("Images/smasa.png", UriKind.Relative));
                        (this.Owner as Masalar).tms3.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#EFC517"));
                        break;
                    case " Masa4":
                        sqlCommand.CommandText = "update masasip set ödemetur='" + cm_ödemeturu.SelectedValue + "' where masaid=4 update masasip set masaid='0' where masaid=4 update masalar set durum ='0' where ID=4";

                        (this.Owner as Masalar).ims4.Source = new BitmapImage(new Uri("Images/smasa.png", UriKind.Relative));
                        (this.Owner as Masalar).tms4.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#EFC517"));
                        break;
                    case " Masa5":
                        sqlCommand.CommandText = "update masasip set ödemetur='" + cm_ödemeturu.SelectedValue + "' where masaid=5 update masasip set masaid='0' where masaid=5 update masalar set durum ='0' where ID=5";

                        (this.Owner as Masalar).ims5.Source = new BitmapImage(new Uri("Images/smasa.png", UriKind.Relative));
                        (this.Owner as Masalar).tms5.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#EFC517"));
                        break;
                    case " Masa6":
                        sqlCommand.CommandText = "update masasip set ödemetur='" + cm_ödemeturu.SelectedValue + "' where masaid=6 update masasip set masaid='0' where masaid=6 update masalar set durum ='0' where ID=6";

                        (this.Owner as Masalar).ims6.Source = new BitmapImage(new Uri("Images/smasa.png", UriKind.Relative));
                        (this.Owner as Masalar).tms6.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#EFC517"));
                        break;
                    case " Masa7":
                        sqlCommand.CommandText = " update masasip set ödemetur='" + cm_ödemeturu.SelectedValue + "' where masaid=7 update masasip set masaid='0' where masaid=7 update masalar set durum ='0' where ID=7";

                        (this.Owner as Masalar).ims7.Source = new BitmapImage(new Uri("Images/smasa.png", UriKind.Relative));
                        (this.Owner as Masalar).tms7.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#EFC517"));
                        break;
                    case " Masa8":
                        sqlCommand.CommandText = "update masasip set ödemetur='" + cm_ödemeturu.SelectedValue + "' where masaid=8 update masasip set masaid='0' where masaid=8 update masalar set durum ='0' where ID=8";

                        (this.Owner as Masalar).ims8.Source = new BitmapImage(new Uri("Images/smasa.png", UriKind.Relative));
                        (this.Owner as Masalar).tms8.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#EFC517"));
                        break;
                    case " Masa9":
                        sqlCommand.CommandText = "update masasip set ödemetur='" + cm_ödemeturu.SelectedValue + "' where masaid=9 update masasip set masaid='0' where masaid=9 update masalar set durum ='0' where ID=9";

                        (this.Owner as Masalar).ims9.Source = new BitmapImage(new Uri("Images/smasa.png", UriKind.Relative));
                        (this.Owner as Masalar).tms9.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#EFC517"));
                        break;
                    case " Masa10":
                        sqlCommand.CommandText = "update masasip set ödemetur='" + cm_ödemeturu.SelectedValue + "' where masaid=10 update masasip set masaid='0' where masaid=10 update masalar set durum ='0' where ID=10";

                        (this.Owner as Masalar).ims10.Source = new BitmapImage(new Uri("Images/smasa.png", UriKind.Relative));
                        (this.Owner as Masalar).tms10.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#EFC517"));
                        break;
                    case " Masa11":
                        sqlCommand.CommandText = "update masasip set ödemetur='" + cm_ödemeturu.SelectedValue + "' where masaid=11 update masasip set masaid='0' where masaid=11 update masalar set durum ='0' where ID=11";

                        (this.Owner as Masalar).ims11.Source = new BitmapImage(new Uri("Images/smasa.png", UriKind.Relative));
                        (this.Owner as Masalar).tms11.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#EFC517"));
                        break;
                    case " Masa12":
                        sqlCommand.CommandText = "update masasip set ödemetur='" + cm_ödemeturu.SelectedValue + "' where masaid=12 update masasip set masaid='0' where masaid=12 update masalar set durum ='0' where ID=12";

                        (this.Owner as Masalar).ims12.Source = new BitmapImage(new Uri("Images/smasa.png", UriKind.Relative));
                        (this.Owner as Masalar).tms12.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#EFC517"));
                        break;
                    case " Masa13":
                        sqlCommand.CommandText = "update masasip set ödemetur='" + cm_ödemeturu.SelectedValue + "' where masaid=13 update masasip set masaid='0' where masaid=13 update masalar set durum ='0' where ID=13";

                        (this.Owner as Masalar).ims13.Source = new BitmapImage(new Uri("Images/smasa.png", UriKind.Relative));
                        (this.Owner as Masalar).tms13.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#EFC517"));
                        break;
                    case " Masa14":
                        sqlCommand.CommandText = "update masasip set ödemetur='" + cm_ödemeturu.SelectedValue + "' where masaid=14 update masasip set masaid='0' where masaid=14 update masalar set durum ='0' where ID=14";

                        (this.Owner as Masalar).ims14.Source = new BitmapImage(new Uri("Images/smasa.png", UriKind.Relative));
                        (this.Owner as Masalar).tms14.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#EFC517"));
                        break;
                    case " Masa15":
                        sqlCommand.CommandText = "update masasip set ödemetur='" + cm_ödemeturu.SelectedValue + "' where masaid=15 update masasip set masaid='0' where masaid=15 update masalar set durum ='0' where ID=15";

                        (this.Owner as Masalar).ims15.Source = new BitmapImage(new Uri("Images/smasa.png", UriKind.Relative));
                        (this.Owner as Masalar).tms15.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#EFC517"));
                        break;
                    case " Masa16":
                        sqlCommand.CommandText = "update masasip set ödemetur='" + cm_ödemeturu.SelectedValue + "' where masaid=16 update masasip set masaid='0' where masaid=16 update masalar set durum ='0' where ID=16";

                        (this.Owner as Masalar).ims16.Source = new BitmapImage(new Uri("Images/smasa.png", UriKind.Relative));
                        (this.Owner as Masalar).tms16.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#EFC517"));
                        break;
                    case " Masa17":
                        sqlCommand.CommandText = "update masasip set ödemetur='" + cm_ödemeturu.SelectedValue + "' where masaid=17 update masasip set masaid='0' where masaid=17 update masalar set durum ='0' where ID=17";

                        (this.Owner as Masalar).ims17.Source = new BitmapImage(new Uri("Images/smasa.png", UriKind.Relative));
                        (this.Owner as Masalar).tms17.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#EFC517"));
                        break;
                    case " Masa18":
                        sqlCommand.CommandText = "update masasip set ödemetur='" + cm_ödemeturu.SelectedValue + "' where masaid=18 update masasip set masaid='0' where masaid=18 update masalar set durum ='0' where ID=18";

                        (this.Owner as Masalar).ims18.Source = new BitmapImage(new Uri("Images/smasa.png", UriKind.Relative));
                        (this.Owner as Masalar).tms18.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#EFC517"));
                        break;
                    case " Masa19":
                        sqlCommand.CommandText = "update masasip set ödemetur='" + cm_ödemeturu.SelectedValue + "' where masaid=19 update masasip set masaid='0' where masaid=19 update masalar set durum ='0' where ID=19";

                        (this.Owner as Masalar).ims19.Source = new BitmapImage(new Uri("Images/smasa.png", UriKind.Relative));
                        (this.Owner as Masalar).tms19.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#EFC517"));
                        break;
                    case " Masa20":
                        sqlCommand.CommandText = "update masasip set ödemetur='" + cm_ödemeturu.SelectedValue + "' where masaid=20 update masasip set masaid='0' where masaid=20 update masalar set durum ='0' where ID=20";

                        (this.Owner as Masalar).ims20.Source = new BitmapImage(new Uri("Images/smasa.png", UriKind.Relative));
                        (this.Owner as Masalar).tms20.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#EFC517"));
                        break;
                    case " Masa21":
                        sqlCommand.CommandText = "update masasip set ödemetur='" + cm_ödemeturu.SelectedValue + "' where masaid=21 update masasip set masaid='0' where masaid=21 update masalar set durum ='0' where ID=21";

                        (this.Owner as Masalar).ims21.Source = new BitmapImage(new Uri("Images/smasa.png", UriKind.Relative));
                        (this.Owner as Masalar).tms21.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#EFC517"));
                        break;

                }
                sqlCommand.Connection = sqlConnection;
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();


                Close();
            }
            else
            {
                MessageBox.Show("Yetkiniz Yok");
            }
           


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cm_ödemeturu.Items.Add("Nakit");
            cm_ödemeturu.Items.Add("Kredi Kartı");
            cm_ödemeturu.Items.Add("Yemek Kartı");

            txtmasaisim.Text = Masalar._masaisim;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = _connect.connect;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            
            switch (txtmasaisim.Text)
                {
                    case " Masa1":
                    if (1==1)
                    {
                        sqlCommand.CommandText = "Select durum from masalar where ID =1 ";
                        SqlDataReader dataReaderr = sqlCommand.ExecuteReader();
                        while (dataReaderr.Read())
                        {
                            urun.durum = Convert.ToInt32(dataReaderr["durum"]);
                        }
                        dataReaderr.Close();

                    }
                    if (urun.durum == 1)
                       {
                        sqlCommand.CommandText = "Select urun,fiyat from masasip where masaid =1 select sum(fiyat) from masasip where masaid=1";
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            urun.urunadi = Convert.ToString(dataReader["urun"]);
                            urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                            lbl1.Content = urun.urunadi;
                            lbUrun.Items.Add(urun.urunadi);
                            lbl2.Content = urun.fiyat;
                            lbFiyat.Items.Add(urun.fiyat);
                            datagrid.Items.Add(new { urunadi = lbl1.Content, fiyat = lbl2.Content + " TL" });
                        }

                    dataReader.Close();

                    SqlDataAdapter da = new SqlDataAdapter("Select fiyat from masasip where masaid =1 ", sqlConnection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    tutar =Convert.ToInt32(dt.Compute("sum(fiyat)", ""));
                        lbl3.Content = tutar;
                       }
                    
                    break;
            
                case " Masa2":
                    if (1==1)
                    {
                        sqlCommand.CommandText = "Select durum from masalar where ID =2 ";
                        SqlDataReader dataReaderr = sqlCommand.ExecuteReader();
                        while (dataReaderr.Read())
                        {
                            urun.durum = Convert.ToInt32(dataReaderr["durum"]);
                        }
                        dataReaderr.Close(); 
                    }

                    if (urun.durum == 1)
                    {
                        sqlCommand.CommandText = "Select urun,fiyat from masasip where masaid =2 ";
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            urun.urunadi = Convert.ToString(dataReader["urun"]);
                            urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                            lbl1.Content = urun.urunadi;
                            lbUrun.Items.Add(urun.urunadi);
                            lbl2.Content = urun.fiyat;
                            lbFiyat.Items.Add(urun.fiyat);
                            datagrid.Items.Add(new { urunadi = lbl1.Content, fiyat = lbl2.Content + " TL" });
                        }

                        dataReader.Close();
                        SqlDataAdapter da = new SqlDataAdapter("Select fiyat from masasip where masaid =2 ", sqlConnection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        tutar = Convert.ToInt32(dt.Compute("sum(fiyat)", ""));
                        lbl3.Content = tutar;
                    }

                    break;
                case " Masa3":
                    if (1 == 1)
                    {
                        sqlCommand.CommandText = "Select durum from masalar where ID =3 ";
                        SqlDataReader dataReaderr = sqlCommand.ExecuteReader();
                        while (dataReaderr.Read())
                        {
                            urun.durum = Convert.ToInt32(dataReaderr["durum"]);
                        }
                        dataReaderr.Close();
                    }

                    if (urun.durum == 1)
                    {
                        sqlCommand.CommandText = "Select urun,fiyat from masasip where masaid =3 ";
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            urun.urunadi = Convert.ToString(dataReader["urun"]);
                            urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                            lbl1.Content = urun.urunadi;
                            lbUrun.Items.Add(urun.urunadi);
                            lbl2.Content = urun.fiyat;
                            lbFiyat.Items.Add(urun.fiyat);
                            datagrid.Items.Add(new { urunadi = lbl1.Content, fiyat = lbl2.Content + " TL" });
                        }

                        dataReader.Close();
                        SqlDataAdapter da = new SqlDataAdapter("Select fiyat from masasip where masaid =3 ", sqlConnection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        tutar = Convert.ToInt32(dt.Compute("sum(fiyat)", ""));
                        lbl3.Content = tutar;
                    }


                    break;
                case " Masa4":
                    if (1 == 1)
                    {
                        sqlCommand.CommandText = "Select durum from masalar where ID =4 ";
                        SqlDataReader dataReaderr = sqlCommand.ExecuteReader();
                        while (dataReaderr.Read())
                        {
                            urun.durum = Convert.ToInt32(dataReaderr["durum"]);
                        }
                        dataReaderr.Close();
                    }

                    if (urun.durum == 1)
                    {
                        sqlCommand.CommandText = "Select urun,fiyat from masasip where masaid =4 ";
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            urun.urunadi = Convert.ToString(dataReader["urun"]);
                            urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                            lbl1.Content = urun.urunadi;
                            lbUrun.Items.Add(urun.urunadi);
                            lbl2.Content = urun.fiyat;
                            lbFiyat.Items.Add(urun.fiyat);
                            datagrid.Items.Add(new { urunadi = lbl1.Content, fiyat = lbl2.Content + " TL" });
                        }

                        dataReader.Close();
                        SqlDataAdapter da = new SqlDataAdapter("Select fiyat from masasip where masaid =4 ", sqlConnection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        tutar = Convert.ToInt32(dt.Compute("sum(fiyat)", ""));
                        lbl3.Content = tutar;
                    }


                    break;
                case " Masa5":
                    if (1 == 1)
                    {
                        sqlCommand.CommandText = "Select durum from masalar where ID =5 ";
                        SqlDataReader dataReaderr = sqlCommand.ExecuteReader();
                        while (dataReaderr.Read())
                        {
                            urun.durum = Convert.ToInt32(dataReaderr["durum"]);
                        }
                        dataReaderr.Close();
                    }

                    if (urun.durum == 1)
                    {
                        sqlCommand.CommandText = "Select urun,fiyat from masasip where masaid =5 ";
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            urun.urunadi = Convert.ToString(dataReader["urun"]);
                            urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                            lbl1.Content = urun.urunadi;
                            lbUrun.Items.Add(urun.urunadi);
                            lbl2.Content = urun.fiyat;
                            lbFiyat.Items.Add(urun.fiyat);
                            datagrid.Items.Add(new { urunadi = lbl1.Content, fiyat = lbl2.Content + " TL" });
                        }

                        dataReader.Close();
                        SqlDataAdapter da = new SqlDataAdapter("Select fiyat from masasip where masaid =5 ", sqlConnection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        tutar = Convert.ToInt32(dt.Compute("sum(fiyat)", ""));
                        lbl3.Content = tutar;
                    }


                    break;
                case " Masa6":
                    if (1 == 1)
                    {
                        sqlCommand.CommandText = "Select durum from masalar where ID =6 ";
                        SqlDataReader dataReaderr = sqlCommand.ExecuteReader();
                        while (dataReaderr.Read())
                        {
                            urun.durum = Convert.ToInt32(dataReaderr["durum"]);
                        }
                        dataReaderr.Close();
                    }

                    if (urun.durum == 1)
                    {
                        sqlCommand.CommandText = "Select urun,fiyat from masasip where masaid =6 ";
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            urun.urunadi = Convert.ToString(dataReader["urun"]);
                            urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                            lbl1.Content = urun.urunadi;
                            lbUrun.Items.Add(urun.urunadi);
                            lbl2.Content = urun.fiyat;
                            lbFiyat.Items.Add(urun.fiyat);
                            datagrid.Items.Add(new { urunadi = lbl1.Content, fiyat = lbl2.Content + " TL" });
                        }

                        dataReader.Close();
                        SqlDataAdapter da = new SqlDataAdapter("Select fiyat from masasip where masaid =6 ", sqlConnection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        tutar = Convert.ToInt32(dt.Compute("sum(fiyat)", ""));
                        lbl3.Content = tutar;
                    }


                    break;
                case " Masa7":
                    if (1 == 1)
                    {
                        sqlCommand.CommandText = "Select durum from masalar where ID =7 ";
                        SqlDataReader dataReaderr = sqlCommand.ExecuteReader();
                        while (dataReaderr.Read())
                        {
                            urun.durum = Convert.ToInt32(dataReaderr["durum"]);
                        }
                        dataReaderr.Close();
                    }

                    if (urun.durum == 1)
                    {
                        sqlCommand.CommandText = "Select urun,fiyat from masasip where masaid =7 ";
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            urun.urunadi = Convert.ToString(dataReader["urun"]);
                            urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                            lbl1.Content = urun.urunadi;
                            lbUrun.Items.Add(urun.urunadi);
                            lbl2.Content = urun.fiyat;
                            lbFiyat.Items.Add(urun.fiyat);
                            datagrid.Items.Add(new { urunadi = lbl1.Content, fiyat = lbl2.Content + " TL" });
                        }

                        dataReader.Close();
                        SqlDataAdapter da = new SqlDataAdapter("Select fiyat from masasip where masaid =7 ", sqlConnection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        tutar = Convert.ToInt32(dt.Compute("sum(fiyat)", ""));
                        lbl3.Content = tutar;
                    }


                    break;
                case " Masa8":
                    if (1 == 1)
                    {
                        sqlCommand.CommandText = "Select durum from masalar where ID =8 ";
                        SqlDataReader dataReaderr = sqlCommand.ExecuteReader();
                        while (dataReaderr.Read())
                        {
                            urun.durum = Convert.ToInt32(dataReaderr["durum"]);
                        }
                        dataReaderr.Close();
                    }

                    if (urun.durum == 1)
                    {
                        sqlCommand.CommandText = "Select urun,fiyat from masasip where masaid =8 ";
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            urun.urunadi = Convert.ToString(dataReader["urun"]);
                            urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                            lbl1.Content = urun.urunadi;
                            lbUrun.Items.Add(urun.urunadi);
                            lbl2.Content = urun.fiyat;
                            lbFiyat.Items.Add(urun.fiyat);
                            datagrid.Items.Add(new { urunadi = lbl1.Content, fiyat = lbl2.Content + " TL" });
                        }

                        dataReader.Close();
                        SqlDataAdapter da = new SqlDataAdapter("Select fiyat from masasip where masaid =8 ", sqlConnection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        tutar = Convert.ToInt32(dt.Compute("sum(fiyat)", ""));
                        lbl3.Content = tutar;
                    }


                    break;
                case " Masa9":
                    if (1 == 1)
                    {
                        sqlCommand.CommandText = "Select durum from masalar where ID =9 ";
                        SqlDataReader dataReaderr = sqlCommand.ExecuteReader();
                        while (dataReaderr.Read())
                        {
                            urun.durum = Convert.ToInt32(dataReaderr["durum"]);
                        }
                        dataReaderr.Close();
                    }

                    if (urun.durum == 1)
                    {
                        sqlCommand.CommandText = "Select urun,fiyat from masasip where masaid =9 ";
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            urun.urunadi = Convert.ToString(dataReader["urun"]);
                            urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                            lbl1.Content = urun.urunadi;
                            lbUrun.Items.Add(urun.urunadi);
                            lbl2.Content = urun.fiyat;
                            lbFiyat.Items.Add(urun.fiyat);
                            datagrid.Items.Add(new { urunadi = lbl1.Content, fiyat = lbl2.Content + " TL" });
                        }

                        dataReader.Close();
                        SqlDataAdapter da = new SqlDataAdapter("Select fiyat from masasip where masaid =9 ", sqlConnection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        tutar = Convert.ToInt32(dt.Compute("sum(fiyat)", ""));
                        lbl3.Content = tutar;
                    }


                    break;
                case " Masa10":
                    if (1 == 1)
                    {
                        sqlCommand.CommandText = "Select durum from masalar where ID =10 ";
                        SqlDataReader dataReaderr = sqlCommand.ExecuteReader();
                        while (dataReaderr.Read())
                        {
                            urun.durum = Convert.ToInt32(dataReaderr["durum"]);
                        }
                        dataReaderr.Close();
                    }

                    if (urun.durum == 1)
                    {
                        sqlCommand.CommandText = "Select urun,fiyat from masasip where masaid =10 ";
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            urun.urunadi = Convert.ToString(dataReader["urun"]);
                            urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                            lbl1.Content = urun.urunadi;
                            lbUrun.Items.Add(urun.urunadi);
                            lbl2.Content = urun.fiyat;
                            lbFiyat.Items.Add(urun.fiyat);
                            datagrid.Items.Add(new { urunadi = lbl1.Content, fiyat = lbl2.Content + " TL" });
                        }

                        dataReader.Close();
                        SqlDataAdapter da = new SqlDataAdapter("Select fiyat from masasip where masaid =10 ", sqlConnection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        tutar = Convert.ToInt32(dt.Compute("sum(fiyat)", ""));
                        lbl3.Content = tutar;
                    }


                    break;
                case " Masa11":
                    if (1 == 1)
                    {
                        sqlCommand.CommandText = "Select durum from masalar where ID =11 ";
                        SqlDataReader dataReaderr = sqlCommand.ExecuteReader();
                        while (dataReaderr.Read())
                        {
                            urun.durum = Convert.ToInt32(dataReaderr["durum"]);
                        }
                        dataReaderr.Close();
                    }

                    if (urun.durum == 1)
                    {
                        sqlCommand.CommandText = "Select urun,fiyat from masasip where masaid =11 ";
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            urun.urunadi = Convert.ToString(dataReader["urun"]);
                            urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                            lbl1.Content = urun.urunadi;
                            lbUrun.Items.Add(urun.urunadi);
                            lbl2.Content = urun.fiyat;
                            lbFiyat.Items.Add(urun.fiyat);
                            datagrid.Items.Add(new { urunadi = lbl1.Content, fiyat = lbl2.Content + " TL" });
                        }

                        dataReader.Close();
                        SqlDataAdapter da = new SqlDataAdapter("Select fiyat from masasip where masaid =11 ", sqlConnection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        tutar = Convert.ToInt32(dt.Compute("sum(fiyat)", ""));
                        lbl3.Content = tutar;
                    }

                    break;
                case " Masa12":
                    if (1 == 1)
                    {
                        sqlCommand.CommandText = "Select durum from masalar where ID =12 ";
                        SqlDataReader dataReaderr = sqlCommand.ExecuteReader();
                        while (dataReaderr.Read())
                        {
                            urun.durum = Convert.ToInt32(dataReaderr["durum"]);
                        }
                        dataReaderr.Close();
                    }

                    if (urun.durum == 1)
                    {
                        sqlCommand.CommandText = "Select urun,fiyat from masasip where masaid =12 ";
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            urun.urunadi = Convert.ToString(dataReader["urun"]);
                            urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                            lbl1.Content = urun.urunadi;
                            lbUrun.Items.Add(urun.urunadi);
                            lbl2.Content = urun.fiyat;
                            lbFiyat.Items.Add(urun.fiyat);
                            datagrid.Items.Add(new { urunadi = lbl1.Content, fiyat = lbl2.Content + " TL" });
                        }

                        dataReader.Close();
                        SqlDataAdapter da = new SqlDataAdapter("Select fiyat from masasip where masaid =12 ", sqlConnection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        tutar = Convert.ToInt32(dt.Compute("sum(fiyat)", ""));
                        lbl3.Content = tutar;
                    }

                    break;
                case " Masa13":
                    if (1 == 1)
                    {
                        sqlCommand.CommandText = "Select durum from masalar where ID =13 ";
                        SqlDataReader dataReaderr = sqlCommand.ExecuteReader();
                        while (dataReaderr.Read())
                        {
                            urun.durum = Convert.ToInt32(dataReaderr["durum"]);
                        }
                        dataReaderr.Close();
                    }

                    if (urun.durum == 1)
                    {
                        sqlCommand.CommandText = "Select urun,fiyat from masasip where masaid =13 ";
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            urun.urunadi = Convert.ToString(dataReader["urun"]);
                            urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                            lbl1.Content = urun.urunadi;
                            lbUrun.Items.Add(urun.urunadi);
                            lbl2.Content = urun.fiyat;
                            lbFiyat.Items.Add(urun.fiyat);
                            datagrid.Items.Add(new { urunadi = lbl1.Content, fiyat = lbl2.Content + " TL" });
                        }

                        dataReader.Close();
                        SqlDataAdapter da = new SqlDataAdapter("Select fiyat from masasip where masaid =13 ", sqlConnection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        tutar = Convert.ToInt32(dt.Compute("sum(fiyat)", ""));
                        lbl3.Content = tutar;
                    }

                    break;
                case " Masa14":
                    if (1 == 1)
                    {
                        sqlCommand.CommandText = "Select durum from masalar where ID =14 ";
                        SqlDataReader dataReaderr = sqlCommand.ExecuteReader();
                        while (dataReaderr.Read())
                        {
                            urun.durum = Convert.ToInt32(dataReaderr["durum"]);
                        }
                        dataReaderr.Close();
                    }

                    if (urun.durum == 1)
                    {
                        sqlCommand.CommandText = "Select urun,fiyat from masasip where masaid =14 ";
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            urun.urunadi = Convert.ToString(dataReader["urun"]);
                            urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                            lbl1.Content = urun.urunadi;
                            lbUrun.Items.Add(urun.urunadi);
                            lbl2.Content = urun.fiyat;
                            lbFiyat.Items.Add(urun.fiyat);
                            datagrid.Items.Add(new { urunadi = lbl1.Content, fiyat = lbl2.Content + " TL" });
                        }

                        dataReader.Close();
                        SqlDataAdapter da = new SqlDataAdapter("Select fiyat from masasip where masaid =14 ", sqlConnection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        tutar = Convert.ToInt32(dt.Compute("sum(fiyat)", ""));
                        lbl3.Content = tutar;
                    }

                    break;
                case " Masa15":
                    if (1 == 1)
                    {
                        sqlCommand.CommandText = "Select durum from masalar where ID =15 ";
                        SqlDataReader dataReaderr = sqlCommand.ExecuteReader();
                        while (dataReaderr.Read())
                        {
                            urun.durum = Convert.ToInt32(dataReaderr["durum"]);
                        }
                        dataReaderr.Close();
                    }

                    if (urun.durum == 1)
                    {
                        sqlCommand.CommandText = "Select urun,fiyat from masasip where masaid =15 ";
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            urun.urunadi = Convert.ToString(dataReader["urun"]);
                            urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                            lbl1.Content = urun.urunadi;
                            lbUrun.Items.Add(urun.urunadi);
                            lbl2.Content = urun.fiyat;
                            lbFiyat.Items.Add(urun.fiyat);
                            datagrid.Items.Add(new { urunadi = lbl1.Content, fiyat = lbl2.Content + " TL" });
                        }

                        dataReader.Close();
                        SqlDataAdapter da = new SqlDataAdapter("Select fiyat from masasip where masaid =15 ", sqlConnection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        tutar = Convert.ToInt32(dt.Compute("sum(fiyat)", ""));
                        lbl3.Content = tutar;
                    }

                    break;
                case " Masa16":
                    if (1 == 1)
                    {
                        sqlCommand.CommandText = "Select durum from masalar where ID =16 ";
                        SqlDataReader dataReaderr = sqlCommand.ExecuteReader();
                        while (dataReaderr.Read())
                        {
                            urun.durum = Convert.ToInt32(dataReaderr["durum"]);
                        }
                        dataReaderr.Close();
                    }

                    if (urun.durum == 1)
                    {
                        sqlCommand.CommandText = "Select urun,fiyat from masasip where masaid =16 ";
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            urun.urunadi = Convert.ToString(dataReader["urun"]);
                            urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                            lbl1.Content = urun.urunadi;
                            lbUrun.Items.Add(urun.urunadi);
                            lbl2.Content = urun.fiyat;
                            lbFiyat.Items.Add(urun.fiyat);
                            datagrid.Items.Add(new { urunadi = lbl1.Content, fiyat = lbl2.Content + " TL" });
                        }

                        dataReader.Close();
                        SqlDataAdapter da = new SqlDataAdapter("Select fiyat from masasip where masaid =16 ", sqlConnection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        tutar = Convert.ToInt32(dt.Compute("sum(fiyat)", ""));
                        lbl3.Content = tutar;
                    }
                    break;
                case " Masa17":
                    if (1 == 1)
                    {
                        sqlCommand.CommandText = "Select durum from masalar where ID =17 ";
                        SqlDataReader dataReaderr = sqlCommand.ExecuteReader();
                        while (dataReaderr.Read())
                        {
                            urun.durum = Convert.ToInt32(dataReaderr["durum"]);
                        }
                        dataReaderr.Close();
                    }

                    if (urun.durum == 1)
                    {
                        sqlCommand.CommandText = "Select urun,fiyat from masasip where masaid =17 ";
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            urun.urunadi = Convert.ToString(dataReader["urun"]);
                            urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                            lbl1.Content = urun.urunadi;
                            lbUrun.Items.Add(urun.urunadi);
                            lbl2.Content = urun.fiyat;
                            lbFiyat.Items.Add(urun.fiyat);
                            datagrid.Items.Add(new { urunadi = lbl1.Content, fiyat = lbl2.Content + " TL" });
                        }

                        dataReader.Close();
                        SqlDataAdapter da = new SqlDataAdapter("Select fiyat from masasip where masaid =17 ", sqlConnection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        tutar = Convert.ToInt32(dt.Compute("sum(fiyat)", ""));
                        lbl3.Content = tutar;
                    }

                    break;
                case " Masa18":
                    if (1 == 1)
                    {
                        sqlCommand.CommandText = "Select durum from masalar where ID =18 ";
                        SqlDataReader dataReaderr = sqlCommand.ExecuteReader();
                        while (dataReaderr.Read())
                        {
                            urun.durum = Convert.ToInt32(dataReaderr["durum"]);
                        }
                        dataReaderr.Close();
                    }

                    if (urun.durum == 1)
                    {
                        sqlCommand.CommandText = "Select urun,fiyat from masasip where masaid =18 ";
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            urun.urunadi = Convert.ToString(dataReader["urun"]);
                            urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                            lbl1.Content = urun.urunadi;
                            lbUrun.Items.Add(urun.urunadi);
                            lbl2.Content = urun.fiyat;
                            lbFiyat.Items.Add(urun.fiyat);
                            datagrid.Items.Add(new { urunadi = lbl1.Content, fiyat = lbl2.Content + " TL" });
                        }

                        dataReader.Close();
                        SqlDataAdapter da = new SqlDataAdapter("Select fiyat from masasip where masaid =18 ", sqlConnection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        tutar = Convert.ToInt32(dt.Compute("sum(fiyat)", ""));
                        lbl3.Content = tutar;
                    }

                    break;
                case " Masa19":
                    if (1 == 1)
                    {
                        sqlCommand.CommandText = "Select durum from masalar where ID =19 ";
                        SqlDataReader dataReaderr = sqlCommand.ExecuteReader();
                        while (dataReaderr.Read())
                        {
                            urun.durum = Convert.ToInt32(dataReaderr["durum"]);
                        }
                        dataReaderr.Close();
                    }

                    if (urun.durum == 1)
                    {
                        sqlCommand.CommandText = "Select urun,fiyat from masasip where masaid =19 ";
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            urun.urunadi = Convert.ToString(dataReader["urun"]);
                            urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                            lbl1.Content = urun.urunadi;
                            lbUrun.Items.Add(urun.urunadi);
                            lbl2.Content = urun.fiyat;
                            lbFiyat.Items.Add(urun.fiyat);
                            datagrid.Items.Add(new { urunadi = lbl1.Content, fiyat = lbl2.Content + " TL" });
                        }

                        dataReader.Close();
                        SqlDataAdapter da = new SqlDataAdapter("Select fiyat from masasip where masaid =19 ", sqlConnection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        tutar = Convert.ToInt32(dt.Compute("sum(fiyat)", ""));
                        lbl3.Content = tutar;
                    }

                    break;
                case " Masa20":
                    if (1 == 1)
                    {
                        sqlCommand.CommandText = "Select durum from masalar where ID =20 ";
                        SqlDataReader dataReaderr = sqlCommand.ExecuteReader();
                        while (dataReaderr.Read())
                        {
                            urun.durum = Convert.ToInt32(dataReaderr["durum"]);
                        }
                        dataReaderr.Close();
                    }

                    if (urun.durum == 1)
                    {
                        sqlCommand.CommandText = "Select urun,fiyat from masasip where masaid =20 ";
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            urun.urunadi = Convert.ToString(dataReader["urun"]);
                            urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                            lbl1.Content = urun.urunadi;
                            lbUrun.Items.Add(urun.urunadi);
                            lbl2.Content = urun.fiyat;
                            lbFiyat.Items.Add(urun.fiyat);
                            datagrid.Items.Add(new { urunadi = lbl1.Content, fiyat = lbl2.Content + " TL" });
                        }

                        dataReader.Close();
                        SqlDataAdapter da = new SqlDataAdapter("Select fiyat from masasip where masaid =20 ", sqlConnection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        tutar = Convert.ToInt32(dt.Compute("sum(fiyat)", ""));
                        lbl3.Content = tutar;
                    }

                    break;
                case " Masa21":
                    if (1 == 1)
                    {
                        sqlCommand.CommandText = "Select durum from masalar where ID =21 ";
                        SqlDataReader dataReaderr = sqlCommand.ExecuteReader();
                        while (dataReaderr.Read())
                        {
                            urun.durum = Convert.ToInt32(dataReaderr["durum"]);
                        }
                        dataReaderr.Close();
                    }

                    if (urun.durum == 1)
                    {
                        sqlCommand.CommandText = "Select urun,fiyat from masasip where masaid =21 ";
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();
                        while (dataReader.Read())
                        {
                            urun.urunadi = Convert.ToString(dataReader["urun"]);
                            urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                            lbl1.Content = urun.urunadi;
                            lbUrun.Items.Add(urun.urunadi);
                            lbl2.Content = urun.fiyat;
                            lbFiyat.Items.Add(urun.fiyat);
                            datagrid.Items.Add(new { urunadi = lbl1.Content, fiyat = lbl2.Content + " TL" });
                        }

                        dataReader.Close();
                        SqlDataAdapter da = new SqlDataAdapter("Select fiyat from masasip where masaid =21 ", sqlConnection);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        tutar = Convert.ToInt32(dt.Compute("sum(fiyat)", ""));
                        lbl3.Content = tutar;
                    }

                    break;
                }
            
            sqlConnection.Close();

            lbUrun.Items.Clear();
            lbFiyat.Items.Clear();

            urun.ürüngetirlbb1(ListBoxürün);

            if (ListBoxürün.Items.Count == 8)
            {
                txtblck1.Text = ListBoxürün.Items[0].ToString();
                txtblck2.Text = ListBoxürün.Items[1].ToString();
                txtblck3.Text = ListBoxürün.Items[2].ToString();
                txtblck4.Text = ListBoxürün.Items[3].ToString();
                txtblck5.Text = ListBoxürün.Items[4].ToString();
                txtblck6.Text = ListBoxürün.Items[5].ToString();
                txtblck7.Text = ListBoxürün.Items[6].ToString();
                txtblck8.Text = ListBoxürün.Items[7].ToString();
            }
            else if (ListBoxürün.Items.Count == 7)
            {
                txtblck1.Text = ListBoxürün.Items[0].ToString();
                txtblck2.Text = ListBoxürün.Items[1].ToString();
                txtblck3.Text = ListBoxürün.Items[2].ToString();
                txtblck4.Text = ListBoxürün.Items[3].ToString();
                txtblck5.Text = ListBoxürün.Items[4].ToString();
                txtblck6.Text = ListBoxürün.Items[5].ToString();
                txtblck7.Text = ListBoxürün.Items[6].ToString();
                txtblck8.Text = "Urun";
            }
        }
        //public override string ToString()
        //{
        //    return ListBoxürün.SelectedItems.ToString();
        //}

        private void Btnsckicecek_OnClick(object sender, RoutedEventArgs e)
        {
            urun.ürüngetirlbb2(ListBoxürün);

            if (ListBoxürün.Items.Count == 8)
            {
                txtblck1.Text = ListBoxürün.Items[0].ToString();
                txtblck2.Text = ListBoxürün.Items[1].ToString();
                txtblck3.Text = ListBoxürün.Items[2].ToString();
                txtblck4.Text = ListBoxürün.Items[3].ToString();
                txtblck5.Text = ListBoxürün.Items[4].ToString();
                txtblck6.Text = ListBoxürün.Items[5].ToString();
                txtblck7.Text = ListBoxürün.Items[6].ToString();
                txtblck8.Text = ListBoxürün.Items[7].ToString();
            }
            else if (ListBoxürün.Items.Count == 7)
            {
                txtblck1.Text = ListBoxürün.Items[0].ToString();
                txtblck2.Text = ListBoxürün.Items[1].ToString();
                txtblck3.Text = ListBoxürün.Items[2].ToString();
                txtblck4.Text = ListBoxürün.Items[3].ToString();
                txtblck5.Text = ListBoxürün.Items[4].ToString();
                txtblck6.Text = ListBoxürün.Items[5].ToString();
                txtblck7.Text = ListBoxürün.Items[6].ToString();
                txtblck8.Text = "Urun";
            }
            else
            {
                MessageBox.Show("Eksik Ürün! Lütfen Yeni Ürün Ekleyin");
            }
        }

        private void Btnyiyecek_OnClick(object sender, RoutedEventArgs e)
        {
            urun.ürüngetirlbb3(ListBoxürün);

            if (ListBoxürün.Items.Count == 8)
            {
                txtblck1.Text = ListBoxürün.Items[0].ToString();
                txtblck2.Text = ListBoxürün.Items[1].ToString();
                txtblck3.Text = ListBoxürün.Items[2].ToString();
                txtblck4.Text = ListBoxürün.Items[3].ToString();
                txtblck5.Text = ListBoxürün.Items[4].ToString();
                txtblck6.Text = ListBoxürün.Items[5].ToString();
                txtblck7.Text = ListBoxürün.Items[6].ToString();
                txtblck8.Text = ListBoxürün.Items[7].ToString();
            }
            else if (ListBoxürün.Items.Count == 7)
            {
                txtblck1.Text = ListBoxürün.Items[0].ToString();
                txtblck2.Text = ListBoxürün.Items[1].ToString();
                txtblck3.Text = ListBoxürün.Items[2].ToString();
                txtblck4.Text = ListBoxürün.Items[3].ToString();
                txtblck5.Text = ListBoxürün.Items[4].ToString();
                txtblck6.Text = ListBoxürün.Items[5].ToString();
                txtblck7.Text = ListBoxürün.Items[6].ToString();
                txtblck8.Text = "Urun";
            }
            else
            {
                MessageBox.Show("Eksik Ürün! Lütfen Yeni Ürün Ekleyin");
            }
        }

        private void Btntatli_OnClick(object sender, RoutedEventArgs e)
        {
            urun.ürüngetirlbb4(ListBoxürün);

            if (ListBoxürün.Items.Count == 8)
            {
                txtblck1.Text = ListBoxürün.Items[0].ToString();
                txtblck2.Text = ListBoxürün.Items[1].ToString();
                txtblck3.Text = ListBoxürün.Items[2].ToString();
                txtblck4.Text = ListBoxürün.Items[3].ToString();
                txtblck5.Text = ListBoxürün.Items[4].ToString();
                txtblck6.Text = ListBoxürün.Items[5].ToString();
                txtblck7.Text = ListBoxürün.Items[6].ToString();
                txtblck8.Text = ListBoxürün.Items[7].ToString();
            }
            else if (ListBoxürün.Items.Count == 7)
            {
                txtblck1.Text = ListBoxürün.Items[0].ToString();
                txtblck2.Text = ListBoxürün.Items[1].ToString();
                txtblck3.Text = ListBoxürün.Items[2].ToString();
                txtblck4.Text = ListBoxürün.Items[3].ToString();
                txtblck5.Text = ListBoxürün.Items[4].ToString();
                txtblck6.Text = ListBoxürün.Items[5].ToString();
                txtblck7.Text = ListBoxürün.Items[6].ToString();
                txtblck8.Text = "Urun";
            }
            else
            {
                MessageBox.Show("Eksik Ürün! Lütfen Yeni Ürün Ekleyin");
            }
        }

        private void Btnaperatif_OnClick(object sender, RoutedEventArgs e)
        {
            urun.ürüngetirlbb5(ListBoxürün);

            if (ListBoxürün.Items.Count == 8)
            {
                txtblck1.Text = ListBoxürün.Items[0].ToString();
                txtblck2.Text = ListBoxürün.Items[1].ToString();
                txtblck3.Text = ListBoxürün.Items[2].ToString();
                txtblck4.Text = ListBoxürün.Items[3].ToString();
                txtblck5.Text = ListBoxürün.Items[4].ToString();
                txtblck6.Text = ListBoxürün.Items[5].ToString();
                txtblck7.Text = ListBoxürün.Items[6].ToString();
                txtblck8.Text = ListBoxürün.Items[7].ToString();
            }
            else if (ListBoxürün.Items.Count == 7)
            {
                txtblck1.Text = ListBoxürün.Items[0].ToString();
                txtblck2.Text = ListBoxürün.Items[1].ToString();
                txtblck3.Text = ListBoxürün.Items[2].ToString();
                txtblck4.Text = ListBoxürün.Items[3].ToString();
                txtblck5.Text = ListBoxürün.Items[4].ToString();
                txtblck6.Text = ListBoxürün.Items[5].ToString();
                txtblck7.Text = ListBoxürün.Items[6].ToString();
                txtblck8.Text = "Urun";
            }
            else
            {
                MessageBox.Show("Eksik Ürün! Lütfen Yeni Ürün Ekleyin");
            }
        }

        private void Btnekstra_OnClick(object sender, RoutedEventArgs e)
        {
            urun.ürüngetirlbb6(ListBoxürün);

            if (ListBoxürün.Items.Count >= 8)
            {
                txtblck1.Text = ListBoxürün.Items[0].ToString();
                txtblck2.Text = ListBoxürün.Items[1].ToString();
                txtblck3.Text = ListBoxürün.Items[2].ToString();
                txtblck4.Text = ListBoxürün.Items[3].ToString();
                txtblck5.Text = ListBoxürün.Items[4].ToString();
                txtblck6.Text = ListBoxürün.Items[5].ToString();
                txtblck7.Text = ListBoxürün.Items[6].ToString();
                txtblck8.Text = ListBoxürün.Items[7].ToString();
            }
            else if (ListBoxürün.Items.Count == 7)
            {
                txtblck1.Text = ListBoxürün.Items[0].ToString();
                txtblck2.Text = ListBoxürün.Items[1].ToString();
                txtblck3.Text = ListBoxürün.Items[2].ToString();
                txtblck4.Text = ListBoxürün.Items[3].ToString();
                txtblck5.Text = ListBoxürün.Items[4].ToString();
                txtblck6.Text = ListBoxürün.Items[5].ToString();
                txtblck7.Text = ListBoxürün.Items[6].ToString();
                txtblck8.Text = "Urun";
            }
            else
            {
                MessageBox.Show("Eksik Ürün! Lütfen Yeni Ürün Ekleyin");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var sqlConnection = new SqlConnection(_connect.connect);
            var sqlCommand = new SqlCommand("Select * from ürünler where urunadi = '" + txtblck1.Text + "'",
                sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
            var dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                var urun = new Urun();
                urun.kategoriid = Convert.ToInt32(dataReader["kategoriid"]);
                urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                urun.urunadi = Convert.ToString(dataReader["urunadi"]);
                urun.Urunid = Convert.ToInt32(dataReader["ID"]);
                lbl1.Content = urun.urunadi;
                lbUrun.Items.Add(urun.urunadi);
                lbl2.Content = urun.fiyat;
                lbFiyat.Items.Add(urun.fiyat);
                datagrid.Items.Add(new {urunadi = lbl1.Content, fiyat = lbl2.Content + " TL"});
            }

            dataReader.Close();
            sqlConnection.Close();
            tutar = tutar + Convert.ToInt32(lbl2.Content);
            lbl3.Content = tutar + " TL";

            //SqlConnection sqlConnection = new SqlConnection(_connect.connect);
            //SqlCommand sqlCommand = new SqlCommand("Select urunadi as Ürün,fiyat as Fiyat from ürünler where urunadi = '" + txtblck1.Text + "'", sqlConnection);

            //if (sqlConnection.State == ConnectionState.Closed)
            //{
            //    sqlConnection.Open();
            //}
            //SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);

            //dataGrid.DataContext = (dt.DefaultView);

            //sqlConnection.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var sqlConnection = new SqlConnection(_connect.connect);
            var sqlCommand = new SqlCommand("Select * from ürünler where urunadi = '" + txtblck2.Text + "'",
                sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
            var dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                var urun = new Urun();
                urun.kategoriid = Convert.ToInt32(dataReader["kategoriid"]);
                urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                urun.urunadi = Convert.ToString(dataReader["urunadi"]);
                urun.Urunid = Convert.ToInt32(dataReader["ID"]);
                lbl1.Content = urun.urunadi;
                lbUrun.Items.Add(urun.urunadi);
                lbl2.Content = urun.fiyat;
                lbFiyat.Items.Add(urun.fiyat);
                datagrid.Items.Add(new {urunadi = lbl1.Content, fiyat = lbl2.Content + " TL"});
            }

            dataReader.Close();
            sqlConnection.Close();
            tutar = tutar + Convert.ToInt32(lbl2.Content);
            lbl3.Content = tutar + " TL";
            //SqlConnection sqlConnection = new SqlConnection(_connect.connect);
            //SqlCommand sqlCommand = new SqlCommand("Select urunadi as Ürün,fiyat as Fiyat from ürünler where urunadi = '" + txtblck2.Text + "'", sqlConnection);

            //if (sqlConnection.State == ConnectionState.Closed)
            //{
            //    sqlConnection.Open();
            //}
            //SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);

            //dataGrid.Items.Add(dt.DefaultView);

            //sqlConnection.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var sqlConnection = new SqlConnection(_connect.connect);
            var sqlCommand = new SqlCommand("Select * from ürünler where urunadi = '" + txtblck3.Text + "'",
                sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
            var dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                var urun = new Urun();
                urun.kategoriid = Convert.ToInt32(dataReader["kategoriid"]);
                urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                urun.urunadi = Convert.ToString(dataReader["urunadi"]);
                urun.Urunid = Convert.ToInt32(dataReader["ID"]);
                lbl1.Content = urun.urunadi;
                lbUrun.Items.Add(urun.urunadi);
                lbl2.Content = urun.fiyat;
                lbFiyat.Items.Add(urun.fiyat);
                datagrid.Items.Add(new {urunadi = lbl1.Content, fiyat = lbl2.Content + " TL"});
            }

            dataReader.Close();
            sqlConnection.Close();
            tutar = tutar + Convert.ToInt32(lbl2.Content);
            lbl3.Content = tutar + " TL";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var sqlConnection = new SqlConnection(_connect.connect);
            var sqlCommand = new SqlCommand("Select * from ürünler where urunadi = '" + txtblck4.Text + "'",
                sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
            var dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                var urun = new Urun();
                urun.kategoriid = Convert.ToInt32(dataReader["kategoriid"]);
                urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                urun.urunadi = Convert.ToString(dataReader["urunadi"]);
                urun.Urunid = Convert.ToInt32(dataReader["ID"]);
                lbl1.Content = urun.urunadi;
                lbUrun.Items.Add(urun.urunadi);
                lbl2.Content = urun.fiyat;
                lbFiyat.Items.Add(urun.fiyat);
                datagrid.Items.Add(new {urunadi = lbl1.Content, fiyat = lbl2.Content + " TL"});
            }

            dataReader.Close();
            sqlConnection.Close();
            tutar = tutar + Convert.ToInt32(lbl2.Content);
            lbl3.Content = tutar + " TL";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var sqlConnection = new SqlConnection(_connect.connect);
            var sqlCommand = new SqlCommand("Select * from ürünler where urunadi = '" + txtblck5.Text + "'",
                sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
            var dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                var urun = new Urun();
                urun.kategoriid = Convert.ToInt32(dataReader["kategoriid"]);
                urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                urun.urunadi = Convert.ToString(dataReader["urunadi"]);
                urun.Urunid = Convert.ToInt32(dataReader["ID"]);
                lbl1.Content = urun.urunadi;
                lbUrun.Items.Add(urun.urunadi);
                lbl2.Content = urun.fiyat;
                lbFiyat.Items.Add(urun.fiyat);
                datagrid.Items.Add(new {urunadi = lbl1.Content, fiyat = lbl2.Content + " TL"});
            }

            dataReader.Close();
            sqlConnection.Close();
            tutar = tutar + Convert.ToInt32(lbl2.Content);
            lbl3.Content = tutar + " TL";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            var sqlConnection = new SqlConnection(_connect.connect);
            var sqlCommand = new SqlCommand("Select * from ürünler where urunadi = '" + txtblck6.Text + "'",
                sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
            var dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                var urun = new Urun();
                urun.kategoriid = Convert.ToInt32(dataReader["kategoriid"]);
                urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                urun.urunadi = Convert.ToString(dataReader["urunadi"]);
                urun.Urunid = Convert.ToInt32(dataReader["ID"]);
                lbl1.Content = urun.urunadi;
                lbUrun.Items.Add(urun.urunadi);
                lbl2.Content = urun.fiyat;
                lbFiyat.Items.Add(urun.fiyat);
                datagrid.Items.Add(new {urunadi = lbl1.Content, fiyat = lbl2.Content + " TL"});
            }

            dataReader.Close();
            sqlConnection.Close();
            tutar = tutar + Convert.ToInt32(lbl2.Content);
            lbl3.Content = tutar + " TL";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            var sqlConnection = new SqlConnection(_connect.connect);
            var sqlCommand = new SqlCommand("Select * from ürünler where urunadi = '" + txtblck7.Text + "'",
                
            sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
            var dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                var urun = new Urun();
                urun.kategoriid = Convert.ToInt32(dataReader["kategoriid"]);
                urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                urun.urunadi = Convert.ToString(dataReader["urunadi"]);
                urun.Urunid = Convert.ToInt32(dataReader["ID"]);
                lbl1.Content = urun.urunadi;
                lbUrun.Items.Add(urun.urunadi);
                lbl2.Content = urun.fiyat;
                lbFiyat.Items.Add(urun.fiyat);
                datagrid.Items.Add(new {urunadi = lbl1.Content, fiyat = lbl2.Content + " TL"});
            }

            dataReader.Close();
            sqlConnection.Close();
            tutar = tutar + Convert.ToInt32(lbl2.Content);
            lbl3.Content = tutar + " TL";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            var sqlConnection = new SqlConnection(_connect.connect);
            var sqlCommand = new SqlCommand("Select * from ürünler where urunadi = '" + txtblck8.Text + "'",
                sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
            var dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                var urun = new Urun();
                urun.kategoriid = Convert.ToInt32(dataReader["kategoriid"]);
                urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                urun.urunadi = Convert.ToString(dataReader["urunadi"]);
                urun.Urunid = Convert.ToInt32(dataReader["ID"]);
                lbl1.Content = urun.urunadi;
                lbUrun.Items.Add(urun.urunadi);
                lbl2.Content = urun.fiyat;
                lbFiyat.Items.Add(urun.fiyat);
                datagrid.Items.Add(new {urunadi = lbl1.Content, fiyat = lbl2.Content + " TL"});
            }

            dataReader.Close();
            sqlConnection.Close();
            if (txtblck8.Text == "Urun") lbl2.Content = 0;
            tutar = tutar + Convert.ToInt32(lbl2.Content);
            lbl3.Content = tutar + " TL";
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            tutar = 0;
            Close();
        }
        //sipariş butonu
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            tutar = 0;
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = _connect.connect;
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            switch (txtmasaisim.Text)
                {
                        


                case " Masa1":
                    
                    for (int i = 0; i < lbUrun.Items.Count; i++)
                   {
                        
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Parameters.Clear();
                        sqlCommand.CommandText = "insert into masasip (urun,fiyat,masaid) values (@urun,@fiyat,@masaid)";
                        sqlCommand.Parameters.AddWithValue("@urun", lbUrun.Items[i]);
                        sqlCommand.Parameters.AddWithValue("@fiyat", Convert.ToInt32(lbFiyat.Items[i]));
                        sqlCommand.Parameters.AddWithValue("@masaid", 1);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.CommandText = "update masalar set durum ='1' where ID=1 ";
                    (this.Owner as Masalar).ims1.Source = new BitmapImage(new Uri("Images/Kmasasonsonpng.png", UriKind.Relative));
                    (this.Owner as Masalar).tms1.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#E46860"));
                    break;
                case " Masa2":
                    for (int i = 0; i < lbUrun.Items.Count; i++)
                    {

                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Parameters.Clear();
                        sqlCommand.CommandText = "insert into masasip (urun,fiyat,masaid) values (@urun,@fiyat,@masaid)";
                        sqlCommand.Parameters.AddWithValue("@urun", lbUrun.Items[i]);
                        sqlCommand.Parameters.AddWithValue("@fiyat", Convert.ToInt32(lbFiyat.Items[i]));
                        sqlCommand.Parameters.AddWithValue("@masaid", 2);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.CommandText = "update masalar set durum ='1' where ID=2 ";
                    (this.Owner as Masalar).ims2.Source = new BitmapImage(new Uri("Images/Kmasasonsonpng.png", UriKind.Relative));
                    (this.Owner as Masalar).tms2.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#E46860"));

                    break;
                case " Masa3":
                    for (int i = 0; i < lbUrun.Items.Count; i++)
                    {

                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Parameters.Clear();
                        sqlCommand.CommandText = "insert into masasip (urun,fiyat,masaid) values (@urun,@fiyat,@masaid)";
                        sqlCommand.Parameters.AddWithValue("@urun", lbUrun.Items[i]);
                        sqlCommand.Parameters.AddWithValue("@fiyat", Convert.ToInt32(lbFiyat.Items[i]));
                        sqlCommand.Parameters.AddWithValue("@masaid", 3);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.CommandText = "update masalar set durum ='1' where ID=3 ";
                    (this.Owner as Masalar).ims3.Source = new BitmapImage(new Uri("Images/Kmasasonsonpng.png", UriKind.Relative));
                    (this.Owner as Masalar).tms3.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#E46860"));
                    break;
                case " Masa4":
                    for (int i = 0; i < lbUrun.Items.Count; i++)
                    {

                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Parameters.Clear();
                        sqlCommand.CommandText = "insert into masasip (urun,fiyat,masaid) values (@urun,@fiyat,@masaid)";
                        sqlCommand.Parameters.AddWithValue("@urun", lbUrun.Items[i]);
                        sqlCommand.Parameters.AddWithValue("@fiyat", Convert.ToInt32(lbFiyat.Items[i]));
                        sqlCommand.Parameters.AddWithValue("@masaid", 4);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.CommandText = "update masalar set durum ='1' where ID=4 ";
                    (this.Owner as Masalar).ims4.Source = new BitmapImage(new Uri("Images/Kmasasonsonpng.png", UriKind.Relative));
                    (this.Owner as Masalar).tms4.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#E46860"));
                    break;
                case " Masa5":
                    for (int i = 0; i < lbUrun.Items.Count; i++)
                    {

                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Parameters.Clear();
                        sqlCommand.CommandText = "insert into masasip (urun,fiyat,masaid) values (@urun,@fiyat,@masaid)";
                        sqlCommand.Parameters.AddWithValue("@urun", lbUrun.Items[i]);
                        sqlCommand.Parameters.AddWithValue("@fiyat", Convert.ToInt32(lbFiyat.Items[i]));
                        sqlCommand.Parameters.AddWithValue("@masaid", 5);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.CommandText = "update masalar set durum ='1' where ID=5 ";
                    (this.Owner as Masalar).ims5.Source = new BitmapImage(new Uri("Images/Kmasasonsonpng.png", UriKind.Relative));
                    (this.Owner as Masalar).tms5.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#E46860"));
                    break;
                case " Masa6":
                    for (int i = 0; i < lbUrun.Items.Count; i++)
                    {

                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Parameters.Clear();
                        sqlCommand.CommandText = "insert into masasip (urun,fiyat,masaid) values (@urun,@fiyat,@masaid)";
                        sqlCommand.Parameters.AddWithValue("@urun", lbUrun.Items[i]);
                        sqlCommand.Parameters.AddWithValue("@fiyat", Convert.ToInt32(lbFiyat.Items[i]));
                        sqlCommand.Parameters.AddWithValue("@masaid", 6);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.CommandText = "update masalar set durum ='1' where ID=6 ";
                    (this.Owner as Masalar).ims6.Source = new BitmapImage(new Uri("Images/Kmasasonsonpng.png", UriKind.Relative));
                    (this.Owner as Masalar).tms6.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#E46860"));
                    break;
                case " Masa7":
                    for (int i = 0; i < lbUrun.Items.Count; i++)
                    {

                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Parameters.Clear();
                        sqlCommand.CommandText = "insert into masasip (urun,fiyat,masaid) values (@urun,@fiyat,@masaid)";
                        sqlCommand.Parameters.AddWithValue("@urun", lbUrun.Items[i]);
                        sqlCommand.Parameters.AddWithValue("@fiyat", Convert.ToInt32(lbFiyat.Items[i]));
                        sqlCommand.Parameters.AddWithValue("@masaid", 7);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.CommandText = "update masalar set durum ='1' where ID=7 ";
                    (this.Owner as Masalar).ims7.Source = new BitmapImage(new Uri("Images/Kmasasonsonpng.png", UriKind.Relative));
                    (this.Owner as Masalar).tms7.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#E46860"));
                    break;
                case " Masa8":
                    for (int i = 0; i < lbUrun.Items.Count; i++)
                    {

                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Parameters.Clear();
                        sqlCommand.CommandText = "insert into masasip (urun,fiyat,masaid) values (@urun,@fiyat,@masaid)";
                        sqlCommand.Parameters.AddWithValue("@urun", lbUrun.Items[i]);
                        sqlCommand.Parameters.AddWithValue("@fiyat", Convert.ToInt32(lbFiyat.Items[i]));
                        sqlCommand.Parameters.AddWithValue("@masaid", 8);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.CommandText = "update masalar set durum ='1' where ID=8 ";
                    (this.Owner as Masalar).ims8.Source = new BitmapImage(new Uri("Images/Kmasasonsonpng.png", UriKind.Relative));
                    (this.Owner as Masalar).tms8.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#E46860"));
                    break;
                case " Masa9":
                    for (int i = 0; i < lbUrun.Items.Count; i++)
                    {

                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Parameters.Clear();
                        sqlCommand.CommandText = "insert into masasip (urun,fiyat,masaid) values (@urun,@fiyat,@masaid)";
                        sqlCommand.Parameters.AddWithValue("@urun", lbUrun.Items[i]);
                        sqlCommand.Parameters.AddWithValue("@fiyat", Convert.ToInt32(lbFiyat.Items[i]));
                        sqlCommand.Parameters.AddWithValue("@masaid", 9);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.CommandText = "update masalar set durum ='1' where ID=9 ";
                    (this.Owner as Masalar).ims9.Source = new BitmapImage(new Uri("Images/Kmasasonsonpng.png", UriKind.Relative));
                    (this.Owner as Masalar).tms9.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#E46860"));
                    break;
                case " Masa10":
                    for (int i = 0; i < lbUrun.Items.Count; i++)
                    {

                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Parameters.Clear();
                        sqlCommand.CommandText = "insert into masasip (urun,fiyat,masaid) values (@urun,@fiyat,@masaid)";
                        sqlCommand.Parameters.AddWithValue("@urun", lbUrun.Items[i]);
                        sqlCommand.Parameters.AddWithValue("@fiyat", Convert.ToInt32(lbFiyat.Items[i]));
                        sqlCommand.Parameters.AddWithValue("@masaid", 10);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.CommandText = "update masalar set durum ='1' where ID=10";
                    (this.Owner as Masalar).ims10.Source = new BitmapImage(new Uri("Images/Kmasasonsonpng.png", UriKind.Relative));
                    (this.Owner as Masalar).tms10.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#E46860"));
                    break;
                case " Masa11":
                    for (int i = 0; i < lbUrun.Items.Count; i++)
                    {

                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Parameters.Clear();
                        sqlCommand.CommandText = "insert into masasip (urun,fiyat,masaid) values (@urun,@fiyat,@masaid)";
                        sqlCommand.Parameters.AddWithValue("@urun", lbUrun.Items[i]);
                        sqlCommand.Parameters.AddWithValue("@fiyat", Convert.ToInt32(lbFiyat.Items[i]));
                        sqlCommand.Parameters.AddWithValue("@masaid", 11);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.CommandText = "update masalar set durum ='1' where ID=11 ";
                    (this.Owner as Masalar).ims11.Source = new BitmapImage(new Uri("Images/Kmasasonsonpng.png", UriKind.Relative));
                    (this.Owner as Masalar).tms11.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#E46860"));
                    break;
                case " Masa12":
                    for (int i = 0; i < lbUrun.Items.Count; i++)
                    {

                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Parameters.Clear();
                        sqlCommand.CommandText = "insert into masasip (urun,fiyat,masaid) values (@urun,@fiyat,@masaid)";
                        sqlCommand.Parameters.AddWithValue("@urun", lbUrun.Items[i]);
                        sqlCommand.Parameters.AddWithValue("@fiyat", Convert.ToInt32(lbFiyat.Items[i]));
                        sqlCommand.Parameters.AddWithValue("@masaid", 12);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.CommandText = "update masalar set durum ='1' where ID=12 ";
                    (this.Owner as Masalar).ims12.Source = new BitmapImage(new Uri("Images/Kmasasonsonpng.png", UriKind.Relative));
                    (this.Owner as Masalar).tms12.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#E46860"));
                    break;
                case " Masa13":
                    for (int i = 0; i < lbUrun.Items.Count; i++)
                    {

                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Parameters.Clear();
                        sqlCommand.CommandText = "insert into masasip (urun,fiyat,masaid) values (@urun,@fiyat,@masaid)";
                        sqlCommand.Parameters.AddWithValue("@urun", lbUrun.Items[i]);
                        sqlCommand.Parameters.AddWithValue("@fiyat", Convert.ToInt32(lbFiyat.Items[i]));
                        sqlCommand.Parameters.AddWithValue("@masaid", 13);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.CommandText = "update masalar set durum ='1' where ID=13 ";
                    (this.Owner as Masalar).ims13.Source = new BitmapImage(new Uri("Images/Kmasasonsonpng.png", UriKind.Relative));
                    (this.Owner as Masalar).tms13.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#E46860"));
                    break;
                case " Masa14":
                    for (int i = 0; i < lbUrun.Items.Count; i++)
                    {

                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Parameters.Clear();
                        sqlCommand.CommandText = "insert into masasip (urun,fiyat,masaid) values (@urun,@fiyat,@masaid)";
                        sqlCommand.Parameters.AddWithValue("@urun", lbUrun.Items[i]);
                        sqlCommand.Parameters.AddWithValue("@fiyat", Convert.ToInt32(lbFiyat.Items[i]));
                        sqlCommand.Parameters.AddWithValue("@masaid", 14);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.CommandText = "update masalar set durum ='1' where ID=14 ";
                    (this.Owner as Masalar).ims14.Source = new BitmapImage(new Uri("Images/Kmasasonsonpng.png", UriKind.Relative));
                    (this.Owner as Masalar).tms14.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#E46860"));
                    break;
                case " Masa15":
                    for (int i = 0; i < lbUrun.Items.Count; i++)
                    {

                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Parameters.Clear();
                        sqlCommand.CommandText = "insert into masasip (urun,fiyat,masaid) values (@urun,@fiyat,@masaid)";
                        sqlCommand.Parameters.AddWithValue("@urun", lbUrun.Items[i]);
                        sqlCommand.Parameters.AddWithValue("@fiyat", Convert.ToInt32(lbFiyat.Items[i]));
                        sqlCommand.Parameters.AddWithValue("@masaid", 15);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.CommandText = "update masalar set durum ='1' where ID=15 ";
                    (this.Owner as Masalar).ims15.Source = new BitmapImage(new Uri("Images/Kmasasonsonpng.png", UriKind.Relative));
                    (this.Owner as Masalar).tms15.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#E46860"));
                    break;
                case " Masa16":
                    for (int i = 0; i < lbUrun.Items.Count; i++)
                    {

                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Parameters.Clear();
                        sqlCommand.CommandText = "insert into masasip (urun,fiyat,masaid) values (@urun,@fiyat,@masaid)";
                        sqlCommand.Parameters.AddWithValue("@urun", lbUrun.Items[i]);
                        sqlCommand.Parameters.AddWithValue("@fiyat", Convert.ToInt32(lbFiyat.Items[i]));
                        sqlCommand.Parameters.AddWithValue("@masaid", 16);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.CommandText = "update masalar set durum ='1' where ID=16 ";
                    (this.Owner as Masalar).ims16.Source = new BitmapImage(new Uri("Images/Kmasasonsonpng.png", UriKind.Relative));
                    (this.Owner as Masalar).tms16.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#E46860"));
                    break;
                case " Masa17":
                    for (int i = 0; i < lbUrun.Items.Count; i++)
                    {

                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Parameters.Clear();
                        sqlCommand.CommandText = "insert into masasip (urun,fiyat,masaid) values (@urun,@fiyat,@masaid)";
                        sqlCommand.Parameters.AddWithValue("@urun", lbUrun.Items[i]);
                        sqlCommand.Parameters.AddWithValue("@fiyat", Convert.ToInt32(lbFiyat.Items[i]));
                        sqlCommand.Parameters.AddWithValue("@masaid", 17);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.CommandText = "update masalar set durum ='1' where ID=17 ";
                    (this.Owner as Masalar).ims17.Source = new BitmapImage(new Uri("Images/Kmasasonsonpng.png", UriKind.Relative));
                    (this.Owner as Masalar).tms17.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#E46860"));
                    break;
                case " Masa18":
                    for (int i = 0; i < lbUrun.Items.Count; i++)
                    {

                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Parameters.Clear();
                        sqlCommand.CommandText = "insert into masasip (urun,fiyat,masaid) values (@urun,@fiyat,@masaid)";
                        sqlCommand.Parameters.AddWithValue("@urun", lbUrun.Items[i]);
                        sqlCommand.Parameters.AddWithValue("@fiyat", Convert.ToInt32(lbFiyat.Items[i]));
                        sqlCommand.Parameters.AddWithValue("@masaid", 18);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.CommandText = "update masalar set durum ='1' where ID=18 ";
                    (this.Owner as Masalar).ims18.Source = new BitmapImage(new Uri("Images/Kmasasonsonpng.png", UriKind.Relative));
                    (this.Owner as Masalar).tms18.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#E46860"));
                    break;
                case " Masa19":
                    for (int i = 0; i < lbUrun.Items.Count; i++)
                    {

                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Parameters.Clear();
                        sqlCommand.CommandText = "insert into masasip (urun,fiyat,masaid) values (@urun,@fiyat,@masaid)";
                        sqlCommand.Parameters.AddWithValue("@urun", lbUrun.Items[i]);
                        sqlCommand.Parameters.AddWithValue("@fiyat", Convert.ToInt32(lbFiyat.Items[i]));
                        sqlCommand.Parameters.AddWithValue("@masaid", 19);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.CommandText = "update masalar set durum ='1' where ID=19 ";
                    (this.Owner as Masalar).ims19.Source = new BitmapImage(new Uri("Images/Kmasasonsonpng.png", UriKind.Relative));
                    (this.Owner as Masalar).tms19.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#E46860"));
                    break;
                case " Masa20":
                    for (int i = 0; i < lbUrun.Items.Count; i++)
                    {

                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Parameters.Clear();
                        sqlCommand.CommandText = "insert into masasip (urun,fiyat,masaid) values (@urun,@fiyat,@masaid)";
                        sqlCommand.Parameters.AddWithValue("@urun", lbUrun.Items[i]);
                        sqlCommand.Parameters.AddWithValue("@fiyat", Convert.ToInt32(lbFiyat.Items[i]));
                        sqlCommand.Parameters.AddWithValue("@masaid", 20);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.CommandText = "update masalar set durum ='1' where ID=20 ";
                    (this.Owner as Masalar).ims20.Source = new BitmapImage(new Uri("Images/Kmasasonsonpng.png", UriKind.Relative));
                    (this.Owner as Masalar).tms20.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#E46860"));
                    break;
                case " Masa21":
                    for (int i = 0; i < lbUrun.Items.Count; i++)
                    {

                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.Parameters.Clear();
                        sqlCommand.CommandText = "insert into masasip (urun,fiyat,masaid) values (@urun,@fiyat,@masaid)";
                        sqlCommand.Parameters.AddWithValue("@urun", lbUrun.Items[i]);
                        sqlCommand.Parameters.AddWithValue("@fiyat", Convert.ToInt32(lbFiyat.Items[i]));
                        sqlCommand.Parameters.AddWithValue("@masaid", 21);
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlCommand.CommandText = "update masalar set durum ='1' where ID=21 ";
                    (this.Owner as Masalar).ims21.Source = new BitmapImage(new Uri("Images/Kmasasonsonpng.png", UriKind.Relative));
                    (this.Owner as Masalar).tms21.Foreground = new System.Windows.Media.SolidColorBrush((Color)ColorConverter.ConvertFromString("#E46860"));
                    break;
            }

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Close();
            }
            
            sqlConnection.Close();



            Close();
        }
    }
}