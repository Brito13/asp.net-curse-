

using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Primitives;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) => {
    int numero1 = 0;
    int numero2 = 0;
    string operation = null;
    int? resultado = null;

    if (context.Request.Method == "GET" && context.Request.Path == "/")
    {
        if (context.Request.Query.ContainsKey("firstNumber"))
        {
           string firstNumberString = context.Request.Query["firstNumber"];
            if (!string.IsNullOrEmpty(firstNumberString))
            {
                 int.TryParse(firstNumberString, out numero1);
            }

            else
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                await context.Response.WriteAsync("Invalid input for the first number");
            }
        }

        if (context.Request.Query.ContainsKey("secondNumber"))
        {
            string secondNumberString = context.Request.Query["secondNumber"];
            if (!string.IsNullOrEmpty(secondNumberString))
            {
                int.TryParse(secondNumberString, out numero2);
            }

            else
            {
                context.Response.StatusCode = context.Response.StatusCode = StatusCodes.Status400BadRequest;
                await context.Response.WriteAsync("Invalid input for the second number");
                
            }
        }

        if (context.Request.Query.ContainsKey("operator"))
        {
            string operationString = context.Request.Query["operator"];
            if (!string.IsNullOrEmpty(operationString))
            {
                operation = context.Request.Query["operator"];
            }
            else
            {
                context.Response.StatusCode = context.Response.StatusCode = StatusCodes.Status400BadRequest;
                await context.Response.WriteAsync("Invalid input for the operation");
            }
        }

        switch (operation) {
            case "sum": resultado = numero1 + numero2; break;
            case "subtraction": resultado = numero1 - numero2; break;
            case "multiplication": resultado = numero1 * numero2; break;
            case "division":
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                }
                else
                {
                    context.Response.StatusCode = context.Response.StatusCode = StatusCodes.Status400BadRequest;
                    await context.Response.WriteAsync("It is not possible divided by 0");
                }
                break;
        }

        if (resultado != null)
        {
            await context.Response.WriteAsync($"Resultado = {resultado}");
        }
        else
        {
            await context.Response.WriteAsync("Missing parameter");
        }
    }
});

app.Run();
