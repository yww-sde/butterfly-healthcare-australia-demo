using MyCalculator.Domain;

namespace MyCalculator.UnitTests;

public class CalculatorServiceTests
{
    private readonly ICalculatorService _calculatorService;
    
    public CalculatorServiceTests()
    {
        _calculatorService = new CalculatorService();
    }

    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(-1, 1, 0)]
    [InlineData(0, 0, 0)]
    public void Add_ShouldReturnCorrectSum(double a, double b, double expected)
    {
        // Act
        var result = _calculatorService.Add(a, b);
        
        // Assert
        Assert.Equal(expected, result);

    }
    
    [Theory]
    [InlineData(1, 1, 0)]
    [InlineData(-1, 1, -2)]
    [InlineData(0, 0, 0)]
    public void Subtract_ShouldReturnCorrectDifference(double a, double b, double expected)
    {
        // Act
        var result = _calculatorService.Subtract(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(-2, 3, -6)]
    [InlineData(0, 5, 0)]
    public void Multiply_ShouldReturnCorrectProduct(double a, double b, double expected)
    {
        // Act
        var result = _calculatorService.Multiply(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(-6, 2, -3)]
    [InlineData(0, 5, 0)]
    public void Divide_ShouldReturnCorrectQuotient(double a, double b, double expected)
    {
        // Act
        var result = _calculatorService.Divide(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test1()
    {
    }
}