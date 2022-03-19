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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double rez = rateDollar * sumDollar;
            resSum.Text = rez.ToString();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double rez = rateEuro * sumEuro;
            resSum1.Text = rez.ToString();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            double rateIena = Convert.ToDouble(rate3.Text);
            double sumIena = Convert.ToDouble(sum3.Text);
            double rez = rateIena * sumIena;
            resSum3.Text = rez.ToString();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            double rateFunt = Convert.ToDouble(rate4.Text);
            double sumFunt = Convert.ToDouble(sum4.Text);
            double rez = rateFunt * sumFunt;
            resSum4.Text = rez.ToString();
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            double valueD = Convert.ToDouble(value.Text);
            double rez = valueD*0.0254;
            result.Text = rez.ToString();
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            double valueWerst = Convert.ToDouble(value2.Text);
            double rez = valueWerst * 1066.8;
            result2.Text = rez.ToString();
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            double valueMili = Convert.ToDouble(value3.Text);
            double rez = valueMili* 1609.34;
            result3.Text = rez.ToString();
        }

        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            double valueFut = Convert.ToDouble(value4.Text);
            double rez = valueFut * 0.3048;
            result4.Text = rez.ToString();
        }

      
    }
    
}
