using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {
        //RandomTask1();
        RandomPassword();
    }
    //Случайный цвет: Создайте массив с основными цветами(например, красный, зеленый, синий)
    //     и напишите программу, которая выбирает случайный цвет и выводит его на экран.
    public static void RandomTask1()
    {
        string[] colors = { "blue", "red", "green" };
        Random random = new Random();

        for (int i = 0; i < colors.Length; i++)
        {

            int index = random.Next(colors.Length);
            Console.WriteLine(colors[index]); // опятть бесконечный вывод. 




        }




    }
    //. Пароль генератор: Напишите программу,
    //    которая генерирует случайный пароль длиной 8 символов, содержащий буквы и цифры.
    public static void RandomPassword()
    {
        Random random = new Random();
        char[] letters = "123456789QWERTYUIOPASDFGHJKLZXCVBNM".ToCharArray();
        string password = "";

        for (int i = 0; i < 8; i++)
        {
            password += letters[random.Next(letters.Length)];

        }
        Console.WriteLine($"Ваш пароль: {password}");
    }
    //Подбрасывание монеты: Напишите программу, которая симулирует подбрасывание монеты 1млн раз и считает,
    //    сколько раз выпала орел, а сколько решка.

    public static void HeadsAndTails()
    {

        int heads = 0;
        int tails = 0;

        for (int i = 0; i < 1000000; i++)
        {
            bool result = RandomNumber() == 0 ? true : false;


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