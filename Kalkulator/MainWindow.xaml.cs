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
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calc c = new Calc();
        public MainWindow()
        {
            InitializeComponent();
        }
        private decimal getNumbers(string txtbox)
        {
            decimal zmienna;
            decimal.TryParse(txtbox, out zmienna);
            return zmienna;
        }


        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            if (Calc.txtKtore == true)
            {
                txtLiczbaA.Text += "0";
            }
            else
                txtLiczbaB.Text += "0";
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            if (Calc.txtKtore == true)
            {
                txtLiczbaA.Text += "1";
            }
            else
                txtLiczbaB.Text += "1";
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            if (Calc.txtKtore == true)
            {
                txtLiczbaA.Text += "2";
            }
            else
                txtLiczbaB.Text += "2";
        }
        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            if (Calc.txtKtore == true)
            {
                txtLiczbaA.Text += "3";
            }
            else
                txtLiczbaB.Text += "3";
        }
        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            if (Calc.txtKtore == true)
            {
                txtLiczbaA.Text += "4";
            }
            else
                txtLiczbaB.Text += "4";
        }
        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            if (Calc.txtKtore == true)
            {
                txtLiczbaA.Text += "5";
            }
            else
                txtLiczbaB.Text += "5";
        }
        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            if (Calc.txtKtore == true)
            {
                txtLiczbaA.Text += "6";
            }
            else
                txtLiczbaB.Text += "6";
        }
        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            if (Calc.txtKtore == true)
            {
                txtLiczbaA.Text += "7";
            }
            else
                txtLiczbaB.Text += "7";
        }
        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            if (Calc.txtKtore == true)
            {
                txtLiczbaA.Text += "8";
            }
            else
                txtLiczbaB.Text += "8";
        }
        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            if (Calc.txtKtore == true)
            {
                txtLiczbaA.Text += "9";
            }
            else
                txtLiczbaB.Text += "9";
        }

        private void txtLiczbaA_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Calc.txtKtore = true;
        }
        private void txtLiczbaB_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Calc.txtKtore = false;
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            decimal a;
            decimal zwrot;
            if (Calc.txtKtore == true)
            {
                a = getNumbers(txtLiczbaA.Text);
                zwrot = -1 * a;
                txtLiczbaA.Text = zwrot.ToString();
            }
            else
            {
                a = getNumbers(txtLiczbaB.Text);
                zwrot = -1 * a;
                txtLiczbaB.Text = zwrot.ToString();
            }
        }
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            if (Calc.txtKtore == true)
            {
                txtLiczbaA.Text = "";
            }
            else
                txtLiczbaB.Text = "";
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            Calc.txtKtore=!Calc.txtKtore;
            txtWynik.Text = (c.Dodawanie(getNumbers(txtLiczbaA.Text), getNumbers(txtLiczbaB.Text))).ToString();
        }
        private void btnOdejmij_Click(object sender, RoutedEventArgs e)
        {
            Calc.txtKtore = !Calc.txtKtore;
            txtWynik.Text = (c.Odejmowanie(getNumbers(txtLiczbaA.Text), getNumbers(txtLiczbaB.Text))).ToString();
        }
        private void btnMnozenie_Click(object sender, RoutedEventArgs e)
        {
            Calc.txtKtore = !Calc.txtKtore;
            txtWynik.Text = (c.Mnozenie(getNumbers(txtLiczbaA.Text), getNumbers(txtLiczbaB.Text))).ToString();
        }
        private void btnDzielenie_Click(object sender, RoutedEventArgs e)
        {
            Calc.txtKtore = !Calc.txtKtore;
            try
            {
                txtWynik.Text = (c.Dzielenie(getNumbers(txtLiczbaA.Text), getNumbers(txtLiczbaB.Text))).ToString();
            }
            catch (Exception msg)
            {
                txtWynik.Text = "Probujesz dzielic przez 0!";
            }
        }

        private void btnNotatnik_Click(object sender, RoutedEventArgs e)
        {
            Notatnik n = new Notatnik();
            
            n.Show();
        }
    }
}
