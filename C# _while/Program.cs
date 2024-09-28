

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
        Task1();
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

        { Console.WriteLine("number"); }

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
        number2= Convert.ToChar(number2);

        Console.WriteLine( number + " " + number2); // Как ввести в Консоль Врайт Лайн два значения? 

        
    }
    
}