// shift alt f - форматирование 

using System;

class Program
{
// 3. Есть ли в массиве одинаковые элементы


    static void Main()
    {
        // Task1();
        // Task2();
        // Task3();
        // Task4();
        // Task5();
        // Task6();
        // TaskSameElements();
        // 
        TaskConsole();
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
        // Необходимо создать метод, который заполняет данные с клавиатуры по пользователю (возвращает кортеж):
        // Имя;
        // Фамилия;
        // Возраст;
        // Наличие питомца;
        // Если питомец есть, то запросить количество питомцев;
        // Если питомец есть, вызвать метод, принимающий на вход количество питомцев и возвращающий массив их кличек (заполнение с клавиатуры);
        // Запросить количество любимых цветов;
        // Вызвать метод, который возвращает массив любимых цветов по их количеству (заполнение с клавиатуры);
        // Сделать проверку, ввёл ли пользователь корректные числа: возраст, количество питомцев, количество цветов в отдельном методе;
        // Требуется проверка корректного ввода значений и повтор ввода, если ввод некорректен;
        // Корректный ввод: ввод числа типа int больше 0.
        // Метод, который принимает кортеж из предыдущего шага и показывает на экран данные.
        // Вызов методов из метода Main.

        var colorsCount = ReadPositiveInt("Количество цветов: ");
        var colors = ReadStrings(colorsCount, "Цвет");

        for (int i = 0; i < colorsCount; i++)
        {
            Console.Write($"Цвет №{i + 1}: ");
            var color = Console.ReadLine();
            colors[i] = color;
        }

        Console.WriteLine(string.Join("@", colors));

        // Домашка - вынести в отдельный меотод bool ReadBool(string message)
        // var hasPets = ReadBool("Есть ли питомцы (yes/y/no/n): ")
        bool? hasPets = null;
        do
        {
            Console.WriteLine("Есть ли питомцы (yes/y/no/n): ");
            var input = Console.ReadLine();
            if (input == "yes" || input == "y")
                hasPets = true;
            else if (input == "no" || input == "n")
                hasPets = false;
        } while (hasPets == null);

        if (hasPets != null && hasPets == true)
        {
            var petsCount = ReadPositiveInt("Количество питомцев: ");
            var pets = ReadStrings(petsCount, "Питомец");

            Console.WriteLine(string.Join(";", pets));
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
    }
}