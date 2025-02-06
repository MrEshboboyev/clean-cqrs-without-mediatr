using Api.Models;
using Shared.Common;

namespace Api.Commands.CreateProduct;

public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, Product>
{
    public async Task<Product> Handle(
        CreateProductCommand command,
        CancellationToken cancellationToken)
    {
        // logic for create product and add database
        // using repo pattern and in memories
        
        return new Product(command.Id, command.Name, command.Description, command.Price);
    }
}