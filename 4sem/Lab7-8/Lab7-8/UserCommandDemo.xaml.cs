using Lab7_8.usercontrol;
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
    /// Логика взаимодействия для UserCommandDemo.xaml
    /// </summary>
    public partial class UserCommandDemo : Window
    {
        public UserCommandDemo()
        {
            InitializeComponent();
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.liminp.MaxLength = (int)e.Parameter * 2;
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
            //if (this.liminp.Text == null) e.Handled = false;
            //else if (this.liminp.Text.Length == this.liminp.MaxLength) e.Handled = true;
            //e.Handled = true;
        }
    }
}
