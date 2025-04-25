using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithClass
{
    public class WorkWithFiles
    {
        //        Допустим, нам нужно создать файл и записать в него информацию, в коде выполним следующие действия: 

        //Проверим существование файла
        //Если не существует, создадим его и запишем строку.
        //Откроем файл и прочитаем ранее записанную строку.

        public static void FileWriter()
        {


            string filePath = @"C:\Users\фвьшт\OneDrive\Рабочий стол\TestFolder\student2.txt"; // Укажем путь
            if (!File.Exists(filePath)) // Проверим, существует ли файл по данному пути
            {
                // Если не существует - создаем и записываем в строку
                using (StreamWriter sw = new StreamWriter(filePath))
                {

                    sw.WriteLine("OLEG");
                    sw.WriteLine("Dmitriy");
                    sw.WriteLine("Ivan");

                }
            }
            else
            {


                using (StreamReader sr = File.OpenText(filePath)) // Откроем файл и прочиатаем его содержимое 

                {
                    string str = " ";
                    while ((str = sr.ReadLine()) != null) // Пока не кончатся строки - считываем из файла по одной и выводим в консоль
                    {
                        Console.WriteLine(str);
                    }

                }

            }

        }
        //Далее рассмотрим пример аналогичной задачи, 
        //    где после операций чтения/записи в файл нам необходимо работать с ним
        //    в дальнейшем.Для этого используем функционал класса FileInfo.

        public static void Task831()
        {
            string tempFile = Path.GetTempFileName();// используем генерацию имени файла.
            var fileInfo = new FileInfo(tempFile); // Создаем объект класса FileInfo

            // Создаем файл и записываем в него.
            using (StreamWriter sw = fileInfo.CreateText())
            {
                sw.WriteLine("Igor");
                sw.WriteLine("Andrey");
                sw.WriteLine("Sergey");
            }
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

                //убедимся , что файл назначения точно отсутсвует 
                fileInfo2.Delete();

                fileInfo.CopyTo(tempFile2);
                Console.WriteLine($"{tempFile2} скопирован в файл {tempFile}.");
                //Удаляем ранее созданный файл.
                fileInfo.Delete();
                Console.WriteLine($"{tempFile} удален");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex}");
            }
        }
    }

}


