using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    [Serializable]
    public class Author
    {
        public static int ID;
        public int id;
        public string name;
        public string country;
        public Author()
        {
            this.id = Author.ID++;
            this.name = "";
            this.country = "";
        }
        public Author(string nm, string c)
        {
            this.id = Author.ID++;
            this.name = nm;
            this.country = c;
        }
    }
    [Serializable]
    public class Book
    {
        public string format;
        public float file_size;
        public string size_format;
        public string title;
        public int pages;
        public string publishers;
        public DateTime upload;
        public Author author;
        public Book()
        {
            this.author = new Author();
            this.upload = DateTime.Now;
        }
        public override string ToString()
        {
            return "'" + this.title + "', " + this.author.name + ", " + this.pages.ToString()
                + ", " + this.file_size.ToString() + this.size_format + ", " + this.format
                + ", " + this.upload.ToString();
        }
    }
}
