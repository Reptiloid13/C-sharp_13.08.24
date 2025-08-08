using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Поведенчиские_Паттерны;
/// <summary>
/// Попробуем написать небольшую модель биржевых торгов. Пример сюда подходит очень хорошо, так как в этом случае у нас как раз есть объект наблюдения (курс валюты на бирже) и куча наблюдателей в лице банков и частных брокеров.
/// </summary>
public class ObserverRealityInstance
{

}
//Начнём с общего интерфейса для наблюдателя. Предусмотрим метод Update() для получения информации:
interface IObserverExample
{
    void Upgdate(Object o);
}
//И нам понадобится модель данных, которые наблюдатели могли бы получать с биржи.
//Пусть это будет курс доллара и евро в рублях: 
class StockData
{
    public int USD { get; set; }
    public int Euro { get; set; }
}
/// <summary>
/// Интерфейс наблюдаемого объекта(источника информации, на который подписаны наблюдатели)
/// </summary>
interface IObservable
{
    // добавить наблюдателя
    void RegisterObserver(IObserver observer);
    // удалить наблюдателя
    void RemoveObserver(IObserver observer);

    // уведомление наблюдателей
    void NotifyObservers();

}

class Bank : IObserverExample
{
    IObservable stock;
    public Bank(IObservable obs)
    {
        stock = obs;
        stock.RegisterObsercer(this);
    }
    public void Upgdate(Object o)
    {
        StockData sData = (StockData)o;

        if (sData.Euro > 85)
            Console.WriteLine($"Банк продает евро по курсу {sData.Euro}");
        else
            Console.WriteLine(($"Банк покупает евро по курсу {sData.Euro}");
    }
}
class Broker : IObserverExample
{
    IObserver stock;

    public Broker(IObserver obs)
    {
        stock = obs;
        stock.RegisterObserver(this);
    }
    public void Update(object o)
    {
        StockData sData = (StockData)o;
        if (sData.USD > 85)
            Console.WriteLine($"Брокер продает доллары  по курсу {sData.USD}");
        else
            Console.WriteLine($"Брокер покупает доллары  по курсу {sData.USD}");

        public void StopTrade()
        {
            stock.RemoveObserver(this);
            stock = null;
        }
    }
}
/// <summary>
/// Теперь реализуем интерфейс нашего наблюдаемого объекта, на который подпишутся наши наблюдатели. 
/// </summary>
class Stock : IObservable
{
    // Информация о торгах
    StockData _sData;
    List<IObserver> observers;
    public Stock()
    {
        observers = new List<IObserver>();
        _sData = new StockData();
    }
    public void RegisterObserver(IObserver obs)
    {
        observers.Add(obs);
    }
    public void RemoveObserver(IObserver obs)
    {
        observers.Remove(obs);
    }
    public void NotifyObservers()
    {
        foreach (IObserver obs in observers)
        {
            obs.Update(_sData);
        }
    }
    public void Market()
    {
        Random rnd = new Random();
        _sData.USD = rnd.Next(70, 90);
        _sData.Euro = rnd.Next(80, 100);
        NotifyObservers();
    }
}