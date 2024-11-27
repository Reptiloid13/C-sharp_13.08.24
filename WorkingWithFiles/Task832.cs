using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkingWithFiles.Task832;

public class SolvingTask832()
{
    //Сделайте так, чтобы ваша программа из задания 8.3.1
    //при каждом запуске добавляла в свой исходный код
    //комментарий о времени последнего запуска. 


    //var fileInfo = new FileInfo(@"C:\Users\фвьшт\AppData\Local\Temp\tmpvo0fk5.tmp");

    public void GetBinary()
    {
        string filePath = @"C:\Users\фвьшт\Downloads\BinaryFile.bin";

        if (File.Exists(filePath))
        {
            string stringValue;
            File.GetAttributes(filePath);
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                stringValue = reader.ReadString();
            }

            Console.WriteLine("Из файла считано: ");
            Console.WriteLine(stringValue);
        }
    }

    public void Task1()
    {
        using (var person = new Person() { Name = "Иван", Age = 20 })
        {
            person.PrintName();
        }

        // Напишите программу, которая чистит нужную нам папку от файлов  и папок, которые не использовались более 30 минут
        Console.WriteLine(Environment.CurrentDirectory);
        string dirName =
            @"C:\Users\New\Desktop\code\csharp\C-sharp_13.08.24\WorkingWithFiles\Folder"; // Почему выводит только папку с Мувис остальное указывает как файлы? 
        if (Directory.Exists(dirName))
        {
            Console.WriteLine("Папки");
            var dirs = Directory.GetDirectories(dirName);

            foreach (var dir in dirs)
            {
                Console.WriteLine(dir);

                Console.WriteLine("Вложенные файлы");
                var filesInChildrenFolders = Directory.GetFiles(dir);

                Console.WriteLine(string.Join(", ", filesInChildrenFolders));
            }

            Console.WriteLine("Файлы");
            var files = Directory.GetFiles(dirName);

            Console.WriteLine(string.Join(", ", files));
        }
    }
}

interface IPerson
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void PrintName();
}

class Person : IPerson, IDisposable
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void PrintName()
    {
        Console.WriteLine($"{Name}, {Age}");
    }

    public void Dispose()
    {
        Console.WriteLine("Объект удален из памяти");
    }
}