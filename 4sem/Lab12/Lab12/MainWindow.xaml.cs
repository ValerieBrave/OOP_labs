using Lab12.Model;
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

namespace Lab12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public enum CURRENT { BOOKS =1, AUTHORS =2, FILES =3};
    public partial class MainWindow : Window
    {
        UnitOfWork uow = new UnitOfWork();
        dbContext db;
        BasicRepo<Book> bookrepo;
        BasicRepo<Author> authrepo;
        BasicRepo<File> filerepo;
        CURRENT state;
        public MainWindow()
        {
            InitializeComponent();
            db = uow.db;
            //bookrepo = new BasicRepo<Book>(db);
            //authrepo = new BasicRepo<Author>(db);
            //filerepo = new BasicRepo<File>(db);
            bookrepo = uow.BookRepository;
            authrepo = uow.AuthorRepository;
            filerepo = uow.FileRepository;
            state = CURRENT.BOOKS;
            FillList();
            FillForm();
        }
        private void btnUP_Click(object sender, RoutedEventArgs e)
        {
            this.listview.SelectedIndex = this.listview.SelectedIndex == 0 ? 0 : this.listview.SelectedIndex - 1;
        }
        private void btnDOWN_Click(object sender, RoutedEventArgs e)
        {
            this.listview.SelectedIndex = this.listview.SelectedIndex == this.listview.Items.Count - 1 ? this.listview.SelectedIndex : this.listview.SelectedIndex + 1;
        }
        private void FillList()
        {
            try
            {
                switch (this.state)
                {
                    case CURRENT.BOOKS:
                        {
                            this.listview.Items.Clear();
                            //var books = from b in db.Books select b;
                            List<Book> books = bookrepo.GetAll();
                            foreach (Book b in books) this.listview.Items.Add(b);
                        }
                        break;
                    case CURRENT.AUTHORS:
                        {
                            this.listview.Items.Clear();
                            //var authors = from a in db.Authors select a;
                            List<Author> authors = authrepo.GetAll();
                            foreach (Author a in authors) this.listview.Items.Add(a);
                        }
                        break;
                    case CURRENT.FILES:
                        {
                            this.listview.Items.Clear();
                            //var files = from f in db.Files select f;
                            List<File> files = filerepo.GetAll();
                            foreach (File f in files) this.listview.Items.Add(f);
                        }
                        break;
                }
            }
            catch(Exception ex)
            {
                this.errors.Text = ex.Message + '\n' + this.errors.Text;
            }
        }
        private void FillForm()
        {
            //var authors = from a in db.Authors select a;
            List<Author> authors = authrepo.GetAll();
            this.auth_select.Items.Clear();
            foreach (Author a in authors) this.auth_select.Items.Add(a);
            this.auth_select.SelectedIndex = 1;
            //-----------
            //var files = from f in db.Files select f;
            List<File> files = filerepo.GetAll();
            this.file_select.Items.Clear();
            foreach (File f in files) this.file_select.Items.Add(f);
            this.file_select.SelectedIndex = 1;
        }
        private void btn_Show(object sender, RoutedEventArgs e)
        {
            try
            {
                switch(Int32.Parse(((Button)sender).Tag.ToString()))
                {
                    case 1:
                        {
                            this.state = CURRENT.BOOKS;
                            FillList();
                        }break;
                    case 2:
                        {
                            this.state = CURRENT.AUTHORS;
                            FillList();
                        }break;
                    case 3:
                        {
                            this.state = CURRENT.FILES;
                            FillList();
                        }break;
                }
            }
            catch (Exception ex)
            {
                this.errors.Text = ex.Message + '\n' + this.errors.Text;
            }
        }

        private void btn_sort_pages_Click(object sender, RoutedEventArgs e)
        {
            if(state == CURRENT.BOOKS)
            {
                this.listview.Items.Clear();
                var sorted = from b in db.Books
                             orderby b.pages
                             select b;
                foreach (Book b in sorted) this.listview.Items.Add(b);
            }
        }

        private void btn_sort_year_Click(object sender, RoutedEventArgs e)
        {
            if (state == CURRENT.BOOKS)
            {
                this.listview.Items.Clear();
                var sorted = from b in db.Books
                             orderby b.year
                             select b;
                foreach (Book b in sorted) this.listview.Items.Add(b);
            }
        }

        private void btn_sort_title_Click(object sender, RoutedEventArgs e)
        {
            if (state == CURRENT.BOOKS)
            {
                this.listview.Items.Clear();
                var sorted = from b in db.Books
                             orderby b.title
                             select b;
                foreach (Book b in sorted) this.listview.Items.Add(b);
            }
        }

        private void btn_Del_Click(object sender, RoutedEventArgs e)
        {
            if(this.listview.SelectedIndex != -1)
            {
                try
                {
                    switch (state)
                    {
                        case CURRENT.BOOKS:
                            {
                                //Book to_del = db.Books.Find(((Book)this.listview.SelectedItem).title);
                                Book to_del = bookrepo.GetById(((Book)this.listview.SelectedItem).title);
                                //db.Books.Remove(to_del);
                                bookrepo.Delete(to_del.title);
                                //db.SaveChanges();
                                FillList();
                            }
                            break;
                        case CURRENT.AUTHORS:
                            {
                                //Author to_del = db.Authors.Find(((Author)this.listview.SelectedItem).FIO);
                                Author to_del = authrepo.GetById(((Author)this.listview.SelectedItem).FIO);
                                //db.Authors.Remove(to_del);
                                authrepo.Delete(to_del.FIO);
                                //db.SaveChanges();
                                FillList();
                                FillForm();
                            }break;
                        case CURRENT.FILES:
                            {
                                //File to_del = db.Files.Find(((File)this.listview.SelectedItem).file_id);
                                File to_del = filerepo.GetById(((File)this.listview.SelectedItem).file_id);
                                //db.Files.Remove(to_del);
                                filerepo.Delete(to_del.file_id);
                                //db.SaveChanges();
                                FillList();
                                FillForm();
                            }
                            break;
                    }
                }
                catch (Exception ex)
                {
                    this.errors.Text = ex.Message + '\n' + this.errors.Text;
                }
            }
            
        }

        private void search_field_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                switch (state)
                {
                    case CURRENT.BOOKS:
                        {
                            string query = "select * from Books where title like '%" + this.search_field.Text + "%'";
                            var books = db.Database.SqlQuery<Book>(query);
                            this.listview.Items.Clear();
                            foreach (Book b in books) this.listview.Items.Add(b);
                        }
                        break;
                    case CURRENT.AUTHORS:
                        {
                            string query = "select * from Authors where FIO like '%" + this.search_field.Text + "%'";
                            var authors = db.Database.SqlQuery<Author>(query);
                            this.listview.Items.Clear();
                            foreach (Author a in authors) this.listview.Items.Add(a);
                        }
                        break;
                    case CURRENT.FILES:
                        {
                            string query = "select * from Files where file_id like '%" + this.search_field.Text + "%'";
                            var files = db.Database.SqlQuery<File>(query);
                            this.listview.Items.Clear();
                            foreach (File f in files) this.listview.Items.Add(f);
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                this.errors.Text = ex.Message + '\n' + this.errors.Text;
            }
        }

        private bool CheckForm()
        {
            bool rc = true;
            if (this.title_select.Text.Equals(""))
            {
                rc = false;
                this.errors.Text = "Нет названия" + '\n' + this.errors.Text;
            }
            int p, y;
            if (!int.TryParse(this.pages_select.Text, out p))
            {
                rc = false;
                this.errors.Text = "Плохие страницы" + '\n' + this.errors.Text;
            }
            if (int.TryParse(this.year_select.Text, out y))
            {
                if (y > 2020 || y < 1500)
                {
                    rc = false;
                    this.errors.Text = "Плохой год" + '\n' + this.errors.Text;
                }
            }
            else
            {
                rc = false;
                this.errors.Text = "Плохой год" + '\n' + this.errors.Text;
            }
            return rc;
        }

        private void btn_AddBook_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(CheckForm())
                {
                    Book bk = new Book();
                    bk.title = this.title_select.Text;
                    bk.author = ((Author)this.auth_select.SelectedItem).FIO;
                    bk.file_id = ((File)this.file_select.SelectedItem).file_id;
                    int p, y;
                    int.TryParse(this.pages_select.Text, out p);
                    int.TryParse(this.year_select.Text, out y);
                    bk.pages = p;
                    bk.year = y;
                    //db.Books.Add(bk);
                    //db.SaveChanges();
                    bookrepo.Create(bk);
                    FillList();
                }
            }
            catch (Exception ex)
            {
                this.errors.Text = ex.Message + '\n' + this.errors.Text;
            }
        }

        private void btn_AddAu_Click(object sender, RoutedEventArgs e)
        {
            if (!this.fio_select.Text.Equals("") && !this.country_select.Text.Equals(""))
            {
                Author au = new Author();
                au.FIO = this.fio_select.Text;
                au.country = this.country_select.Text;
                //db.Authors.Add(au);
                //db.SaveChanges();
                authrepo.Create(au);
                FillForm();
            }
        }

        private void btn_AddFi_Click(object sender, RoutedEventArgs e)
        {
            int size;
            if (!this.fileid_select.Text.Equals("") &&
                this.format_select.SelectedIndex != -1 &&
                int.TryParse(this.filesize_select.Text, out size))
            {
                File file = new File();
                file.file_id = this.fileid_select.Text;
                file.file_size = size;
                file.format = ((ComboBoxItem)this.format_select.Items[this.format_select.SelectedIndex]).Content.ToString();
                //db.Files.Add(file);
                //db.SaveChanges();
                filerepo.Create(file);
                FillForm();
            }
        }
    }
}
