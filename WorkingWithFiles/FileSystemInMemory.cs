using System.Diagnostics.CodeAnalysis;

namespace WorkingWithFiles.Model;

public class ModelTask
{
    public void GetCatalogs()
    {
        string dirName = @"C:\\";
        if (Directory.Exists(dirName))
        {
            Console.WriteLine("Folders: ");
            string[] dirs = Directory.GetDirectories(dirName);
            foreach (string dir in dirs)
                Console.WriteLine(dir);
            Console.WriteLine();
            Console.WriteLine("Files");
            string[] files = Directory.GetFiles(dirName);
            foreach (string s in files)
                Console.WriteLine(s);
        }
    }

    public static void GetCatalogsVer2()
    {
        var createdTime = File.GetCreationTime(@$"{Environment.CurrentDirectory}\Folder\NewFile.txt");

        try
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C://");
            if (dirInfo.Exists)
            {
                Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
            }

            DirectoryInfo newdirInfo = new DirectoryInfo(@"C:\Users\luft");
            if (!newdirInfo.Exists)
                newdirInfo.Create();

            newdirInfo.CreateSubdirectory("NewFolder");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }


    //Допустим, нам нужно создать файл и записать
    //в него информацию, в коде выполним следующие действия: 
    // Проверим существование файла
    //Если не существует, создадим его и запишем строку.
    //Откроем файл и прочитаем ранее записанную строку.

    public void GetFileInformation()
    {
        string filePath = @"D:\Folder\"; // не верный путь почему? 

        if (!File.Exists(filePath))
        {
            using (StreamWriter sw = File.CreateText(filePath))
            {
                sw.WriteLine("Oleg"); // А где консоль? 
                sw.WriteLine("Dima");
                sw.WriteLine("Ivan");
            }
        }

        using (StreamReader sr = File.OpenText(filePath))
        {
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}