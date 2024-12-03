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
        //Напишите программу, которая чистит нужную нам папку от файлов  и папок, которые не использовались более 30 минут
        string dirName = @"C:\Users\фвьшт\OneDrive\Рабочий стол\Folder";
        if (Directory.Exists(dirName))
        {
            Console.WriteLine("Папки");
            var dirs = Directory.GetDirectories(dirName);

            foreach (var dir in dirs)
            {

                Console.WriteLine(dir);
                Console.WriteLine();

                //if (File.GetLastWriteTime(dir) < DateTime.Now.AddMinutes(-30))
                //{
                //    File.Delete(dir);
                //}
                Console.WriteLine($"Объем {dir.TotalSize}  Bytes");

            }
            Console.WriteLine("Папка очищена от файлов, которые не использовались более 30 минут");



            string[] files = Directory.GetFiles(dirName);
            Console.WriteLine("Файлы");

            foreach (string f in files)
            {

                Console.WriteLine(f);
            }

interface IPerson
{
    public string Name { get; set; }
    public int Age { get; set; }

        }

class Person : IPerson, IDisposable
{
    public string Name { get; set; }
    public int Age { get; set; }



    }



    public void Task2()
    // Напишите программу, которая считает размер папки на диске(вместе со всеми вложенными папками и файлами).
    // На вход метод принимает URL директории, в ответ — размер в байтах.



    {
        string dirName = @"C:\Users\фвьшт\OneDrive\Рабочий стол\Folder";


    }
}



