using System.ComponentModel.Design;
using System.Globalization;
using System.Net.WebSockets;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;
using System.Linq;
using System.Text;


namespace Linq;

public class Program
{
    static void Main(string[] args)
    {


    }
    /// <summary>
    /// Есть массив строк:
    /// string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" }
    ///Задача: выбрать имена на букву А и отсортировать в алфавитном порядке.
    /// </summary>
    public static void Examples()
    {
        string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };


        var selectedPeople = from p in people // промежуточная переменная p
                             where p.StartsWith("A")// фильтрация по условию
                             orderby p//сортировка по возрастанию (дефолтная)
                             select p; //выбираем объект и сохраняем в выборк
        foreach (var s in selectedPeople)
        {
            Console.WriteLine($"Выведи {s}");
        }
    }
}
