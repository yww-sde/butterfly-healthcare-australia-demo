namespace MyCalculator.Application.DTOs;

public class OperationResponse
{
    public double Result { get; set; }
    public string Operation { get; set; } = string.Empty;
    public bool Success { get; set; }
    public string? ErrorMessage { get; set; } 
}