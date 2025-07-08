using System.Collections;
using System.Diagnostics;

namespace Collections;

public class Program
{
    static void Main(string[] args)
    {
        //HashSet.Example();
        //Task13310();
        Dictionary.DictionaryTasks();
        SortedDictionary.SortedTask1345();
    }

    public static void Task1325()
    {
        //Сохраните их значения в ArrayList так,
        //чтобы после строкового названия месяца шёл его числовой номер.


        var months = new[]
{
   "Jan", "Feb", "Mar", "Apr", "May" , "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
};

        var numbers = new[]
        {
   1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
};

        // Инициализируем ArrayList
        var arrayList = new ArrayList();

        // пробегаемся по массиву
        foreach (var number in numbers)
        {
            // Добавляем в ArrayList строку месяца (начинаем с нулевого по индексу)
            arrayList.Add(months[number - 1]);

            // Добавляем его порядковый номер
            arrayList.Add(numbers);
        }
        foreach (var value in arrayList)
        {
            Console.WriteLine(value);
        }


    }

    public static void Task13310()
    //Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>,
    //учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.

    // 1. Инициализирова Хашсэт
    //2. Добавить текст 

    {
        var sentence =
             "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>, учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";

        // сохраняем в массив char
        var characters = sentence.ToCharArray();

        var symbols = new HashSet<char>();

        // добавляем во множество. Сохраняются только неповторяющиеся символы
        foreach (var symbol in characters)
            symbols.Add(symbol);

        // Выводим результат
        Console.WriteLine(symbols.Count);

    }
}
