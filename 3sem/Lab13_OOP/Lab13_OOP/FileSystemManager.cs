using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab13_OOP
{
    static class FileSystemManager
    {
        public enum REGIME { CREATE = 1, APPEND = 2, EXISTS =3};
        public static void FileInfo(string filename)
        {
            var file = new FileInfo(filename);
            Console.WriteLine("creation time: {0}", File.GetCreationTime(filename).ToString());
            Console.WriteLine("last change: {0}", file.LastWriteTime.ToString());
            Console.WriteLine("full name: {0}", file.FullName.ToString());       
        }
        public static void SearchByName(string directory, string filename)
        {
            var dir = new DirectoryInfo(directory);
            FileInfo[] f = dir.GetFiles(filename);
            foreach (FileInfo fu in f) Console.WriteLine(fu.FullName);
        }
        public static void SearchByMask(string directory, string mask)
        {
            var dir = new DirectoryInfo(directory);
            FileInfo[] f = dir.GetFiles(mask, SearchOption.AllDirectories);
            foreach (FileInfo fu in f) Console.WriteLine(fu.FullName);
        }
        public static void AllDisksInfo()
        {
            var allDrives = DriveInfo.GetDrives();
            foreach (var d in allDrives)
            {
                Console.WriteLine("Name: {0}", d.Name);
                Console.WriteLine("Free size: {0}", d.TotalFreeSpace);
                Console.WriteLine("Volume Label: {0}", d.VolumeLabel);
                Console.WriteLine("Total size: {0}", d.TotalSize);
                Console.WriteLine("----------------------------------------------------");
            }
        }
        public static void NewSubdirectiory(string dirpath, string newdir)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dirpath);
            if (!dirInfo.Exists) throw new Exception("no such directory found");
            dirInfo.CreateSubdirectory(newdir);
        }
        public static void NewFile(string dirpath, string filename, string text, FileSystemManager.REGIME reg)
        {
            string pathtofile = Path.Combine(dirpath, filename);
            
            switch (reg)
            {
                case REGIME.CREATE:
                    {
                        var file = new FileInfo(pathtofile);
                        FileStream fs = file.Open(FileMode.Create, FileAccess.ReadWrite);
                        fs.Write(new UTF8Encoding(true).GetBytes(text), 0, text.Length);
                        fs.Close();
                    }
                    break;
                case REGIME.APPEND:
                    {
                        var file = new FileInfo(pathtofile);
                        FileStream fs = file.Open(FileMode.Append, FileAccess.Write);
                        fs.Write(new UTF8Encoding(true).GetBytes(text), 0, text.Length);
                        fs.Close();
                    }
                    break;
                case REGIME.EXISTS:
                    {
                        var file = new FileInfo(pathtofile);
                        if (file.Exists) throw new Exception("file with this name already exists");
                        else
                        {
                            FileStream fs = file.Open(FileMode.Create, FileAccess.ReadWrite);
                            fs.Write(new UTF8Encoding(true).GetBytes(text), 0, text.Length);
                            fs.Close();
                        }
                    }
                    break;
            }
        }
        public static FileStream GiveStream(string fullpath)
        {
            var file = new FileInfo(fullpath);
            if (!file.Exists) throw new Exception("no file with this name found");
            return new FileStream(fullpath, FileMode.Open, FileAccess.ReadWrite);
        }
    }
}
