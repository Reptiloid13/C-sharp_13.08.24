using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Collections;

public class StackQueueLinkedList
{
    //В общем смысле стек — это абстрактный тип данных,
    //позволяющий сохранить элементы в список  по принципу Last In — First Out (LIFO),
    //то есть последний сохраненный элемент будет обработан первым. 

    public static void Push()
    {
        var stack = new Stack<string>();

        stack.Push("FirstWord");
        stack.Push("LastWord");

        //   в стеке; FirstWord, LastWord


        // достанем  слово LastWord. FirstWord осталось в стеке
        var element = stack.Pop();

        // просмотрим  слово LastWord.  оба слова остались в стеке
        element = stack.Peek();
    }

    public static void Stack()
    {
        //  создадим числовой стек

        Stack<int> numbers = new Stack<int>();

        numbers.Push(3);
        numbers.Push(5);
        numbers.Push(8);

        Console.WriteLine("Элементы числового стека: ");

        foreach (var number in numbers)
            Console.WriteLine(number);

        Console.WriteLine($"Извлекаем верхний элемент из стека: {numbers.Pop()}");
        //  в стеке остались числа 5 и 3

        Console.WriteLine();

        // создадим стек объектов

        Stack<Person> persons = new Stack<Person>();
        persons.Push(new Person() { Name = "Ivan" });
        persons.Push(new Person() { Name = "Sergey" });
        persons.Push(new Person() { Name = "Anna" });

        Console.WriteLine("Элементы стека объектов: ");

        foreach (Person p in persons)
            Console.WriteLine(p.Name);

        Console.WriteLine($"Извлекаем верхний элемент из стека объектов: {persons.Pop().Name}");


    }

}

public class Person
{
    public string Name { get; set; }
}

public class Queue()

//Очередь (queue) — это коллекция, в которой элементы обрабатываются по схеме «первый вошел,
//первый вышел» (First In, First Out — FIFO).
//Enqueue() — добавляет элемент в конец очереди.
//Dequeue() — извлекает и возвращает первый элемент очереди.
//Так же, как и у стека, есть метод для просмотра
//крайнего элемента очереди без его удаления — Peek().
{
    public static void ExampleQueue()
    {
        // создаем очередь
        Queue<int> q = new Queue<int>();

        // добавляем в нее целые числа от 0 до 10

        for (int i = 0; i <= 10; i++)
        {
            q.Enqueue(i);
            Console.WriteLine($"{i} зашёл в очередь");
        }

        // Посмотрим, кто первый в очереди
        Console.WriteLine($"Первый элемент:   {q.Peek()}");

        //  Посмотрим всю очередь

        Console.WriteLine(" Элементы в очереди");

        foreach (int i in q)

            Console.Write(i + " ");

        Console.WriteLine();
        Console.WriteLine($"В очереди  {q.Count} элементов");

        // обработаем очередь -
        // достанем из неё элементы один за другим

        var queueLength = q.Count;

        for (int i = 0; i <= queueLength; i++)
            Console.WriteLine();

        Console.WriteLine($"{q.Dequeue()} вышел из очереди");
        //  Посмотрим, сколько элементов осталось
        Console.WriteLine($"В очереди  {q.Count} элементов");


    }

}

public class LinkedListTest()
{
    public static LinkedList<string> LinkedList = new LinkedList<string>();

    public static void LinkedListExample()
    {
        LinkedList.AddFirst("Fox");
        LinkedList.AddFirst("Wolf");
        LinkedList.AddLast("Rabbbit");

        var mouse = LinkedList.AddFirst("Mouse");

        GoOnwards(); //   Прямой проход списка
        GoBackwards();// Обратный проход списка
    }

    public static void GoOnwards()
    {
        LinkedListNode<string> node;

        Console.WriteLine("Элементы коллекции в прямом направлении: ");
        for (node = LinkedList.First; node != null; node = node.Next)
            Console.WriteLine(node.Value + " ");
    }

    public static void GoBackwards()
    {
        LinkedListNode<string> node;
        Console.WriteLine("\n\nЭлементы коллекции в обратном направлении: ");

        for (node = LinkedList.Last; node != null; node = node.Previous)
            Console.WriteLine(node.Value + " ");
    }
}

