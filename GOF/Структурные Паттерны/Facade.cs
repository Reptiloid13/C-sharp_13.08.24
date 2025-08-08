using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GOF.Структурные_Паттерны;
/// <summary>
/// Паттерн Facade скрывает сложность системы от клиентского кода с помощью предоставления универсального упрощенного интерфейса для взаимодействия с ней.
/// Когда используем? 
/// 1. Система сложна, необходимо упростить с ней работу. Фасад позволит определить одну упрощенную точку взаимодействия с ней.
/// 2. коде может возникнуть слишком много зависимостей между клиентом и сложной системой. Реализация фасада позволит отделить (изолировать) части и компоненты сложной системы от клиента и работать с ними независимо.
/// 3.Если нам нужно определить подсистемы компонентов в сложной системе. Создание фасадов для компонентов каждой отдельной подсистемы упрощает взаимодействие между ними.
/// 
/// Основные компоненты паттерна
/// 1. Facade — класс фасада, предоставляющий простой интерфейс
/// 2. Subsystem — подсистемы, которые фасад скрывает от клиента
/// </summary>
public class FacadeInstance
{
    public static void FacadeSolution()
    {
        // Клиент взаимодействует только с фасадом
        var facade = new Facade();
        facade.Operation();
    }

}
public class Facade
{
    private SubsystemA _subsystemA = new SubsystemA();
    private SubsystemB _subsystemB = new SubsystemB();
    private SubsystemC _subsystemC = new SubsystemC();

    public void Operation()
    {
        _subsystemA.OperationA();
        _subsystemB.OperationB();
        _subsystemC.OperationC();
    }
}
// Подсистема 1
public class SubsystemA
{
    public void OperationA()
    {
        Console.WriteLine("Подсистема A выполняет операцию");
    }
}
// Подсистема 2
public class SubsystemB()
{
    public void OperationB()
    {
        Console.WriteLine("Подсистема B выполняет операцию");
    }
}
// Подсистема 3
public class SubsystemC
{
    public void OperationC()
    {
        Console.WriteLine("Подсистема C выполняет операцию");
    }
}

