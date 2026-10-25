using Session09Assignment;

namespace Session09Assignment.Tests;

public class FineCalculatorTests
{
    private readonly FineCalculator _calculator;

    public FineCalculatorTests()
    {
        _calculator = new FineCalculator();
    }

    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        // Arrange
        int a = 2, b = 3;

        // Act
        int result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Add_ShouldReturnNotEqual()
    {
        // Arrange
        int a = 2, b = 3;

        // Act
        int result = _calculator.Add(a, b);

        // Assert
        Assert.NotEqual(6, result);
    }

    [Fact]
    public void Subtract_ShouldReturnCorrectDifference()
    {
        // Arrange
        int a = 10, b = 4;

        // Act
        int result = _calculator.Subtract(a, b);

        // Assert
        Assert.Equal(6, result);
    }

    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(-4, 5, -20)]
    [InlineData(0, 7, 0)]
    public void Multiply_ShouldReturnCorrectResult(int a, int b, int expected)
    {
        // Act
        int result = _calculator.Multiply(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 3, 7)]
    [InlineData(-4, 5, 20)]
    [InlineData(1, 1, 2)]
    public void Multiply_ShouldReturnNotEqual(int a, int b, int notExpected)
    {
        // Act
        int result = _calculator.Multiply(a, b);

        // Assert
        Assert.NotEqual(notExpected, result);
    }

    [Fact]
    public void Divide_ByZero_ShouldThrowException()
    {
        // Arrange
        int a = 10, b = 0;

        // Act + Assert
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
    }
}
