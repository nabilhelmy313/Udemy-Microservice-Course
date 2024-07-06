﻿using Marten.Linq.QueryHandlers;

namespace Catalog.API.Products.GetProducts;
public record GetProductsQuery() : IQuery<GetProductsResult>;
public record GetProductsResult(IEnumerable<Product> Products);

internal class GetProductsQueryHandler
    (IDocumentSession session, ILogger<GetProductsQueryHandler> logger) : IQueryHandler<GetProductsQuery, GetProductsResult>
{
    public async Task<GetProductsResult> Handle(GetProductsQuery query, CancellationToken cancellationToken)
    {
        var products= await session.Query<Product>().ToListAsync();
        return new GetProductsResult(products);
    }
}
