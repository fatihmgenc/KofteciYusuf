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

namespace KöfteciYusuf
{
    /// <summary>
    /// Adreslerim.xaml etkileşim mantığı
    /// </summary>
    public partial class Adreslerim : Window
    {
        public Adreslerim()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UyeMainWindow uyeMainWindow = new UyeMainWindow();
            uyeMainWindow.Show();
            this.Close();
        }
    }
}
