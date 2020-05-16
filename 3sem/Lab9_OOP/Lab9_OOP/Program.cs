using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9_OOP
{
    public delegate void WorkHandler(); // делегат для события Work
    public delegate void UpgradeHandler(); //делегат для события Upgrade
    public delegate void Formatter(ref string str);
    class Program
    {
        public static void MyFormat(ref string str, Formatter change)
        {
            change(ref str);
        }
        public static void NoCommas(ref string str)
        {
            str = str.Replace(",", " ");
            Console.WriteLine(str);
        }
        public static void ToLower(ref string str)
        {
            str = str.ToLower();
            Console.WriteLine(str);
        }
        public static void AddHello(ref string str)
        {
            str += "Hello";
            Console.WriteLine(str);
        }
        static void Main(string[] args)
        {
            User user = new User();
            Software soft = new Software();
            user.Work += soft.OnWork;
            user.Upgrade += soft.OnUpgrade;
            user.InitWork();
            user.InitUpgrade();
            user.InitUpgrade();
            //---------------------------
            string str = "This string contains commas,, HUGE LETTERS and some space for word... ";
            Formatter change;
            change = NoCommas;
            change += ToLower;
            change += AddHello;
            MyFormat(ref str, change);
            Console.ReadKey();
        }
        
    }
}
