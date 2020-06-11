using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab12.Model;

namespace Lab12.Model
{
    public class BasicRepo<T>:IRepository<T> where T:class
    {
        private dbContext db;
        private DbSet<T> dbset; 
        public BasicRepo(dbContext d)
        {
            db = d;
            dbset = db.Set<T>();
        }
        public List<T> GetAll()
        {
            return dbset.ToList();
        }
        public T GetById(string id)
        {
            return dbset.Find(id);
        }
        public void Create(T item)
        {
            dbset.Add(item);
            db.SaveChanges();
        }
        public void Delete(string id)
        {
            dbset.Remove(this.GetById(id));
            db.SaveChanges();
        }
        public void Update(T oldi, T newi)
        {
            dbset.Remove(oldi);
            dbset.Add(newi);
            db.SaveChanges();
        }
    }
}
