using System;

namespace HomeTask_03._02._23_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Hometask
            Store store = new Store();
            store.Products = new Product[0];

            Product pr1 = new Product()
            {
                Category = "Women",
                Price = 170
            };
            Product pr2 = new Product()
            {
                Category = "Men",
                Price = 67
            };

            Product pr3 = new Product()
            {
                Category = "Child",
                Price = 90
            };
            ////store.AddProduct(pr1);
            ////store.AddProduct(pr2);
            ////store.AddProduct(pr3);

            try
            {
                store.AddProduct(pr1);
                store.AddProduct(pr2);
                store.AddProduct(pr3);
            }
            catch (DuplicatedItemException)
            {
                Console.WriteLine("Product movcuddur!");
            }
            catch (ProductNotFoundException)
            {
                Console.WriteLine("Bu nomreli Product yoxdur.");
            }
            #endregion



        }
    }
}
