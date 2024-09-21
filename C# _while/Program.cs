// shift alt f - форматирование 

using System;

class Program
{
    // 3. Есть ли в массиве одинаковые элементы


    static void Main()
    {
        //Console.WriteLine("WTF");
        // Task1();
        // Task2();
        // Task3();
        // Task4();
        // Task5();
        // Task6();
        // TaskSameElements();
        // TaskDoubleMax();
        //TaskConsole();
        Massive1();


    }

    static void Task1()
    {
        // 1. Поиск максимального элемента в массиве
        var array = new int[] { 8, 9, 10 };

        int max = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
                max = array[i];
            }
        }

        Console.WriteLine(max);
    }

    static void Task2()
    {
        // 2. Вывести элементы массива, которые больше предыдущего
        var numbers = new int[] { 6, 3, 8, 11, 5, 6 };

        // numbers[i];
        // numbers[i-1];

        for (var i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > numbers[i - 1])
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }

    static void Task3()
    {
        // 3. Есть ли в массиве одинаковые элементы
        int[] array = { 6, 7, 6, 8 };

        var repeatedNumbers = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            var isRepeat = false;
            for (var j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    isRepeat = true;
                }
            }

            // if (!isRepeat)
            // if (isRepeat == false)
            if (isRepeat)
            {
                var isAlreadyRepeated = false;
                for (int k = 0; k < repeatedNumbers.Length; k++)
                {
                    if (array[i] == repeatedNumbers[k])
                    {
                        isAlreadyRepeated = true;
                    }
                }

                if (!isAlreadyRepeated)
                {
                    Console.WriteLine($"Повторяется {array[i]}");
                }
            }
            else
            {
                Console.WriteLine($"Не повторяется {array[i]}");
            }
        }
    }

    static void Task4()
    {
        // 4. Заменить элементы масси
        // Меняя исходный массивва на противоположные
        // Не меняя исходный массив

        var a = 1;
        var b = a;
        b = 5;

        var numbers = new int[] { 6, 3, 8, 11, 5, 6 };

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = numbers[i] * -1;
        }

        // Для каждого
        // foreach (var number in numbers)
        // {
        //     number = number * -1;
        // }
        //
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    static void Task5()
    {
        // Максимальный по модулю элемент массива
        var numbers = new int[] { -7, 6, -8, 1 };
        var max = 0;
        var minMax = -1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < 0)
            {
                minMax = numbers[i];
                minMax *= -1;
            }

            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        if (minMax > max)
        {
            minMax *= -1;
            Console.WriteLine(minMax);
        }
        else
        {
            Console.WriteLine(max);
        }
    }

    static void Task6()
    {
        //2.  Найти разность между
        //максимальным и минимальным элементами массива

        int[] array = { -6, -3, };
        var max = array[0];
        var min = array[0];


        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }


            if (array[i] < min)
            {
                min = array[i];
            }
        }

        Console.WriteLine($"Разность {max - min}");
    }

    static void TaskSameElements()
    {
        int[] array = { 5, 6, 7, 2, 1 };
        var same = false;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] == array[i])
                    same = true;
            }
        }

        if (same)
            Console.WriteLine("Повторяются");
        else
            Console.WriteLine("Не повторяются");
    }

    static void TaskDoubleMax()
    {
        int[] array = { 4, 6, 8, 12, 11 };
        int max1 = array[0];
        int max2 = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max1)
            {
                max1 = array[i];
            }

            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > max2 && array[j] < array[i])
                {
                    max2 = array[j];
                }
            }
        }

        Console.WriteLine($"Maximum 1 : {max1} , Maximum 2 :  {max2} ");
    }

    static void TaskConsole()
    {
        static (string Name, string LastName, int Age, bool Pets, int[] favcolors) EnterUser()
        {
            (string Name, string LastName, int Age, bool Pets) User;

            Console.WriteLine("Enter your name: ");
            User.Name = Console.ReadLine();

            Console.WriteLine("Enter your LastName: ");
            User.LastName = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            User.Age = Convert.ToInt32(Console.ReadLine());


            bool? Pets = null;
            do
            {
                Console.WriteLine("Do you have  pets (Yes/Y/No/N) : ");
                var inPut = Console.ReadLine();

                if (inPut == "Yes" || inPut == "Y")
                {
                    Pets = true;
                }
                else if (inPut == "NO" || inPut == "N")
                {
                    Pets = false;
                }
            }
            while (Pets == null);

            if (Pets != null && Pets == true)
            {
                var petsCount = ReadPositiveInt("Количество питомцев: ");
                var hasPet = ReadStrings(petsCount, "Pets: ");

                Console.WriteLine(string.Join(";", hasPet));

            }





            return EnterUser();



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
            int colorsCount;
            do
            {
                Console.Write(message);
            } while (!int.TryParse(Console.ReadLine(), out colorsCount) && colorsCount > 0);

            return colorsCount;

        }
    }



    static void Massive1()
    {
        /* На ввод поступает массив размером n.

Увеличьте каждый четный элемент массива на единицу.   */

        int n;
        n = Convert.ToInt32(Console.ReadLine());
        int result = 1;


        string[] s = Console.ReadLine().Split(' ');
        int[] array = new int[n];

        for (int i = 0; i > array.Length; i++)
        {
            array[i] = Convert.ToInt32(s[i]);


            if (array[i] % 2 == 0)
            {
                result = array[i] + 1;


            }



        }

        Console.WriteLine(result);

    }
    //    var square = new Rectangle() { Width = 20, Height = 4 };
    //    Console.WriteLine(square.Area());

    //struct Rectangle
    //    {
    //        public int Width, Height;


    //        public Rectangle(int width, int heigt)
    //        {
    //            Width = width;
    //            Height = heigt;

    //        }

    //        public int Area()
    //        {
    //            return Width * Height;
    //        }



}