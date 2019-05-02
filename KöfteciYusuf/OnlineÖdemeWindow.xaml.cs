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
   
    public partial class OnlineÖdemeWindow : Window
    {
        SingeltonService SingeltonService = SingeltonService.getServisOgesi();
        public OnlineÖdemeWindow()
        {
            InitializeComponent();
        }

        public void ÖdemeİslemiBaslasın(object sender, RoutedEventArgs e)
        {
            if (SingeltonService.Server.ÖdemeKontrol(KartNo.Text, Tarih.Text))
            {
                MessageBox.Show("Başarılı Siparişiniz Alınmıştır, 30 dk içinde gelecek.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Son kullanma Tarihi Hatalı");
                this.Close();
            }
        }

        public void CVC_Focus(object sender,RoutedEventArgs e)
        {
            
        }

        public void Kartno_Focus(object sender, RoutedEventArgs e)
        {

        }

        public void Kullanma_Focus(object sender, RoutedEventArgs e)
        {

        }

        public void NameFocus(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    
}
