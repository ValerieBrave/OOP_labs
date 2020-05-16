using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace Lab10_OOP
{
    class Program
    {
        public class Student
        {
            public string name;
            public int course;
            public Student(string n, int c)
            {
                this.name = n;
                this.course = c;
            }
            public override string ToString()
            {
                return this.name +" "+ this.course.ToString();
            }
        }
        public static void DeleteRange(ref SortedList<string, string> list, int start, int num)
        {
            if (start + num < list.Count)
            {
                for (int i = 0; i < num; i++) list.RemoveAt(start);
            }
            else Console.WriteLine("you are out of range");
        }
        private static void student_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    Student newstud = e.NewItems[0] as Student;
                    Console.WriteLine($"Добавлен новый объект: {newstud.name}");
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление
                    Student oldstud = e.OldItems[0] as Student;
                    Console.WriteLine($"Удален объект: {oldstud.name}");
                    break;

            }
        }
        static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList() { 1, 3, 45, 15, "hello" , 99.89, new Student("Vasek Sidorov", 2)};
            foreach (object v in arraylist) { Console.WriteLine(v.ToString()); }
            arraylist.RemoveAt(5);
            //------------------------------------------------------------
            SortedList<string, string> sortedlist = new SortedList<string, string>();
            sortedlist["key1"] = "item1";
            sortedlist["key2"] = "item2";
            sortedlist.Add("key3", "item3");
            sortedlist.Add("key4","item4");
            sortedlist.Add("key5", "item5");
            sortedlist.Add("key6", "item6");
            sortedlist.Add("key7", "item7");
            DeleteRange(ref sortedlist, 2, 3);
            List<string> list = sortedlist.Values.ToList();
            foreach (string l in list) Console.WriteLine(l);
            //-----------------------------------------------------------
            ObservableCollection<Student> observed = new ObservableCollection<Student>
            {
                new Student("Ann", 2),
                new Student("Helen", 4),
                new Student("Peter",1)
            };
            observed.CollectionChanged += student_CollectionChanged;
            observed.RemoveAt(0);
            observed.Add(new Student("Alex", 1));
            Console.ReadKey();
        }
    }
}
