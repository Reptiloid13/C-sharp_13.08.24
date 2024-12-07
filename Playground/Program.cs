namespace Playground;

class Program
{
    public static void Main()
    {
        var filesForDeleting = new List<string>();
        var foldersForDeleting = new List<string>();
        
        filesForDeleting.Add("1qwdwaefaer.txt");
        filesForDeleting.Add("2.txt");
        filesForDeleting.Add("2.txt");
        
        foldersForDeleting.Add("Models");
        foldersForDeleting.Add("Photos");

        var selectedVariant = 0; // 0 - не выбрано, 1 - да, 2 - нет

        while (true)
        {
            Console.Clear();
            PrintItemsForDeleting(filesForDeleting, foldersForDeleting);
            PrintYesNo(selectedVariant);
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
        Console.WriteLine("Будут удалены следующие элементы");
        Console.WriteLine("Папки:");
        foreach (var folder in foldersForDeleting)
        {
            Console.WriteLine(folder);
        }
        Console.WriteLine();
        Console.WriteLine("Файлы:");
        foreach (var file in filesForDeleting)
        {
            Console.WriteLine(file);
        }
    }

    public static void PrintYesNo(int selectedVariant)
    {
        Console.WriteLine("Вы точно хотите продолжить?");
        
        if (selectedVariant == 0)
        {
            Console.Write("   Да   ");
            Console.Write("      ");
            Console.Write("   Нет   ");
        }
        
        if (selectedVariant == 1)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("   Да   ");
            Console.ResetColor();
            Console.Write("      ");
            Console.Write("   Нет   ");
        }
        
        if (selectedVariant == 2)
        {
            Console.Write("   Да   ");
            Console.ResetColor();
            Console.Write("      ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("   Нет   ");
        }
    }
}