
using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

class MainClass
{
    //    Необходимо создать метод, который заполняет данные с клавиатуры по пользователю(возвращает кортеж) :
    //Имя;
    //Фамилия;
    //Возраст;
    //Наличие питомца;
    //    Если питомец есть, то запросить количество питомцев;
    //    Если питомец есть, вызвать метод, принимающий на вход количество питомцев и возвращающий массив их кличек(заполнение с клавиатуры);
    //    Запросить количество любимых цветов;
    //    Вызвать метод, который возвращает массив любимых цветов по их количеству(заполнение с клавиатуры);
    //    Сделать проверку, ввёл ли пользователь корректные числа: возраст, количество питомцев, количество цветов в отдельном методе;
    //    Требуется проверка корректного ввода значений и повтор ввода, если ввод некорректен;
    //    Корректный ввод: ввод числа типа int больше 0.
    //Метод, который принимает кортеж из предыдущего шага и показывает на экран данные.
    //Вызов методов из метода Main.


    public static void Main(string[] args)
    {
        var userInfo = EnterUser();
        Console.WriteLine($"User Info:\nИмя {userInfo.Name} \nФамилия {userInfo.LastName} \nВозраст: {userInfo.Age} \nДомашние питомцы: {userInfo.Pets} \nЛюбимые цвета: {string.Join(", ", userInfo.favcolors)}");
    }

    static (string Name, string LastName, int Age, bool Pets, int[] favcolors) EnterUser()
    {
        (string Name, string LastName, int Age, bool Pets) User;

        Console.WriteLine("Введите имя");
        User.Name = Console.ReadLine();

        Console.WriteLine("Введите Фамилию");
        User.LastName = Console.ReadLine();

        //string age;
        //int intage;
        do
        {
            Console.WriteLine("Введите возраст цифрами");
            //age = Console.ReadLine();
        } while (!int.TryParse(Console.ReadLine(), out User.Age));
        //User.Age = intage;

        bool? Pets = null;
        do
        {
            Console.WriteLine("У вас есть домашний питомец ( Да/Нет):  ");
            var inPut = Console.ReadLine();
            if (inPut == "Да")
            {
                Pets = true;
            }
            else if (inPut == "Нет")
            {
                Pets = false;
            }


        }
        while (Pets == null);
        if (Pets != null && Pets == true)
        {
            var petsCount = ReadPositiveInt("Как мношо у вас домшних питомцов");
            var hasPets = ReadStrings(petsCount, "Имя животного/ых");
            Console.WriteLine(string.Join(", ", hasPets));
        }
        var colorCount = ReadPositiveInt("Как много у тебя любимых цветов");
        var colors = ReadStrings(colorCount, "Color:");

        //for (int i = 0; i < colorCount; i++)
        //{
        //    Console.Write($"Color № {i + 1}");
        //    var color = Console.ReadLine();
        //    colors[i] = color;
        //}
        //Console.WriteLine(string.Join(", ", colors));
        return EnterUser();
    }
    static bool CheckNum(string number, out int corrnumber)
    {


        if (int.TryParse(number, out int intnum))
        {
            if (intnum > 0)
            {
                corrnumber = intnum;
                return false;
            }
        }
        {
            corrnumber = 0;
            return true;
        }

    }
    static string[] ReadStrings(int count, string message)
    {
        var strings = new string[count];
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{message} № {i + 1}: ");
            strings[i] = Console.ReadLine();
        }
        return strings;
    }
    static int ReadPositiveInt(string message)
    {
        int colorCount;
        do
        {
            Console.Write($"{message}: ");
        } while (!int.TryParse(Console.ReadLine(), out colorCount) && colorCount <= 0);
        return colorCount;
    }
}