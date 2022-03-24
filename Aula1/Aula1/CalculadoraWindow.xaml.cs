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

namespace Aula1
{
    /// <summary>
    /// Lógica interna para CalculadoraWindow.xaml
    /// </summary>
    public partial class CalculadoraWindow : Window
    {
        public CalculadoraWindow()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, RoutedEventArgs e)
        {
            double peso = Convert.ToDouble(txtPeso.Text);
            double altura = Convert.ToDouble(txtAltura.Text);
            double resultado = peso / (altura * altura);
            MessageBox.Show("O IMC calculado é: " + resultado);

            if (resultado < 18.5)
            {
                MessageBox.Show("Classificação: Abaixo do peso");
            }
            else if ((resultado >= 18.5) && (resultado <= 24.9))
            {
                MessageBox.Show("Classificação: Peso normal");
            }
            else if ((resultado >= 25) && (resultado <= 29.9))
            {
                MessageBox.Show("Classificação: Sobrepeso");
            }
            else if ((resultado >= 30) && (resultado <= 34.9))
            {
                MessageBox.Show("Classificação: Obesidade grau 1");
            }
            else if ((resultado >= 35) && (resultado <= 39.9))
            {
                MessageBox.Show("Classificação: Obesidade grau 2");
            }
            else if (resultado >= 40)
            {
                MessageBox.Show("Classificação: Obesidade mórbida");
            }
        }
    }
}
