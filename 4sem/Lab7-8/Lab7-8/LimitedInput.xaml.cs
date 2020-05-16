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

namespace Lab7_8.usercontrol
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class LimitedInput : UserControl
    {
        public static FrameworkPropertyMetadata metadata;
        public static readonly DependencyProperty TitleDep;
        public static readonly DependencyProperty LengDep;
        public static readonly DependencyProperty TextDep;
       

        static LimitedInput()
        {
            metadata = new FrameworkPropertyMetadata();
            metadata.CoerceValueCallback = new CoerceValueCallback(CorrectValue);
            TitleDep = DependencyProperty.Register("Title", typeof(string), typeof(LimitedInput));
            LengDep = DependencyProperty.Register("MaxLength", typeof(int), typeof(LimitedInput), metadata, new ValidateValueCallback(ValidateValue));
            TextDep = DependencyProperty.Register("Text", typeof(string), typeof(LimitedInput));
           
        }

        public LimitedInput()
        {
            InitializeComponent();
            this.DataContext = this;

        }

        private static bool ValidateValue(object value)
        {
            int currentValue = (int)value;
            if (currentValue >= 0) // если текущее значение от нуля и выше
                return true;
            return false;
        }

        private static object CorrectValue(DependencyObject d, object baseValue)
        {
            int currentValue = (int)baseValue;
            if (currentValue >= 140) return 140;
            return currentValue; // иначе возвращаем текущее значение
        }

        public string Title {
            get { return (string)GetValue(TitleDep);}
            set{ SetValue(TitleDep, value);}
        }
        public string Text
        {
            get { return (string)GetValue(TextDep);}
            set { SetValue(TextDep, value);}
        }
        public int MaxLength {
            get { return (int)GetValue(LengDep);}
            set { SetValue(LengDep, value); }
        }
    }
}
