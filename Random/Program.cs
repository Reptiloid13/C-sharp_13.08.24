using Playground2.Tasks1;
using System;
using System.Security.Cryptography.X509Certificates;
namespace Playground2.Tasks1;


// В задаче имеется "Крикун", который будет кричать,
// как только массив дойдет до цифры 35. 
// Как только i = 35, мы должны вызвать событие OnScream,
// которое ссылается на метод Scream()

// Как только Scream крикнул =>  мы вызываем событие
//AskWhyScream. Которое ссылается на перезагружаемый метод Scream()

class Counter
{
    public delegate void GetMethodScream();
    public event GetMethodScream OnScream;


    public void Cicle()
    {
        for (int i = 0; i < 50; i++)
        {
            Console.WriteLine("I = " + i);
            if (i == 35)
            {
                OnScream();
                break;
            }
        }
    }


}

class Reaction
{
    public delegate void GetMethodAsk();
    public event GetMethodAsk AskWhyScream;


    public virtual void Scream()
    {
        Console.WriteLine("Внимание! Число 35! Число 35!");
        AskWhyScream();
    }
}
class Ask : Reaction
{
    public override void Scream()
    {
        Console.WriteLine("У нас тут Событие!");
    }
}

class Program
{

    public static void Main(string[] args)
    {
        Counter counter = new Counter();
        Reaction reaction = new Reaction();
        Ask ask = new Ask();
        counter.OnScream += reaction.Scream;
        reaction.AskWhyScream += ask.Scream;
        counter.Cicle();



    }

}