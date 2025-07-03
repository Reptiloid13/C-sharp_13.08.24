using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections;

// 1.Коллекция, содержащая не повторяющиеся (уникальные) элементы,
// иначе называется множеством (set).
//2.Во всех случаях, когда вам нужна уникальность, но не важна упорядоченность элементов,
//с точки зрения производительности оптимально использовать именно его.
//3.HashSet<T> также способен автоматически изменять размер при добавлении/удалении элементов.
public class HashSet
{
    public static void Example()
    {
        // Создаем массив строк

        string[] names = { "Igor", "Andrew", "Vasya", "Sofia", "Helen", "Anna", "Igor" };

        //выведем длинну массива в консоль

        Console.WriteLine($"Длинна массива {names.Length}");
        Console.WriteLine();
        Console.WriteLine("Данные в массиве");

        foreach (var name in names)
            Console.WriteLine(name);
        Console.WriteLine();

        //Создаем хэш-сэт, передавая в конструктор наш маасив

        HashSet<string> hSet = new HashSet<string>(names);

        //посчитаем объекты в массиве 
        Console.WriteLine("Длина хэш-сета " + hSet.Count);
        Console.WriteLine();

        //выведем все элементы в консоль и посмотрим есть ли дубликаты

        Console.WriteLine("Элементы в хэшсете:");
        foreach (var name in hSet)
            Console.WriteLine(name);


        //4.UnionWith()
        // Используется для объединения сета с другой коллекцией.

        hSet.UnionWith(new[] { "Dmitriy", "Sergei", "Igor" });

        Console.WriteLine("Элементы после объединения с новой коллекцией: ");

        foreach (var name in hSet)
            Console.WriteLine(name);


    }
}
