﻿using System.ComponentModel.Design;
using System.Globalization;
using System.Net.WebSockets;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;

namespace Playground2.Tasks1;

class Person2
{
    public string Name = "";
    public int Age;

    public void SayHello()
    {
        Console.WriteLine($"Hello, I'm {this.Name}");
    }
}

class Program
{

    public static void Main(string[] args)
    {
        //GetMinElement();
        //GetBigger();
        // GetModulMax();
        Test();
        //GetMultiplicationTable();

        //// instance
        //var ivan = new Person2();

        //ivan.Name = "Ivan";

        //var petr = new Person2() { Name = "Петр" };
        //var john = new Person2();

        //ivan.SayHello();
        //petr.SayHello();

        //var counter = new DateCounter() { Time = "24:10:12" };
        //int minutes = counter.Count("m"); // counter.GetMinutes()
        //int seconds = counter.Count("s"); // counter.GetSecond()
        //int hours = counter.Count("h"); // counter.GetHours()
        //int days = counter.Count("d"); // counter.GetDays()


        //Console.WriteLine(ivan);
    }


    //Найти количество перестановок для массива чисел. Пример: [20, 93, 99999] -> 6

    public static void GetSwapElements()
    {
        int[] array = { 20, 93, 11 };
        var swap = 0;

        // [x] 1
        // [x x] 2
        // [x x x] 6
        // [x x x x] 24
        // 3 = 1 * 2 * 3 = 3!
        // 4 = 1 * 2 * 3 * 4 = 4!

        //for (int i = 0; i < array.Length; i++)
        //{
        //    for (int j = i + 1; j < array.Length; j++)
        //    {
        //        if (array[i] != array[j])
        //        {

        //        }
        //    }
        //}

        // Дописать
    }

    // Вывести таблицу умножения
    public static void GetMultiplicationTable()
    {
        // Вывести в несколько столбцов
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j,3}");
            }
        }
    }
    // есди в числе есть хотя бы 1 7 пишем Ес. Если есть 0 или  7 ки нет, то пишем Ноу 
    public static void Test()
    {
        // По данному трехзначному числу, определите, все ли его цифры различны.
        var n = Convert.ToInt32(Console.ReadLine());
        var result = 0;

        while (n > 0)
        {
            result = n % 10;
            n =/ 10;
        }
    }

}


}





