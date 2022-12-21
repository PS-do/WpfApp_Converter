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

namespace WpfApp_Converter
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

        string ConvertValut(string rate,string sum)
        {
            return Convert.ToString(Convert.ToDouble(rate) * Convert.ToDouble(sum));
        }
        string ConvertL(string L, double k)
        {
            return Convert.ToString(Convert.ToDouble(L) * k);
        }

        private void Button_d_Click(object sender, RoutedEventArgs e)
        {    
            d_resSum.Text = ConvertValut(d_rate.Text,d_sum.Text);
        }
        private void Button_e_Click(object sender, RoutedEventArgs e)
        {
            e_resSum.Text = ConvertValut(e_rate.Text, e_sum.Text);
        }
        private void Button_g_Click(object sender, RoutedEventArgs e)
        {
            g_resSum.Text = ConvertValut(g_rate.Text, g_sum.Text);
        }
        private void Button_dr_Click(object sender, RoutedEventArgs e)
        {
            dr_resSum.Text = ConvertValut(dr_rate.Text, dr_sum.Text);
        }

        private void Button_inch_Click(object sender, RoutedEventArgs e)
        {
            inch_res.Text = ConvertL(inch_L.Text, 0.0254);
        }
        private void Button_foot_Click(object sender, RoutedEventArgs e)
        {
            foot_res.Text = ConvertL(foot_L.Text, 0.3048);
        }
        private void Button_mile_Click(object sender, RoutedEventArgs e)
        {
            mile_res.Text = ConvertL(mile_L.Text, 1609.0);
        }
        private void Button_verst_Click(object sender, RoutedEventArgs e)
        {
            verst_res.Text = ConvertL(verst_L.Text, 1066.8);
        }
    }
}
