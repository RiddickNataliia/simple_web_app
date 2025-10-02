using System.Transactions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Howest.Functions;

public class GetTransactions
{
    private readonly ILogger<GetTransactions> _logger;

    public GetTransactions(ILogger<GetTransactions> logger)
    {
        _logger = logger;
    }

    [Function("GetTransactions")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "transactions")] HttpRequest req)
    {
        TransactionRepository repository = new TransactionRepository();
        var transactions = repository.GetAllTransactionsAsync();
        // _logger.LogInformation("C# HTTP trigger function processed a request.");
        return new OkObjectResult("Welcome to Azure Functions!");
    }
}