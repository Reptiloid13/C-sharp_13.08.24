using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory.PrintItems
{
    internal class PrintItems
    {

        public static void PrintItemsMain()
        {
            var fileForDeleting = new List<string>();
            var folderForDeleting = new List<string>();

            fileForDeleting.Add(@"FoldersMain.txt");
            fileForDeleting.Add(@"F1.txt");
            fileForDeleting.Add(@"F2.txt");


            folderForDeleting.Add(@"Folders");
            folderForDeleting.Add(@"F1");
            folderForDeleting.Add(@"F2");

            var selectedVariant = 0;

            while (true)
            {
                Console.Clear();
                PrintItems.PrintItemsForDeleting(fileForDeleting, folderForDeleting);
                PrintItems.PrintYesNo(selectedVariant);

                var key = Console.ReadKey().Key;

                if (key == ConsoleKey.RightArrow)
                    selectedVariant = 2;

                if (key == ConsoleKey.LeftArrow)
                    selectedVariant = 1;

                if (key == ConsoleKey.Enter)
                    break;
            }




        }
        public static void PrintItemsForDeleting(List<string> filesForDeleting, List<string> foldersForDeleting)
        {
            Console.WriteLine("Будут удалены слудующие элементы");
            Console.WriteLine("Папки: ");
            foreach (var folder in foldersForDeleting)
            {
                Console.WriteLine(folder);
            }
            Console.WriteLine();
            Console.WriteLine("Файлы: ");
            foreach (var files in filesForDeleting)
            {
                Console.WriteLine(files);
            }

        }

        public static void PrintYesNo(int selectedVariant)
        {
            Console.WriteLine("Вы точно хотите продолжить?");

            if (selectedVariant == 0)
            {
                Console.Write("   YES  ");
                Console.Write("        ");
                Console.Write("   NO   ");
            }

            if (selectedVariant == 1)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("   YES   ");
                Console.ResetColor();
                Console.Write("         ");
                Console.Write("   NO    ");

            }

            if (selectedVariant == 2)
            {


                Console.Write("   YES   ");
                Console.Write("         ");
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("   NO    ");
                Console.ResetColor();
            }

        }
    }
}
