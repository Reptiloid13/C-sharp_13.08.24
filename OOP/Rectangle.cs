namespace OOP;

var rect = new Rectangle(10, 20);
var area1 = rect.GetAreaNotStatic();

// Для статических методов не нужен экземпляр класса
var area2 = Rectangle.GetAreaStatic(30, 20);

public struct Rectangle
{
    public int Width, Height;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int GetAreaNotStatic()
    {
        return Width * Height;
    }

    public static int GetAreaStatic(int width, int height)
    {
        return width * height;
    }
}