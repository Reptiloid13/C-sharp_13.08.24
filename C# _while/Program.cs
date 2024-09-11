// shift alt f - форматирование 

class Program
{
// 3. Есть ли в массиве одинаковые элементы


    static void Main()
    {
        // Task1();
        // Task2();
        // Task3();
        // Task4();
        Task5();
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
        // 4. Заменить элементы массива на противоположные
        // Не меняя исходный массив
        // Меняя исходный массив

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

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < 0)
            {
                numbers[i] *= -1;
            }

            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        Console.WriteLine(max);
    }
}