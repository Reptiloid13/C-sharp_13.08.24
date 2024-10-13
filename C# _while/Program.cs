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
        //ListEvenNumbers();
        // ListStringsWords();
        //ReverseArray();
        // DictionaryWords();
        // ListCapacity();
        //Clone();
        RandomNumbers();


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

            if (result >= 0)
            {
                array[i] = array[i] * n;
            }

            Console.Write(string.Join(" ", array[i]));
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



    static void ListEvenNumbers()
    {
        var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var filtered = new List<int>();

        foreach (var number in numbers)
        {
            if (number % 2 == 0) filtered.Add(number);
        }

        Console.WriteLine("Чётные числа: " + string.Join(", ", filtered));
    }

    static void ListStringsWords()
    {
        var myList = new List<string>()
            { "Dog", "Cat", "Parrot", "Wolf", "10" }; // Можно ли создать int и string одновременно?

        var nums = new int[16];

        foreach (var item in myList)
        {
            Console.WriteLine("Enter Home animal: ");
            string animal = Console.ReadLine();

            if (ContainsAnimal(myList, animal))
            {
                Console.WriteLine($"Word has {animal} in the list");
            }
            else
                Console.WriteLine($"Word hasn't {animal} in the list");
        }
    }

    public static bool ContainsAnimal(List<string> list, string animal)
    {
        return list.Contains(animal);
    }

    static void ReverseArray()
    {
        var numbers = new List<int>() { 1, 2, 3, 4, 5 };
        var reversed = new List<int>();
        for (int i = numbers.Count - 1; i >= 0; i--)
        {
            reversed.Add(numbers[i]);
            // Console.WriteLine(string.Join("; ",numbers[i])); // Почему не получается вывести ответ в одну строку? 
        }

        Console.WriteLine(string.Join(";", reversed));
    }


    static void DictionaryWords()
    {
        //Нужно найти количество слов.
        //
        var text =
            "More Money, More Problems: Sean Diddy Combs accused of bribing music artists to tamper with the witnesses before trial.";
        var wordCount = new Dictionary<string, int>();
        var words = text.Split(' ', ',', '.', ':');

        foreach (var letter in text)
        {
            Console.WriteLine(letter);
        }

        Console.WriteLine("Количество слов: {0}  ", wordCount.Count);
        // Нужно найти количество слов, длина которых == 3.
        foreach (var word in words)
        {
            if (word.Length == 3)
            {
                // Console.WriteLine(word);
            }
        }


        // Начинаются с буквы М - Math math
        foreach (var word in words)
        {
            if (word != "")
            {
                var first = word[0].ToString().ToLower();
                if (first == "m")
                {
                    Console.WriteLine(word);
                }
            }
        }
    }

    static void ListCapacity()
    {
        List<int> list = new List<int>();

        for (int i = 0; i < 200; i++)
        {
            list.Add(i);
            // Console.WriteLine($"Nubmer now:  {list[i]}   Capacity: {list.Capacity}");
            if (list.Capacity == i + 1)
            {
                Console.WriteLine($"{list[i]} - число изменений Capacity {list.Capacity} ");
            }
        }
    }

    static void Clone()
    {
        //int[] array = { 5, 5, 9, 8, 3 };
        //int result = array[0];
        //int[] array2 = (int[])array.Clone();
        //array2 = { 1, 2, 3 } ;

        string original = "Big";
        string cloneOriginal = (string)original.Clone();
        cloneOriginal = original;
        cloneOriginal = "Small";
        Console.WriteLine($"{original}  получилось {cloneOriginal}");

    }

    static void RandomNumbers()
    {
        /*Случайное число: Напишите программу, 
          * которая генерирует случайное целое число от 1 до 100 и выводит его на экран.*/
        int numbers = new Random().Next(0, 101);
        Console.WriteLine(numbers);

        //Случайное слово: Создайте массив строк с названиями фруктов. 
        //    Напишите программу, которая выбирает случайный фрукт из этого массива и выводит его на экран.

        string[] array = { "Bananas", "Orange", "Pineapple", "Apple", "Blackberry" };
        int index = new Random().Next(0, array.Length);
        Console.WriteLine(array[index]);


        //Бросок кубиков: Напишите программу, которая симулирует бросок двух шестигранных кубиков и выводит сумму выпавших значений.
        int cube1 = new Random().Next(1, 7);
        int cube2 = new Random().Next(1, 7);
        int result = cube1 + cube2;
        Console.WriteLine($"На первом кубике выпало: {cube1} На втором кубике Выпало: {cube2} Итого: {result}");


    }
}