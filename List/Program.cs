using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list7 = new List<int>(5) { 1, 2, 3 };
            list7.RemoveAt(0);
            Console.WriteLine(list7.Capacity);

        }
    }
}
