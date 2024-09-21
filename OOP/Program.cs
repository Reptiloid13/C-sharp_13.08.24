using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;

// Площадь Треугольника


//var square = new Rectangle() { Width = 20, Height = 4 };
//Console.WriteLine(square.Area());

//struct Rectangle
//{
//    public int Width, Height;


//    public Rectangle(int width, int heigt)
//    {
//        Width = width;
//        Height = heigt;

//    }

//    public int Area()
//    {
//        return Width * Height;
//    }
//}





// Создать структуру "Color". Написать метод для получения оттенков цвета.
//который будет возвращать массив Color[] с длинной shadesCount




//struct Color
//{
//    public int fromColor;
//    public int toColor;
//    public int shadesCount;



//static  Color[] GetColorShades(Color fromColor, Color toColor, int shadesCount)
//    {
//        Color[] shades = new Color[shadesCount];

//        for (int i = 0; i < shadesCount; i++)
//        {




//        }



//        return shades;

//}

//}


//. Создать структуру "Point" с полями X и Y. Написать метод, который вычисляет расстояние от этой точки до начала координат.

//То есть для точки (3; 4) ответ будет 5



var result = new Point() { X = 3, Y = 4 };
Console.WriteLine(result.Distance());
struct Point()
{
    public double X = 3;
    public double Y = 4;

    public static double Distance(double X, double Y)
    {
        return Math.Sqrt(X * X + Y * Y);
    }
}