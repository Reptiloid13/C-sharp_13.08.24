﻿using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Security.AccessControl;

namespace OOP;

//Задача: Создайте класс Car с приватным полем speed.
//    Реализуйте геттер и сеттер для скорости.
//    Сеттер должен проверять, находится ли входная скорость в диапазоне от 0 до 200 км/ч.
public class Car
{
    public int Speed;
    public string Name;
    private int _speed { get; set; }

    public int speed
    {
        set
        {
            if (value < 0 || value > 200)

                Console.WriteLine("Такой скорости у этой модели нет");
            else
                speed = value;
        }
        get { return speed; }
    }

    public Car(int speed, string name)
    {
        Speed = speed;
        Name = name;
    }

    public void Drive()
    {
        Console.WriteLine($"Машина едет: {Name}");
    }

    public static int GetMaxSpeed(Car[] cars) // Почему Массив не работает? 
    {
        int maxSpeed = 0;
        foreach (var car in cars)
        {
            if (car.Speed > maxSpeed)
            {
                maxSpeed = car.Speed;
            }
        }

        return maxSpeed;
    }
}

class CarTask
{
    public static void Test()
    {
        var car = new Car(120, "BMW");

        var car1 = new Car(210, "Lada");
        var car2 = new Car(110, "Opel");


        car.Drive();
        car1.Drive();

        var maxSpeedEver = Car.GetMaxSpeed(new Car[] { car, car1, car2 }); // 210
        Console.WriteLine(maxSpeedEver);
    }
}

//Напишите класс Triangle с приватными полями point1, point2 и point3.
//    Они будут типа Point.У Point есть x и y Реализуйте геттеры и сеттеры для этих полей, обеспечивая, чтобы сеттеры проверяли, 
//        являются ли входные значения правильными координатами.

public class GetPoints
{
    public static void Test()
    {
        Triangle point1 = new Triangle();
        point1.X = 0;
        point1.Y = 0;
        Triangle point2 = new Triangle();
        point2.X = 1;
        point2.Y = 1;
        Triangle point3 = new Triangle();
        point3.X = 2;
        point3.Y = 2;
        Console.WriteLine(
            $" X1 = {point1.X} Y1 = {point1.Y}\n X2 = {point2.X} Y2 = {point2.Y} \n X3 {point3.X} Y3 = {point3.Y}");
    }
}

class Triangle
{
    private int x { get; set; }
    private int y { get; set; }

    public int X
    {
        set
        {
            if (value >= 0)
                x = value;
        }
        get { return x; }
    }

    public int Y
    {
        set
        {
            if (value >= 0) y = value;
        }
        get { return y; }
    }
}

//4. Задача: Разработайте класс Time с приватными полями hours и minutes.Предоставьте геттеры и сеттеры для этих полей.
//    Сеттеры должны проверять, находятся ли входные значения в диапазоне от 0 до 23 для часов и от 0 до 59 для минут
//var time = new Time(); // 00:00:00
//time.seconds = 65; // 00:01:05

public class GetTime
{
    public static void Test()
    {
        Time time = new Time();
        time.Minutes = 61;
        time.Hours = 10; // часы не изменяются почему то 
        time.Seconds = 90;

        // 01:05
        Console.WriteLine($" hours {time.Hours} minutes {time.Minutes} seconds {time.Seconds}");
    }
}

class Time
{
    private int hours { get; set; }
    private int minutes { get; set; }
    private int seconds { get; set; }

    public int Hours
    {
        set

        {
            if (value < 0)
            {

                Console.WriteLine(" Не то время");
            }

            else if (value > 24)
            {
                Hours += value / 24;
                hours = value % 24;
                hours++;

            }
            else
            {
                hours = value;
            }
        }
        get { return hours; }
    }

    public int Minutes
    {
        set
        {
            if (value < 0) Console.WriteLine(" Не то время");

            else if (value > 60)
            {
                Minutes += value / 60;
                minutes = value % 60;
                hours++;


            }
            else
            {
                minutes = value;
            }
        }
        get { return minutes; }
    }
    public int Seconds
    {
        set
        {
            if (value < 0) Console.WriteLine("Не то время");
            else if (value > 60)
            {
                Seconds += value / 60;
                seconds = value % 60;
                minutes++;


            }
            else seconds = value;
        }
        get { return seconds; }

    }

}
//Задача: Создайте класс Password с приватным полем password.Реализуйте геттер и сеттер для пароля.
//    Сеттер должен проверять, соответствует ли входной пароль определённым критериям 
//    (например, минимальной длине, содержанию хотя бы одной цифры и т. д.).
class Password
{
}