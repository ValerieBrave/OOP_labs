using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12.Model
{
    interface IRepository<T> where T : class
    {
        List<T> GetAll(); // получение всех объектов
        T GetById(string id); // получение одного объекта по id
        void Create(T item); // создание объекта
        void Update(T olditem, T newitem); // обновление объекта
        void Delete(string id); // удаление объекта по id
    }
}
