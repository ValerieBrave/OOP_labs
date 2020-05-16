using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Lab5
{
    public partial class AddForm : Form
    {
        public string author_name;
        public string author_country;
        //--------------------------
        public string book_format;
        public float book_file_size;
        public string book_size_format;
        public string book_title;
        public int pages;
        public string publishers;
        DateTime upload;
        public AddForm()
        {
            InitializeComponent();
            
        }

        private void title_TextChanged(object sender, EventArgs e)
        {
            this.AddBook.Enabled = true;
            if (!this.title.Text.Equals(""))
            {
                this.help_title.Text = "";
                this.book_title = this.title.Text;
            } 
            else this.help_title.Text = "Введите название";
        }
        
        private void pages_bar_ValueChanged(object sender, EventArgs e)
        {
            this.pages_lable.Text = this.pages_bar.Value.ToString();
        }

        private void size_format_CheckedChanged(object sender, EventArgs e)
        {
            this.book_size_format = "Гб";
            if (((RadioButton)sender).Name.Equals("GB")) this.book_size_format = "Гб";
            else if(((RadioButton)sender).Name.Equals("MB")) this.book_size_format = "Мб";
            else if (((RadioButton)sender).Name.Equals("KB")) this.book_size_format = "Кб";
            else if (((RadioButton)sender).Name.Equals("B")) this.book_size_format = "б";
        }

        private void pages_bar_Scroll(object sender, EventArgs e)
        {
            this.pages = ((TrackBar)sender).Value;
        }

        
        private void filesize_TextChanged(object sender, EventArgs e)
        {
            this.AddBook.Enabled = true;
            if(!this.filesize.Text.Equals(""))
            {
                float x;
                if (float.TryParse(this.filesize.Text, out x))
                {
                    this.book_file_size = x;
                    this.size_help.Text = "";
                }
                else this.size_help.Text = "Плохой размер";
            }
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.book_format = "Гб";
            int iSelectedIndex = checkedListBox1.SelectedIndex;
            if (iSelectedIndex == -1)
                return;
            for (int iIndex = 0; iIndex < checkedListBox1.Items.Count; iIndex++)
                checkedListBox1.SetItemCheckState(iIndex, CheckState.Unchecked);
            checkedListBox1.SetItemCheckState(iSelectedIndex, CheckState.Checked);
            this.book_format=this.checkedListBox1.SelectedItem.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.AddBook.Enabled = true;
            if (this.dateTimePicker1.Value <= DateTime.Now)
            {
                this.upload_help.Text = "";
                this.upload = this.dateTimePicker1.Value;
            }
            else this.upload_help.Text = "Плохая дата";
        }

        private void publisher_TextChanged(object sender, EventArgs e)
        {
            this.AddBook.Enabled = true;
            if (!this.publisher.Text.Equals(""))
            {
                this.publishers = this.publisher.Text;
                this.pub_help.Text = "";
            } 
            else this.pub_help.Text = "Введите издательство";
        }
       
        private void auth_TextChanged(object sender, EventArgs e)
        {
            this.AddBook.Enabled = true;
            if (!this.auth.Text.Equals(""))
            {
                this.author_name = this.auth.Text;
                this.auth_help.Text = "";
            } 
            else this.auth_help.Text = "Введите имя автора";
        }
        private void country_TextChanged(object sender, EventArgs e)
        {
            this.AddBook.Enabled = true;
            if (!this.country.Text.Equals(""))
            {
                this.author_country = this.country.Text;
                this.country_help.Text = "";
            }
            else this.country_help.Text = "Введите страну автора";
        }
        public bool Check_form()
        {
            bool rc = true;
            if (this.title.Text.Equals(""))
            {
                this.help_title.Text = "Это поле обязательное";
                this.AddBook.Enabled = false;
                rc = false;
            }
            if (this.publisher.Text.Equals(""))
            {
                this.pub_help.Text = "Это поле обязательное";
                this.AddBook.Enabled = false;
                rc = false;
            }
            if (this.filesize.Text.Equals(""))
            {
                this.size_help.Text = "Это поле обязательное";
                this.AddBook.Enabled = false;
                rc = false;
            }
            if(this.checkedListBox1.SelectedItems.Count == 0)
            {
                this.format_help.Text = "Это поле обязательное";
                this.AddBook.Enabled = false;
                rc = false;
            }
            if(this.dateTimePicker1.Value == null)
            {
                this.upload_help.Text = "Это поле обязательное";
                this.AddBook.Enabled = false;
                rc = false;
            }
            if(this.auth.Text.Equals(""))
            {
                this.auth_help.Text = "Это поле обязательное";
                this.AddBook.Enabled = false;
                rc = false;
            }
            if (this.country.Text.Equals(""))
            {
                this.country_help.Text = "Это поле обязательное";
                this.AddBook.Enabled = false;
                rc = false;
            }
            return rc;
        }
        public void CleanUp()
        {
            this.title.Text = "";
            this.help_title.Text = "";
            this.auth.Text = "";
            this.auth_help.Text = "";
            this.country.Text = "";
            this.country_help.Text = "";
            this.publisher.Text = "";
            this.pub_help.Text = "";
            this.filesize.Text = "";
            this.size_help.Text = "";
            this.pages_bar.Value = 1;
        }
        private void AddBook_Click(object sender, EventArgs e)
        {
            if(this.Check_form())
            {
                using (StreamWriter sw = new StreamWriter("library.json", true))
                {
                    Author au = new Author(this.author_name, this.author_country);
                    Book bk = new Book();
                    bk.title = this.book_title;
                    bk.pages = this.pages;
                    bk.publishers = this.publishers;
                    bk.file_size = this.book_file_size;
                    bk.format = this.book_format;
                    bk.size_format = this.book_size_format;
                    bk.upload = this.upload;
                    bk.author = au;
                    string newbk = JsonConvert.SerializeObject(bk);
                    sw.WriteLine(newbk);
                }
                this.CleanUp();
            }
        }

        private void clean_Click(object sender, EventArgs e)
        {
            this.CleanUp();
        }

        private void escape_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
