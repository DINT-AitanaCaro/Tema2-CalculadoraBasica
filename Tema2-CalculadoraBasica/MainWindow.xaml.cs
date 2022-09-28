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

namespace Tema2_CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(operando1TextBox.Text) || String.IsNullOrEmpty(operando2TextBox.Text))
                MessageBox.Show("Se ha producido un error. Revise los operandos.");
            else
            {
                int n1 = int.Parse(operando1TextBox.Text);
                int n2 = int.Parse(operando2TextBox.Text);
                switch (operadorTextBox.Text)
                {
                    case "+":
                        resultadoTextBox.Text = (n1 + n2).ToString();
                        break;
                    case "-":
                        resultadoTextBox.Text = (n1 - n2).ToString();
                        break;
                    case "*":
                        resultadoTextBox.Text = (n1 * n2).ToString();
                        break;
                    case "/":
                        resultadoTextBox.Text = (n1 / n2).ToString();
                        break;
                }
            }
        }

        private void operadorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string op = operadorTextBox.Text;
            if (op == "+" || op == "-" || op == "*"|| op == "/")
            {
                calcularButton.IsEnabled = true;
            }
            else calcularButton.IsEnabled = false;
        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            operando1TextBox.Clear();
            operando2TextBox.Clear();
            operadorTextBox.Clear();
            resultadoTextBox.Clear();
        }
    }
}
