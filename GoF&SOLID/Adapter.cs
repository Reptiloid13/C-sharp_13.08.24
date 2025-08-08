using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF_SOLID;

/// <summary>
/// Adapter — очень распространенный паттерн, позволяющий работать вместе объектам с несовместимыми интерфейсами.
/// Нам необходимо использовать уже имеющийся класс, но его интерфейс не соответствует нашим потребностям.
/// Нужно использовать существующий класс совместно с другими, интерфейсы которых не совместимы.
/// </summary>
public class Adapter
{
    public static void AdapterRealExample()
    {
        // Нам надо отрисовать изображение на бумаге и холсте
        // Запускаем класс для отрисовки
        var imageDrawer = new ImageDrawer();

        // Создаем класс для работы с бумажным принтером
        PaperPrinter paperPrinter = new PaperPrinter();
        // Запускаем отрисовку на бумаге
        imageDrawer.DrawWith(paperPrinter);
        // Теперь нужна печать на холсте
        CanvasPainter canvasPainter = new CanvasPainter();
        // используем адаптер
        IPrinter imagePrinter = new CanvasPainterToPrintAdapter(canvasPainter);




    }
}

/// <summary>
/// Example1
/// </summary>
// Наш код, где необходимо использование класса-источника
public class Client
{
    public void Request(DataSource dataSource)
    {
        dataSource.GetData();
    }
}
/// <summary>
/// Класс - источник ресурса, к которому нужно подключиться
/// </summary>
public class DataSource
{
    public virtual void GetData() { }
}
/// <summary>
/// Класс - потребитель ресурса
/// </summary>
public class DataConsumer
{
    public void GetSpecificData() { }
}

/// <summary>
/// Адаптер для подключения
/// </summary>
public class AdapterInstance : DataSource
{
    private DataConsumer _dataConsumer = new DataConsumer();

    public override void GetData()
    {
        _dataConsumer.GetSpecificData();
    }
}

/// <summary>
/// REAL EXAMPLE
/// </summary>
interface IPrinter
{
    void Print();
}
/// <summary>
/// Интерфейс устройства, печатающего на холсте
/// </summary>
interface IPainter
{
    void Paint();
}
/// <summary>
/// Класс для работы с принтером
/// </summary>
public class PaperPrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Печатаем на бумаге");
    }
}
/// <summary>
/// Класс для работы с устройством,
/// печатающим на холсте
/// </summary>
public class CanvasPainter : IPainter
{
    public void Paint()
    {
        Console.WriteLine("Рисуем на холсте");
    }
}
/// <summary>
/// Класс для отрисовки изображений
/// </summary>
public class ImageDrawer
{
    // Метод, запускающий печать с помощью внешнего устройства
    public void DrawWith(IPrinter printer)
    {
        printer.Print();
    }
}

