namespace MyCalculator.Domain;

public interface ICalculatorService
{
    /// <summary>
    /// Adds two numbers
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    double Add(double a, double b);
    /// <summary>
    /// Subtracts second number from first number
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    double Subtract(double a, double b);
    /// <summary>
    /// Multiplies two numbers
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    double Multiply(double a, double b);
    /// <summary>
    /// Divides first number by second number
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    double Divide(double a, double b);
}