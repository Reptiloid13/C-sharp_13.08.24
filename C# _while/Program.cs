using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Xml.XPath;

class Program
{
    static void Main()
    {
        //ArrayMultiply();
        //ArrayMultiplyVer2();
        // ArrayPlusOne();
        //ArrayWithoutZero();
        //ArraySumOddNumbers();
        //SymbolsLetterOrNumver();
        //Task1();
        //StringTask();
        // StringTask2();
        // StringTask3();
        Array3();
    }

    static void ArrayMultiply()
    {
        //       На ввод поступает массив размером n.  
        //Перемножьте каждый элемент массива на число n. 5
        //5 5 9 8 3

        int[] array = { 5, 5, 9, 8, 3 };
        int result = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (result > 0)
            {
                array[i] *= result;
            }
        }

        Console.WriteLine(string.Join("; ", array));
    }

    static void ArrayMultiplyVer2()
    {
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ');
        int[] array = new int[n];
        int result = array[0];


        for (int i = 0; i < s.Length; i++)
        {
            array[i] = Convert.ToInt32(s[i]);

            if (result > 0)
            {
                result *= array[i];
            }

            Console.Write(string.Join(" ", array));
        }
    }

    static void ArrayPlusOne()
    {
        int n;
        n = Convert.ToInt32(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ');
        int[] array = new int[n];
        int result = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(s[i]);

            if (array[i] % 2 == 0)
            {
                array[i] += 1;
            }
        }

        Console.Write(string.Join(", ", array));
    }

    static void ArrayWithoutZero()
    {
        // На ввод поступает целое число N, а далее Nе количество целых чисел.
        //Необходимо создать массив, заполнить его числами и вывести на экран все числа этого массива, отличные от "0", разделив их пробелами.

        int[] array = { 5, 4, 0, 2, 1, };

        // ПОЧему не работает через цикл for ?

        // for (int i = 0; i < array.Length; i++)
        // {
        //     if (array[i] != 0 && array[i] > 0)
        //         Console.Write(array[i] + " ");
        // }

        foreach (var item in array)
        {
            if (item != 0)
                Console.Write(item + " ");
        }
    }


    //    На ввод поступает целое число N, а далее Nе количество целых чисел.
    //Необходимо вывести на экран сумму всех нечетных элементов данного массива чисел.
    static void ArraySumOddNumbers()
    {
        int[] array = { 5, 5, 4, 3, 2 };
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                sum = sum + array[i];
            }
        }

        Console.Write(sum + " ");
    }


    static void SymbolsLetterOrNumver()
    {
        char a;
        a = Convert.ToChar(Console.ReadLine());

        if (char.IsDigit(a))

        {
            Console.WriteLine("number");
        }

        else if (char.IsLetter(a))
        {
            Console.WriteLine("letter");
        }
    }

    static void Task1()

        //        На ввод поступает число.
        //Программа должна вывести на консоль символ, соответствующий данному числу согласно таблице ASCII.

    {
        int number = Convert.ToInt32(Console.ReadLine());
        number = Convert.ToChar(number);
        int number2 = Convert.ToInt32(Console.ReadLine());
        number2 = Convert.ToChar(number2);

        Console.WriteLine(number + " " + number2); // Как ввести в Консоль Врайт Лайн два значения? 
    }

    static void StringTask()
    {
        // На ввод поступает строка состоящая из символов.
        //Определите кол-во  цифр в данной строке.  (Строка без пробелов). 
        //ac24e5sf0

        string a = Console.ReadLine();
        int numbers = 0;
        foreach (char ch in a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (ch >= '0' && ch <= '9')
                {
                }
            }
        }

        numbers++; // Не получается вывести кол-во цифр в  строке
        Console.WriteLine(numbers);
    }

    static void StringTask2()

    {
        //На ввод поступает строка, определите количество слов в строке

        string s = Console.ReadLine();
        int count = 1;
        for (int i = 0; i <= s.Length; i++)
        {
            if ((i < s.Length))
            {
                if ((s[i] == ' ') && (s[i - 1] != ' ')) count++;
            }
        }

        Console.WriteLine(count);
    }

    static void StringTask3()
    {
        //        Напишите программу, которая запрашивает положительное натуральное целое число,
        //        и выводит "YES", если в числе есть хотя бы один ноль, и "NO" иначе

        int num1 = Convert.ToInt32(Console.ReadLine());
        while (num1 > 0)
        {
            if (num1 % 10 == 0)
            {
                Console.Write("YES");
                num1++;
                break;
            }
            else
            {
                num1 = num1 / 10;
                Console.Write("NO");
                break;
            }
        }
    }

    static void Array3()
    {
        //        На ввод подается размер массива и сам массив.

        //Перезапишите и выведите массив на печать, где каждый элемент возведён в 3ю степень

        int n = Convert.ToInt32(Console.ReadLine());
        double[] numbers = new double[n];
        string[] item = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++)
        {
            numbers[i] = Convert.ToInt32(item[i]);
            numbers[i] = Math.Pow(numbers[i], 3);
        }

        Console.Write(string.Join(" ", numbers));
    }
}