using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Структурные_Паттерны;

/// <summary>
/// Adapter -  это структурный паттерн проектирования, который позволяет использовать классы с несовместимыми интерфейсами вместе. Он преобразует интерфейс одного класса в интерфейс другого, делая их совместимыми.. 
/// 
/// Основные компоненты паттерна
/// 1. Target — целевой интерфейс, с которым работает клиент
/// 2. Adaptee — адаптируемый класс, который нужно использовать
/// 3. Adapter — сам адаптер, который преобразует интерфейс Adaptee в Target
/// </summary>
public class AdapterInstance
{

}
//  Наш код, где необходимо использование класса-источника
class Client
{
    public void Request(DataSource dataSource)
    {
        dataSource.GetData();
    }
}
// Target — интерфейс DataSource
// Класс - источник ресурса, к которому нужно подключиться
class DataSource
{
    public virtual void GetData() { }
}
// Adaptee — класс DataConsumer
// Класс - потребитель ресурса
class DataConsumer
{
    public void GetSpecificData() { }
}
// Адаптер для подключения
class Adapter : DataSource
{
    private DataConsumer _dataConsumer = new DataConsumer();
}