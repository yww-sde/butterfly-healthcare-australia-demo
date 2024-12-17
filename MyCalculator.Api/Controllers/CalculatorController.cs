using Microsoft.AspNetCore.Mvc;
using MyCalculator.Application;
using MyCalculator.Application.DTOs;

namespace MyCalculator.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CalculatorController : ControllerBase
{
    private readonly CalculatorApplicationService _calculatorService;

    public CalculatorController(CalculatorApplicationService calculatorService)
    {
        _calculatorService = calculatorService;
    }

    /// <summary>
    /// Performs a calculation based on the provided operation
    /// </summary>
    /// <param name="request">The calculation request containing operands and operator</param>
    /// <returns>The result of the calculation</returns>
    /// <response code="200">Returns the calculation result</response>
    /// <response code="400">If the request is invalid</response>
    [HttpPost("calculate")]
    [ProducesResponseType(typeof(OperationResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult Calculate([FromBody] OperationRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var response = _calculatorService.Calculate(request);
        
        if (!response.Success)
        {
            return BadRequest(response);
        }

        return Ok(response);
    }
}