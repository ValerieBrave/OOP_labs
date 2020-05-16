using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
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
using System.Globalization;

namespace Lab7_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            App.LanguageChanged += LanguageChanged;

            CultureInfo currLang = App.Language;
            
        }

        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;
        }

        public void MainWindowLoad(object sender, RoutedEventArgs e)
        {
           DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.txbStartDatetime.Text = DateTime.Now.ToLongDateString() + '\n' + DateTime.Now.ToLongTimeString();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            Shedule sh = new Shedule();
            sh.Show();
            this.Close();
        }

        private void btnChangeLang_Click(object sender, RoutedEventArgs e)
        {
            String curlang = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;
            if (curlang.Equals("en-US")) App.Language = new CultureInfo("ru-RU");
            else App.Language = new CultureInfo("en-US");
        }
    }
}
