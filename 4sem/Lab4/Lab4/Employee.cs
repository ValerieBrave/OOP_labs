using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Employee 
    {
        public int id;
        public int age;
        public int stage;
        public Employee()
        {
            this.age = this.stage = 0;
            this.id = 0;
        }
        public Employee(int i, int a, int s)
        {
            this.id = i;
            this.age = a;
            this.stage = s;
        }

        

        public override string ToString()
        {
            return "id: "+this.id.ToString() + " age: "+this.age.ToString()+ " stage: "+this.stage.ToString();
        }
    }
    public class EmployeeComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.stage > y.stage) return 1;
            else if (x.stage < y.stage) return -1;
            else return 0;
        }
    }
    public class EmployeeAgeComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.age > y.age) return -1;
            else if (x.age < y.age) return 1;
            else return 0;
        }
    }
}
