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
        //Test();
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

        var hasPet = ReadLineBool("Есть питомец (yes/y/no/n) -  ");

        if (hasPet)
        {
            var petsCount = ReadLineInt("Введите количество питомцев - ");

            if (petsCount > 0)
            {
                var currentPets = ReadLineStrings("Введите клички питомцев", petsCount);

                Console.WriteLine("Клички животных - ");

                foreach (string pet in currentPets)
                {
                    Console.WriteLine(pet);
                }
            }
        }

        var favColors = ReadLineInt("Введите количество любимых цветов - ");

        if (favColors > 0)
        {
            var colors = ReadLineStrings("Введите любимые цвета: ", favColors);
            Console.WriteLine("Любимые цвета - ");

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
        }
    }

    public static string[] ReadLineStrings(string message, int count)
    {
        var strings = new string[count];
        Console.WriteLine(message);
        for (int i = 0; i < strings.Length; i++)
        {
            Console.Write($"{i + 1}. ");
            strings[i] = Console.ReadLine();
        }
        return strings;
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

