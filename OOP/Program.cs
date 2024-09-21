using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Drawing;


var square = new Rectangle() { Width = 20, Height = 4 };
Console.WriteLine(square.Area());

struct Rectangle
{
    public int Width, Height;


    public Rectangle(int width, int heigt)
    {
        Width = width;
        Height = heigt;

    }

    public int Area()
    {
        return Width * Height;
    }
}

