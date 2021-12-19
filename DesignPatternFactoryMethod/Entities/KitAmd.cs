using DesignPatternFactoryMethod.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace DesignPatternFactoryMethod.Entities
{
    //faz o papel do participante concrete product
    public class KitAmd : kitUpgrade
    {
        public KitAmd(KitType kitType, string name)
        {
            KitType = kitType;
            Name = name;
        }

        public override void InsertListOfProducts(List<Product> products)
        {
            Products.AddRange(products);
        }

        public override void InsertProduct(Product product)
        {
            Products.Add(product);
        }

        public override void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        public override double TotalPrice()
        {
            return Products.Sum(x => x.Price);
        }

        public override void PrintKitUpgrade()
        {
            Console.WriteLine();
            Console.WriteLine($"Kit {Name} - Tipo {KitType}");

            foreach (Product product in Products)
            {
                Console.WriteLine($"{WHITE_SPACES} - {product.Name}, {product.Model}, {product.Price.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine($"Valor total do kit upgrade: {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
