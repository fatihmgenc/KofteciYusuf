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
    /// Interaction logic for ÜyeOl.xaml
    /// </summary>
    public partial class ÜyeOl : Window
    {
        SingeltonService service = SingeltonService.getServisOgesi();

        string[] YalovaIlceleri = new string[] { "Ismet Paşa Mah.","Termal","Çiftlikköy","Çınarcık","Armutlu","Altınova","Yalova Merkez"};

        string[] BursaIlceleri = new string[] { "Ovaakça", "Kestel", "Gürsü", "Yıldırım", "Osmangazi", "Nilüfer", "Harmancık","Büyük Orhan",
            "Yenişehir","Orhaneli","Mustafa Kemal Paşa ","Mudanya","Keles","Karacabey","Iznık","Gemlik"};

        string[] eskişehirIlceleri = new string[] { "Beylikova"," Çifteler", "Günyüzü", "Han","İnönü", "Mahmudiye","Mihalgazi", "Mihalıççık", "Odunpazarı",
 "Sarıcakaya","Seyitgazi", "Sivrihisar", "Tepebaşı" };




        public void Setİlceler(int Index) {
            switch (Index)
            {
                case 0:
                    
                    IlçeBox.ItemsSource = BursaIlceleri;
                    break;

                case 1:
                  
                    IlçeBox.ItemsSource = eskişehirIlceleri;

                    break;

                case 2:
                  
                    IlçeBox.ItemsSource = YalovaIlceleri;
                    break;
            }
        }





        public ÜyeOl()
        {
            InitializeComponent();

            AdrestipiBox.Items.Add("Ev");
            AdrestipiBox.Items.Add("iş");
            AdrestipiBox.Items.Add("Diğer");
            İlBox.Items.Add("Bursa");
            İlBox.Items.Add("Eskişehir");
            İlBox.Items.Add("Yalova");

            

        }


        public void AdınızaGirildi(Object sender, RoutedEventArgs e)
        {
            AdKutusu.Clear();
        }

        private void İlBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Setİlceler(İlBox.SelectedIndex);
        }
        private void ÜyeOl_Click(Object sender,RoutedEventArgs e)
        {
            if (service.Server.üyeOl(AdKutusu.Text, MailKutusu.Text, ParolaKutusu.Text, TelKutusu.Text, kapınobox.Text, DaireNoBox.Text, İlBox.SelectedIndex, IlçeBox.SelectedIndex))
            {
                MessageBox.Show("Başarıyla Üye Olundu !");
                this.Close();
            }
            else
            {
                MessageBox.Show("Failure");
            }
        }
    }
}
