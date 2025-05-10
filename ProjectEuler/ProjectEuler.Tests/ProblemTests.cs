namespace ProjectEuler.Tests;

public class ProblemTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Problem1()
    {
        // Arrange
        const int expectedResult = 233_168;

        // Act
        int actualResult = Problems.Problem1();

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Problem2()
    {
        // Arrange
        const int expectedResult = 4_613_732;

        // Act
        int actualResult = Problems.Problem2();

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Problem3()
    {
        // Arrange
        const int expectedResult = 6_857;

        // Act
        int actualResult = Problems.Problem3();

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}