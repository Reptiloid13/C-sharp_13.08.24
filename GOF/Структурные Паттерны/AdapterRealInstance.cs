using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Структурные_Паттерны;

public class AdapterRealInstance
{
    public static void AdapterSolution()
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
        IPrinter imagePrinter = new CanvasPainterToPrinterAdapter(canvasPainter);
        imageDrawer.DrawWith(imagePrinter);

    }
}
interface IPrinter
{
    void Print();
}
interface IPainter
{
    void Paint();
}
class PaperPrinter : IPrinter
{
    public void Print()
    {
        Console.WriteLine("Печатаем на бумаге");
    }
}
class CanvasPainter : IPainter
{
    public void Paint()
    {
        Console.WriteLine("Рисуем на холсте");
    }
}
//Наш класс, с помощью которого мы печатаем(который поддерживает печать на бумаге, но не поддерживает печать на холсте):

class ImageDrawer
{
    public void DrawWith(IPrinter printer)
    {
        printer.Print();
    }
}
class CanvasPainterToPrinterAdapter : IPrinter
{
    private IPainter _painter;

    public CanvasPainterToPrinterAdapter(IPainter painter)
    {
        if (painter == null)
            throw new ArgumentNullException(nameof(painter));

        _painter = painter;
    }

    public void Print()
    {
        try
        {
            _painter.Paint();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка при рисовании: {ex.Message}");
        }
    }
}
