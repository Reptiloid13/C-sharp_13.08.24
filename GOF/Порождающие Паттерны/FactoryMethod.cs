using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF;
/// <summary>
///  это порождающий паттерн проектирования, который определяет интерфейс для создания объектов, позволяя подклассам изменять тип создаваемых объектов.
///  
/// Основные компоненты паттерна
/// Product — продукт, интерфейс или абстрактный класс создаваемых объектов
/// ConcreteProduct — конкретные продукты
/// Creator — абстрактный класс, содержащий фабричный метод
/// ConcreteCreator — конкретные классы, переопределяющие фабричный метод
/// </summary>
public class FactoryMethod
{

}
//Базовый абстрактный класс
abstract class BaseClass { }
//Конкретная реализация A
class ConcreteClassA : BaseClass { }
//Конкретная реализация B
class ConcreteClassB : BaseClass { }

abstract class Creator
{
    //Фабричный метод, который будет переопределен в классах-наследниках
    public abstract BaseClass FactoryMethod();
}

class ConcreteCreatorA : Creator
{

    public override BaseClass FactoryMethod()
    {
        return new ConcreteClassA();
    }
}
class CocreteCreatorB : Creator
{
    public override BaseClass FactoryMethod()
    {
        return new ConcreteClassB();
    }
}