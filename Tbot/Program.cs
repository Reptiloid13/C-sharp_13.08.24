using System.Xml.Xsl;

namespace Tbot
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public interface IBotClient;
    // Нам нужен класс, который будет содержать в себе методы, обслуживающие приходящие от пользователя запросы.
    public class Bot
    {
        // Создание интерфейса убирает жесткую привязку
        //Bot к конкретному классу - TelegramBotClient и расширяет наши возможножсти.
        // Теперь мы можем подключить не только TelegramBotClient ,
        // но и любой другой класс, реализующий интерфейс IBotClient
        // Теор. пример - если есть класс работающий с другими мессенджерами -Skype, Discortd
        // Мы сможем его тоже использовать здесь.  Получается, что логика в самом Бот будет универсальная.

        private IBotClient _telegramClient;
        public Bot(IBotClient teltgramClient)
        {
            _telegramClient = teltgramClient;
        }
        //private TelegramBotClient _telegramClient;

        //public Bot(TelegramBotClient telegramClient)
        //{
        //    _telegramClient = telegramClient;
    }
    // Метод ExecuteAsync - Вызывается сразу при старте и регистрирует обработчики событий
    // входящего сообщения HandleMessage и нажатия кнопки HandleButtonClick
    protected override async Task ExecuteAsync(CancellationToken cancellation)
    {
        _telegramClient.OnMessage += HandleMessage;
        _telegramClient.OnMessage += HandleButtonClick;

        Console.WriteLine("Bot started");
    }

    // Обработчик входящик текстовых сообщений 
    // Отправка пользователю ответов может осуществляться прямо из метода
    // HandleMessage, например вот так: 
    private async Task HandleMessage(object sender, MessageEventArgs e)
    {
        // Бот получает входящеее сообзение пользователя
        var messageTexe = e.Message.Text;
        //Бот отправляет ответ 
        _telegramClient.SendTextMessage(e.ChatId, "Ответ на сообщение пользователя");
    }

    // Обработка нажатий на кнопики 
    private async Task HandleButtonClick(object sender, MessegeEventArgs e)
    {
    }
}

}
