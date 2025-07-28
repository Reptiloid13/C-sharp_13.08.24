using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.Net.WebSockets;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Xml.XPath;
using System.Linq;

namespace Playground2.Tasks1;



class Program
{

    public static void Main(string[] args)
    {


    }
    /// <summary>
    /// Задана строка s, в которой ровно две одинаковые буквы. Гарантируется, что повторяется только один вид буквы (то есть все остальные символы уникальны). Необходимо найти и вывести эту букву
    /// </summary>
    public static void TaskTwoSamechars()
    {
        string text = "abac";
        var resultLinq = from t in text.ToLower()
                         group t by t into i
                         where i.Count() > 1
                         select new
                         {
                             Symbol = i.Key,
                             Count = i.Count()
                         };

        foreach (var item in resultLinq)
        {
            Console.WriteLine(item.Symbol);
        }


    }





}





