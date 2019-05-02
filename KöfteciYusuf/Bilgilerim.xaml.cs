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

namespace KöfteciYusuf
{
    /// <summary>
    /// Bilgilerim.xaml etkileşim mantığı
    /// </summary>
    public partial class Bilgilerim : Window
    {
        public Bilgilerim()
        {
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UyeMainWindow uyeMainWindow = new UyeMainWindow();
            uyeMainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ParolamıDegistir paroladegis = new ParolamıDegistir();
            paroladegis.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
