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
using System.Collections.ObjectModel;

namespace KöfteciYusuf
{
    
    
    /// <summary>
    /// Interaction logic for UyeMainWindow.xaml
    /// </summary>
    public partial class UyeMainWindow : Window
    {
        int[] gramlar = new int[] { 100, 150, 200, 250, 300, 400, 500, 600, 700, 800, 900, 1000 };

        String[] EKPorsiyon = new string[] { "Sade Ekmek Kadayıfı", "Az Ekmek Kadayıfı Sade" , "Kaymaklı Ekmek Kadayıfı" ,
            "Az Ekmek Kadayıfı Kaymaklı","Bol Kaymaklı Ekmek Kadayıfı"};

        String[] SalataPorsiyon = new string[] { "Salata", "Az Salata", "Duble Salata", };

        String[] PiyazPorsiyon = new string[] { "Piyaz", "Az Piyaz", "Duble Piyaz", };

        String[] PatatesPorsiyon = new string[] { "Patates", "Az Patates", "Duble Patates", };

        private void Window_Loaded()
        {
            

        }

        private void Adreslerim_Selected(object sender, RoutedEventArgs e)
        {
            KöfteciYusuf.Adreslerim adreslerimWindow = new Adreslerim();
            adreslerimWindow.Show();
        }

        Sepet Sepet = Sepet.getSepetOgesi();

        public UyeMainWindow()
        {
            InitializeComponent();
            //Köfte Gramı
            

            köftegram.ItemsSource = gramlar;
            //EKmek Kadayıfı
            
            EkmekKAdayıfıPorsiyon.ItemsSource = EKPorsiyon;
            //Iclı Kofte Pors
            IclıKoftePors.Items.Add("İçli Köfte");
            //Salata Pors
            
            SalataPors.ItemsSource = SalataPorsiyon;
            //PiyazPors
          
            PiyazPors.ItemsSource = PiyazPorsiyon;
            //TrileçePors
            TriliçePors.Items.Add("Triliçe");
            //KöfteSucukPors
            KöfteSucukPorsBox.ItemsSource = gramlar;
            //Patatespors
            
            PatatesPorsBox.ItemsSource = PatatesPorsiyon;
            //KahvaltıPors
            KahvaltıPorsBox.Items.Add("Kahvaltı");
            //KangalSucukPors
            for(int i = 200; i < 5001; i = i + 100)
            {
                KangalSucukPorsBox.Items.Add(i);
            }
            //KöfteEkmekPors
            for (int i = 50; i < 201; i += 50)
            {
                EkmekArasıPorsBox.Items.Add(i+" gram köfte ekmek arası");
            }
            for (int i = 50; i < 201; i += 50)
            {
                EkmekArasıPorsBox.Items.Add(i + " gram kuzu şiş ekmek arası");
            }
            for (int i = 50; i < 201; i += 50)
            {
                EkmekArasıPorsBox.Items.Add(i + " gram köfte sucuk ekmek arası");
            }
            for (int i = 50; i < 201; i += 50)
            {
                EkmekArasıPorsBox.Items.Add(i + " gram piliç incik ekmek arası");
            }
            for (int i = 50; i < 201; i += 50)
            {
                EkmekArasıPorsBox.Items.Add(i + " gram köfte sucuk piliç incik ekmek arası");
            }
            //Ayran
            AyranPorsBox.Items.Add("1 Lt Ayran");
            AyranPorsBox.Items.Add("Bardak Ayran");

        }

       
      



        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

            FiyatKöfte.Text = (gramlar[köftegram.SelectedIndex] / 12.5).ToString();
        }

        private void ComboBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {
            if (IclıKoftePors.SelectedIndex == 0)
            {
                FiyatİcliKöfte.Text = "2";
            }
        }
        
        private void ___No_Name__Copy_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void EkmekKAdayıfıPorsiyon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            if (EkmekKAdayıfıPorsiyon.SelectedIndex == 0)
            {
                FiyatEkmekKadayıfı.Text = "5";
            }
            else if (EkmekKAdayıfıPorsiyon.SelectedIndex==1)
            {
                FiyatEkmekKadayıfı.Text = "4";
            }
            else if (EkmekKAdayıfıPorsiyon.SelectedIndex == 2)
            {
                FiyatEkmekKadayıfı.Text = "8";
            }
            else if (EkmekKAdayıfıPorsiyon.SelectedIndex == 3)
            {
                FiyatEkmekKadayıfı.Text = "5";
            }
            else
            {
                FiyatEkmekKadayıfı.Text = "9";
            }
           
        }

        private void SalataPors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SalataPors.SelectedIndex == 0)
            {
                FiyatSalata.Text = "5";
            }
            if (SalataPors.SelectedIndex == 1)
            {
                FiyatSalata.Text = "3";
            }
            if (SalataPors.SelectedIndex == 2)
            {
                FiyatSalata.Text = "8.5";
            }
        }

        private void PiyazPors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PiyazPors.SelectedIndex == 0)
            {
                FiyatPiyaz.Text = "5";
            }
            if (PiyazPors.SelectedIndex == 1)
            {
                FiyatPiyaz.Text = "3";
            }
            if (PiyazPors.SelectedIndex == 2)
            {
                FiyatPiyaz.Text = "8.5";
            }
        }

        private void TriliçePors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TriliçePors.SelectedIndex == 0)
            {
                FiyatTriliçe.Text = "5";
            }
        }

        private void KöfteSucukPorsBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FiyatKofteSucuk.Text = (gramlar[KöfteSucukPorsBox.SelectedIndex] / 12.5).ToString();
        }

        private void PatatesPorsBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PatatesPorsBox.SelectedIndex == 0)
            {
                FiyatPatates.Text = "5";
            }
            if (PatatesPorsBox.SelectedIndex == 1)
            {
                FiyatPatates.Text = "3";
            }
            if (PatatesPorsBox.SelectedIndex == 2)
            {
                FiyatPatates.Text = "8.5";
            }
        }

        private void KahvaltıPorsBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (KahvaltıPorsBox.SelectedIndex == 0)
            {
                FiyatKahvaltıTabagı.Text = "16";
            }
        }

        private void KangalSucukPorsBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FiyatKangalSucuk.Text = ((((KangalSucukPorsBox.SelectedIndex)+200)+(KangalSucukPorsBox.SelectedIndex)*100) / 22.727272727272).ToString();
        }

        private void EkmekArasıPorsBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(EkmekArasıPorsBox.SelectedIndex==0)
            {
                FiyatEkmekArası.Text = "6";
            }
            if (EkmekArasıPorsBox.SelectedIndex == 1)
            {
                FiyatEkmekArası.Text = "8";
            }
            if (EkmekArasıPorsBox.SelectedIndex == 2)
            {
                FiyatEkmekArası.Text = "12";
            }
            if (EkmekArasıPorsBox.SelectedIndex == 3)
            {
                FiyatEkmekArası.Text = "15";
            }
            if (EkmekArasıPorsBox.SelectedIndex == 4)
            {
                FiyatEkmekArası.Text = "7";
            }
            if (EkmekArasıPorsBox.SelectedIndex == 5)
            {
                FiyatEkmekArası.Text = "10";
            }
            if (EkmekArasıPorsBox.SelectedIndex == 6)
            {
                FiyatEkmekArası.Text = "15";
            }
            if (EkmekArasıPorsBox.SelectedIndex == 7)
            {
                FiyatEkmekArası.Text = "20";
            }
            if (EkmekArasıPorsBox.SelectedIndex == 8)
            {
                FiyatEkmekArası.Text = "6";
            }
            if (EkmekArasıPorsBox.SelectedIndex == 9)
            {
                FiyatEkmekArası.Text = "8";
            }
            if (EkmekArasıPorsBox.SelectedIndex == 10)
            {
                FiyatEkmekArası.Text = "12";
            }
            if (EkmekArasıPorsBox.SelectedIndex == 11)
            {
                FiyatEkmekArası.Text = "15";
            }
            if (EkmekArasıPorsBox.SelectedIndex == 12)
            {
                FiyatEkmekArası.Text = "6";
            }
            if (EkmekArasıPorsBox.SelectedIndex == 13)
            {
                FiyatEkmekArası.Text = "8";
            }
            if (EkmekArasıPorsBox.SelectedIndex == 14)
            {
                FiyatEkmekArası.Text = "10";
            }
            if (EkmekArasıPorsBox.SelectedIndex == 15)
            {
                FiyatEkmekArası.Text = "12";
            }
            if (EkmekArasıPorsBox.SelectedIndex == 16)
            {
                FiyatEkmekArası.Text = "6";
            }
            if (EkmekArasıPorsBox.SelectedIndex == 17)
            {
                FiyatEkmekArası.Text = "8";
            }
            if (EkmekArasıPorsBox.SelectedIndex == 18)
            {
                FiyatEkmekArası.Text = "12";
            }
            if (EkmekArasıPorsBox.SelectedIndex == 19)
            {
                FiyatEkmekArası.Text = "15";
            }
        }

        private void AyranPorsBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (AyranPorsBox.SelectedIndex == 0)
            {
                FiyatAyran.Text = "6";
            }
            if (AyranPorsBox.SelectedIndex == 1)
            {
                FiyatAyran.Text = "2";
            }
        }

        private void Bilgilerim_Selected(object sender, RoutedEventArgs e)
        {
            KöfteciYusuf.Bilgilerim bilgilerimwindow = new Bilgilerim();
            bilgilerimwindow.Show();
        }

        private void siparişlerim_Selected(object sender, RoutedEventArgs e)
        {
            Siparişlerim siparişlerimWindow = new Siparişlerim();
            siparişlerimWindow.Show();
            this.Close();
        }

        private void KöfteSepetBut_Click(object sender, RoutedEventArgs e)
        {
            Sepet.SepettekiÜrünler.Add("Köfte");
            Sepet.SepettekiFiyatlar.Add(FiyatKöfte.Text);
            Sepet.SepettekiPorsiyonlar.Add(gramlar[köftegram.SelectedIndex].ToString());
            MessageBox.Show("Sepete Eklendi.");
        }

       
        private void SepeteGitBut_click(object sender, RoutedEventArgs e)
        {
            SepetimWindow sepetimWindow = new SepetimWindow();
            sepetimWindow.Show();
        }

        private void EkmekKadayifiSepetBut_Click(object sender, RoutedEventArgs e)
        {
            Sepet.SepettekiÜrünler.Add("Ekmek Kadayıfı");
            Sepet.SepettekiFiyatlar.Add(FiyatEkmekKadayıfı.Text);
            Sepet.SepettekiPorsiyonlar.Add(EKPorsiyon[EkmekKAdayıfıPorsiyon.SelectedIndex]);
            MessageBox.Show("Sepete Eklendi.");
        }

        private void İçliKöfte_Click(object sender, RoutedEventArgs e)
        {
            Sepet.SepettekiÜrünler.Add("İçli Köfte");
            Sepet.SepettekiFiyatlar.Add(FiyatİcliKöfte.Text);
            Sepet.SepettekiPorsiyonlar.Add("Normal");
            MessageBox.Show("Sepete Eklendi.");
        }

        private void Salata_Click(object sender, RoutedEventArgs e)
        {
            Sepet.SepettekiÜrünler.Add("Salata");
            Sepet.SepettekiFiyatlar.Add(FiyatSalata.Text);
            Sepet.SepettekiPorsiyonlar.Add(SalataPorsiyon[SalataPors.SelectedIndex]);
            MessageBox.Show("Sepete Eklendi.");
        }

        private void Piyaz_Click(object sender, RoutedEventArgs e)
        {
            Sepet.SepettekiÜrünler.Add("Piyaz");
            Sepet.SepettekiFiyatlar.Add(FiyatPiyaz.Text);
            Sepet.SepettekiPorsiyonlar.Add(PiyazPorsiyon[PiyazPors.SelectedIndex]);
            MessageBox.Show("Sepete Eklendi.");
        }

        private void Triliçe_Click(object sender, RoutedEventArgs e)
        {
            Sepet.SepettekiÜrünler.Add("Triliçe");
            Sepet.SepettekiFiyatlar.Add(FiyatTriliçe.Text);
            Sepet.SepettekiPorsiyonlar.Add("Normal");
            MessageBox.Show("Sepete Eklendi.");
        }

        private void Sucuk_Click(object sender, RoutedEventArgs e)
        {
            Sepet.SepettekiÜrünler.Add("Köfte Sucuk");
            Sepet.SepettekiFiyatlar.Add(FiyatKofteSucuk.Text);
            Sepet.SepettekiPorsiyonlar.Add(gramlar[KöfteSucukPorsBox.SelectedIndex].ToString());
            MessageBox.Show("Sepete Eklendi.");
        }

        private void Patates_Click(object sender, RoutedEventArgs e)
        {
            Sepet.SepettekiÜrünler.Add("Patates");
            Sepet.SepettekiFiyatlar.Add(FiyatPatates.Text);
            Sepet.SepettekiPorsiyonlar.Add(PatatesPorsiyon[PatatesPorsBox.SelectedIndex]);
            MessageBox.Show("Sepete Eklendi.");
        }

        private void KahvaltıTabağı_Click(object sender, RoutedEventArgs e)
        {
            Sepet.SepettekiÜrünler.Add("Kahvaltı Tabağı");
            Sepet.SepettekiFiyatlar.Add(FiyatKahvaltıTabagı.Text);
            Sepet.SepettekiPorsiyonlar.Add("Normal");
            MessageBox.Show("Sepete Eklendi.");
        }

        private void Kangal_Click(object sender, RoutedEventArgs e)
        {
            Sepet.SepettekiÜrünler.Add("Kangal Sucuk");
            Sepet.SepettekiFiyatlar.Add(FiyatKangalSucuk.Text);
            Sepet.SepettekiPorsiyonlar.Add(((KangalSucukPorsBox.SelectedIndex)*100+200).ToString());
            MessageBox.Show("Sepete Eklendi.");
        }

        private void EkmekA_Click(object sender, RoutedEventArgs e)
        {
            Sepet.SepettekiÜrünler.Add("Ekmek Arası");
            Sepet.SepettekiFiyatlar.Add(FiyatEkmekArası.Text);
            Sepet.SepettekiPorsiyonlar.Add(((((EkmekArasıPorsBox.SelectedIndex)%4)*50)+50).ToString());
            MessageBox.Show("Sepete Eklendi.");
        }

        private void Ayran_Click(object sender, RoutedEventArgs e)
        {
            Sepet.SepettekiÜrünler.Add("Ayran");
            Sepet.SepettekiFiyatlar.Add(FiyatAyran.Text);
            Sepet.SepettekiPorsiyonlar.Add(AyranPorsBox.SelectedIndex==1 ? "Bardak Ayran":"Litrelik Ayran");
            MessageBox.Show("Sepete Eklendi.");
        }
    }
}
