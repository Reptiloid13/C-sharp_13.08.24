using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID;
/// <summary>
/// У класса должна быть только одна причина для изменения.
/// </summary>
public class Single_responsobility
{
    public static void Solution()
    {
        IExporter exporter = new PdfExporter();
        Document doc = new Document();
        doc.Text = "Hello World";
        doc.Export(exporter);
    }

}
/// <summary>
/// Теперь пример. У нас есть класс, представляющий текстовый документ:
/// </summary>
class Document
{
    public string Text { get; set; }

    //служит для навигации по документу 
    public void ScrollUp()
    {
        Console.WriteLine($"Прокрутка вверх");
    }
    //служит для навигации по документу 
    public void ScrollDown()
    {
        Console.WriteLine($"Прокрутка вниз");
    }
    //служит для навигации по документу 
    public void ZoomIn()
    {
        Console.WriteLine("Увелчиваем масштаб");
    }
    public void Export(IExporter exporter)
    {
        exporter.Export(Text);
    }
}

interface IExporter
{
    void Export(string text);
}
class PdfExporter : IExporter
{
    public void Export(string text)
    {
        Console.WriteLine($"{text}  => Экспортировано в PDF");
    }
}