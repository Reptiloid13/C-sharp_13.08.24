using System;
using System.IO;
namespace WorkingWithFiles
{
    class FileWriter
    {
        public static void Main()
        {
            var test = new Model.Model();
            test.GetCatalogsVer2();



            //string filePath = @"C:\Users\фвьшт\С_sharp\Students.txt"; ; // Укажем путь 
            //if (!File.Exists(filePath)) // Проверим, существует ли файл по данному пути
            //{
            //    //   Если не существует - создаём и записываем в строку
            //    using (StreamWriter sw = File.CreateText(filePath))  // Конструкция Using (будет рассмотрена в последующих юнитах)
            //    {
            //        sw.WriteLine("Олег");
            //        sw.WriteLine("Дмитрий");
            //        sw.WriteLine("Иван");
            //    }
            //}
            //// Откроем файл и прочитаем его содержимое
            //using (StreamReader sr = File.OpenText(filePath))
            //{
            //    string str = "";
            //    while ((str = sr.ReadLine()) != null) // Пока не кончатся строки - считываем из файла по одной и выводим в консоль
            //    {
            //        Console.WriteLine(str);
            //    }
            //}


        }
    }
}