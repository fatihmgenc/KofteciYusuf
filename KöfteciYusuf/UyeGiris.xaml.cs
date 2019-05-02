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
    /// Interaction logic for UyeGiris.xaml
    /// </summary>
    public partial class UyeGiris : Window
    {
        SingeltonService service = SingeltonService.getServisOgesi();
        public UyeGiris()
        {
            InitializeComponent();
        }

        //GirisYapButonu
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (service.Server.GirisKontrol(TelNo.Text,Parola.Password))
            {
                MessageBox.Show("Giris Yapıldı");
                UyeMainWindow uyeMainWindowOrn = new UyeMainWindow();
                uyeMainWindowOrn.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya parola hatalı ");

            }
        }

        private void TelNo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
