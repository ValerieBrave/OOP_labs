using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Lab16_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[1000];
            var rand = new Random();


            Task task1 = new Task(() => { for (int i = 0; i < 200; i++) vector[i] = rand.Next(); Console.WriteLine("{0} task1", Task.CurrentId); });
            Task task2 = new Task(() => { for (int i = 200; i < 400; i++) vector[i] = rand.Next(); Console.WriteLine("{0} task2", Task.CurrentId); });
            Task task3 = new Task(() => { for (int i = 400; i < 600; i++) vector[i] = rand.Next(); Console.WriteLine("{0} task3", Task.CurrentId); });
            Task task4 = new Task(() => { for (int i = 600; i < 800; i++) vector[i] = rand.Next(); Console.WriteLine("{0} task4", Task.CurrentId); });
            Task task5 = new Task(() => { for (int i = 800; i < 1000; i++) vector[i] = rand.Next(); Console.WriteLine("{0} task5", Task.CurrentId); });
            task1.Start(); task2.Start(); task3.Start(); task4.Start(); task5.Start();
            Task.WaitAll(task1, task2, task3, task4, task5);
            int[] newvector = new int[1000];
            int ind = 0;
            Action< int> grand_minus = (par) =>
            {
                newvector[ind] = par - 100000;
                ind++;
                // неизвестно, в каком порядке форич передает сюда параметры, поэтому проверить не получится
            };
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            ParallelLoopResult plr  = Parallel.ForEach<int>(vector, grand_minus);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

            Console.ReadKey();
        }
    }
}
