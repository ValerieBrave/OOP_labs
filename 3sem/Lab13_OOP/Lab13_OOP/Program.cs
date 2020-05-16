using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Lab13_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string prog_file = Path.GetFullPath("C:\\Users\\valerie_brave\\Desktop\\pl\\CourseProject\\program.txt");
            FileSystemManager.FileInfo(prog_file);
            string dir = "C:\\Users\\valerie_brave\\Desktop\\pl\\CourseProject\\CourseProject";
            FileSystemManager.SearchByName(dir, "FST.???");
            FileSystemManager.SearchByMask(dir, "*.cpp");
            FileSystemManager.AllDisksInfo();
            FileSystemManager.NewSubdirectiory("D:\\", "newdir");
            try
            {
                FileSystemManager.NewFile("D:\\newdir", "newfile1.txt", "Bounjour! ", FileSystemManager.REGIME.CREATE);
                FileSystemManager.NewFile("D:\\newdir", "newfile1.txt", "Hello! ", FileSystemManager.REGIME.APPEND);
                //FileSystemManager.NewFile("D:\\newdir", "newfile.txt", "Драсте ", FileSystemManager.REGIME.EXISTS);
                FileStream fs = FileSystemManager.GiveStream("C:\\Users\\valerie_brave\\Desktop\\pl\\CourseProject\\program.txt");
                int k = 0;
            }
           catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
