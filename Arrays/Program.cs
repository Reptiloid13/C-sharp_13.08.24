using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace Arrays;

public class GetNumberException : Exception
{
    public GetNumberException(string message) : base(message) { }

}
internal class Program
{

    static void Main(string[] args)
    {
        //MaxAndMinElements();
        //FindCurrentNumber();
        // GetDifference();
        //GetPosNegArrays();
        //DeleteRepeatElements();
        //Strings.FunctionWordsCount();
        //Strings.FunctionReplace();
        StepicTask();


    }
    //нахождения всех максимальных или минимальных чисел в массиве

    public static void MaxAndMinElements()
    {
        int[] array = [2, 7, 1, 8, 6, 8, 1];
        PrintArray(array);

        var max = FindAllMaxElements(array);
        Console.WriteLine($"Максимальный элемент - {string.Join(",", max)}");

        var min = FindAllMinElements(array);
        Console.WriteLine($"Минимальный элемент - {string.Join(",", min)}");

        var reverse = ReverseArray(array);
        Console.WriteLine($"Разворачиваем  Массив  - {string.Join(",", reverse)}");

        List<int> firstHalf = new List<int>();
        List<int> secondHalf = new List<int>();

        SplitArray(array, firstHalf, secondHalf);
        Console.WriteLine(string.Join(",", firstHalf));
        Console.WriteLine(string.Join(",", secondHalf));



        var result = SplitArray2(array);
        Console.WriteLine(string.Join(",", result.firstHalf));
        Console.WriteLine(string.Join(",", result.secondHalf));


    }

    public static void PrintArray(int[] array)
    {
        foreach (int i in array)
        {
            Console.Write($" {i} ");
        }
        Console.WriteLine();
    }

    public static List<int> FindAllMaxElements(int[] array) // находим максимальные элементы
    {
        List<int> result = new List<int>();
        int max = array[0];


        foreach (int number in array)
        {
            if (number > max)
            {
                max = number;
                result = new List<int> { number };
            }
            else if (number == max)
            {
                result.Add(number);
            }

        }

        return result;
    }
    public static List<int> FindAllMinElements(int[] array) // находим минимальные элементы
    {
        List<int> result = new List<int>();
        int min = array[0];

        foreach (int number in array)
        {
            if (number < min)
            {
                min = number;
                result = new List<int> { number };


            }
            else if (number == min)
            {
                result.Add(number);
            }
        }
        return result;
    }

    //переворачивания массива(с конца в начало)
    public static List<int> ReverseArray(int[] array) // разворачиваем массив
    {
        List<int> result = new List<int>();
        foreach (int number in array) { result.Add(number); }
        result.Reverse();


        return result;
    }


    public static void SplitArray(int[] array, List<int> firstHalf, List<int> secondHalf)
    {
        int mid = array.Length / 2;
        //int firstHalf = new int[mid];
        //secondHalf = new int[array.Length - mid];

        for (int i = 0; i < mid; i++)
        {
            firstHalf.Add(array[i]);

        }
        for (int i = mid; i < array.Length; i++)
        {
            secondHalf.Add(array[i]);
        }

    }
    public static List<int> CopyArray(int[] array, int begin, int end)
    {
        var result = new List<int>();

        for (int i = begin; i < end; i++)
        {
            result.Add(array[i]);
        }
        return result;
    }

    public static (List<int> firstHalf, List<int> secondHalf) SplitArray2(int[] array)
    {
        int mid = array.Length / 2;

        var firstHalf = CopyArray(array, 0, mid);
        var secondHalf = CopyArray(array, mid, array.Length);

        return (firstHalf, secondHalf);
    }

    // Задание 1. Определить, содержит ли массив данное число.Продумать что возвращать, если нет искомого числа.
    public static void FindCurrentNumber()
    {
        int[] array = [2, 7, 1, 8, 6, 8, 1];
        PrintArray(array);

        var index = GetCurrentNumber(array, 6);
        Console.WriteLine($"Искомое число находится по индексу -  {index}");

        index = GetCurrentNumber(array, 0);
        Console.WriteLine($"Искомое число находится по индексу -  {index}");
    }


    public static int GetCurrentNumber(int[] array, int curNumber)
    {
        // var curNumber = 6; // Есть ли наибольшее число в массиве выше решали

        // Console.WriteLine(curNumber);

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == curNumber)
            {
                // Console.WriteLine($"Текущие число - {curNumber} Есть в массиве - {array[i]}");
                return i;
            }


        }

        throw new GetNumberException($"Текущего числа {curNumber} нет в массиве ");
    }

    //  Задание 2. Найдите количество элементов массива, которые отличны от наибольшего элемента не более чем на 10%.

    public static void GetDifference()
    {
        int[] array = [20, 75, 10, 60, 50, 80, 75, 10];
        PrintArray(array);
        var max = GetMaximum(array);
        Console.WriteLine($"Maximum Element - {max}");
        var count = FindTenPercentDifference(array);
        Console.WriteLine($"Количество элементов, которые отличаются от максимума на 10%  - {count}");

    }



    public static int FindTenPercentDifference(int[] array)
    {
        var max = GetMaximum(array);

        var count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            double difference = Math.Abs(array[i] - max);
            double percent = difference / max * 100;
            if (percent <= 10)
            {
                count++;
            }

        }
        return count;
    }



    public static int GetMaximum(int[] array)
    {
        var max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    //Задание 4. Найти в массиве все положительные и отрицательные числа, переместить их в два разных массива, подсчитать количество нулей, положительных и отрицательных элементов.

    public static void GetPosNegArrays()
    {
        int[] array = [-4, 3, -2, 6, 0, 7, 0, -10, 0];
        PrintArray(array);
        var positive = GetPositiveArray(array);
        PrintArray(positive.ToArray());

        Console.WriteLine(positive.Count);

        var negative = GetNegativeArray(array);
        PrintArray(negative.ToArray());

        Console.WriteLine(negative.Count);

        var zero = GetZeroArray(array);
        PrintArray(zero.ToArray());

    }
    public static List<int> GetPositiveArray(int[] array) // Решить через ЛИСТ 
    {
        List<int> positiveArray = new List<int>();



        foreach (int item in array)
        {
            if (item > 0)
            {
                positiveArray.Add(item);
            }
        }
        return positiveArray;
    }
    public static List<int> GetNegativeArray(int[] array) // Решить через ЛИСТ 
    {
        List<int> negativeArray = new List<int>();



        foreach (int item in array)
        {
            if (item < 0)
            {
                negativeArray.Add(item);
            }
        }
        return negativeArray;
    }


    public static List<int> GetZeroArray(int[] array)
    {
        List<int> zeroArray = new List<int>();



        foreach (int item in array)
        {
            if (item == 0)
            {
                zeroArray.Add(item);
            }
        }
        return zeroArray;
    }

    // Задание 3. Удалить в массиве все числа, которые повторяются более двух раз.
    public static void DeleteRepeatElements()
    {
        int[] array = [5, 4, 5, -3, 2, 2, 0];
        PrintArray(array);
        var repeatElements = ThrowRepeatElements(array);
        PrintArray(repeatElements.ToArray());


    }

    public static List<int> ThrowRepeatElements(int[] array)
    {
        Dictionary<int, int> countElements = new Dictionary<int, int>();
        foreach (int item in array)
        {
            if (countElements.ContainsKey(item))
            {
                countElements[item]++;
            }
            else
            {
                countElements[item] = 1;
            }
        }

        List<int> repeatElements = new List<int>();

        foreach (int item in array)
        {
            if (countElements[item] <= 1)
            {
                repeatElements.Add(item);
            }
        }

        return repeatElements;

    }



    public static void StepicTask()
    {



        var array = CreateArray();
        Test(array);


        foreach (var num in array)
        {
            Console.Write(num + " ");
        }



    }
    public static int[] CreateArray()
    {
        var n = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[n];

        string[] ss = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            numbers[i] = Convert.ToInt32(ss[i]);
        }
        return numbers;
    }

    //Дан массив, состоящий из целых чисел.
    //    Напишите программу, которая вычитает из всех элементов массива минимальный элемент.

    public static void Test(int[] array)
    {

        var min = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];


            }


        }
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i] - min;


        }





    }

}
