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

namespace WpfZadanie4
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
            double rateYuan = Convert.ToDouble(rate.Text);
            double sumYuan = Convert.ToDouble(sum.Text);
            double resDouble = rateYuan * sumYuan;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rate1Peso = Convert.ToDouble(rate1.Text);
            double sum1Peso = Convert.ToDouble(sum1.Text);
            double res1Double = rate1Peso * sum1Peso;
            resSum1.Text = res1Double.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rate2Yen = Convert.ToDouble(rate2.Text);
            double sum2Yen = Convert.ToDouble(sum2.Text);
            double resDouble = rate2Yen * sum2Yen;
            resSum2.Text = resDouble.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rate3Brahm = Convert.ToDouble(rate3.Text);
            double sum3Brahm = Convert.ToDouble(sum3.Text);
            double resDouble = rate3Brahm * sum3Brahm;
            resSum3.Text = resDouble.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double rate4Arshin = Convert.ToDouble(rate4.Text);
            double resDouble = rate4Arshin * 0.71;
            resSum4.Text = resDouble.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double rate5Sazhen = Convert.ToDouble(rate5.Text);
            double resDouble = rate5Sazhen * 2.13;
            resSum5.Text = resDouble.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double rate6Sazhen = Convert.ToDouble(rate6.Text);
            double resDouble = rate6Sazhen * 1066.8;
            resSum6.Text = resDouble.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double rate7Lokt = Convert.ToDouble(rate7.Text);
            double resDouble = rate7Lokt * 0.44;
            resSum7.Text = resDouble.ToString();
        }
    }
}
