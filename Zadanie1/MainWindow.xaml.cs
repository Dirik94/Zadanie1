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

namespace Zadanie1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MaszynaLosujaca maszynaLosujaca;
        public MainWindow()
        {
            InitializeComponent();
            maszynaLosujaca = new MaszynaLosujaca();
        }

        private void dodajKupon(object sender, RoutedEventArgs e)
        {
            if (textBoxItem.Text != "")
            {
                maszynaLosujaca.dodajNowyKupon(textBoxItem.Text);
                textBoxItem.Text = "";
                listaOdswierz();
            }
        }

        private void wylosujKupon(object sender, RoutedEventArgs e)
        {
            if (!maszynaLosujaca.listaKuponowPusta())
            {
                string kupon = maszynaLosujaca.wylowsowanyKupon();
                wylosowany.Content = kupon;
                listaOdswierz();
            }
        }

        private void listaOdswierz()
        {
            listaK.Items.Clear();
            foreach (string item in maszynaLosujaca.wszystkieKupony())
            {
                listaK.Items.Add(item);
            }
        }
    }
}

