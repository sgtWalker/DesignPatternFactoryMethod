using DesignPatternFactoryMethod.Entities.Enum;
using System.Collections.Generic;

namespace DesignPatternFactoryMethod.Entities
{
    //faz o papel do participante Product
    public abstract class kitUpgrade
    {
        protected const string WHITE_SPACES = "   ";
        protected KitType KitType { get; set; }
        protected string Name { get; set; }
        protected List<Product> Products = new List<Product>();

        public abstract void InsertListOfProducts(List<Product> products);
        public abstract void InsertProduct(Product product);
        public abstract void RemoveProduct(Product product);
        public abstract double TotalPrice();
        public abstract void PrintKitUpgrade();
    }
}
