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
    /// Rapor.xaml etkileşim mantığı
    /// </summary>
    public partial class Rapor : Window
    {
        Connect _connect=new Connect();
        public Rapor()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Rapor_OnLoaded(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(_connect.connect);

            SqlCommand sqlCommand = new SqlCommand("Select urunadi from ürünler ", sqlConnection);

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Urun urun = new Urun();
                urun.urunadi = Convert.ToString(dataReader["urunadi"]);
                lbUrun.Items.Add(urun.urunadi);
            }
            dataReader.Close();
            sqlConnection.Close();
        }

        private void sec()
        {
            datagrid.Items.Clear();
            datagrid.Items.Refresh();
            string text = lbUrun.SelectedItem.ToString();


            var sqlConnection = new SqlConnection(_connect.connect);

            sqlConnection.Open();



            SqlDataAdapter da = new SqlDataAdapter("Select urun,fiyat from masasip where masaid=0 and urun =  '" + text + "' and tarih = convert(varchar, getdate(), 23)", sqlConnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            try
            {
                datagrid.Items.Add(new
                {
                    umiktar = Convert.ToString(dt.Compute("count(urun)", "")),
                    tfiyat = Convert.ToInt32(dt.Compute("sum(fiyat)", ""))
                });
                 
            }
            catch (Exception)
            {
                datagrid.Items.Add(new
                {
                    umiktar = 0,
                    tfiyat = 0
                });
            }
            sqlConnection.Close();
        }

        private void LbUrun_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            sec();
        }
    }
}
