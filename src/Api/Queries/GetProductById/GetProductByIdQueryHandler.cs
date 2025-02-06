using Api.Models;
using Shared.Common;

namespace Api.Queries.GetProductById;

public class GetProductByIdQueryHandler : IQueryHandler<GetProductByIdQuery, Product>
{
    public async Task<Product> Handle(
        GetProductByIdQuery query,
        CancellationToken cancellationToken)
    {
        return new Product(query.ProductId, "product-name", "product-description", 1.1);
    }
}