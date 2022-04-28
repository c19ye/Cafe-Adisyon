using System;
using System.Collections.Generic;
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
    /// MainSelections.xaml etkileşim mantığı
    /// </summary>
    public partial class MainSelections : Window
    {
       

        
        public MainSelections()
        {
            InitializeComponent();
        }
        
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Masalar masalar=new Masalar();
            this.Hide();
            masalar.Show();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (MainWindow.kullaniciid == 4)
            {
                PersonelKayit personelKayit = new PersonelKayit();

                personelKayit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Yetkiniz Yok");
            }
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (MainWindow.kullaniciid == 4)
            {
                uruneklemenu uruneklemenu = new uruneklemenu();
                uruneklemenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Yetkiniz Yok");
            }
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (MainWindow.kullaniciid == 4 || MainWindow.kullaniciid == 5)
            {
            Rapor rapor=new Rapor();
            rapor.ShowDialog();
            }
            else
            {
                MessageBox.Show("Yetkiniz Yok");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (MainWindow.kullaniciid == 4 || MainWindow.kullaniciid == 5)
            {
                KasaRapor kasaRapor = new KasaRapor();
                kasaRapor.ShowDialog();
            }
            else
            {
                MessageBox.Show("Yetkiniz Yok");
            }
            
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Rezervasyon rezervasyon=new Rezervasyon();
            rezervasyon.ShowDialog();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        
    }
}
