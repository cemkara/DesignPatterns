using Factory.DAL.Entities;

namespace Factory.FactoryPattern
{
    public class ProductFactory
    {
        public Product CreateProduct(string productType)
        {
            switch (productType.ToLower())
            {
                case "electronics":
                    return new Electronic
                    {
                        Name = "Laptop",
                        Price = 1500.00m,
                        ProductType = "Electronics",
                        Brand = "Brand A",
                        Warranty = "2 years"
                    };
                case "clothing":
                    return new Clothing
                    {
                        Name = "T-Shirt",
                        Price = 19.99m,
                        ProductType = "Clothing",
                        Size = "M",
                        Color = "Red"
                    };
                case "food":
                    return new Food
                    {
                        Name = "Apple",
                        Price = 1.50m,
                        ProductType = "Food",
                        ExpirationDate = DateTime.Now.AddMonths(1),
                        Manufacturer = "Fruit Co."
                    };
                default:
                    return null;
            }
        }
    }
}
