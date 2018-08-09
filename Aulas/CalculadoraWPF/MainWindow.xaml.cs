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
    {//Main
        double ult = 0;
        string op = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void limpar_Click(object sender, RoutedEventArgs e){
            regi.Text += "clear";
            display.Text = "";
            op = "";
            ult = 0;

        }//Função de limpar o Display
        //Numeros
        private void um_Click(object sender, RoutedEventArgs e){
            regi.Text += "1";
            display.Text += "1";
        }
        private void dois_Click(object sender, RoutedEventArgs e)
        {
            regi.Text += "2";
            display.Text += "2";
        }
        private void tres_Click(object sender, RoutedEventArgs e)
        {
            regi.Text += "3";
            display.Text += "3";
        }

        private void quatro_Click(object sender, RoutedEventArgs e)
        {
            regi.Text += "4";
            display.Text += "4";
        }

        private void cinco_Click(object sender, RoutedEventArgs e)
        {
            regi.Text += "5";
            display.Text += "5";
        }

        private void seis_Click(object sender, RoutedEventArgs e)
        {
            regi.Text += "6";
            display.Text += "6";
        }

        private void sete_Click(object sender, RoutedEventArgs e)
        {
            regi.Text += "7";
            display.Text += "7";
        }

        private void oito_Click(object sender, RoutedEventArgs e)
        {
            regi.Text += "8";
            display.Text += "8";
        }

        private void nove_Click(object sender, RoutedEventArgs e)
        {
            regi.Text += "9";
            display.Text += "9";
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if(display.Text == "")
            {
                display.Text = "";
            }
            else
            {
                regi.Text += "0";
                display.Text += "0";
            }
        }

        //Numeros ==-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-==
        //Operadores

        private void soma_Click(object sender, RoutedEventArgs e)
        {
            if(op == "*" || op == "/" || op == "-")
            {
                regi.Text += "+";
                op = "+";
            }
            else
            {
                regi.Text += "+";
                ult += double.Parse(display.Text);
                display.Text = "";
                op = "+";
            }
        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            if (op == "*" || op == "/" || op == "+")
            {
                regi.Text += "-";
                op = "-";
            }
            else
            {
                regi.Text += "-";
                ult += double.Parse(display.Text);
                display.Text = "";
                op = "-";
            }
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            if (op == "*" || op == "+" || op == "-")
            {
                regi.Text += "/";
                op = "/";
            }
            else
            {
                regi.Text += "/";
                ult += double.Parse(display.Text);
                display.Text = "";
                op = "/";
            }
        }

        private void mult_Click(object sender, RoutedEventArgs e)
        {
            if (op == "+" || op == "/" || op == "-")
            {
                regi.Text += "X";
                op = "*";
            }
            else
            {
                regi.Text += "X";
                ult += double.Parse(display.Text);
                display.Text = "";
                op = "*";
            }
        }


        //operadores =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

        //resultado
        private void igual_Click(object sender, RoutedEventArgs e)
        {
            if(op == "+")
            {
                regi.Text += "=";
                ult += double.Parse(display.Text);
                display.Text = ult.ToString();
                regi.Text += ult.ToString();
            }
            else if(op == "-")
            {
                regi.Text += "=";
                ult -= double.Parse(display.Text);
                display.Text = ult.ToString();
                regi.Text += ult.ToString();
            }
            else if(op == "*")
            {
                regi.Text += "=";
                ult *= double.Parse(display.Text);
                display.Text = ult.ToString();
                regi.Text += ult.ToString();
            }
            else if(op == "/")
            {
                regi.Text += "=";
                if (double.Parse(display.Text) != 0)
                {
                    ult /= double.Parse(display.Text);
                    display.Text = ult.ToString();
                    regi.Text += ult.ToString();
                }
                else
                {
                    display.Text="ERRO";
                    regi.Text += "ERRO";
                }
            }


        }

        //resultado =-=-=-=-=-=-=-=-=-=-=-=-=-=-==-=-=-=-=
        private void ponto_Click(object sender, RoutedEventArgs e)//otal do ponto
        {
            regi.Text += ",";
            display.Text += ",";
        }//otal do ponto =-=-=-=-=-=-=-=-=-=-=-=-=-=
    }//Main
}
