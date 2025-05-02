using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface;

public class Explict_Unexplit
{
    public static void Test()
    {
        // 3. Затем в класс Main выполним создание экземпляра класс NewMessenger
        //и поочередное выполнение методов SendMessage:

        NewMessenger newMessenger = new NewMessenger();
        ((IWhatsApp)newMessenger).SendMessage("Hello World"); // явная реализация 
        ((IViber)newMessenger).SendMessage("Hello World"); // явная реализация



        ////Задание 10.2.2
        //Explict explict = new Explict();
        //((IWriter1)explict).Write();

        Woker woker = new Woker();
        ((IWoker)woker).Build();


    }
}
//1. Давайте увидим смысл явной реализации интерфейсов на примере.
//У  нас есть следующие два интерфейса.
public interface IWhatsApp
{
    public void SendMessage(string message); // одинаковая сигнатура
}
public interface IViber
{
    public void SendMessage(string message); // одинаковая сигнатура
}
// 2. Далее создаём класс NewMessenger и применяем к нему два наших интерфейса:

public class NewMessenger : IWhatsApp, IViber
{
    void IWhatsApp.SendMessage(string message)
    {
        //throw new NotImplementedException(); // явная реализация членов интерфейса IWatsApp 
        Console.WriteLine("{0}:{1}", "WhatsApp", message);
    }

    void IViber.SendMessage(string message)
    {
        Console.WriteLine("{0}:{1}", "Viber", message);
        //throw new NotImplementedException(); // явная реализация членов интерфейса IVIber
    }
}

//Задание 10.2.2
//Используя теоретический материал из данного юнита, 
//постарайтесь самостоятельно реализовать явную реализацию следующего интерфейса:
public interface IWriter1
{
    public void Write();
}

public class Explict : IWriter1
{
    public void Write()
    {
        throw new NotImplementedException();
    }

    void IWriter1.Write()
    {
        throw new NotImplementedException();
    }
}

//Задание 10.2.3
//Реализуйте неявно следующий интерфейс:

public interface IWoker
{
    public void Build();
}

public class Woker : IWoker
{
    void IWoker.Build()
    {
        throw new NotImplementedException();
    }
}


