using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GOF.Поведенчиские_Паттерны;
/// <summary>
/// Нам надо управлять лифтом, который может перемещаться между подвалом, первым и верхними этажами (местоположение лифтовой кабины относительно земли будет как раз являться Состоянием, которое мы отразим в коде).
/// </summary>
public class StateRealInstance
{
    public static void Solution()
    {
        Elevator elevator = new Elevator(new GroundElevatorState());

        elevator.Up();
        elevator.Down();
        elevator.Down();
    }
}
//Интерфейс состояния лифта
interface IElevatorState
{
    void Up(Elevator elevator);
    void Down(Elevator elevator);
}
// Реализация подземного состояния (лифт в подвале)
class LowerElevatorState : IElevatorState
{
    public void Up(Elevator elevator)
    {
        Console.WriteLine("Поднимаемся на первый этаж");
        elevator.ElevatorState = new GroundElevatorState();
    }
    public void Down(Elevator elevator)
    {
        Console.WriteLine("Опускаемся ещё ниже");
    }
}
class GroundElevatorState : IElevatorState
{
    public void Up(Elevator elevator)
    {
        Console.WriteLine("Поднимаемся на верхний этаж");
        elevator.ElevatorState = new UpperElevatorState();
    }
    public void Down(Elevator elevator)
    {
        Console.WriteLine("Опускаемся на подвальный этаж");
        elevator.ElevatorState = new LowerElevatorState();
    }
}
// Реализация надземного состояния (лифт на верхних этажах)
class UpperElevatorState : IElevatorState
{
    public void Up(Elevator elevator)
    {
        Console.WriteLine("Перемещаемся ещё выше");
    }
    public void Down(Elevator elevator)
    {
        Console.WriteLine("Опускаемся на первый этаж");
        elevator.ElevatorState = new GroundElevatorState();
    }
}
class Elevator
{
    // Хранилище состояни
    public IElevatorState ElevatorState { get; set; }
    public Elevator(IElevatorState elevatorState)
    {
        ElevatorState = elevatorState;
    }
    // Подъем
    public void Up()
    {
        ElevatorState.Up(this);
    }
    // Спуск
    public void Down()
    {
        ElevatorState.Down(this);
    }
}