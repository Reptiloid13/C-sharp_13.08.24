using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Поведенчиские_Паттерны;
/// <summary>
/// State — это поведенческий паттерн проектирования, который позволяет объекту изменять свое поведение в зависимости от внутреннего состояния.
/// 
/// Основные компоненты паттерна
/// 1.Context — контекст, который делегирует работу текущему состоянию
/// 2.State — базовый интерфейс или абстрактный класс состояний
/// 3.ConcreteState — конкретные классы состояний
/// 
/// когда используем? 
/// 1. Когда поведение некоторых объектов в нашей программе может динамически изменяться в зависимости от состояния.
/// 2.Когда вы обнаружили в коде слишком много условных конструкций, которые обрабатывают различные состояния одного объекта.
/// </summary>
public class StateInstance
{
    public static void Solution()
    {
        var context = new Context();

        context.Request(); // Состояние A
        context.Request(); // Состояние B

        context.Request(); // Состояние A
    }
}

// Интерфейс состояния
public interface IState
{
    void Handle(Context context);
}
// Конкретное состояние 1
public class StateA : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Состояние A обрабатывает запрос");
        context.SetState(new StateB());
    }
}
// Конкретное состояние 2
public class StateB : IState
{
    public void Handle(Context context)
    {
        Console.WriteLine("Состояние B обрабатывает запрос");
        context.SetState(new StateA());
    }
}
// Контекст
public class Context
{
    private IState _state;
    public Context()
    {
        _state = new StateA();
    }
    public void SetState(IState state)
    {
        _state = state;
    }
    public void Request()
    {
        _state.Handle(this); // TODO Почему так написано? 
    }

}