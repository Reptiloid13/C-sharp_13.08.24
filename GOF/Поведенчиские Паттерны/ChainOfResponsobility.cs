using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Поведенчиские_Паттерны;
/// <summary>
/// Chain of Responsibility — это поведенческий паттерн проектирования, который позволяет передавать запросы последовательно через цепочку обработчиков до тех пор, пока один из них не обработает запрос.
/// 
/// Признаки того, что мы можем использовать цепочку: 
/// 1. Имеется более одного объекта, который способен обрабатывать запрос.
/// 2. Нам нужно, чтобы запрос был обработан одни или несколькими объектами, но точно не определено, кем именно.
/// 3.Если у нас динамически задаётся набор объектов.
/// 
/// Основные компоненты паттерна
/// 1.Handler — базовый интерфейс или абстрактный класс для обработчиков
/// 2.ConcreteHandler — конкретные классы обработчиков
/// 3.Client — клиент, отправляющий запросы
/// 
/// </summary>
public class ChainOfResponsobility
{
}
// Клиент
public class Client
{
    public static void Solution()
    {
        // Создаем цепочку обработчиков
        var handler1 = new ConcreteHandler1();
        var handler2 = new ConcreteHandler2();

        handler1.SetSuccessor(handler2);

        // Отправляем запросы
        handler1.HandleRequest(new Request { Type = "Type1", Content = "Запрос 1" });
        handler1.HandleRequest(new Request { Type = "Type2", Content = "Запрос 2" });
        handler1.HandleRequest(new Request { Type = "Type3", Content = "Запрос 3" });

    }
}
// Базовый обработчик
public abstract class Handler
{
    protected Handler successor;

    public void SetSuccessor(Handler successor)
    {
        this.successor = successor;
    }
    public abstract void HandleRequest(Request request);
}

// Запрос
public class Request
{
    public string Type { get; set; }
    public string Content { get; set; }
}

// Конкретный обработчик 1
public class ConcreteHandler1 : Handler
{
    public override void HandleRequest(Request request)
    {
        if (request.Type == "Type1")
        {
            Console.WriteLine($"ConcreteHandler1 обработал запрос: {request.Content}");
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);
        }
    }
}
// Конкретный обработчик 2
public class ConcreteHandler2 : Handler
{
    public override void HandleRequest(Request request)
    {
        if (request.Type == "Type")
        {
            Console.WriteLine($"ConcreteHandler2 обработал запрос: {request.Content}");
        }
        else if (successor != null)
        {
            successor.HandleRequest(request);
        }
    }
}