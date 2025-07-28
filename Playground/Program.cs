using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Threading.Tasks.Dataflow;

namespace Playground;



class Program
{
    public static void Main()
    {




    }
}
public interface IStudent
{
    int Year { get; set; }
    void DoHomework();
}

public interface IWorker
{
    // Зарплата
    int Salary { get; set; }
    void Work();
}
public class Person
{
    string Name { get; set; }
    int Age { get; set; }
}
public class Student : Person, IWorker, IStudent
{
    public int Year { get; set; }
    public void DoHomework()
    {

    }
    public int Salary { get; set; }
    public void Work()
    {

    }
    public string Name { get; set; }
    public int Age { get; set; }







}




































