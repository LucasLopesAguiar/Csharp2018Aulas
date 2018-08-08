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

namespace CalculadoraWPF
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void limpar_Click(object sender, RoutedEventArgs e){display.Text = "";}//Função de limpar o Display
        private void um_Click(object sender, RoutedEventArgs e){display.Text += "1";}
        private void dois_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "2";
        }
        private void tres_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "3";
        }

        private void quatro_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "4";
        }

        private void cinco_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "5";
        }

        private void seis_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "6";
        }

        private void sete_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "7";
        }

        private void oito_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "8";
        }

        private void nove_Click(object sender, RoutedEventArgs e)
        {
            display.Text += "9";
        }
    }
}
