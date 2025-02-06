using Api.Commands.CreateProduct;
using Api.Extensions;
using Api.Models;
using Api.Queries.GetProductById;
using Microsoft.AspNetCore.Mvc;
using Shared.Common;
using Shared.Implementations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

#region Register section

builder.Services.AddSingleton<ICommandDispatcher, CommandDispatcher>();
builder.Services.AddSingleton<IQueryDispatcher, QueryDispatcher>();

// Register command and query handlers
builder.RegisterCommandHandlers();
builder.RegisterQueryHandlers();

#endregion

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

#region Endpoints

app.MapGet("/products/{id:int}", async (
    int id,
    IQueryDispatcher queryDispatcher,
    CancellationToken cancellationToken) =>
{
    var query = new GetProductByIdQuery(id);

    var response = await queryDispatcher.Dispatch<GetProductByIdQuery, Product>(query, cancellationToken);
    
    return response;
});

app.MapPost("/products", async (
    ICommandDispatcher commandDispatcher,
    [FromBody] CreateProductCommand command,
    CancellationToken cancellationToken) =>
{
    var response = await commandDispatcher.Dispatch<CreateProductCommand, Product>(command, cancellationToken);
    
    return response;
});

#endregion

app.UseHttpsRedirection();

app.Run();