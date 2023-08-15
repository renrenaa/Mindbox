using MindboxTest.Models;

namespace MindboxTest.Tests;
public class TriangleTest
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(-1, 1, 1)]
    [TestCase(1, -1, 1)]
    [TestCase(1, 1, -1)]
    [TestCase(0, 0, 0)]
    [TestCase(1, 2, 3)]
    [TestCase(1, 2, 4)]
    public void WrongTriangleEdgesTest(double a, double b, double c)
    {
        Assert.Catch<ArgumentException>(() => new Triangle(a, b, c));
    }

    [Test]
    public void RightTriangleEdgesTest()
    {
        //arrange 
        double a = 6, b = 8, c = 10;
        var triangle = new Triangle(a, b, c);

        //assert
        Assert.NotNull(triangle);
    }

    [Test]
    public void SquereGettingTest()
    {
        //arrange 
        double a = 6, b = 8, c = 10;
        var triangle = new Triangle(a, b, c);

        //act
        var square = triangle.GetSquare();

        //assert
        Assert.AreEqual(24, square);
    }

    [TestCase(3, 4, 5, ExpectedResult = true)]
    [TestCase(3, 4, 6, ExpectedResult = false)]
    public bool TriangleIsRight(double a, double b, double c)
    {
        //arrange 
        var triangle = new Triangle(a, b, c);

        //act
        var isRight = triangle.isRight;

        //assert
        return isRight;
    }
}
