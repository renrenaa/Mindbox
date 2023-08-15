using MindboxTest.Models;

namespace MindboxTest.Tests;

public class CircleTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ZeroRadiusTest()
    {
        Assert.Catch<ArgumentException>(() => new Circle(0));
    }

    [Test]
    public void NegativeRadiusTest()
    {
        Assert.Catch<ArgumentException>(() => new Circle(-1));
    }

    [Test]
    public void SquereGettingTest()
    {
        //arrange
        var radius = 100;
        var circle = new Circle(radius);

        //act
        var square = circle.GetSquare();

        //assert
        Assert.AreEqual(Math.PI * Math.Pow(radius, 2), square);
    }
}