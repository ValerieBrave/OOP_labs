using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab7_8
{
    public static class Command
    {
        private static readonly RoutedUICommand _doubleLength = new RoutedUICommand("double maxlength", "DoubleLength", typeof(Command));
        public static RoutedUICommand DoubleLength
        {
            get { return _doubleLength; }
        }
    }
}
