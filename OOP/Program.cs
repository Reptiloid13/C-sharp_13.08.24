var point = new Point(-99999999, 4);

Console.WriteLine(point.Distance());
Console.WriteLine(point);
Console.WriteLine(point.ToString());
Console.WriteLine(Point.Distance(3, 4));

struct Point
{
    private double X = 0;
    private double Y = 0;

    public override string ToString()
    {
        return base.ToString() + $"; x = {X}, y = {Y}";
    }

    public Point(double x, double y)
    {
        if (!IsRight(x, y))
        {
            Console.WriteLine($"Неверные координаты x = {x}, y = {y}");
            x = 0;
            y = 0;
        }

        X = x;
        Y = y;
    }

    private bool IsRight(double x, double y)
    {
        return x > -99999 && y < 99999;
    }

    public static double Distance(double x, double y)
    {
        return Math.Sqrt(x * x + y * y);
    }

    public double Distance()
    {
        return Math.Sqrt(X * X + Y * Y);
    }
}