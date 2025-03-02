using System.Data;
using System.Diagnostics.Tracing;

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

        Console.Write("Возраст -  ");
        var age = int.Parse(Console.ReadLine()); //Try.Parse

        Console.Write("Есть питомец (yes/y/no/n) -  ");
        var hasPet = Console.ReadLine();

        while (hasPet != "yes" && hasPet != "y" && hasPet != "no" && hasPet != "n")
        {
            Console.Write("Есть питомец (yes/y/no/n) -  ");
            hasPet = Console.ReadLine();
        }

        bool result;

        if (hasPet == "yes" || hasPet == "y")
        {
            result = true;
        }
        else
        {
            result = false;
        }

        if (result == true)
        {
            Console.Write("Введите количество питомцев - ");
            var valuePets = Convert.ToInt32(Console.ReadLine());

            if (valuePets > 0)
            {
                string[] currentPet = GetPetsNames(valuePets);

                Console.WriteLine("Клички животных - ");

                foreach (string pet in currentPet)
                {
                    Console.WriteLine(pet);
                }


            }

            Console.Write("Какое у вас количество любимых цветов - ");
            var favColors = int.Parse(Console.ReadLine());

            if (favColors > 0)
            {
                string[] numbersOfColor = GetFavoriteColors(favColors);
                Console.WriteLine("Любимые цвета - ");

                foreach (var color in numbersOfColor)
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

    public static string[] GetPetsNames(int valuePets)
    {
        string[] namePet = new string[valuePets];
        for (int i = 0; i < namePet.Length; i++)
        {
            Console.WriteLine($"Введите клички ваших животных{i + 1} - ");
            namePet[i] = Console.ReadLine();
        }
        return namePet;
    }
}
