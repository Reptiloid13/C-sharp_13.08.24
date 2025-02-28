using System.Data;

namespace Playground;

class Program
{



    public static void Main()
    {

        //BiggestElement();
        //SmallestElement();
        // SumElements();
        //ReverseArray();
        // Numbers();
        // Multiply();
        //PlusOne();
        //Multiply2();
        //ThirdDegree();
        //UnNull();
        OddNumbers();
    }
    //Создать метод для нахождения наибольшего элемента массива
    public static void BiggestElement()
    {
        int[] array = [1, 5, 6, 29];

        var maxValue = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];

            }

        }

        Console.WriteLine(maxValue);
    }
    // Найти наименьшее числа массива
    public static void SmallestElement()
    {
        int[] array = [2, 5, 1, 29];
        var minValue = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minValue)
            {
                minValue = array[i];
            }
        }
        Console.WriteLine(minValue);

    }


    //. Создать Метод для нахождения суммы всех элементов массива

    public static void SumElements()
    {
        int[] array = [2, 5, 1, 29];
        var sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        Console.WriteLine(sum);
    }

    // Развернуть массив

    public static void ReverseArray()
    {
        int[] array = [2, 5, 1, 29];
        // Array.Reverse(array);
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write($" {array[i]}");
        }


    }

    // На ввод подается массив, последнее число массива 0.
    //Узнайте количество чисел в этом массиве.

    public static void Numbers()
    {
        int[] array = [2, 5, 1, 29, 0];

        for (int i = 0; i <= array.Length; i++)
        {

        }
        Console.WriteLine(array.Length);

    }
    //Найдите произведение четных чисел в этом массиве.
    public static void Multiply()
    {

        int[] array = [2, 3, 6, 5, 10];
        var multiply = 1;

        for (int i = 0; i < array.Length; i++) //  Почему нельзя поставить знак <=
        {
            if (array[i] % 2 == 0)
            {
                multiply = multiply * array[i];
            }
        }
        Console.WriteLine(multiply);

    }
    //Увеличьте каждый четный элемент массива на единицу.
    public static void PlusOne()
    {
        int[] array = [2, 3, 6, 5, 10];



        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                array[i] += 1;
            }
        }
        foreach (int plusOne in array) // выводит что то непонятное
        {
            Console.WriteLine(plusOne);
        }

    }

    //   9) На ввод поступает массив размером n.

    //Перемножьте каждый элемент массива на число n.

    public static void Multiply2()
    {
        int[] array = { 2, 3, 6, 5, 10 };

        var number = 5;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] *= number;
        }

        foreach (int numbers in array)
        {
            Console.WriteLine(numbers);
        }
    }

    //    10) На ввод подается размер массива и сам массив.

    //Перезапишите и выведите массив на печать, где каждый элемент возведён в 3ю степень

    public static void ThirdDegree()
    {
        double[] array = { 2, 3, 6, 5, 10 };
        // double result = 0;

        for (int i = 0; i < array.Length; i++)
        {
            // result = Math.Pow(array[i], 3);
            array[i] = Math.Pow(array[i], 3);
        }


        foreach (int numbers in array)
        {
            Console.WriteLine(numbers);
        }
    }

    //  Необходимо создать массив, заполнить его числами и вывести на экран все числа этого массива, отличные от "0", разделив их пробелами.

    public static void UnNull()
    {
        int[] array = { 0, 2, 3, 6, 5, 10 };

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != 0)
            {
                Console.WriteLine(array[i]);
            }
        }


    }
    // Необходимо вывести на экран сумму всех нечетных элементов данного массива чисел.
    public static void OddNumbers()
    {
        int[] array = { 2, 3, 6, 5, 10 };
        int result = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                result += array[i];
            }

        }
        Console.WriteLine(result);
    }
}
