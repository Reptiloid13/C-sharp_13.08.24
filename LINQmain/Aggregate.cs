using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ;

/// <summary>
/// Агрегация. Примеры таких операций: выборка (получение определенного числа элементов), получение максимально и среднего значений в выборке, различные арифметические операции над значениями.
/// </summary>
public class Aggregate
{

    public static void AggregateExample()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int result = numbers.Aggregate((x, y) => x - y);
        // вычислит 1-2-3-4-5 = -13
        Console.WriteLine(result);

        //Другие арифметические действия также возможны: 
        int sum = numbers.Aggregate((x, y) => x + y);

    }
    /// <summary>
    /// Факториал натурального числа n — это произведение всех натуральных целых чисел от 1 до n включительно
    /// </summary>
    public static void Task1521()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        var result = numbers.Aggregate((x, y) => x * y);
        Console.WriteLine(result);
    }
    //Напишите метод, возвращающий среднее арифметическое числовых объектов коллекции.


    public static void Task1523()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        var result = numbers.Average();

    }

}

