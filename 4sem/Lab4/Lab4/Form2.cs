using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form2 : Form
    {
        public List<Employee> collection;
        public Form2()
        {
            InitializeComponent();
            this.collection = new List<Employee>();
        }
        
        private void size_input(object sender, KeyPressEventArgs e)
        {
            this.size_message.Text = "";
            this.collection_basic.Items.Clear();
            this.sorted_col.Items.Clear();
            if (((KeyPressEventArgs)e).KeyChar == (char)Keys.Enter)
            {
                int x;
                Random random = new Random();
                if (int.TryParse(this.col_size.Text, out x) && x > 0)
                {
                    this.collection = new List<Employee>(x);
                    for (int i = 0; i < x; i++)
                    {
                        this.collection.Add(new Employee(i, random.Next(20, 60), random.Next(2, 30)));
                        this.collection_basic.Items.Add(this.collection[this.collection.Count - 1].ToString());
                    }
                }
                else
                {
                    this.size_message.Text = "Плохой размер!";
                }
            }
        }

        private void sortAsc_Click(object sender, EventArgs e)
        {
            this.sorted_col.Items.Clear();
            if(this.collection.Count != 0)
            {
                List<Employee> sorted = new List<Employee>(this.collection);
                sorted.Sort(new EmployeeComparer());
                foreach (Employee em in sorted) this.sorted_col.Items.Add(em.ToString());
            }
        }

        private void age_sort_Click(object sender, EventArgs e)
        {
            this.sorted_col.Items.Clear();
            if (this.collection.Count != 0)
            {
                List<Employee> sorted = new List<Employee>(this.collection);
                sorted.Sort(new EmployeeAgeComparer());
                foreach (Employee em in sorted) this.sorted_col.Items.Add(em.ToString());
            }
        }

        private void newEmps_Click(object sender, EventArgs e)
        {
            this.sorted_col.Items.Clear();
            if (this.collection.Count != 0)
            {
                var newem = this.collection.Where(m => m.stage < 5);
                foreach(Employee m in newem) this.sorted_col.Items.Add(m.ToString());
            }
        }

        private void experts_Click(object sender, EventArgs e)
        {
            this.sorted_col.Items.Clear();
            if (this.collection.Count != 0)
            {
                var newem = this.collection.Where(m => m.stage > 10);
                foreach (Employee m in newem) this.sorted_col.Items.Add(m.ToString());
            }
        }

        private void youngsters_Click(object sender, EventArgs e)
        {
            this.sorted_col.Items.Clear();
            if (this.collection.Count != 0)
            {
                var newem = this.collection.Where(m => m.age < 35);
                foreach (Employee m in newem) this.sorted_col.Items.Add(m.ToString());
            }
        }
    }
}
