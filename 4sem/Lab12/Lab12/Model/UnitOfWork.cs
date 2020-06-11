using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12.Model
{
    public class UnitOfWork: IDisposable
    {
        public dbContext db = new dbContext();
        private BasicRepo<Book> bookrepo;
        private BasicRepo<Author> authrepo;
        private BasicRepo<File> filerepo;
        public BasicRepo<Book> BookRepository 
        {
            get { if (bookrepo == null) bookrepo = new BasicRepo<Book>(db); return bookrepo; }
        }
        public BasicRepo<Author> AuthorRepository
        {
            get { if (authrepo == null) authrepo = new BasicRepo<Author>(db); return authrepo; }
        }
        public BasicRepo<File> FileRepository
        {
            get { if (filerepo == null) filerepo = new BasicRepo<File>(db); return filerepo; }
        }
        public void Dispose() { }
    }
}
