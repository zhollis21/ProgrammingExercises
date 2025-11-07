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

    [Test]
    public void Problem4()
    {
        // Arrange
        const int expectedResult = 906_609;

        // Act
        int actualResult = Problems.Problem4();

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Problem5()
    {
        // Arrange
        const int expectedResult = 232_792_560;

        // Act
        int actualResult = Problems.Problem5();

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Problem6()
    {
        // Arrange
        const int expectedResult = 25_164_150;

        // Act
        int actualResult = Problems.Problem6();

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}