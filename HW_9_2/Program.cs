namespace HW_9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, double>()
            {
                {"apple", 44.5},
                {"orange", 20},
                {"banana", 13.8},
                {"watermelon", 7},
                {"strawberry", 50.7},
            };
            products.Add("melon", 100);
            foreach (var item in products)
            {
                Console.WriteLine(item.Key + ": "+ item.Value);
            }

            Console.WriteLine("Enter product");
            var pruductToFind = Console.ReadLine();
            if (products.ContainsKey(pruductToFind))
            {
                Console.WriteLine("it's price is " + products[pruductToFind]);
            }
            else
            {
                Console.WriteLine("There is no such product");
            }
            foreach (var item in products)
            {
                products[item.Key] *= 1.1;
            }
            foreach (var item in products)
            {
                Console.WriteLine(item.Key + ": " + Math.Round(item.Value, 2));
            }
        }
    }
}
