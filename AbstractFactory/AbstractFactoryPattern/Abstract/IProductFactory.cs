using AbstractFactory.DAL.Entities;

namespace AbstractFactory.AbstractFactoryPattern.Abstract
{
    public interface IProductFactory
    {
        Product CreateProduct(string name, decimal price);
    }
}
