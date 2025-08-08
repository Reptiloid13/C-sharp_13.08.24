using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_SOLID;
/// <summary>
/// Этот паттерн стоит применять в следующих случаях:
/// 1. Когда заранее неизвестен тип создаваемых объектов.
/// 2.Когда в системе нужно заранее предусмотреть независимость от процесса создания новых объектов и расширяемость. При этом легко можно будет добавлять поддержку создания объектов нового класса
/// 3.Когда создание объектов необходимо делегировать от основного класса классам-наследникам.
/// </summary>
public class FactoryMethod
{
    string messageText = "Ваш номер заказа - 83456";

    // Отправляем заказ по SMS
    MessageSender sender = new SmsMessageSender("+79856455320");
    Message smsMessage = sender.Send(messageText);

    // Отправляем заказ по e-mail
    sender = new EmailMessageSender("orders@myshop.com");
    Message message = sender.Send(messageText);
}

abstract class Message
{

}
/// Создадим отдельные реализации для e-mail и SMS-сообщений:
public class SmsMessage : Message
{
    public SmsMessage()
    {
        Console.WriteLine("SMS Send");
    }
}
public class EmailMessage : Message
{
    public EmailMessage()
    {
        Console.WriteLine("E-mail send");
    }
}
/// <summary>
/// Абстрактный класс для рассылок
/// </summary>
abstract class MessageSender
{
    public string From { get; set; }
    public MessageSender(string @from)
    {
        From = @from;
    }
    // Фабричный метод
    abstract public Message Send(string text);

}

public class EmailMessageSender : MessageSender
{
    public EmailMessageSender(string @from) : base(@from) { }
    public override Message Send(string text)
    {
        return new EmailMessage();
    }
}

public class SmsMessageSender : MessageSender
{
    public SmsMessageSender(string @from) : base(@from) { }

    public override Message Send(string text)
    {
        return new SmsMessage();
    }
}