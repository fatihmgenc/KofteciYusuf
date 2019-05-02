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
    /// ParolamıDegistir.xaml etkileşim mantığı
    /// </summary>
    public partial class ParolamıDegistir : Window
    {
        public ParolamıDegistir()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Bilgilerim bilgiler = new Bilgilerim();
            bilgiler.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {

            UyeMainWindow uyeMainWindow = new UyeMainWindow();
            uyeMainWindow.Show();
            this.Close();

        }
    }
}
