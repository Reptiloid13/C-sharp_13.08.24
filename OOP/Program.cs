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