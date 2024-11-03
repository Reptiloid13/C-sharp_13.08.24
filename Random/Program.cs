using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {
    }
    //Подбрасывание монеты: Напишите программу, которая симулирует подбрасывание монеты 1млн раз и считает,
    //    сколько раз выпала орел, а сколько решка.

    public static void HeadsAndTails()
    {
        int heads = 0;
        int tails = 0;

        for (int i = 0; i < 1000000; i++)
        {
            if (GetRandomNumber() == 0)
                heads++;
            else
                tails++;
        }
    }

    private static int GetRandomNumber()
    {
        var random = new Random();
        return random.Next(2);
    }
}