using MindboxTest.Abstractions;

namespace MindboxTest.Models;

public class Circle : Shape
{
    public double Radius { get; private set; }

    public Circle(double radius)
    {
        if (radius > 0) Radius = radius;
        else throw new ArgumentException("Circle radius can't be lesser or equal zero.");
    }

    public override double GetSquare()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}