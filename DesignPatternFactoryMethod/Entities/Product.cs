
namespace DesignPatternFactoryMethod.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string name, string model, double price)
        {
            Name = name;
            Model = model;
            Price = price;
        }
    }
}
