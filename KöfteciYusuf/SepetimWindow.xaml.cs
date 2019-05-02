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
    /// Interaction logic for Sepetim.xaml
    /// </summary>
    public partial class SepetimWindow : Window
    {
        Sepet sepet = Sepet.getSepetOgesi();

        int Ylocation = 400;
        int Total = 0;
        int temp;
        Button ButtonOnay = new Button();
        
        public void Ödemeyegec(object sender, RoutedEventArgs e)
        {
            ÖdemeWindow ödemeWindow = new ÖdemeWindow();
            ödemeWindow.Show();
        }

        public void ButonYarat(int Total)
        {
            ButtonOnay.Content = "Sepeti Onayla Toplam : "+Total.ToString()+" TL";
            ButtonOnay.Height = 50;
            ButtonOnay.Width = 300;
            ButtonOnay.Margin = new Thickness(80, Ylocation, 0, 0);
            ButtonOnay.Background = new SolidColorBrush(Colors.Orange);
            ButtonOnay.Foreground = new SolidColorBrush(Colors.White);
            ButtonOnay.VerticalAlignment = VerticalAlignment.Top;
            ButtonOnay.HorizontalAlignment = HorizontalAlignment.Left;
            ButtonOnay.SetValue(Grid.RowProperty, 1);
            ButtonOnay.Click += Ödemeyegec;
            AnaGrid.Children.Add(ButtonOnay);
        }

        private void LabelYarat(string contextÜrünEtiketi,ref int Ylocation,string ürünPorsiyon,string ürünFiyat)
        {
           
            Label Labeli = new Label();
            Labeli.Content = contextÜrünEtiketi;
            Labeli.Height = 30;
            Labeli.Width = 200;
            Labeli.Margin = new Thickness(10, Ylocation, 0, 0);
            Labeli.Foreground = new SolidColorBrush(Colors.Black);
            Labeli.Background = new SolidColorBrush(Colors.White);
            Labeli.VerticalAlignment = VerticalAlignment.Top;
            Labeli.HorizontalAlignment = HorizontalAlignment.Left;
            Labeli.SetValue(Grid.RowProperty, 1);
            AnaGrid.Children.Add(Labeli);
            


            Label Labelj = new Label();
            Labelj.Content = ürünPorsiyon;
            Labelj.Height = 30;
            Labelj.Width = 120;
            Labelj.Margin = new Thickness(170, Ylocation, 0, 0);
            Labelj.Foreground = new SolidColorBrush(Colors.Black);
            Labelj.Background = new SolidColorBrush(Colors.White);
            Labelj.VerticalAlignment = VerticalAlignment.Top;
            Labelj.HorizontalAlignment = HorizontalAlignment.Left;
            Labelj.SetValue(Grid.RowProperty, 1);
            AnaGrid.Children.Add(Labelj);

            Label Labelk = new Label();
            Labelk.Content = ürünFiyat;
            Labelk.Height = 30;
            Labelk.Width = 200;
            Labelk.Margin = new Thickness(300, Ylocation, 0, 0);
            Labelk.Foreground = new SolidColorBrush(Colors.Black);
            Labelk.Background = new SolidColorBrush(Colors.White);
            Labelk.VerticalAlignment = VerticalAlignment.Top;
            Labelk.HorizontalAlignment = HorizontalAlignment.Left;
            Labelk.SetValue(Grid.RowProperty, 1);
            AnaGrid.Children.Add(Labelk);

            Ylocation += 30;


        }
       

        private void UrunleriOlustur()
        {

            for (int i = 0; i <sepet.SepettekiÜrünler.Count(); i++)
            {
                switch (sepet.SepettekiÜrünler[i])
                {
                    case "Köfte":
                        LabelYarat("Köfte",ref Ylocation,sepet.SepettekiPorsiyonlar[i],sepet.SepettekiFiyatlar[i]);
                      
                        break;
                    case "Ekmek Kadayıfı":
                        LabelYarat("Ekmek Kadayıfı", ref Ylocation,sepet.SepettekiPorsiyonlar[i],sepet.SepettekiFiyatlar[i]);
                        
                        break;
                    case "İçli Köfte":
                        LabelYarat("İçli Köfte", ref Ylocation, sepet.SepettekiPorsiyonlar[i], sepet.SepettekiFiyatlar[i]);
                        
                        break;
                    case "Salata":
                        LabelYarat("Salata", ref Ylocation, sepet.SepettekiPorsiyonlar[i], sepet.SepettekiFiyatlar[i]);
                       
                        break;
                    case "Piyaz":
                        LabelYarat("Piyaz", ref Ylocation, sepet.SepettekiPorsiyonlar[i], sepet.SepettekiFiyatlar[i]);
                        
                        break;
                    case "Triliçe":
                        LabelYarat("Triliçe", ref Ylocation, sepet.SepettekiPorsiyonlar[i], sepet.SepettekiFiyatlar[i]);
                     
                        break;
                    case "Köfte Sucuk":
                        LabelYarat("Köfte Sucuk", ref Ylocation, sepet.SepettekiPorsiyonlar[i], sepet.SepettekiFiyatlar[i]);
                        
                        break;
                    case "Patates":
                        LabelYarat("Patates", ref Ylocation, sepet.SepettekiPorsiyonlar[i], sepet.SepettekiFiyatlar[i]);
                        break;
                    case "Kahvaltı Tabağı":
                        LabelYarat("Kahvaltı Tabağı", ref Ylocation, sepet.SepettekiPorsiyonlar[i], sepet.SepettekiFiyatlar[i]);
                        break;
                    case "Kangal Sucuk":
                        LabelYarat("Kangal Sucuk", ref Ylocation, sepet.SepettekiPorsiyonlar[i], sepet.SepettekiFiyatlar[i]);
                        break;
                    case "Ekmek Arası":
                        LabelYarat("Ekmek Arası", ref Ylocation, sepet.SepettekiPorsiyonlar[i], sepet.SepettekiFiyatlar[i]);
                        break;
                    case "Ayran":
                        LabelYarat("Ayran", ref Ylocation, sepet.SepettekiPorsiyonlar[i], sepet.SepettekiFiyatlar[i]);
                        
                        break;



                }

                Int32.TryParse(sepet.SepettekiFiyatlar[i], out temp);
                Total += temp;

            }


        }

        
        

        public SepetimWindow()
        {
            InitializeComponent();
            UrunleriOlustur();

            ButonYarat(Total);
        }

       

    }
}
