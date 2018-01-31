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

namespace FajnoGra
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Gra gra;
        Zapis zapis;
        Budynek budynek;

        public MainWindow()
        {
            gra = new Gra();
            zapis = new Zapis();
            InitializeComponent();
        }

  
        private void zapis_Click(object sender, RoutedEventArgs e)
        {
            gra.setState(new Tuple<int, int, int, int, int, int, ulong>(gra.LiczbaChatkaDrwala, gra.LiczbaTartak, gra.LiczbaKamieniolom, gra.LiczbaHawierniaZlota, gra.LiczbaMennica, gra.LacznyPrzychod, gra.Zloto));
            zapis.add(gra.saveStateToMemento());
            listaZapisow.Items.Add("Zapis " + Zapis.licznikZapisow);
           
        }

        private void wczytaj_Click(object sender, RoutedEventArgs e)
        {
            if (listaZapisow.SelectedIndex >= 0)
            {
                gra.getStateFromMemento(zapis.get(listaZapisow.SelectedIndex));
                gra.LiczbaChatkaDrwala = gra.StanGry.Item1;
                gra.LiczbaTartak = gra.StanGry.Item2;
                gra.LiczbaKamieniolom = gra.StanGry.Item3;
                gra.LiczbaHawierniaZlota = gra.StanGry.Item4;
                gra.LiczbaMennica = gra.StanGry.Item5;
                gra.LacznyPrzychod = gra.StanGry.Item6;
                gra.Zloto = gra.StanGry.Item7;

                liczbaChatkaDrwala.Text = gra.LiczbaChatkaDrwala.ToString();
                liczbaTartakow.Text = gra.LiczbaTartak.ToString();
                liczbaKamieniolom.Text = gra.LiczbaKamieniolom.ToString(); ;
                liczbaHawierniaZlota.Text = gra.LiczbaHawierniaZlota.ToString();
                liczbaMennica.Text = gra.LiczbaMennica.ToString();
                liczbaZloto.Text = gra.Zloto.ToString() + " (+" + gra.LacznyPrzychod + ")";
            }
            else
            {
                MessageBox.Show("Na, najprzod wybierz zapis!");
            }
        }

        private bool budujBudynek()
        {
            bool czyBudowac = budynek.buduj(gra.Zloto, gra.LiczbaChatkaDrwala, gra.LiczbaTartak, gra.LiczbaKamieniolom);
            if (czyBudowac)
            {
                gra.Zloto -= (ulong)budynek.Koszt;
                gra.LacznyPrzychod += budynek.Przychod;
                liczbaZloto.Text = gra.Zloto.ToString() + " (+" + gra.LacznyPrzychod + ")";
            }
            return czyBudowac;
        }

        private void budujChatkaDrwalaClick(object sender, RoutedEventArgs e)
        {
            budynek = new BudynekA(1500, 300);
            if (budujBudynek())
            {
                ++gra.LiczbaChatkaDrwala;
                liczbaChatkaDrwala.Text = gra.LiczbaChatkaDrwala.ToString();
            }
        }

        private void budujTartak_Click(object sender, RoutedEventArgs e)
        {
            budynek = new BudynekA(3000,500);
            if (budujBudynek())
            {
                ++gra.LiczbaTartak;
                liczbaTartakow.Text = gra.LiczbaTartak.ToString();
            }
        }

        private void budujKamieniolom_Click(object sender, RoutedEventArgs e)
        {
            budynek = new BudynekA(500, 200);
            if (budujBudynek())
            {
                ++gra.LiczbaKamieniolom;
                liczbaKamieniolom.Text = gra.LiczbaKamieniolom.ToString();
            }
        }

        private void budujHawierniaZlota_Click(object sender, RoutedEventArgs e)
        {
            budynek = new BudynekB(5000, 100);
            if (budujBudynek())
            {
                ++gra.LiczbaHawierniaZlota;
                liczbaHawierniaZlota.Text = gra.LiczbaHawierniaZlota.ToString();
            }
        }

        private void budujMennica_Click(object sender, RoutedEventArgs e)
        {
            budynek = new BudynekB(10000, 3000);
            if (budujBudynek())
            {
                ++gra.LiczbaMennica;
                liczbaMennica.Text = gra.LiczbaMennica.ToString();
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void nastepnaTura_Click(object sender, RoutedEventArgs e)
        {
            gra.Zloto += (ulong)gra.LacznyPrzychod;
            liczbaZloto.Text = gra.Zloto.ToString() + " (+" + gra.LacznyPrzychod + ")";
        }

        private void nowaGra_Click(object sender, RoutedEventArgs e)
        {
            gra = new Gra();
            liczbaZloto.Text = "2000" + " (+0)";
            liczbaChatkaDrwala.Text = "0";
            liczbaTartakow.Text = "0";
            liczbaKamieniolom.Text = "0";
            liczbaHawierniaZlota.Text = "0";
            liczbaMennica.Text = "0";
        }

    }
}

