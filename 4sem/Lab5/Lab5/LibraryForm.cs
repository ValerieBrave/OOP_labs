using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Lab5
{
    public partial class LibraryForm : Form
    {
        List<Book> library;
        public LibraryForm()
        {
            InitializeComponent();
            library = new List<Book>();
            using (StreamReader sr = new StreamReader("library.json"))
            {
                string line = sr.ReadLine();
                while (line != null)
                {
                    Book bk = JsonConvert.DeserializeObject<Book>(line);
                    library.Add(bk);
                    line = sr.ReadLine();
                }
            }
            foreach(Book b in library)
            {
                this.all_books.Items.Add(b.ToString());
            }
        }

        private void au_search_Click(object sender, EventArgs e)
        {
            this.results.Items.Clear();
            if(!this.au_str.Text.Equals(""))
            {
                foreach(Book b in this.library)
                {
                    if (b.author.name.ToLower().Contains(this.au_str.Text.ToLower())) this.results.Items.Add(b.ToString());
                }
            }
        }

        private void format_search_Click(object sender, EventArgs e)
        {
            this.results.Items.Clear();
            if (this.formatUpDown.SelectedItem!=null)
            {
                string test = this.formatUpDown.SelectedItem.ToString();
                foreach (Book b in this.library)
                {
                    if (b.format.Equals(test)) this.results.Items.Add(b.ToString());
                }
            }
        }
    }
}
