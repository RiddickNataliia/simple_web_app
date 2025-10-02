using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Howest.Functions;

public class CalculatorTrigger
{
    private readonly ILogger<CalculatorTrigger> _logger;

    public CalculatorTrigger(ILogger<CalculatorTrigger> logger)
    {
        _logger = logger;
    }

    [Function("CalculatorTrigger")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "calculator/{a:int}/{b:int}")] HttpRequest req, int a, int b)
    {
        int result = a + b;
        return new OkObjectResult($"The sum of {a} and {b} is {result}");
    }
}