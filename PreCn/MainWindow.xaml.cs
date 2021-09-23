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

namespace PreCn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {   //declaração de cariaveis
        double n1, n2, resultado;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, RoutedEventArgs e)
        {
            //Entrada de dados
            n1 = Convert.ToDouble (txtNumero1.Text);//efetuando uma conversão
            n2 = Convert.ToDouble(txtNumero2.Text);

            //Efetuando o calcúlo 
            resultado = n1 + n2;

            //Saida de dados
            lblResultado.Content =  "Soma:" + resultado.ToString();

        }

        private void btnDivisao_Click(object sender, RoutedEventArgs e)
        {
            //Entrada de dados
            n1 = Convert.ToDouble(txtNumero1.Text);//efetuando uma conversão
            n2 = Convert.ToDouble(txtNumero2.Text);

            //Efetuando o calcúlo 
            resultado = n1 / n2;

            //Saida de dados
            lblResultado.Content = "Divisão:" + resultado.ToString();
        }

        private void btnSubtrair_Click(object sender, RoutedEventArgs e)
        {
            //Entrada de dados
            n1 = Convert.ToDouble(txtNumero1.Text);//efetuando uma conversão
            n2 = Convert.ToDouble(txtNumero2.Text);

            //Efetuando o calcúlo 
            resultado = n1 - n2;

            //Saida de dados
            lblResultado.Content = "Subtrair:" + resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, RoutedEventArgs e)
        {
            
            //Entrada de dados
            n1 = Convert.ToDouble(txtNumero1.Text);//efetuando uma conversão
            n2 = Convert.ToDouble(txtNumero2.Text);

            //Efetuando o calcúlo 
            resultado = n1 * n2;

            //Saida de dados
            lblResultado.Content = "Multiplicar:" + resultado.ToString();

           
        }
        
        }
}
