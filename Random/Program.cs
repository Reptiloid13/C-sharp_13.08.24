using Playground2.Tasks1;
using System;
using System.Security.Cryptography.X509Certificates;
namespace Playground2.Tasks1;


// В задаче имеется "Крикун", который будет кричать,
// как только массив дойдет до цифры 35. 
// Как только i = 35, мы должны вызвать событие OnScream,
// которое ссылается на метод Scream()

// Как только Scream крикнул =>  мы вызываем событие
//AskWhyScream. Которое ссылается на перезагружаемый метод Scream()



class Program
{

    public static void Main(string[] args)
    {
        //GetMaxElement();
        //GetSum();
        //GetMinElement();
        ChangeTwoElements();
        //GetBigger();
        // GetModulMax();
        //GetMultiplicationTable();

    }
    //Напишите программу, в которую пользователь 
    //    вводит 5 целых чисел и выводит их среднее значение.
    public static void AverageValue()
    {
        int[] array = [4, 5, 6, 3, 2];

        var sum = GetSum(array);
        var average = (double)sum / array.Length;

        Console.WriteLine(average);
    }

    //Создать функцию для нахождения наибольшего элемента массива/списка.
    public static void GetMaxElement()
    {
        int[] array = [4, 2, 5, 6, 7];
        int max = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        Console.WriteLine(max);
    }

    //Создать функцию для нахождения суммы всех элементов массива/списка.
    public static int GetSum(int[] array)
    {

        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    //Создать функцию, которая возвращает наименьший элемент массива и его порядковый номер.

    public static void GetMinElement()
    {
        int[] array = [4, 2, 5, 6, 7];
        int min = array[0];
        var index = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index = i;

            }
        }
        Console.WriteLine($" наименьший элемент - {min} Его порядковый номер - {index}");
    }

    //Создать функцию, которая меняет местами значения двух переменных.

    public static void ChangeTwoElements() // out ref
    {
        int[] array = [4, 2, 5, 6, 7];
        var temp = 0;

        for (int i = 0; i < array.Length; i++)
        {
            temp = array[0];
            array[0] = array[i];
            array[i] = array[1];
        }
        Console.WriteLine(temp);
    }


    //  Вывести элементы массива, которые больше предыдущего.
    //Например, для массива[2, 7, 4, 3, 6, 8, 1] ответ будет[7, 6, 8]

    public static void GetBigger()
    {
        int[] array = [2, 7, 4, 3, 6, 8, 1];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[i - 1])
            {
                Console.WriteLine(array[i]);
            }

        }


    }

    //Найти максимальный по модулю элемент массива. [5, 3, -4, 6, -7, 6, 2] -> -7


    public static void GetModulMax()
    {
        int[] array = [5, 3, -4, 6, -7, 6, 2];
        int max = 0;

        for (int i = 0; i < array.Length; i++)
        {

            //if (Math.Abs(array[i]) > Math.Abs(max))
            //{
            //    max = array[i];
            //}
            if (array[i] < 0)
            {
                array[i] *= -1;
            }
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        Console.WriteLine(max);
    }


    //Найти количество перестановок для массива чисел. Пример: [20, 93, 11] -> 6

    public static void GetSwapElements()
    {
        int[] array = { 20, 93, 11 };
        var swap = 0;

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] != array[j])
                {

                }
            }
        }




    }

    // Вывести таблицу умножения
    public static void GetMultiplicationTable()
    {
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                Console.WriteLine($"{i} x {j} = {i * j,3}");
            }
        }
    }

    // 1 ) Напишите программу, в которую пользователь вводит свой пол(
    //    "М" для мужского, "Ж" для женского) 
    //    и выводит ответное сообщение "Вы мужчина" или "Вы женщина". 
    //    В случае иного ввода программа должна вывести сообщение 
    //    "Некорректный ввод"


    // 2) Калькулятор времени: Напишите программу,
    // которая принимает от пользователя количество часов и минут, а затем выводит общее количество минут.
    //Пользователь вводит сначала число часов, потом число минут.
    //Программа выводит лишь одно число - число минут.
}