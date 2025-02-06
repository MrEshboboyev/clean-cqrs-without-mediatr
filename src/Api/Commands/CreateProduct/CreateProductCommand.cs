namespace Api.Commands.CreateProduct;

public sealed record CreateProductCommand(
    int Id,
    string Name,
    string Description,
    double Price);