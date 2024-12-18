using MyCalculator.Application.DTOs;
using MyCalculator.Domain;

namespace MyCalculator.Application;

public class CalculatorApplicationService
{
    private readonly ICalculatorService _calculatorService;
    public CalculatorApplicationService(ICalculatorService calculatorService)
    {
        _calculatorService = calculatorService;
    }
    
    public OperationResponse Calculate(OperationRequest request)
    {
        try
        {
            var result = request.Operator switch
            {
                "+" => _calculatorService.Add(request.A, request.B),
                "-" => _calculatorService.Subtract(request.A, request.B),
                "*" => _calculatorService.Multiply(request.A, request.B),
                "/" => _calculatorService.Divide(request.A, request.B),
                _ => throw new ArgumentException($"Unsupported operator: {request.Operator}")
            };

            return new OperationResponse
            {
                Result = result,
                Operation = $"{request.A} {request.Operator} {request.B}",
                Success = true
            };
        }
        catch (Exception ex)
        {
            return new OperationResponse
            {
                Success = false,
                ErrorMessage = ex.Message,
                Operation = $"{request.A} {request.Operator} {request.B}"
            };
        }
    }
}