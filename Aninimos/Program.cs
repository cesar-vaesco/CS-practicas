namespace Anonimos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var cesar = new
            {
                Name = "César",
                Country = "Mexico"
            };

            var beers = new[]
            {
                new{Name = "Red", Brand= "Delirirum" },
                new{Name = "Corono", Brand= "Cuautemoc" }
            };


            foreach (var beer in  beers) {

                Console.WriteLine($"{beer.Name} - {beer.Brand}");
            }

            Console.WriteLine($"{cesar.Name} - {cesar.Country}");
        }
    }
}