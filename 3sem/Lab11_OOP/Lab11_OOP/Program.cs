using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_OOP
{
    public class Train 
    {
        public int passengers;
        public int carriages;
        public string destination;
        public DateTime departure;
        public Train()
        {
            this.passengers = 0;
            this.carriages = 0;
            this.destination = "";
        }
        public Train(int p, int c, string d, DateTime time)
        {
            this.passengers = p;
            this.carriages = c;
            this.destination = d;
            this.departure = time;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] month = new string[] {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            IEnumerable<string> m1 = from p in month
                                     where p.Length == 8
                                     select p;
            IEnumerable<string> m2 = month.Take(2).Concat(month.Skip(5).Take(3));
            IEnumerable<string> m3 = month.OrderBy(m => m);
            IEnumerable<string> m4 = from m in month
                                     where m.Contains('u')
                                     select m;
            IEnumerable<string> m5 = from m in month
                                     where m.Length <= 4
                                     select m;
            //-------------------------------------------------------------------------------
            Train[] timetable = new Train[]
            {
                new Train(244, 7, "Moscow", new DateTime(2019, 12, 2, 14, 30, 0) ),
                new Train(100, 4, "Moscow", new DateTime(2019, 12, 6, 18, 0, 0) ),
                new Train(80, 4, "Moscow", new DateTime(2019, 12, 10, 12, 0, 0) ),
                new Train(100, 4, "Brest", new DateTime(2019, 12, 5, 22, 15, 0) ),
                new Train(314, 10, "Adler", new DateTime(2019, 12, 2, 14, 30, 0) ),
                new Train(100, 4, "Tallin", new DateTime(2019, 12, 3, 12, 30, 0) ),
                new Train(400, 12, "Warsaw", new DateTime(2019, 12, 13, 20, 50, 0) ),
                new Train(170, 5, "Mogilev", new DateTime(2019, 12, 15, 21, 30, 0) ),
                new Train(100, 4, "Moscow", new DateTime(2019, 12, 3, 12, 0, 0) ),
                new Train(324, 9, "Saint-Petersburg", new DateTime(2019, 12, 25, 19, 45, 0) ),
            };
            IEnumerable<Train> to_moscow = from t in timetable
                                           where t.destination == "Moscow"
                                           select t;
            IEnumerable<Train> to_moscow_time = timetable.Where(s => s.destination == "Moscow")
                                                         .Where(p => p.departure.Hour > 12)
                                                         .Select(p=>p);
            Train max_pass = timetable.OrderByDescending(s => s.passengers).First();
            IEnumerable<Train> dest_alphabet = timetable.OrderBy(s => s.destination);
            //------------------------------------------------------------
            Console.ReadKey();
        }
    }
}
