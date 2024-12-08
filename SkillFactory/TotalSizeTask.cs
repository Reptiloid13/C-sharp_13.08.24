using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillFactoryTask1;

namespace SkillFactoryTotalSize
{
    internal class TotalSizeTask
    {
        //Напишите программу, которая считает размер папки на 
        //диске(вместе со всеми вложенными папками и файлами). На вход метод принимает URL директории, в ответ — размер в байтах.

        public void TotalSize()
        {
            DirectoryInfo folder = new DirectoryInfo(@"C:\Users\фвьшт\Source\Repos\C-sharp_13.08.24\SkillFactory\Folders\");
            if (!folder.Exists) throw new Exception("Папака не существует");

            Console.WriteLine("Folders: ");
            var dirs = folder.GetDirectories();

            foreach (var dir in dirs)
            {
                Console.WriteLine(dir.FullName);
                Console.WriteLine();
            }

            Console.WriteLine("Files: ");

            var files = folder.GetFiles("*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                Console.WriteLine();
                Console.WriteLine(file.FullName);

            }
            long totalFolderSize = folderSize(folder);

            Console.WriteLine($"Total folders size in bytes: {totalFolderSize}");

        }

        static long folderSize(DirectoryInfo folder)
        {
            long totalSizeofDir = 0;

            FileInfo[] allfiles = folder.GetFiles();

            foreach (FileInfo file in allfiles)
            {
                totalSizeofDir += file.Length;


            }

            DirectoryInfo[] subfolders = folder.GetDirectories();

            foreach (DirectoryInfo dir in subfolders)
            {
                totalSizeofDir += folderSize(dir);

            }

            return totalSizeofDir;
        }
    }
}