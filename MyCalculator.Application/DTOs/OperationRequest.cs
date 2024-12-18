using System.ComponentModel.DataAnnotations;

namespace MyCalculator.Application.DTOs;

public class OperationRequest
{
    [Required]
    public double A { get; set; }

    [Required]
    public double B { get; set; }

    [Required]
    [RegularExpression(@"^[\+\-\*\/]$", ErrorMessage = "Operator must be one of: +, -, *, /")]
    public string Operator { get; set; } = "+"; 
}