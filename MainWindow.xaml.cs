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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!String.IsNullOrEmpty(rate.Text) && !String.IsNullOrEmpty(sum.Text))
            {
                double rateDollar = Convert.ToDouble(rate.Text);
                double sumDollar = Convert.ToDouble(sum.Text);
                double resDollar = rateDollar * sumDollar;
                resSum.Text = resDollar.ToString();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(eurrate.Text) && !String.IsNullOrEmpty(eursum.Text))
            {
                double rateEuro = Convert.ToDouble(eurrate.Text);
                double sumEuro = Convert.ToDouble(eursum.Text);
                double resEuro = rateEuro * sumEuro;
                eurresSum.Text = resEuro.ToString();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(grrate.Text) && !String.IsNullOrEmpty(grsum.Text))
            {
                double rateGrivn = Convert.ToDouble(grrate.Text);
                double sumGrivn = Convert.ToDouble(grsum.Text);
                double resGrivn = rateGrivn * sumGrivn;
                grresSum.Text = resGrivn.ToString();
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(drrate.Text) && !String.IsNullOrEmpty(drsum.Text))
            {
                double rateDr = Convert.ToDouble(drrate.Text);
                double sumDr = Convert.ToDouble(drsum.Text);
                double resDr = rateDr * sumDr;
                drresSum.Text = resDr.ToString();
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(kmamount.Text))
            {
                double kmAmount = Convert.ToDouble(kmamount.Text);
                double kmResult = kmAmount * 1000;
                kmresult.Text = kmResult.ToString();
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(cmamount.Text))
            {
                double cmAmount = Convert.ToDouble(cmamount.Text);
                double cmResult = cmAmount / 100;
                cmresult.Text = cmResult.ToString();
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(mmamount.Text))
            {
                double mmAmount = Convert.ToDouble(mmamount.Text);
                double mmResult = mmAmount / 1000;
                mmresult.Text = mmResult.ToString();
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(mileamount.Text))
            {
                double mileAmount = Convert.ToDouble(mileamount.Text);
                double mileResult = mileAmount * 1609;
                mileresult.Text = mileResult.ToString();
            }
        }
    }
}
