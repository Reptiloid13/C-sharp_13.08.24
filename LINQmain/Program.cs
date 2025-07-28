
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace LINQ;


public class Program
{
    static void Main(string[] args)
    {
        //Examples();
        //Examples2();
        //Task82();
        //Filtration.WhereExample2();
        //SetOperation.Task1514();
        //Aggregate.Task1521();
        GroupBy.GroupByExample();

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
                             where p.StartsWith("А")// фильтрация по условию/ Далее с помощью оператора where проводится фильтрация объектов, и если объект соответствует критерию, то этот объект передаётся дальше.
                             orderby p//сортировка по возрастанию (дефолтная)/Оператор orderby упорядочивает по возрастанию, то есть сортирует выбранные объекты.
                             select p; //выбираем объект и сохраняем в выборк/
        foreach (var s in selectedPeople)
        {
            Console.WriteLine($"{s}");
        }
    }

    /// <summary>
    /// Вот тот же самый пример из начала курса, реализованный с помощью методов расширения:
    /// </summary>
    public static void Examples2()
    {
        string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };
        var selectedPeople = people.Where(p => p.StartsWith("А")).OrderBy(p => p);

        foreach (string s in selectedPeople)
            Console.WriteLine(s);
    }
    /// <summary>
    /// Используйте выражения LINQ, чтобы достать оттуда все имена и вывести их в консоль в алфавитном порядке.
    /// </summary>
    public static void Task8()
    {

        var objects = new List<object>
{
    1,
    "Сергей",
    "Андрей",
    300
};
        var selectedPeopele = from p in objects
                              where p is string // проверка на совместимость с типом
                              orderby p // сортировка по имени
                              select p; // выборка
        foreach (var s in selectedPeopele)
        {
            Console.WriteLine(s);
        }



    }
    /// <summary>
    ///  Перепишите программу из задания выше, используя методы-расширения так, 
    ///  чтобы вывод на консоль и сортировка происходили в две строчки.
    /// </summary>

    public static void Task82()
    {

        var objects = new List<object>
{
    1,
    "Сергей",
    "Андрей",
    300
};

        var people = objects.Where(p => p is string).OrderBy(p => p);
        foreach (var s in people)
            Console.WriteLine(s);


    }
}
