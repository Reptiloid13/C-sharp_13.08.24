using System.Collections.Concurrent;
using System.ComponentModel.Design;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.IO.Pipes;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using System.Linq;
using System.Text;


namespace Playground;

class Program
{


    public static void Main()
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





























