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
using System.Text.RegularExpressions;

namespace Lab6
{
    public enum SEARCH { AU = 1, TIT = 2, PUB = 3, AUR = 4, TITR = 5, PUBR = 6 };
    public partial class LibraryForm : Form
    {
        List<Book> library;
        List<Book> forsave;
        public SEARCH src;
        public LibraryForm()
        {
            InitializeComponent();
            library = new List<Book>();
            forsave = new List<Book>();
            src = SEARCH.AU;
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
            foreach (Book b in library)
            {
                this.all_books.Items.Add(b.ToString());
            }
            this.allfiles_label.Text += this.library.Count.ToString();
            this.search_textbox.Enabled = false;
            this.search.Enabled = false;
        }

        private void au_searchToolStrip_Click(object sender, EventArgs e)
        {
            this.search_textbox.Enabled = true;
            this.search.Enabled = true;
            this.results.Items.Clear();
            this.src = SEARCH.AU;
        }

        private void tit_searchToolStrip_Click(object sender, EventArgs e)
        {
            this.search_textbox.Enabled = true;
            this.search.Enabled = true;
            this.results.Items.Clear();
            this.src = SEARCH.TIT;
        }

        private void pub_searchToolStrip_Click(object sender, EventArgs e)
        {
            this.search_textbox.Enabled = true;
            this.search.Enabled = true;
            this.results.Items.Clear();
            this.src = SEARCH.PUB;
        }

        private void au_regToolStrip_Click(object sender, EventArgs e)
        {
            this.search_textbox.Enabled = true;
            this.search.Enabled = true;
            this.results.Items.Clear();
            this.src = SEARCH.AUR;
        }

        private void tit_regToolStrip_Click(object sender, EventArgs e)
        {
            this.search_textbox.Enabled = true;
            this.search.Enabled = true;
            this.results.Items.Clear();
            this.src = SEARCH.TITR;
        }

        private void pub_regToolStrip_Click(object sender, EventArgs e)
        {
            this.search_textbox.Enabled = true;
            this.search.Enabled = true;
            this.results.Items.Clear();
            this.src = SEARCH.PUBR;
        }

        private void search_Click(object sender, EventArgs e)
        {
            this.results.Items.Clear();
            this.forsave.Clear();
            switch(this.src)
            {
                case SEARCH.AU:
                    {
                        if (!this.search_textbox.Text.Equals(""))
                        {
                            foreach (Book b in this.library)
                            {
                                if (b.author.name.ToLower().Contains(this.search_textbox.Text.ToLower()))
                                {
                                    this.results.Items.Add(b.ToString());
                                    this.forsave.Add(b);
                                }
                            }
                        }
                    }
                    break;
                case SEARCH.AUR:
                    {
                        if (!this.search_textbox.Text.Equals(""))
                        {
                            foreach (Book b in this.library)
                            {
                                if(Regex.IsMatch(b.author.name, this.search_textbox.Text))
                                {
                                    this.results.Items.Add(b.ToString());
                                    this.forsave.Add(b);
                                }
                            }
                        }
                    }
                    break;
                case SEARCH.PUB:
                    {
                        if (!this.search_textbox.Text.Equals(""))
                        {
                            foreach (Book b in this.library)
                            {
                                if (b.publishers.ToLower().Contains(this.search_textbox.Text.ToLower()))
                                {
                                    this.results.Items.Add(b.ToString());
                                    this.forsave.Add(b);
                                }
                            }
                        }
                    }
                    break;
                case SEARCH.PUBR:
                    {
                        if (!this.search_textbox.Text.Equals(""))
                        {
                            foreach (Book b in this.library)
                            {
                                if (Regex.IsMatch(b.publishers, this.search_textbox.Text))
                                {
                                    this.results.Items.Add(b.ToString());
                                    this.forsave.Add(b);
                                }
                            }
                        }
                    }
                    break;
                case SEARCH.TIT:
                    {
                        if (!this.search_textbox.Text.Equals(""))
                        {
                            foreach (Book b in this.library)
                            {
                                if (b.title.ToLower().Contains(this.search_textbox.Text.ToLower()))
                                {
                                    this.results.Items.Add(b.ToString());
                                    this.forsave.Add(b);
                                }
                            }
                        }
                    }
                    break;
                case SEARCH.TITR:
                    {
                        if (!this.search_textbox.Text.Equals(""))
                        {
                            foreach (Book b in this.library)
                            {
                                if (Regex.IsMatch(b.title, this.search_textbox.Text))
                                {
                                    this.results.Items.Add(b.ToString());
                                    this.forsave.Add(b);
                                }
                            }
                        }
                    }
                    break;
            }
        }

        private void au_sortToolStrip_Click(object sender, EventArgs e)
        {
            this.results.Items.Clear();
            this.forsave.Clear();
            List<Book> sorted = new List<Book>(this.library);
            sorted.Sort(new AuthorComparer());
            foreach(Book b in sorted)
            {
                this.results.Items.Add(b.ToString());
                this.forsave.Add(b);
            }
        }

        private void tit_sortToolStrip_Click(object sender, EventArgs e)
        {
            this.results.Items.Clear();
            this.forsave.Clear();
            List<Book> sorted = new List<Book>(this.library);
            sorted.Sort(new TitleComparer());
            foreach (Book b in sorted)
            {
                this.results.Items.Add(b.ToString());
                this.forsave.Add(b);
            }
        }

        private void save_ToolStrip_Click(object sender, EventArgs e)
        {
            if(this.results.Items.Count !=0)
            {
                using (StreamWriter sw = new StreamWriter("search.json", true))
                {
                    foreach(Book b in this.forsave)
                    {
                        string bo = JsonConvert.SerializeObject(b);
                        sw.WriteLine(bo);
                    }
                }
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About ab = new About();
            ab.ShowDialog();
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            ControlExtension.Draggable(this.drag_tool, true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
}
