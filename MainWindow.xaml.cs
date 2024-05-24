using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;

namespace Rekenmachine
{
    public partial class MainWindow : Window
    {
        // Constructor van MainWindow
        public MainWindow()
        {
            // Stel de cultuur in op een waar decimaalteken een komma is
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("nl-NL");

            InitializeComponent();
        }

        // +/-
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Som.Text))
            {
                if (Som.Text[0] == '-')
                {
                    Som.Text = Som.Text.Substring(1);
                }
                else
                {
                    Som.Text = "-" + Som.Text;
                }
            }
        }

       

        // 0
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Som.Text = Som.Text + 0;
        }

        // ,
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            // Controleer of de invoer een geldig getal is met een komma
            if (double.TryParse(Som.Text + ",", out _))
            {
                Som.Text = Som.Text + ".";
            }
            else
            {
                // Geef een foutmelding weer of voer andere logica uit voor ongeldige invoer
            }
        }

        // =
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            // function to calculate
            try
            {
                var result = new DataTable().Compute(Som.Text, null);
                Som.Text = result.ToString();
            }
            catch
            {
                Som.Text = "Error";
            }
        }

        // 1
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Som.Text = Som.Text + 1;
        }

        // 2
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Som.Text = Som.Text + 2;
        }

        // 3
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Som.Text = Som.Text + 3;
        }

        // +
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Som.Text = Som.Text + "+";
        }

        // 4
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Som.Text = Som.Text + 4;
        }

        // 5
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Som.Text = Som.Text + 5;
        }

        // 6
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Som.Text = Som.Text + 6;
        }

        // -
        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Som.Text = Som.Text + "-";
        }

        // 7
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            Som.Text = Som.Text + 7;
        }

        // 8
        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            Som.Text = Som.Text + 8;
        }

        // 9
        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            Som.Text = Som.Text + 9;
        }

        // x
        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            Som.Text = Som.Text + "*";
        }

        // C
        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            Som.Text = "";
        }

        // (
        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            Som.Text = Som.Text + "(";
        }

        // )
        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            Som.Text = Som.Text + ")";
        }

        // /
        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            Som.Text = Som.Text + "/";
        }
    }
}
