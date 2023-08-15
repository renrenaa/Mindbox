namespace MindboxTest.Interfaces;

public interface ITriangle
{
    double EdgeA { get; }
    double EdgeB { get; }
    double EdgeC { get; }

    bool isRight { get; }
}