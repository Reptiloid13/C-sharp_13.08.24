using SkillFactory.PrintItems;

namespace SkillFactoryTask1
{
    internal class Task1
    {
        //Напишите программу, которая чистит нужную нам папку от файлов и папок, которые не использовались более 30 минут
        public void DeleteUnusingFiles()
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Folders");
            var rootDir = new DirectoryInfo(path);
            
            if (!rootDir.Exists) throw new Exception("Папка не существует");

            Console.WriteLine("Folders: ");
            var dirs = rootDir.GetDirectories();

            foreach (var dir in dirs)
            {
                Console.WriteLine(dir.FullName);
                Console.WriteLine();
            }

            var files = rootDir.GetFiles("*", SearchOption.AllDirectories);
            var filesForDeleting = new List<string>();

            foreach (var file in files)
            {
                Console.WriteLine();
                Console.WriteLine(file.FullName);

                if (IsLongAgoUsed(rootDir))
                {
                    // file.Delete();
                    filesForDeleting.Add(file.FullName);
                }
            }
            
            PrintItems.ConfirmDeleting(filesForDeleting);
        }

        private bool IsLongAgoUsed(DirectoryInfo rootDir)
        {
            // var span = TimeSpan.FromMinutes(30);
            var span = TimeSpan.FromSeconds(1);
            return DateTime.Now - rootDir.LastAccessTime > span;
        }
    }
}