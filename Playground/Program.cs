using System.Collections.Concurrent;
using System.Data;
using System.Diagnostics.Tracing;
using System.Security.Cryptography;

namespace Playground;

class Program
{



    public static void Main()
    {


        GetName();
    }

    public static void GetName()
    {
        // Необходимо создать метод, который заполняет данные с клавиатуры по пользователю (возвращает кортеж):
        // Имя;
        // Фамилия;
        // Возраст;
        // Наличие питомца;
        // Если питомец есть, то запросить количество питомцев;
        // Если питомец есть, вызвать метод, принимающий на вход количество питомцев и возвращающий массив их кличек (заполнение с клавиатуры); // Трудности с пониманием и реализацией доп. задачи
        // Запросить количество любимых цветов;
        // Вызвать метод, который возвращает массив любимых цветов по их количеству (заполнение с клавиатуры);
        // Сделать проверку, ввёл ли пользователь корректные числа: возраст, количество питомцев, количество цветов в отдельном методе;
        // Требуется проверка корректного ввода значений и повтор ввода, если ввод некорректен;
        // Корректный ввод: ввод числа типа int больше 0.
        // Метод, который принимает кортеж из предыдущего шага и показывает на экран данные.
        // Вызов методов из метода Main.

        Console.Write("Ваше имя - ");
        var name = Console.ReadLine();

        Console.Write("Ваша фамилия -  ");
        var surname = Console.ReadLine();

        var age = ReadLineInt("Возраст - ");
        //var age = ReadLineInt("Возраст - ");
        //var childrenCount = ReadLineInt("Сколько у вас детей - ");

        var hasPet = ReadLineBool("Есть питомец (yes/y/no/n) -  ");

        if (hasPet)
        {

            var valuePets = ReadLineInt("Введите количество питомцев - ");
            //var valuePets = ReadLineInt("Введите количество питомцев - "); //  Сделать метод универсальным. 

            if (valuePets > 0)
            {
                var currentPets = ReadLineStrings(valuePets);
                //var currentPets = ReadLineStrings("Введите клички животных: ", 3); // Массив строк 

                Console.WriteLine("Клички животных - ");

                foreach (string pet in currentPets)
                {
                    Console.WriteLine(pet);
                }
            }

            var favColors = ReadLineInt("Введите количество любимых цветов - ");
            //var favColors = ReadLineInt("Введите количество любимых цветов - "); 

            if (favColors > 0)
            {
                var colors = GetFavoriteColors(favColors);
                //var colors = ReadLineStrings("Введите любимые цвета: ", favColors); 
                Console.WriteLine("Любимые цвета - ");

                foreach (var color in colors)
                {
                    Console.WriteLine(color);
                }
            }
        }

    }

    public static string[] GetFavoriteColors(int favColors)
    {
        string[] numbersOfColor = new string[favColors];
        for (int i = 0; i < numbersOfColor.Length; i++)
        {
            Console.Write($"Введите название любимого цвета {i + 1} - ");
            numbersOfColor[i] = Console.ReadLine();
        }
        return numbersOfColor;

    }

    public static string[] ReadLineStrings(int valuePets)
    {
        string[] namePet = new string[valuePets];
        for (int i = 0; i < namePet.Length; i++)
        {
            Console.WriteLine($"Введите клички ваших животных{i + 1} - ");
            namePet[i] = Console.ReadLine();
        }
        return namePet;
    }

    public static int ReadLineInt(string text)
    {
        int result = 0;

        while (true)
        {
            Console.Write(text);
            if (int.TryParse(Console.ReadLine(), out result) && result > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Введите число");
            }


        }
        return result;
    }

    //public static int GetNum(string promt)
    //{
    //    int result = 0;
    //    while (true)
    //    {
    //        Console.Write(promt);
    //        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
    //        {
    //            break;
    //        }
    //        else
    //        {
    //            Console.WriteLine("Введите число цифрой ");
    //        }
    //    }
    //    return result;
    //}


    //public static int GetNumFavColors(string promt)
    //{
    //    var result = 0;
    //    while (true)
    //    {
    //        Console.Write(promt);
    //        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
    //        {
    //            break;
    //        }
    //        else
    //        {
    //            Console.WriteLine("Введите цифрой");
    //        }

    //    }
    //    return result;
    // }

    public static bool ReadLineBool(string text)
    {
        var input = "";

        Console.WriteLine(text);
        while (input != "yes" && input != "y" && input != "no" && input != "n")
        {
            Console.Write(text);
            input = Console.ReadLine();
        }

        var result = false;
        bool test; // false

        if (input == "yes" || input == "y")
        {
            result = true;
        }
        else
        {
            result = false;
        }

        return result;
    }
}
