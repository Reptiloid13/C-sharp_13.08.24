﻿namespace SkillFactoryTotalSize
{
    // В Program: TotalSize.Calculate(Path.Combine и Environment.CurrentDirectory)
    internal static class TotalSizeTask
    {
        // Напишите программу, которая считает размер папки на 
        // диске(вместе со всеми вложенными папками и файлами). На вход метод принимает URL директории, в ответ — размер в байтах.

        public static void Calculate()
        {
            // var
            // Path.Combine + Environment.CurrentDirectory
            DirectoryInfo folder =
                new DirectoryInfo($@"{Environment.CurrentDirectory}\Folders");

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
            var totalFolderSize = GetFolderSize(folder);

            Console.WriteLine($"Total folders size in bytes: {totalFolderSize}");
        }

        // использовать var
        // Методы должны начинаться с глагола
        public static long GetFolderSize(DirectoryInfo folder)
        {
            var totalSizeDir = (long)0;

            // Соблюдать camelCase
            FileInfo[] allFiles = folder.GetFiles();

            // var
            foreach (var file in allFiles)
            {
                totalSizeDir += file.Length;
            }

            // var
            var subfolders = folder.GetDirectories();

            // var
            foreach (var dir in subfolders)
            {
                totalSizeDir += GetFolderSize(dir);
            }

            return totalSizeDir;
        }
    }
}