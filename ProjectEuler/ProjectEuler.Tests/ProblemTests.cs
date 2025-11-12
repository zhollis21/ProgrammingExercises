namespace ProjectEuler.Tests;

public class ProblemTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Problem_01()
    {
        // Arrange
        const int expectedResult = 233_168;

        // Act
        int actualResult = Problems.Problem1();

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Problem_02()
    {
        // Arrange
        const int expectedResult = 4_613_732;

        // Act
        int actualResult = Problems.Problem2();

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Problem_03()
    {
        // Arrange
        const int expectedResult = 6_857;

        // Act
        int actualResult = Problems.Problem3();

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Problem_04()
    {
        // Arrange
        const int expectedResult = 906_609;

        // Act
        int actualResult = Problems.Problem4();

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Problem_05()
    {
        // Arrange
        const int expectedResult = 232_792_560;

        // Act
        int actualResult = Problems.Problem5();

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Problem_06()
    {
        // Arrange
        const int expectedResult = 25_164_150;

        // Act
        int actualResult = Problems.Problem6();

        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Problem_07()
    {
        // Arrange
        const long expectedResult = 104_743;
        // Act
        long actualResult = Problems.Problem7();
        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Problem_08()
    {
        // Arrange
        const long expectedResult = 23_514_624_000;
        // Act
        long actualResult = Problems.Problem8();
        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Problem_09()
    {
        // Arrange
        const int expectedResult = 31_875_000;
        // Act
        int actualResult = Problems.Problem9();
        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }

    [Test]
    public void Problem10()
    {
        // Arrange
        const long expectedResult = 142_913_828_922;
        // Act
        long actualResult = Problems.Problem10();
        // Assert
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
}