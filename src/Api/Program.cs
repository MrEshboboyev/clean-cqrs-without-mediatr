using Api.Extensions;
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

app.UseHttpsRedirection();

app.Run();