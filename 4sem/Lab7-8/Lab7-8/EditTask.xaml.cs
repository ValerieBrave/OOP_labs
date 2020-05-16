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
    /// Логика взаимодействия для EditTask.xaml
    /// </summary>
    public partial class EditTask : Window
    {
        Shedule shedule;
        TaskToDo taskToEdit = new TaskToDo();
        private int GetFreqIndex(String freq)
        {
            if (freq.Equals("Once")) return 0;
            else if (freq.Equals("Daily")) return 1;
            else if (freq.Equals("Weekly")) return 2;
            else if (freq.Equals("Monthly")) return 3;
            else return 4;
        }
        private int GetPrioIndex(String prio)
        {
            if (prio.Equals("super important")) return 0;
            else if (prio.Equals("important")) return 1;
            else if (prio.Equals("can wait")) return 2;
            else return 3;
        }
        private int GetCatIndex(String cat)
        {
            if (cat.Equals("HEALTH")) return 0;
            else if (cat.Equals("HOME")) return 1;
            else if (cat.Equals("STUDY")) return 2;
            else if (cat.Equals("RELAX")) return 3;
            else return 4;
        }
        private int GetStatIndex(String stat)
        {
            if (stat.Equals("Undone")) return 0;
            else if (stat.Equals("Done")) return 1;
            else return 2;
        }
        private void EditTask_loaded(object sender, RoutedEventArgs e)
        {
            this.taskName.Text = this.taskToEdit.Task;
            this.taskStart.Text= this.taskToEdit.Start.ToLongDateString();
            this.taskEnd.Text = this.taskToEdit.End.ToLongDateString();
            this.taskPrio.SelectedIndex = GetPrioIndex(taskToEdit.priority);
            this.taskFreq.SelectedIndex = GetFreqIndex(taskToEdit.frequency);
            this.taskCat.SelectedIndex = GetCatIndex(taskToEdit.cathegory);
            this.taskStat.SelectedIndex = GetStatIndex(taskToEdit.status);
            this.ExtraInfo.Text = taskToEdit.Description;
        }
        public EditTask()
        {
            InitializeComponent();
            Loaded += EditTask_loaded;
        }
        public EditTask(Shedule shed, TaskToDo ttd)
        {
            InitializeComponent();
            this.shedule = shed;
            this.taskToEdit = ttd;
            Loaded += EditTask_loaded;
        }

        private void taskName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!this.taskName.Text.Equals(""))
            {
                //this.taskToEdit.Task = this.taskName.Text;
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
            if (this.taskStart.Value.Value == null)
            {
                this.help_start.Text += "*";
                this.help_start.Foreground = new SolidColorBrush(Colors.Red);
                rc = false;
            }
            if (this.taskEnd.Value.Value == null)
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

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if(checkForm())
            {
                int rem = this.shedule.all_tasks.IndexOf(taskToEdit);
                
                this.shedule.all_tasks.RemoveAt(rem);
                TaskToDo ttd = new TaskToDo(this.taskName.Text, this.ExtraInfo.Text, this.taskStart.Value.Value, this.taskEnd.Value.Value,
                    this.taskPrio.Text, this.taskFreq.Text, this.taskStat.Text, this.taskCat.Text);
                this.shedule.all_tasks.Add(ttd);
                this.Close();
            }
        }
    }
}
