using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF;

/// <summary>
/// Abstract Factory — это порождающий паттерн проектирования, который предоставляет интерфейс для создания семейств взаимосвязанных или зависимых объектов, не специфицируя их конкретных классов.
/// 
/// Основные компоненты паттерна
/// 
/// 1. Abstract Factory — интерфейс или абстрактный класс, который объявляет методы создания продуктов.
/// 2.Concrete Factory — конкретные классы, реализующие интерфейс Abstract Factory.
/// 3.Abstract Product — интерфейсы или абстрактные классы для продуктов.
/// 4.Concrete Product — конкретные классы продуктов.
/// 
/// 
/// </summary>
public class AbstractFactory
{

}

// Абстрактные продукты
abstract class AbstractProductA { }
abstract class AbstractProductB { }
// Конкретные продукты
class ProductA1 : AbstractProductA { }
class ProductB1 : AbstractProductB { }
class ProductA2 : AbstractProductA { }
class ProductB2 : AbstractProductB { }

//Интерфейс абстрактной фабрики
interface IAbstractFactory
{

    /// Абстрактные методы для создания продукта
    AbstractProductA CreateProductA();
    AbstractProductB CreateProductB();
}
/// <summary>
/// Первая конкретная реализация фабрики
/// </summary>
class ConcreteFactory1 : IAbstractFactory //TODO  Почему здесть не нужно писать модифиикатор доступа? Какой он по умолчанию? 
{
    public AbstractProductA CreateProductA()
    {
        return new ProductA1();
    }
    public AbstractProductB CreateProductB()
    {
        return new ProductB1();
    }
}

class ConcreteFactory2 : IAbstractFactory
{
    public AbstractProductA CreateProductA()
    {
        return new ProductA2();
    }
    public AbstractProductB CreateProductB()
    {
        return new ProductB2();
    }
}
/// <summary>
///  Класс, в котором нам нужно предусмотреть создание объектов фабрикой
/// </summary>
class Client
{
    private AbstractProductA _abstractProductA;
    private AbstractProductB _abstractProductB;

    public Client(IAbstractFactory factory)
    {
        _abstractProductB = factory.CreateProductB();
        _abstractProductA = factory.CreateProductA();
    }
    /// <summary>
    /// Метод с нашей бизнес-логикой, где будут использоваться создаваемые фабрикой объекты
    /// </summary>
    public void Run() { }
}