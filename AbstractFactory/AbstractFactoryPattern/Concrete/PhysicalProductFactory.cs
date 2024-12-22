using AbstractFactory.AbstractFactoryPattern.Abstract;
using AbstractFactory.DAL.Entities;

namespace AbstractFactory.AbstractFactoryPattern.Concrete
{
    public class PhysicalProductFactory : IProductFactory
    {
        public Product CreateProduct(string name, decimal price)
        {
            return new Product
            {
                Name = name,
                Type = "Physical",
                Price = price
            };
        }
    }
}
