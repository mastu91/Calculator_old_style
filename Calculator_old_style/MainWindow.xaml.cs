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

namespace Calculator_old_style
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly CalculatorService calculatorService = new CalculatorService();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            tbOutput.Text += "0";
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            tbOutput.Text += "1";
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            tbOutput.Text += "2";
        }

        private void btnThree_Click(object sender, RoutedEventArgs e)
        {
            tbOutput.Text += "3";
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            tbOutput.Text += "4";
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            tbOutput.Text += "5";
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            tbOutput.Text += "6";
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            tbOutput.Text += "7";
        }

        private void btnEight_Click(object sender, RoutedEventArgs e)
        {
            tbOutput.Text += "8";
        }

        private void btnNine_Click(object sender, RoutedEventArgs e)
        {
            tbOutput.Text += "9";

        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            calculatorService.SetOperator(tbOutput.Text, "+");
            tbOutput.Text = "";
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            calculatorService.SetOperator(tbOutput.Text, "-");
            tbOutput.Text = "";
        }

        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            calculatorService.SetOperator(tbOutput.Text, "*");
            tbOutput.Text = "";
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            calculatorService.SetOperator(tbOutput.Text, "/");
            tbOutput.Text = "";
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            tbOutput.Text = calculatorService.Equalisation(tbOutput.Text);
        }

        private void btnDeletAll_Click(object sender, RoutedEventArgs e)
        {
            tbOutput.Text = calculatorService.Reset();
        }

        private void btnDeletLastValue_Click(object sender, RoutedEventArgs e)
        {
            tbOutput.Text = "";
        }

        private void btnDeletLastInput_Click(object sender, RoutedEventArgs e)
        {
            tbOutput.Text = calculatorService.ResetNumber(tbOutput.Text);
        }

        private void btnChangeSign_Click(object sender, RoutedEventArgs e)
        {
            tbOutput.Text = calculatorService.ChangeSign(tbOutput.Text);
        }
    }
}
