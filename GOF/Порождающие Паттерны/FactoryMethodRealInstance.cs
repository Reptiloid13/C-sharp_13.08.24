using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF;

public class FactoryMethodRealInstance
{
    public static void FactorySolutions()
    {
        string messageText = "Ваш номер заказа - 83456";
        // Отправляем заказ по SMS
        MessageSender sender = new SmsMessageSender("+79856455320"); //создаем отправителя SMS
        Message smsMessage = sender.Send(messageText); // отправляем сообщение

        // Отправляем заказ по e-mail
        sender = new EmailMessageSender("orders@myshop.com"); // создаем отправителя email
        Message message = sender.Send(messageText); // отправляем сообщение
    }
}
// базовый абстрактный класс для всех сообщен
abstract class Message { }
//Создадим отдельные реализации для e-mail и SMS-сообщений:
class SmsMessage : Message
{
    public SmsMessage()
    {
        Console.WriteLine("SMS отправдено");
    }
}
class EmailMessage : Message
{
    public EmailMessage()
    {
        Console.WriteLine("e-mail отправлен");
    }
}
//Создадим абстрактный класс для рассылок с Фабричным методом:
abstract class MessageSender
{
    public string From { get; set; } // свойство отправителя
    public MessageSender(string @from) // конструктор
    {
        From = @from;
    }
    abstract public Message Send(string text); // абстрактный метод отправки
}
//И конкретные реализации под оба вида рассылок: 
class EmailMessageSender : MessageSender
{
    public EmailMessageSender(string @from) : base(@from) { } // вызов базового конструктора
    public override Message Send(string text)
    {
        return new EmailMessage();
    }
}
class SmsMessageSender : MessageSender
{
    public SmsMessageSender(string @from) : base(@from) { } // вызов базового конструктора
    public override Message Send(string text)
    {
        return new SmsMessage();
    }
}