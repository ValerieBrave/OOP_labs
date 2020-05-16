using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime;
using System.Reflection;
using System.Threading;


namespace Lab15_OOP
{
    public static class Counter
    {
        public static void Count(object n)
        {
            int i = 0;
            var currt = Thread.CurrentThread;
            while (i<=(int)n)
            {
                try
                {
                    Thread.Sleep(100);
                    Console.WriteLine("{0}      status: {1}", i.ToString(), currt.ThreadState.ToString());
                    i++;
                }
                catch(ThreadAbortException e)
                {
                    Console.WriteLine("Abortion requsted");
                    Thread.ResetAbort();            // отменить Abort
                }
                
            }
        }
        public static void cEven(object n)
        {
            int i = 0;
            var currt = Thread.CurrentThread;
            while (i <= (int)n)
            {
                Thread.Sleep(100);
                if (i % 2 == 0) Console.WriteLine("cEven thread: {0}", i.ToString());
                i++;
            }
        }
        public static void cOdd(object n)
        {
            int i = 0;
            var currt = Thread.CurrentThread;
            while (i <= (int)n)
            {
                Thread.Sleep(100);
                if (i % 2 == 1) Console.WriteLine("cOdd thread: {0}", i.ToString());
                i++;
            }
        }
    }
    class Program
    {
        public static void sec()
        {
            Console.WriteLine("5 seconds passed");
        }
        static void Main(string[] args)
        {
            var allProcess = Process.GetProcesses();
            //foreach(var p in allProcess)
            //{
            //    Console.WriteLine("name: {0}", p.ProcessName);
            //    Console.WriteLine("id: {0}", p.Id);
            //    Console.WriteLine("base priority: {0}", p.BasePriority);
            //    Console.WriteLine("--------------------");
            //}
            //-------------------------------------------------------
            AppDomain domain = AppDomain.CurrentDomain;
            AppDomainSetup setup = domain.SetupInformation;
            Console.WriteLine("current domain name: {0}", domain.FriendlyName);
            Assembly[] assemblies = domain.GetAssemblies();
            foreach (Assembly a in assemblies) Console.WriteLine(a.GetName().Name);
            Console.WriteLine("setup info: {0}",setup.ApplicationName);
            Assembly asm = Assembly.LoadFrom("D:\\OOP\\Lab15_OOP\\ClassLibrary\\obj\\Debug\\ClassLibrary.dll");
            Type t = asm.GetType("ClassLibrary.Class1", true, true);
            object obj = Activator.CreateInstance(t);
            MethodInfo method = t.GetMethod("SayHello");
            method.Invoke(obj, new object[] { });
            //----------------------------------------------------------
            int n = 100;
            Thread thr1 = new Thread(new ParameterizedThreadStart(Counter.Count));
            thr1.Start(n);
            Thread.Sleep(3000);
            thr1.Abort();

            Console.WriteLine("Other command");
            //thr1.Join();                            // останавливает вызывающий поток
            //-------------------------------------------------------------
            Thread even = new Thread(new ParameterizedThreadStart(Counter.cEven));
            Thread odd = new Thread(new ParameterizedThreadStart(Counter.cOdd));
            even.Start(10);
            //even.Join();        // будет работать только поток even
            odd.Start(10);
            //-----------------------------------------------------------
            Console.WriteLine("----------------------------");
            TimerCallback tm = new TimerCallback(Counter.Count);
            Timer count = new Timer(tm, 5, 0, 200);
            // статус потока будет background
            
            Console.ReadKey();
        }
        
    }
    
}
