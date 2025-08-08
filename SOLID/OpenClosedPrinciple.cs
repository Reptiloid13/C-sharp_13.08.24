using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID;
/// <summary>
/// Сущности программы должны быть открыты для расширения, но закрыты для модификации.
/// </summary>
public class OpenClosedPrinciple
{
}
public abstract class Shape // можно изменить на ИНтерфейс 
{
    public abstract double CalculateArea();
}
public class Circle : Shape
{
    public double Radius { get; set; }
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}
public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}
public class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public override double CalculateArea()
    {
        return 0.5 * Base * Height;
    }

}
public class ShapeCalculator
{
    public double CalculateArea(Shape shape)
    {
        return shape.CalculateArea();
    }
}
