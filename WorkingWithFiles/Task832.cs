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
        string dirName = @"C:\Users\фвьшт\OneDrive\Рабочий стол\Folder"; // Почему выводит только папку с Мувис остальное указывает как файлы? 
        if (Directory.Exists(dirName))
        {
            Console.WriteLine("Папки");
            string[] dirs = Directory.GetDirectories(dirName);

            foreach (string dir in dirs)
            {
                Console.WriteLine(dir);
                Console.WriteLine();
                Console.WriteLine("Файлы");
                string[] files = Directory.GetFiles(dirName);

                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }



            }


        }
    }


}
