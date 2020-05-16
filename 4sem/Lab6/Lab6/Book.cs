using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Lab6
{
    public class AuthorAttribute : ValidationAttribute
    {
        Regex valid_author = new Regex(@"^\w.\w*$");
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                if (Regex.IsMatch(value.ToString(), this.valid_author.ToString())) return true;
                else this.ErrorMessage = "Введите автора согласно шаблону: И.Фамилия";
            }
            return false;
        }
    }


    [Serializable]
    public class Author
    {
        public static int ID;
        public int id;
        [AuthorAttribute]
        public string name { get; set; }
        [Required(ErrorMessage = "Страна автора не установлена", AllowEmptyStrings = false)]
        public string country { get; set; }
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
        [Required(ErrorMessage = "Установите формат", AllowEmptyStrings = false)]
        public string format { get; set; }
        [Required]
        [Range(1, 1024, ErrorMessage = "Установите размер файла")]
        public float file_size { get; set; }
        [Required(ErrorMessage = "Установите единицы измерения размера")]
        public string size_format { get; set; }
        [Required(ErrorMessage = "Укажите название", AllowEmptyStrings = false)]
        public string title { get; set; }
        [Required]
        public int pages { get; set; }
        [Required(ErrorMessage = "Заполните поле издательства", AllowEmptyStrings = false)]
        public string publishers { get; set; }
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
    public class AuthorComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return String.Compare(x.author.name, y.author.name);
        }
    }
    public class TitleComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return String.Compare(x.title, y.title);
        }
    }
}
