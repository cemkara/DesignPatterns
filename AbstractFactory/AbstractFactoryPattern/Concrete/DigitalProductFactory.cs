using AbstractFactory.AbstractFactoryPattern.Abstract;
using AbstractFactory.DAL.Entities;

namespace AbstractFactory.AbstractFactoryPattern.Concrete
{
    public class DigitalProductFactory: IProductFactory
    {
        public Product CreateProduct(string name, decimal price)
        {
            return new Product
            {
                Name = name,
                Type = "Digital",
                Price = price
            };
        }
    }
}
