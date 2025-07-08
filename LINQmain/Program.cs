
using System;
using System.Linq;
using System.Text;

namespace LINQ;

public class Program
{
    static void Main(string[] args)
    {
        Examples();
        Examples2();
    }


    /// <summary>
    /// Есть массив строк:
    /// string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" }
    ///Задача: выбрать имена на букву А и отсортировать в алфавитном порядке.
    /// </summary>
    public static void Examples()
    {
        string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };


        var selectedPeople = from p in people // промежуточная переменная p/ Выражение from p in people проходит по всем элементам массива people и определяет каждый элемент как p. 
                             where p.StartsWith("A")// фильтрация по условию/ Далее с помощью оператора where проводится фильтрация объектов, и если объект соответствует критерию, то этот объект передаётся дальше.
                             orderby p//сортировка по возрастанию (дефолтная)/Оператор orderby упорядочивает по возрастанию, то есть сортирует выбранные объекты.
                             select p; //выбираем объект и сохраняем в выборк/
        foreach (var s in selectedPeople)
        {
            Console.WriteLine($"Выведи {s}");
        }
    }
    /// <summary>
    /// Вот тот же самый пример из начала курса, реализованный с помощью методов расширения:
    /// </summary>
    public static void Examples2()
    {
        string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };
        var selectedPeople = people.Where(p => p.StartsWith("A")).OrderBy(p => p);

        foreach (string s in selectedPeople)
            Console.WriteLine(s);
    }
}
