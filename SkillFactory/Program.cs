using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace SkillFactory;

class SkillFactoryTasks
{

    static void Main(string[] args)
    {
        DirectoryInfo folder = new DirectoryInfo(@"C:\Users\фвьшт\Source\Repos\C-sharp_13.08.24\SkillFactory\Folders\\");
        var span = TimeSpan.FromMinutes(30);
        //var rootDirectory = new DirectoryInfo(folder);

        if (!folder.Exists) throw new Exception("Папака не существует");

        Console.WriteLine("Folders");
        var dirs = folder.GetDirectories();

        foreach (var dir in dirs)
        {
            Console.WriteLine(dir);
            Console.WriteLine();
        }
        FileInfo[] files = folder.GetFiles();

        foreach (var file in files)
        {
            Console.WriteLine();
            Console.WriteLine(files);
        }

        //if(Directory.GetLastWriteTime(dir)< DateTime.Now.AddSeconds(-1))
        //   {
        //       Directory.Delete(dir, true); 
        //   }
    }
}