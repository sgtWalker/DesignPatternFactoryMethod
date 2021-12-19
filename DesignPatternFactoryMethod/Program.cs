using DesignPatternFactoryMethod.Entities;
using DesignPatternFactoryMethod.Entities.Enum;
using DesignPatternFactoryMethod.Entities.Factory;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace DesignPatternFactoryMethod
{
    class Program
    {
        private static KitType _kitType;
        private static string _kitName;

        static void Main(string[] args)
        {
            var data = RequestData();
            ProcessData(data);
        }

        private static List<Product> RequestData()
        {
            List<Product> products = new List<Product>();
            
            try
            {
                Console.Write("Informe o tipo do kit upgrade que será cadastrado (1 - AMD, 2 - Intel): ");
                _kitType = (KitType)int.Parse(Console.ReadLine());
                Console.Write("Informe o nome do kit upgrade: ");
                _kitName = Console.ReadLine();
                Console.Write("Informe a quantidade de produtos que serão incluídos no kit: ");
                int quantity = int.Parse(Console.ReadLine());


                for (int i = 1; i <= quantity; i++)
                {
                    Console.Write($"Informe o nome do produto #{i}: ");
                    string productName = Console.ReadLine();
                    Console.Write($"Informe o modelo do produto #{i}: ");
                    string productModel = Console.ReadLine();
                    Console.Write($"Informe o preço do produto #{i}: ");
                    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new Product(productName, productModel, productPrice));
                }
            }
            catch(ApplicationException ex)
            {
                Console.WriteLine($"Ocorreu uma ApplicationException no método RequestData, mensagens: {ex.Message}, {(ex.InnerException == null ? "" : ex.InnerException.Message)}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ocorreu uma Exception no método RequestData, mensagens: {ex.Message}, {(ex.InnerException == null ? "" : ex.InnerException.Message)}");
            }

            return products;
        }

        private static void ProcessData(List<Product> data)
        {
            try
            {
                KitFactory factory = new KitFactory();
                kitUpgrade kitUpgrade = factory.CreateKitUpgrade(_kitType, _kitName);
                kitUpgrade.InsertListOfProducts(data);
                kitUpgrade.PrintKitUpgrade();
            }
            catch(ApplicationException ex)
            {
                Console.WriteLine($"Ocorreu uma ApplicationException no método ProcessData, mensagens: {ex.Message}, {(ex.InnerException == null ? "" : ex.InnerException.Message)}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ocorreu uma Exception no método ProcessData, mensagens: {ex.Message}, {(ex.InnerException == null ? "" : ex.InnerException.Message)}");
            }

        }
    }
}
