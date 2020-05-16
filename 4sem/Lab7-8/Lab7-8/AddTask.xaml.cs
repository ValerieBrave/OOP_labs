using System;
using System.Collections.Generic;
using System.IO;
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
using Newtonsoft.Json;

namespace Lab7_8
{
    /// <summary>
    /// Логика взаимодействия для AddTask.xaml
    /// </summary>
    public partial class AddTask : Window
    {
        public String Task { get; set; }
        public String Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        //-----------------------
        public String priority { get; set; }
        public String frequency { get; set; }
        public String status { get; set; }
        public String cathegory { get; set; }
        private Shedule shedwin;
        //---------------------
        
        public AddTask()
        {
            InitializeComponent();
        }
        public AddTask(Shedule shed)
        {
            InitializeComponent();
            this.shedwin = shed;

        }

        private void taskName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!this.taskName.Text.Equals(""))
            {
                this.Task = this.taskName.Text;
                this.name_label.Foreground = new SolidColorBrush(Color.FromRgb(0, 81, 255));
            }
            else
            {
                this.name_label.Foreground = new SolidColorBrush(Colors.Red);
                this.name_label.Text += "*";
            }
        }

        public bool checkForm()
        {
            bool rc = true;
            if(this.taskStart.Value == null)
            {
                this.help_start.Text += "*";
                this.help_start.Foreground = new SolidColorBrush(Colors.Red);
                rc = false;
            }
            if (this.taskEnd.Value == null)
            {
                this.help_end.Text += "*";
                this.help_end.Foreground = new SolidColorBrush(Colors.Red);
                rc = false;
            }
            if (this.taskPrio.SelectedIndex == -1)
            {
                this.help_prio.Text += "*";
                this.help_prio.Foreground = new SolidColorBrush(Colors.Red);
                rc = false;
            }
            if (this.taskFreq.SelectedIndex == -1)
            {
                this.help_freq.Text += "*";
                this.help_freq.Foreground = new SolidColorBrush(Colors.Red);
                rc = false;
            }
            if (this.taskStat.SelectedIndex == -1)
            {
                this.help_stat.Text += "*";
                this.help_stat.Foreground = new SolidColorBrush(Colors.Red);
                rc = false;
            }
            return rc;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if(this.checkForm())
            {
                TaskToDo ttd = new TaskToDo(this.taskName.Text, this.ExtraInfo.Text, this.taskStart.Value.Value, this.taskEnd.Value.Value,
                    this.taskPrio.Text, this.taskFreq.Text, this.taskStat.Text, this.taskCat.Text);
                using (StreamWriter sw = new StreamWriter("tasks.json", true))
                {
                    string newttd = JsonConvert.SerializeObject(ttd);
                    sw.WriteLine(newttd);
                }
                this.shedwin.all_tasks.Add(ttd);
                this.shedwin.undo.Push(ttd);
                this.Close();
            }
        }
    }
}
