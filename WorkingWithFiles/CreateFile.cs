using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles.CreateFile;

public class Model
{
    public void GetFile()
    {
        string tempFile = Path.GetTempFileName(); // Используем генерацию мени файла
        var fileInfo = new FileInfo(tempFile);// Создаем объект класса FileInfo

        // Создаем файл и записываем в него. 
        using (StreamWriter sw = fileInfo.CreateText())
        {
            sw.WriteLine("Igor");
            sw.WriteLine("Andrew");
            sw.WriteLine("Sergei");

        }
        // Открываем файл и читаем из него.
        using (StreamReader sr = fileInfo.OpenText())
        {
            string str = "";
            while ((str = sr.ReadLine()) != null)
            {
                Console.WriteLine(str);
            }
        }
        try
        {
            string tempFile2 = Path.GetTempFileName();
            var fileInfo2 = new FileInfo(tempFile2);

            // убедимся что файл назначения точно отсутвует 
            fileInfo2.Delete();


            //Копируем файл
            fileInfo.CopyTo(tempFile2);
            Console.WriteLine($"{tempFile} скопирован в файл {tempFile2}.");

            // Удаляем ранее созданный файл 
            fileInfo.Delete();
            Console.WriteLine($"{tempFile} удален");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ошибка: {e}");
        }




    }
}
