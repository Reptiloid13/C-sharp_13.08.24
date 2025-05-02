using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface;

public class MultRealization
{
    public static void Test()
    {
        IMessenger<Phone> viberInPfone = new Viber<Phone>();
        IMessenger<IPhone> viberInIPfone = new Viber<IPhone>();



    }
}

//Задание 10.3.1
//Создайте класс FileManager и выполните в нём множественную реализацию интерфейсов,
//указанных в примере выше.


public interface IWriter
{
    void Write();
}

public interface IReader
{
    void Read();
}
public interface IMailer
{
    void SendEmail();
}

public class FileManager : IWriter, IReader, IMailer
{
    public void Read()
    {
        throw new NotImplementedException();
    }

    public void SendEmail()
    {
        throw new NotImplementedException();
    }

    public void Write()
    {
        throw new NotImplementedException();
    }
}


public interface IBook
{
    void Read();
}

public interface IDevice
{
    void TurnOn();
    void TurnOff();
}

public class ElectronicBook : IBook, IDevice
{
    void IBook.Read()
    {
        throw new NotImplementedException();
    }

    void IDevice.TurnOff()
    {
        throw new NotImplementedException();
    }

    void IDevice.TurnOn()
    {
        throw new NotImplementedException();
    }
}

public interface IMessenger<out T> //создадим обобщенный интерфейс IMessenger,
                                   //который при вызове функции DeviceInfo,
                                   //будет возвращать объект T:
{
    T DeviceInfo();
}
//Далее мы создаём два класса: Phone и Computer.
public class Phone
{

}
public class IPhone : Phone
{

}
public class Computer
{

}
//А теперь реализуем наш интерфейс IMessenger<T> через класс Phone:
public class Viber<T> : IMessenger<Phone> where T : Phone, new()
{
    public T DeviceInfo()
    {
        T device = new T();
        Console.WriteLine(device);
        return new T();
    }

    Phone IMessenger<Phone>.DeviceInfo()
    {
        throw new NotImplementedException();
    }
}

