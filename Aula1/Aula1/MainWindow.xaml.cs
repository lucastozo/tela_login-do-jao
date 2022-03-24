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

namespace Aula1
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

        private void btEntrar_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Password;

            if((usuario == "lucas") && (senha == "123"))
            {
                MessageBox.Show("Acertou");
                CalculadoraWindow calculadora = new CalculadoraWindow();
                this.Close();
                calculadora.Show();
                
            }
            else
            {
                MessageBox.Show("Errou");
            }
        }

        private void btFechar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
