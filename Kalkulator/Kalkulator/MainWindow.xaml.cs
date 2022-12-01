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

namespace Kalkulator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double first;
        public int numerDzialania;
        public string ostDizlanie;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            Add('0');
        }

        private void jeden_Click(object sender, RoutedEventArgs e)
        {
            Add('1');
        }

        private void dwa_Click(object sender, RoutedEventArgs e)
        {
            Add('2');
        }

        private void trzy_Click(object sender, RoutedEventArgs e)
        {
            Add('3');
        }

        private void cztery_Click(object sender, RoutedEventArgs e)
        {
            Add('4');
        }

        private void piec_Click(object sender, RoutedEventArgs e)
        {
            Add('5');
        }

        private void szesc_Click(object sender, RoutedEventArgs e)
        {
            Add('6');
        }

        private void siedem_Click(object sender, RoutedEventArgs e)
        {
            Add('7');
        }

        private void osiem_Click(object sender, RoutedEventArgs e)
        {
            Add('8');
        }

        private void dziewiec_Click(object sender, RoutedEventArgs e)
        {
            Add('9');
        }

        public void Add(char znak)
        {
            Wpis.Text += znak;
        }

        private void pierw_Click(object sender, RoutedEventArgs e)
        {
            if (Wpis.Text[0] != 'W')
                Wpis.Text = Math.Sqrt(Convert.ToDouble(Wpis.Text)).ToString();
            ostDizlanie = "pierw";
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            Wpis.Text = "";
            numerDzialania = 0;
            ostDizlanie = "clear";
        }

        private void przecinek_Click(object sender, RoutedEventArgs e)
        {
            bool czyJestPrzecinek = false;

            foreach (char znak in Wpis.Text)
            {
                if (znak == ',')
                    czyJestPrzecinek = true;
            }

            if (!czyJestPrzecinek)
                Wpis.Text += ',';
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            if (Wpis.Text[0] != 'W')
            {
                if (numerDzialania == 0)
                {
                    first = Convert.ToDouble(Wpis.Text);
                    numerDzialania++;
                    Wpis.Text = "";
                }
                else
                {
                    first = first + Convert.ToDouble(Wpis.Text);
                    numerDzialania++;
                    Wpis.Text = "";
                }
            }
            ostDizlanie = "plus";
        }

        private void rowna_Click(object sender, RoutedEventArgs e)
        {
            if (Wpis.Text != "Wpisz...")
            {

                if (ostDizlanie == "plus" && Wpis.Text != "")
                    first = first + Convert.ToDouble(Wpis.Text);
                else if (ostDizlanie == "minus" && Wpis.Text != "")
                    first = first - Convert.ToDouble(Wpis.Text);
                else if (ostDizlanie == "razy" && Wpis.Text != "")
                    first = first * Convert.ToDouble(Wpis.Text);
                else if (ostDizlanie == "podziel" && Wpis.Text != "")
                    first = first / Convert.ToDouble(Wpis.Text);

                Wpis.Text = first.ToString();
                numerDzialania = 0;
                ostDizlanie = "rowna";
            }
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            if (Wpis.Text[0] != 'W')
            {
                if (numerDzialania == 0)
                {
                    first = Convert.ToDouble(Wpis.Text);
                    numerDzialania++;
                    Wpis.Text = "";
                }
                else
                {
                    first = first - Convert.ToDouble(Wpis.Text);
                    numerDzialania++;
                    Wpis.Text = "";
                }
            }
            ostDizlanie = "minus";
        }

        private void razy_Click(object sender, RoutedEventArgs e)
        {
            if (Wpis.Text[0] != 'W')
            {
                if (numerDzialania == 0)
                {
                    first = Convert.ToDouble(Wpis.Text);
                    numerDzialania++;
                    Wpis.Text = "";
                }
                else
                {
                    first = first * Convert.ToDouble(Wpis.Text);
                    numerDzialania++;
                    Wpis.Text = "";
                }
            }
            ostDizlanie = "razy";
        }

        private void podzil_Click(object sender, RoutedEventArgs e)
        {
            if (Wpis.Text[0] != 'W')
            {
                if (numerDzialania == 0)
                {
                    first = Convert.ToDouble(Wpis.Text);
                    numerDzialania++;
                    Wpis.Text = "";
                }
                else
                {
                    first /= Convert.ToDouble(Wpis.Text);
                    numerDzialania++;
                    Wpis.Text = "";
                }
            }
            ostDizlanie = "podziel";
        }
    }
}