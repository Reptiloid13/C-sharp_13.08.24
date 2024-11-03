using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {
        RandomTask1();
    }

    //Случайный цвет: Создайте массив с основными цветами(например, красный, зеленый, синий)
    //     и напишите программу, которая выбирает случайный цвет и выводит его на экран.
    public static void RandomTask1()
    {
        string[] colors = { "blue", "red", "green" };
        var random = new Random();

        var randomInt = random.Next(0, colors.Length); // 0, 1, 2
        Console.WriteLine(colors[randomInt]);
    }
    //Подбрасывание монеты: Напишите программу, которая симулирует подбрасывание монеты 1млн раз и считает,
    //    сколько раз выпала орел, а сколько решка.

    public static void HeadsAndTails()
    {
        int heads = 0;
        int tails = 0;

        for (int i = 0; i < 1000000; i++)
        {
            bool result = true; //RandomNumber() == 0 ? true : false;


            if (result)
                heads++;
            else
                tails++;
        }
    }

    private static bool RandomNumber()
    {
        Random random = new Random();
        return random.Next(2) == 0;
    }
}