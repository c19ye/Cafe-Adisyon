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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CafeAdisyon
{
    /// <summary>
    /// MainWindow.xaml etkileşim mantığı
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int kullaniciid;
        
        public MainWindow()
        {
            InitializeComponent();
        }
        Connect connect = new Connect();
        #region Combobaxa Verilerin Gelmesi
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Personel personel = new Personel();
            personel.personelgetir(ComboBoxk);
        }
        #endregion

        #region Giriş Butonuna Tıklama Olayı ve yeni pencerenin gelmesi
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainSelections mainSelections = new MainSelections();
            Personel personel = new Personel();
            bool cikis = personel.personelgir(Convert.ToInt32(PasswordBox.Password), connect.personelId);
            if (cikis)
            {
                this.Hide();
                mainSelections.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Şifre Girişi", "Hata", MessageBoxButton.OK);
            }
        } 
        #endregion

        #region Tıklayarak Şifre Girilmesi
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password.Contains(" "))
            {
                PasswordBox.Password = "0";
            }
            else
            {
                PasswordBox.Password = PasswordBox.Password + "0";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password.Contains(" "))
            {
                PasswordBox.Password = "1";
            }
            else
            {
                PasswordBox.Password = PasswordBox.Password + "1";
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password.Contains(" "))
            {
                PasswordBox.Password = "2";
            }
            else
            {
                PasswordBox.Password = PasswordBox.Password + "2";
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password.Contains(" "))
            {
                PasswordBox.Password = "3";
            }
            else
            {
                PasswordBox.Password = PasswordBox.Password + "3";
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password.Contains(" "))
            {
                PasswordBox.Password = "4";
            }
            else
            {
                PasswordBox.Password = PasswordBox.Password + "4";
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password.Contains(" "))
            {
                PasswordBox.Password = "5";
            }
            else
            {
                PasswordBox.Password = PasswordBox.Password + "5";
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password.Contains(" "))
            {
                PasswordBox.Password = "6";
            }
            else
            {
                PasswordBox.Password = PasswordBox.Password + "6";
            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password.Contains(" "))
            {
                PasswordBox.Password = "7";
            }
            else
            {
                PasswordBox.Password = PasswordBox.Password + "7";
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password.Contains(" "))
            {
                PasswordBox.Password = "8";
            }
            else
            {
                PasswordBox.Password = PasswordBox.Password + "8";
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Password.Contains(" "))
            {
                PasswordBox.Password = "9";
            }
            else
            {
                PasswordBox.Password = PasswordBox.Password + "9";
            }

        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            PasswordBox.Clear();

        }
        #endregion

        #region Comboboxta verilerin seçilmesi
        private void ComboBoxk_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Personel personel = (Personel)ComboBoxk.SelectedItem;
            connect.personelId = personel.Personelid;
            connect.personelgörevId = personel.Personelgörevid;
            kullaniciid = connect.personelgörevId;
        } 
        #endregion
    }
}
