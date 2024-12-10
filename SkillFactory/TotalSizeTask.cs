using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkillFactoryTask1;

namespace SkillFactoryTotalSize
{
    // Сделать статическим
    // Переименовать в TotalSize
    // В Program: TotalSize.Calculate(Path.Combine + Environment.CurrentDirectory)
    internal class TotalSizeTask
    {
        // Напишите программу, которая считает размер папки на 
        // диске(вместе со всеми вложенными папками и файлами). На вход метод принимает URL директории, в ответ — размер в байтах.

        // Переименовать в Calculate
        public void TotalSize()
        {
            // var
            // Path.Combine + Environment.CurrentDirectory
            DirectoryInfo folder =
                new DirectoryInfo(@"C:\Users\фвьшт\Source\Repos\C-sharp_13.08.24\SkillFactory\Folders\");

            // Установить spell checker
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

            // var
            long totalFolderSize = folderSize(folder);

            Console.WriteLine($"Total folders size in bytes: {totalFolderSize}");
        }

        // Указывать модификаторы доступа
        // Методы с большой буквы
        // использовать var
        // Методы должны начинаться с глагола
        static long folderSize(DirectoryInfo folder)
        {
            // Соблюдать camelCase
            // Удалить "ofDir"
            long totalSizeofDir = 0;

            // Соблюдать camelCase
            FileInfo[] allfiles = folder.GetFiles();

            // var
            foreach (FileInfo file in allfiles)
            {
                totalSizeofDir += file.Length;
            }

            // var
            DirectoryInfo[] subfolders = folder.GetDirectories();

            // var
            foreach (DirectoryInfo dir in subfolders)
            {
                totalSizeofDir += folderSize(dir);
            }

            return totalSizeofDir;
        }
    }
}