using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using System.Web.Script.Serialization;
namespace Lab8_OOP
{
    class Program
    {
        public static bool FindEmperors(Employee em)
        {
            if (em.job == "emperor") return true;
            else return false;
        }
        public static bool FindWizards(Employee em)
        {
            if (em.job == "wizard") return true;
            else return false;
        }
        static void Main(string[] args)
        {
            Employee[] earr =
            {
                new Employee("Peter", "Parker", 303, "photographer"),
                new Employee("Harry", "Osborn", 400, "director"),
                new Employee("Nicolai", "Romanov", 100, "emperor"),
                new Employee("Harry", "Potter", 123, "wizard"),
                new Employee("Nolan", "Sorrento", 406, "director"),
                new Employee("Alexander", "of Macedonia", 150, "emperor"),
                new Employee("Napoleon", "Bonapart", 315, "emperor"),
                new Employee("Hermione", "Granger", 410, "wizard")
            };
            Group<Employee> company = new Group<Employee>(earr);
            List<Employee> emperors = company.group.FindAll(FindEmperors);
            List<Employee> wizards = company.group.FindAll(FindWizards);
            foreach (Employee e in wizards) Console.WriteLine(e);
            //--------------------------------------------------------------
            Info info = new Info();
            info.assembly = typeof(Group<Employee>).Assembly.FullName;
            info.hasPublicConstructor = typeof(Group<Employee>).GetConstructors().First() != null;
            info.type = typeof(Group<Employee>).ToString();
            foreach (FieldInfo v in typeof(Group<Employee>).GetFields()) info.publicFields.Add(v.ToString());
            foreach (MethodInfo v in typeof(Group<Employee>).GetMethods()) info.publicMethods.Add(v.ToString());
            var json = new JavaScriptSerializer().Serialize(info);
            System.IO.File.WriteAllText("D:\\ООП\\Lab8_OOP\\Lab8_OOP\\json.json", json);
            Console.ReadKey();

        }
    }
}
