
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

class MainClass
{
    //Разделить метод из задания 5.1.6 GetArrayFromConsole() на два: один метод GetArrayFromConsole() должен 
    //    читать введенные с клавиатуры массивы и возвращать их, второй метод SortArray() 
    //    должен принимать параметром массив array типа данных int, сортировать его и возвращать


    public static void Main(string[] args)
    {
        var x = GetArrayFromConsole();
        var a = SortArray(x); // Ну Почему!?!?! 
    }

    static int[] GetArrayFromConsole()
    {
        var result = new int[5];

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine("Введите элемент массива номер {0} ", i + 1);
            result[i] = int.Parse(Console.ReadLine());

        }
        return result;
    }

    static int[] SortArray(int[] array)
    {


        int temp = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
                if (array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }

        }


        return array;
    }

}