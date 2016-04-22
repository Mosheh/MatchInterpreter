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

namespace InterpreterMatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var x = new Variable("custo");
                var y = new Variable("pagamento");
                var z = new Variable("correção");
                var a = new Variable("acumulado");

                ExpressionMath exp = new OperationSum(new OperationMultiplication(new OperationSum(x, y), z), a);

                var context = new ContextExpression();
                context.Assign(x,Double.Parse( textBoxX.Text));
                context.Assign(y, Double.Parse(textBoxY.Text));
                context.Assign(z, Double.Parse(textBoxZ.Text));
                context.Assign(a, Double.Parse(textBoxA.Text));

                var result = exp.Interpret(context);
                lblResult.Content = result;
            }
            catch 
            {
                MessageBox.Show("Desculpe, o interpretador não sabe o que você quer dizer");
            }
            
        }
    }
}
