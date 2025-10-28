namespace Katarzhin_ISP_232_Lab_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var monster = new
            {
                Name = "Dragon",
                Damage= 50,
                IsBoss = true,
                Description = "Ancinet fire-breathong serpent"

            };

            Console.WriteLine(monster.Description);
            var products = new[]
            {
                new {Name = "Milk", Price = 59.99, Category = "Products"},
                new {Name = "Laptop", Price = 49990.00, Category = "Electronics"},
                new {Name = "Teethbrush", Price = 120.50, Category = "Hygiene"}
            };

            Console.WriteLine("List of products");
            foreach(var product in products)
            {
                Console.WriteLine($"{product.Name} ({product.Category}) - {product.Price} $");
            }

        }
    }
}
