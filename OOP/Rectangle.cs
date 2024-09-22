namespace OOP;

public struct Rectangle
{
    public int Width, Height;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public int GetArea()
    {
        return Width * Height;
    }
}