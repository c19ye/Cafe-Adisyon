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
    /// KasaRapor.xaml etkileşim mantığı
    /// </summary>
    public partial class KasaRapor : Window
    {
        
        Connect _connect=new Connect();
        private int tutar;
        private int miktar;
        public KasaRapor()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            datagrid.Items.Clear();
            datagrid.Items.Refresh();
            DateTime myDateTime = DateTime.Now; 
            string sqlFormattedDate = myDateTime.ToString();
            DateTime zaman = DateTime.Today;
            
            var sqlConnection = new SqlConnection(_connect.connect);
            var sqlCommand = new SqlCommand("Select urun,fiyat,ödemetur from masasip where masaid = 0 and tarih = convert(varchar, getdate(), 23)",
                sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
            var dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())

            {
                var urun = new Urun();
                urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                urun.urunadi = Convert.ToString(dataReader["urun"]);
                urun.tur = Convert.ToString(dataReader["ödemetur"]);
                lbUrun.Content=urun.urunadi;
                lbFiyat.Content=urun.fiyat;
                
                    datagrid.Items.Add(new
                    {
                        urunadi = lbUrun.Content, fiyat = lbFiyat.Content + " TL",
                        tur=urun.tur
                    }); 
                
            }

            
            SqlDataAdapter da = new SqlDataAdapter("Select fiyat from masasip where masaid =0 and tarih =  convert(varchar, getdate(), 23)", sqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            try
            {
                tutar = Convert.ToInt32(dt.Compute("sum(fiyat)", ""));
                miktar = Convert.ToInt32(dt.Compute("count(fiyat)", ""));
            }
            catch (Exception)
            {

                MessageBox.Show("Hiç Ürün Yok");
                Close();
            }
            lbl3.Content = tutar + " TL";
            lbl3_Copy.Content = miktar + " Urun";
            dataReader.Close();
            sqlConnection.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            datagrid.Items.Clear();
            datagrid.Items.Refresh();
            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString();
            DateTime zaman = DateTime.Today;

            var sqlConnection = new SqlConnection(_connect.connect);
            var sqlCommand = new SqlCommand("Select urun,fiyat,ödemetur from masasip where masaid =0 and tarih >= DATEADD(day, -30, getdate())",
                sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed) sqlConnection.Open();
            var dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())

            {
                var urun = new Urun();
                urun.fiyat = Convert.ToInt32(dataReader["fiyat"]);
                urun.urunadi = Convert.ToString(dataReader["urun"]);
                urun.tur = Convert.ToString(dataReader["ödemetur"]);
                lbUrun.Content = urun.urunadi;
                lbFiyat.Content = urun.fiyat;

                datagrid.Items.Add(new
                {
                    urunadi = lbUrun.Content,
                    fiyat = lbFiyat.Content + " TL",
                            tur=urun.tur
                });

            }


            SqlDataAdapter da = new SqlDataAdapter("Select fiyat from masasip where masaid =0 and tarih >= DATEADD(day, -30, getdate())", sqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            try
            {
                tutar = Convert.ToInt32(dt.Compute("sum(fiyat)", ""));
                miktar = Convert.ToInt32(dt.Compute("count(fiyat)", ""));
            }
            catch (Exception)
            {

                MessageBox.Show("Hiç Ürün Yok");
                Close();
            }
            lbl3.Content = tutar + " TL";
            lbl3_Copy.Content = miktar + " Urun";
            dataReader.Close();
            sqlConnection.Close();

        }
    }
}
