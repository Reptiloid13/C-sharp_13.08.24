using System.Numerics;
using System.Security.Authentication;

namespace List;

class Program
{
    public static void Main(string[] args)
    {
        int number1 = new Random().Next(0, 100);
        Console.WriteLine($"Первое число: " + number1);
        int number2 = new Random().Next(0, 100);
        Console.WriteLine($"Второе число:  " + number2);

        var sum = MathHelper.Add(number1, number2);
        Console.WriteLine($"Результат: " + sum);


        var multiply = MathHelper.Multiply(number1, number2);
        Console.WriteLine($"Результат: " + multiply);

        // var mathHelper1 = new MathHelper() { number1 = 1, number2 = 2 };
        // var mathHelper2 = new MathHelper() { number1 = 3, number2 = 4 };

        MathHelper.Add(5, 3);
    }

    //1. Создайте класс MathHelper с статическим методом add, который принимает два целых числа и возвращает их сумму.
    //Используйте этот метод для вычисления суммы двух чисел.
}

class MathHelper
{
    public static int Add(int number1, int number2)
    {
        return number1 + number2;
    }

    public static int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }
}