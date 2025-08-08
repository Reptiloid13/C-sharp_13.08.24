using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID;
/// <summary>
/// Цель в том, чтобы подклассы могли бы служить заменой своих базовых классов. При соблюдении этого принципа мы можем использовать классы-наследники вместо родительских классов, и работа программы не будет нарушена. 
/// </summary>
public class LiskovSubstitutionPrinciple
{

}
public abstract class Flight
{
    public string Name;
    public List<string> PassengerList;

    public Flight(string name, List<string> passengers = null)
    {
        Name = name;
        PassengerList = passengers ?? new List<string>();
    }
    // Подсчет количества пассажиров
    public void CountPassengers()
    {
        Console.WriteLine($"На рейсе {Name} {PassengerList.Count} пассажиров");
    }
}
public class DomesticFlight : Flight
{
    public DomesticFlight(string name, List<string> passengers = null) : base(name, passengers) { }
}
public class InternationalFlight : Flight
{
    public InternationalFlight(string name, List<string> passengers = null) : base(name, passengers) { }
}