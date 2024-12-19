using CQRS.CQRSPattern.Commands;
using CQRS.DAL;
using CQRS.DAL.Context;

namespace CQRS.CQRSPattern.Handlers
{
    public class CreateProductCHandler
    {
        private readonly Context _dbContext;

        public CreateProductCHandler(Context dbContext)
        {
            _dbContext = dbContext;
        }

        public void Handle(CreateProductCommand createProduct)
        {
            _dbContext.Products.Add(new Product
            {
                Name = createProduct.Name,
                Description = createProduct.Description,
                Status = true,
                Price = createProduct.Price,
                Stock = createProduct.Stock
            });
            _dbContext.SaveChanges();
        }
    }
}
