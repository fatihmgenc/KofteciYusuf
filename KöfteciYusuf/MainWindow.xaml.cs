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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] gramlar = new int[] { 100, 150, 200, 250, 300, 400, 500, 600, 700, 800, 900, 1000 };
        public MainWindow()
        {
            InitializeComponent();
            //Köfte Gramı


            köftegram.ItemsSource = gramlar;
            //EKmek Kadayıfı
            String[] EKPorsiyon = new string[] { "Sade Ekmek Kadayıfı", "Az Ekmek Kadayıfı Sade" , "Kaymaklı Ekmek Kadayıfı" ,
            "Az Ekmek Kadayıfı Kaymaklı","Bol Kaymaklı Ekmek Kadayıfı"};
            EkmekKAdayıfıPorsiyon.ItemsSource = EKPorsiyon;
            //Iclı Kofte Pors
            IclıKoftePors.Items.Add("İçli Köfte");
            //Salata Pors
            String[] SalataPorsiyon = new string[] { "Salata", "Az Salata", "Duble Salata", };
            SalataPors.ItemsSource = SalataPorsiyon;
            //PiyazPors
            String[] PiyazPorsiyon = new string[] { "Piyaz", "Az Piyaz", "Duble Piyaz", };
            PiyazPors.ItemsSource = PiyazPorsiyon;
            //TrileçePors
            TriliçePors.Items.Add("Triliçe");
            //KöfteSucukPors
            KöfteSucukPorsBox.ItemsSource = gramlar;
            //Patatespors
            String[] PatatesPorsiyon = new string[] { "Patates", "Az Patates", "Duble Patates", };
            PatatesPorsBox.ItemsSource = PatatesPorsiyon;
            //KahvaltıPors
            KahvaltıPorsBox.Items.Add("Kahvaltı");
            //KangalSucukPors
            for (int i = 200; i < 5001; i = i + 100)
            {
                KangalSucukPorsBox.Items.Add(i);
            }
            //KöfteEkmekPors
            for (int i = 50; i < 201; i += 50)
            {
                EkmekArasıPorsBox.Items.Add(i + " gram köfte ekmek arası");
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UyeGiris GirisYapWindow = new UyeGiris();
            GirisYapWindow.Show();
            this.Close();
        }

        private void Köftegram_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FiyatKöfte.Text = (gramlar[köftegram.SelectedIndex] / 12.5).ToString();
        }

        private void EkmekKAdayıfıPorsiyon_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (EkmekKAdayıfıPorsiyon.SelectedIndex == 0)
            {
                FiyatEkmekKadayıfı.Text = "5";
            }
            else if (EkmekKAdayıfıPorsiyon.SelectedIndex == 1)
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

        private void IclıKoftePors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IclıKoftePors.SelectedIndex == 0)
            {
                FiyatİcliKöfte.Text = "2";
            }
        }

        private void SalataPors_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
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

        private void PiyazPors_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
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

        private void TriliçePors_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (TriliçePors.SelectedIndex == 0)
            {
                FiyatTriliçe.Text = "5";
            }
        }

        private void KöfteSucukPorsBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            FiyatKofteSucuk.Text = (gramlar[KöfteSucukPorsBox.SelectedIndex] / 12.5).ToString();
        }

        private void PatatesPorsBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
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

        private void KahvaltıPorsBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (KahvaltıPorsBox.SelectedIndex == 0)
            {
                FiyatKahvaltıTabagı.Text = "16";
            }
        }

        private void KangalSucukPorsBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            FiyatKangalSucuk.Text = ((((KangalSucukPorsBox.SelectedIndex) + 200) + (KangalSucukPorsBox.SelectedIndex) * 100) / 22.727272727272).ToString();
        }

        private void EkmekArasıPorsBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (EkmekArasıPorsBox.SelectedIndex == 0)
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ÜyeOl üyeOlWindow = new ÜyeOl();
            üyeOlWindow.Show();
        }
    }
}
