namespace WorkingWithFiles.Folder;

public class TryCatch
{
    public static void Start()
    {
        Console.WriteLine(1);
        try
        {
            Console.WriteLine("Начали читать файл");
            // throw new Exception("Что-то пошло не так");
            Console.WriteLine("Чтение файла завершено");
        }
        catch (Exception e)
        {
            Console.WriteLine("Произошла ошибка: " + e.Message);
        }

        Console.WriteLine(2);
    }
}