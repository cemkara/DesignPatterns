using CQRS.CQRSPattern.Results;
using CQRS.DAL.Context;

namespace CQRS.CQRSPattern.Handlers
{
    public class GetProductQHandler
    {
        private readonly Context _dbContext;

        public GetProductQHandler(Context dbContext)
        {
            _dbContext = dbContext;
        }

        public List<GetProductQResult> Handle()
        {
            var values = _dbContext.Products.Select(x => new GetProductQResult
            {
                ProductId = x.ProductId,
                Name = x.Name,
                Price = x.Price,
                Stock = x.Stock
            }).ToList();

            return values;
        }
    }
}
