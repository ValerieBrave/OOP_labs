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
    /// Логика взаимодействия для Shedule.xaml
    /// </summary>
    public partial class Shedule : Window
    {
        public List<TaskToDo> all_tasks;
        List<TaskToDo> today;
        public Stack<TaskToDo> undo;
        public Stack<TaskToDo> redo;
        public Shedule()
        {
            InitializeComponent();
            all_tasks = new List<TaskToDo>();
            today = new List<TaskToDo>();
            undo = new Stack<TaskToDo>();
            redo = new Stack<TaskToDo>();
            using (StreamReader sr = new StreamReader("tasks.json"))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    TaskToDo ttd = JsonConvert.DeserializeObject<TaskToDo>(line);
                    this.all_tasks.Add(ttd);
                    line = sr.ReadLine();
                }
            }
            
            var tod = from a in all_tasks
                    where a.Start.Date == DateTime.Now.Date
                    select a;
            foreach (TaskToDo t in tod) today.Add(t);
            //foreach (TaskToDo t in today) this.todayTasks.Items.Add(t.ToString());
            this.todayTasks.ItemsSource = today;
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            FileStream fcreate = File.Open("tasks.json", FileMode.Create);
            using (StreamWriter sr = new StreamWriter(fcreate))
            {
                foreach(TaskToDo t in this.all_tasks)
                {
                    String ttd = JsonConvert.SerializeObject(t);
                    sr.WriteLine(ttd);
                }
            }
            fcreate.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddTask at = new AddTask(this);
            at.Show();
        }

        private void TaskCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            this.today.Clear();
            var tod = from a in all_tasks
                      where a.Start.Date == this.TaskCalendar.SelectedDate
                      select a;
            foreach (TaskToDo t in tod) today.Add(t);
            
            this.todayTasks.ItemsSource = today;
           
            this.todayTasks.Items.Refresh();
            
            this.todayTasks.SelectedIndex = 0;
        }

        private void todayTasks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.taskExtra.Text = "";
            if(this.todayTasks.SelectedItem != null) this.taskExtra.Text = ((TaskToDo)this.todayTasks.SelectedItem).Description;
            //if (!this.taskExtra.Text.Equals("")) this.taskExtra.Visibility = Visibility.Visible;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (this.todayTasks.SelectedItem != null)
            {
                int all_remove = this.all_tasks.IndexOf((TaskToDo)this.todayTasks.SelectedItem);
                int tod_remove = this.today.IndexOf((TaskToDo)this.todayTasks.SelectedItem);
                this.all_tasks.RemoveAt(all_remove);
                this.today.RemoveAt(tod_remove);
                this.todayTasks.Items.Refresh();
                this.todayTasks.SelectedIndex = 0;
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (this.todayTasks.SelectedItem != null)
            {
                EditTask et = new EditTask(this, (TaskToDo)this.todayTasks.SelectedItem);
                et.Show();
            } 
        }

        private void btnMono_Click(object sender, RoutedEventArgs e)
        {
            this.Style = (Style)this.TryFindResource("Monochrome_win");
            this.todayTasks.Style = (Style)this.TryFindResource("Monochrome_listbox");
            this.taskExtra.Style = (Style)this.TryFindResource("Monochrome_textbox");
            this.btnAdd.Style = (Style)this.TryFindResource("Monochrome_btn");
            this.btnDelete.Style = (Style)this.TryFindResource("Monochrome_btn");
            this.btnEdit.Style = (Style)this.TryFindResource("Monochrome_btn");
        }

        private void btnNorm_Click(object sender, RoutedEventArgs e)
        {
            this.Style = (Style)this.TryFindResource("Normal_win");
            this.todayTasks.Style = (Style)this.TryFindResource("Normal_listbox");
            this.taskExtra.Style = (Style)this.TryFindResource("Normal_textbox");
            this.btnAdd.Style = (Style)this.TryFindResource("Normal_btn");
            this.btnDelete.Style = (Style)this.TryFindResource("Normal_btn");
            this.btnEdit.Style = (Style)this.TryFindResource("Normal_btn");
        }

        private void btnDark_Click(object sender, RoutedEventArgs e)
        {
            this.Style = (Style)this.TryFindResource("Dark_win");
            this.todayTasks.Style = (Style)this.TryFindResource("Dark_listbox");
            this.taskExtra.Style = (Style)this.TryFindResource("Dark_textbox");
            this.btnAdd.Style = (Style)this.TryFindResource("Dark_btn");
            this.btnDelete.Style = (Style)this.TryFindResource("Dark_btn");
            this.btnEdit.Style = (Style)this.TryFindResource("Dark_btn");
        }

        private void btn_Undo_Click(object sender, RoutedEventArgs e)
        {
            if(this.undo.Count != 0)
            {
                int all_remove = this.all_tasks.IndexOf(this.undo.Peek());
                int today_remove = this.today.IndexOf(this.undo.Peek());
                this.redo.Push(this.undo.Peek());
                this.undo.Pop();
                this.all_tasks.RemoveAt(all_remove);
                if (today_remove != -1) this.today.RemoveAt(today_remove);
                this.todayTasks.Items.Refresh();
                this.todayTasks.SelectedIndex = 0;
            }
        }

        private void btn_Redo_Click(object sender, RoutedEventArgs e)
        {
            if(this.redo.Count != 0)
            {
                this.all_tasks.Add(this.redo.Peek());
                if (this.redo.Peek().Start.Date == this.TaskCalendar.SelectedDate) this.today.Add(this.redo.Peek());
                this.undo.Push(this.redo.Peek());
                this.redo.Pop();
                this.todayTasks.Items.Refresh();
                this.todayTasks.SelectedIndex = 0;
            }
        }
    }
}
