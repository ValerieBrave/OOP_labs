using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Xml.Serialization;


namespace Lab12_OOP
{
    [Serializable]
    public class Person
    {
        public string name;
        public string surname;
        public int age;
        public string job { get; set; }
        public Person()
        {
            this.name = "";
            this.surname = "";
            this.age = 0;
            this.job = "assistant";
        }
        public Person(string n, string s, int a, string job)
        {
            this.name = n;
            this.surname = s;
            this.age = a;
            this.job = job;
        }
        public void FullName()
        {
            Console.WriteLine(this.name + " " + this.surname + ", works as "+ this.job);
        }
        public void Expert(int y)
        {
            Console.WriteLine(this.name + " " + this.surname + "works here since age " + (this.age - y).ToString());
        }
        public void ExpertS(string stage)
        {
            Console.WriteLine(this.name + " " + this.surname + "works here for "+ stage+" years");
        }
        public void AddSecondName(string f)
        {
            Console.WriteLine(this.name + " " + this.surname + " " + f);
        }

    }
    public static class Reflector<T>
    {
        public static void WritetoXML(T obj)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(T));
            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, obj);
                fs.Close();
            }
            
        }
        public static void Methods(Type t)
        {
            foreach (MemberInfo p in t.GetMethods()) Console.WriteLine(p.ToString());
        }
        public static void Props(Type t)
        {
            foreach (PropertyInfo p in t.GetProperties()) Console.WriteLine(p.ToString());
        }
        public static void Fields(Type t)
        {
            foreach (FieldInfo p in t.GetFields()) Console.WriteLine(p.ToString());
        }
        public static void Interfaces(Type t)
        {
            foreach (Type p in t.GetInterfaces()) Console.WriteLine(p.ToString());
        }
        public static void MethodForType(Type type, string name, Type[] param)
        {
            Console.WriteLine(type.GetMethod(name, param));
        }
        public static void Voke(Type t, string name, XmlSerializer formatter)
        {
            FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate);
            Person newPerson = (Person)formatter.Deserialize(fs);
            MethodInfo method = t.GetMethod(name);
            switch(name)
            {
                case "FullName": method.Invoke(newPerson, new object[] { }); break;
                case "Expert": method.Invoke(newPerson, new object[] { 10 }); break;
                case "ExpertS": method.Invoke(newPerson, new object[] { "10" }); break;
                case "AddSecondName": method.Invoke(newPerson, new object[] { "James"}); break;
            }
            fs.Close();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Person));
            Person person = new Person("John", "Preston", 56, "financier");
            Reflector<Person>.WritetoXML(person);
            Reflector<Person>.MethodForType(typeof(Person), "Expert", new Type[] { typeof(int)});
            Reflector<Person>.Voke(typeof(Person), "FullName", formatter);
            Reflector<Person>.Voke(typeof(Person), "Expert", formatter);
            Console.ReadKey();
        }
    }
}
