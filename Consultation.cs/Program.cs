namespace Consultation.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

                for (int i = 0;i<.10;i++) 
                {
                var result = Fab(i);
                Console.WriteLine(result);
            }

        }

        static int  Fab(int i)
        {
            Console.WriteLine("Пришло число " + i);
            return i * i; 
        }
    }
}
