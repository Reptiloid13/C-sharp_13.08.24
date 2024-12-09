using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SkillFactory.PrintItems;

namespace SkillFactoryTask1
{
    internal class Task1
    {
        //Напишите программу, которая чистит нужную нам папку от файлов  и папок, которые не использовались более 30 минут
        public void DeleteUnusingFiles()
        {

            DirectoryInfo folder = new DirectoryInfo(@"C:\Users\фвьшт\Source\Repos\C-sharp_13.08.24\SkillFactory\Folders\");
            var span = TimeSpan.FromMinutes(30);
            PrintItems.PrintItemsMain();





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

                //if (DateTime.Now - folder.LastAccessTime > span)
                //{
                //    folder.Delete(true);


                //    Console.WriteLine($" Folders Удалены : {folder}");
                //    Console.WriteLine();
                //    Console.WriteLine($"Files Удалены: {files}");
                //    Console.WriteLine();
                //}
            }


        }
    }

}


