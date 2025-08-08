using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Поведенчиские_Паттерны;
/// <summary>
/// Мы — банковский сервис, и должны уведомить человека об операции на его счету любым доступным способом. У человека (клиента) может быть предусмотрено несколько способов уведомления (SMS, звонок, электронная почта), но нам неважно, какой из них использовать.
/// </summary>
public class ChainOfResponsobilityRealInstance
{
    public static void Solution()
    {
        Receiver receiver = new Receiver(false, true, false);
        NotificationHandler emailNotificationHandler = new EmailNotificationHandler();
        NotificationHandler voiceNotificationHandler = new VoiceNotificationHandler();
        NotificationHandler smsNotificationHandler = new SmsNotificationHandler();
    }
}
//Абстрактный класс для всех обработчиков событий
abstract class NotificationHandler
{
    public NotificationHandler Successor { get; set; }
    public abstract void Handle(Receiver receiver);
}
//Обработчик e-mail уведомлений
class EmailNotificationHandler : NotificationHandler
{
    public override void Handle(Receiver receiver)
    {
        if (receiver.EmailNotification == true)
            Console.WriteLine("Выполнено уведомление по e-mail");
        else if (Successor != null)
            Successor.Handle(receiver);
    }
}
class SmsNotificationHandler : NotificationHandler
{
    public override void Handle(Receiver receiver)
    {
        if (receiver.SmsNotification == true)
            Console.WriteLine("Выполнено уведомление по SMS);
                else if (Successor != null)
            Successor.Handle(receiver);
    }
}
class VoiceNotificationHandler : NotificationHandler
{
    public override void Handle(Receiver receiver)
    {
        if (receiver.VoiceNotification == true)
            Console.WriteLine("Выполнено уведомление по телефону");
        else if (Successor != null)
            Successor.Handle(receiver);
    }
}
//Получатель уведомлений
class Receiver
{
    public bool EmailNotification { get; set; }
    public bool SmsNotification { get; set; }
    public bool VoiceNotification { get; set; }
    public Receiver(bool emailNotification, bool smsNotification, bool voiceNotification)
    {
        EmailNotification = emailNotification;
        SmsNotification = smsNotification;
        VoiceNotification = voiceNotification;
    }
}