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
        public static void Calculate()
        {
            // var
            // Path.Combine + Environment.CurrentDirectory
            DirectoryInfo folder =
                new DirectoryInfo($@"{Environment.CurrentDirectory}");


            if (!folder.Exists) throw new Exception("Папка не существует");

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
            long totalFolderSize = FolderSize(folder);

            Console.WriteLine($"Total folders size in bytes: {totalFolderSize}");
        }

        // Указывать модификаторы доступа
        // Методы с большой буквы
        // использовать var
        // Методы должны начинаться с глагола
        public static long FolderSize(DirectoryInfo folder)
        {
            // Соблюдать camelCase
            // Удалить "ofDir"
            long totalSizeDir = 0;

            // Соблюдать camelCase
            FileInfo[] allFiles = folder.GetFiles();

            // var
            foreach (FileInfo file in allFiles)
            {
                totalSizeDir += file.Length;
            }

            // var
            DirectoryInfo[] subfolders = folder.GetDirectories();

            // var
            foreach (DirectoryInfo dir in subfolders)
            {
                totalSizeDir += FolderSize(dir);
            }

            return totalSizeDir;
        }
    }
}