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
    /// Interaction logic for ÖdemeWindow.xaml
    /// </summary>
    public partial class ÖdemeWindow : Window
    {

        //string[] ÖdemeYöntemleri = new string[] { "Kapıda Nakit","Kapıda Kredi Kartı","Online Kredi Kartı","Multinet","Set Card","Ticket Kupon"};


        public ÖdemeWindow()
        {
            InitializeComponent();
            //ÖYöntemBox.ItemsSource = ÖdemeYöntemleri;

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            OnlineÖdemeWindow onlineÖdemeWindow = new OnlineÖdemeWindow();
            onlineÖdemeWindow.Show();

        }
    }
}
