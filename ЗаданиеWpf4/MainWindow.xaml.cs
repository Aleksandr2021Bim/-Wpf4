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

namespace ЗаданиеWpf4
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
            double dollarCurs = Convert.ToDouble(dollar.Text);
            double sumRubl = Convert.ToDouble(sum.Text);
            double resDoubl = dollarCurs * sumRubl;
            dolSum.Text = resDoubl.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double evroCurs = Convert.ToDouble(evro.Text);
            double sumRubl2 = Convert.ToDouble(sum2.Text);
            double resDoubl2 = evroCurs * sumRubl2;
            evroSum.Text = resDoubl2.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double yuanCurs = Convert.ToDouble(yuan.Text);
            double sumRubl3 = Convert.ToDouble(sum3.Text);
            double resDoubl3 = yuanCurs * sumRubl3;
            yuanSum.Text = resDoubl3.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double francCurs = Convert.ToDouble(franc.Text);
            double sumRubl4 = Convert.ToDouble(sum4.Text);
            double resDoubl4 = francCurs * sumRubl4;
            francSum.Text = resDoubl4.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double inchTrans = Convert.ToDouble(inch.Text);
            double transDoubl = inchTrans * 25 / 1000;
            translation.Text = transDoubl.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double futTrans = Convert.ToDouble(fut.Text);
            double transDoubl2 = futTrans * 3048 / 10000;
            translation2.Text = transDoubl2.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double miljTrans = Convert.ToDouble(milj.Text);
            double transDoubl3 = miljTrans * 160934 / 100000;
            translation3.Text = transDoubl3.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double verstaTrans = Convert.ToDouble(versta.Text);
            double transDoubl4 = verstaTrans * 10668 / 10000;
            translation4.Text = transDoubl4.ToString();
        }
    }
}
