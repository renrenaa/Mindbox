using MindboxTest.Abstractions;
using MindboxTest.Interfaces;

namespace MindboxTest.Models;

public class Triangle : Shape, ITriangle
{
    public double EdgeA { get; }
    public double EdgeB { get; }
    public double EdgeC { get; }
    private double[] _edges => new[] { EdgeA, EdgeB, EdgeC };

    public bool isRight => TriangleIsRight();

    public Triangle(double edgeA, double edgeB, double edgeC)
    {
        var edges = new[] { edgeA, edgeB, edgeC };

        if (edges.Length != 3)
            throw new ArgumentException("Triagnle must have 3 edges.");

        if (edges.Any(edge => edge <= 0))
            throw new ArgumentException("Triangle edge can't be lesser or equal zero.");

        var maxEdge = edges.Max();
        var perimeter = edges.Sum();
        if ((perimeter - maxEdge) <= maxEdge)
            throw new ArgumentException("Biggest edge of triangle must be lesser than sum of another edges.");

        EdgeA = edgeA;
        EdgeB = edgeB;
        EdgeC = edgeC;
    }

    private bool TriangleIsRight()
    {
        var maxEdge = _edges.Max();
        var anotherEdges = _edges.Except(new[] { maxEdge }).ToArray();

        return Math.Pow(maxEdge, 2) == Math.Pow(anotherEdges[0], 2) + Math.Pow(anotherEdges[1], 2);
    }

    public override double GetSquare()
    {
        var semiPerimeter = _edges.Sum() / 2;

        return Math.Sqrt(semiPerimeter * (semiPerimeter - _edges[0]) * (semiPerimeter - _edges[1]) * (semiPerimeter - _edges[2]));
    }
}
