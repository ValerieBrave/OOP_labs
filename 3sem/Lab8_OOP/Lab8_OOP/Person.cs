using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Lab8_OOP
{
    public class Person
    {
        public string name;
        public string surname;
        public Person()
        {
            this.name = "";
            this.surname = "";
        }
        public Person(string n, string s)
        {
            this.name = n;
            this.surname = s;
        }
    }
    public class Employee : Person
    {
        public int cabinet;
        public string job;
        public Employee() : base()
        {
            this.cabinet = 0;
            this.job = "";
        }
        public Employee(string n, string s, int c, string j) : base(n, s)
        {
            this.cabinet = c;
            this.job = j;
        }
        public override string ToString()
        {
            return this.job + " " + this.name + " " + this.surname;
        }
    }
    public class Client : Person
    {
        public int account;
        private int Password { set { Password = value; } }
        public Client() : base()
        {
            this.account = 0;
        }
        public Client(string n, string s, int a) : base(n, s)
        {
            this.account = a;
        }
        public override string ToString()
        {
            return this.account.ToString() + " " + this.name + " " + this.surname;
        }
    }
    [Serializable]
    public class Info
    {
        public bool hasPublicConstructor;
        public string type;
        public string assembly;
        public List<string> publicFields;
        public List<string> publicProperties;
        public List<string> privateFields;
        public List<string> privateProperties;
        public List<string> publicMethods;
        public List<string> privateMethods;
        public Info()
        {
            this.publicFields = new List<string>();
            this.publicProperties = new List<string>();
            this.privateFields = new List<string>();
            this.privateProperties = new List<string>();
            this.publicMethods = new List<string>();
            this.privateMethods = new List<string>();
        }
    }
    public class Group<T> where T : Person
    {
        public List<T> group;
        private int howmany;
        public Group()
        {
            this.group = new List<T>();
            this.howmany = 0;
        }
        public Group(T[] arr)
        {
            this.group = new List<T>(arr);
            this.howmany = this.group.Count;
        }
        public void Add(T obj)
        {
            this.group.Add(obj);
        }
        public void Delete(int n)
        {
            this.group.RemoveAt(n);
        }
    }
}
