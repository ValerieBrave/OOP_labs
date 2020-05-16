using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_OOP
{
    public class User // источник события
    {
        public  event WorkHandler Work;
        public  event UpgradeHandler Upgrade;
        public void InitWork() 
        { // инициировать событие
            Console.WriteLine("User started working");
            if (Work != null) Work();
        }
        public void InitUpgrade()
        {
            Console.WriteLine("User started upgrading");
            if (Upgrade != null) Upgrade();
        }
    }
    public class Software
    {
        public int version;
        public string state;
        public Software()
        {
            this.version = 0;
            this.state = "";
        }
        public void OnWork()
        {
            Console.WriteLine("Software is working");
            this.state = "working";
        }
        public void OnUpgrade()
        {
            this.version++;
            this.state = "upgrading";
            Console.WriteLine("Software is upgrading to version " + this.version.ToString());
        }
    }
}
