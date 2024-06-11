
namespace Catalog.API.Products.CreateProduct;
public record CreateProductCommand(Guid Id,
      string Name,
      List<string> Category,
      string Description,
      string ImageFile,
      decimal Price):ICommand<CreateProductResult>;

public record CreateProductResult(Guid Id);
public class CreateProductCommandHandler (IDocumentSession session)
    : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        //create Product 
        var product = new Product()
        {
            Name = command.Name,
            Category = command.Category,
            Description = command.Description,
            ImageFile = command.ImageFile,
            Price = command.Price,
        };
        //TODO
        //save to DB
        session.Store(product);
        await session.SaveChangesAsync(cancellationToken);
        //retrun the result
        return new CreateProductResult(product.Id);
    }
}
