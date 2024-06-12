﻿namespace Catalog.API.Products.GetProductByCategory;

public record GetProductByCategoryQuery(string Category):IQuery<GetProductByCategoryResult>;
public record  GetProductByCategoryResult(IEnumerable<Product> Products);
internal class GetProductByCategoryQueryHandler
    (IDocumentSession session, ILogger<GetProductByCategoryQueryHandler> logger)
    : IQueryHandler<GetProductByCategoryQuery, GetProductByCategoryResult>

{
    public  async Task<GetProductByCategoryResult> Handle(GetProductByCategoryQuery query, CancellationToken cancellationToken)
    {

        logger.LogInformation($"GetProductByCategoryQueryHandler called with {query}");
        var products= await session.Query<Product>()
            .Where(a=>a.Category.Contains(query.Category)).ToListAsync();
        return new GetProductByCategoryResult(products);
    }
}
