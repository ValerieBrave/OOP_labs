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

namespace Lab7_8
{
    /// <summary>
    /// Логика взаимодействия для RoutedDemo.xaml
    /// </summary>
    public partial class RoutedDemo : Window
    {
        public RoutedDemo()
        {
            InitializeComponent();
        }

        private void routed_MouseDown(object sender, MouseButtonEventArgs e)
        {
            eventTrace.Text = eventTrace.Text + "sender: " + sender.ToString() + "\n";
            eventTrace.Text = eventTrace.Text + "source: " + e.Source.ToString() + "\n\n";
        }

        private void btn_cln_Click(object sender, RoutedEventArgs e)
        {
            eventTrace.Text = "";
        }

        private void attached_Click(object sender, RoutedEventArgs e)
        {
            eventTrace.Text = eventTrace.Text + "sender: " + sender.ToString()  + "\n";
            eventTrace.Text = eventTrace.Text + "source: " + e.Source .ToString()+ " "+((Button)e.Source).Height.ToString() +  "\n\n";
        }
    }
}
