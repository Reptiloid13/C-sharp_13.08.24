using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Поведенчиские_Паттерны;
/// <summary>
/// Observer — это поведенческий паттерн проектирования, который позволяет объектам оповещать другие объекты о происходящих с ними изменениях.
/// 
/// Основные компоненты паттерна
/// 1.Subject (Субъект) — объект, за которым наблюдают
/// 2.Observer (Наблюдатель) — интерфейс для объектов-подписчиков
/// 3. ConcreteSubject — конкретный субъект
/// 4. ConcreteObserver — конкретные наблюдатели
/// 
/// Когда стоит использовать? 
/// 1. Наша система содержит множество классов, причем состояние объектов должно быть синхронизировано.
/// 2. Если есть две стороны: одна из них рассылает сообщения и является главной, другая должна получать и реагировать. При этом логика разделена, а системы могут рассматриваться и использоваться независимо друг от друга.
/// 3. Если существует один объект-источник сообщений, а у него есть множество подписчиков. Количество последних при этом заранее неизвестно и может меняться в процессе работы программы.
/// </summary>
public class Observer
{

}
// Интерфейс наблюдателя
interface IObserver
{
    void Update(string message);
}
// Интерфейс субъекта
public abstract class Subject
{

    private List<IObserver> _observers = new List<IObserver>();

    void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }
    void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }
    public void Notify(string message)
    {
        foreach (var observer in _observers)
            observer.Update(message);
    }
}
// Конкретный субъект
public class ConcreteSubject : Subject
{
    public void PerformAction()
    {
        // Имитация действия
        string message = "Действие выполнено!";
        Notify(message);
    }
}
// Конкретный наблюдатель 1
public class ConcreteObserver1 : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"Observer1 получил сообщение: {message}");
    }
}
// Конкретный наблюдатель 2
public class ConcreteObbserver2 : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"Observer2 получил сообщение: {message}");
    }
}