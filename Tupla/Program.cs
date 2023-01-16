namespace Tupla
{
    class Program
    {
        static void Main(string[] args)
        {

            (int id, string name) product = ( 1, "Cerveza Strout" );
            Console.WriteLine($"{product.id} - {product.name}");

            product.name = "cerveza porter";            
            Console.WriteLine($"{product.id} - {product.name}");

            var person = (1, "César");
            Console.WriteLine($"Persona: {person.Item1} - {person.Item2}");

            Console.WriteLine("\n******\n");
            var people = new[] 
            {
                (1, "César"),
                (2, "Tómas"),
                (3, "Julia")
            };

            foreach (var p in people) 
            {
                Console.WriteLine($"{p.Item1}  {p.Item2}");
            }

            Console.WriteLine("\n******\n");
            (int id, string nombre)[] people2 = new[]
            {
                (1, "César"),
                (2, "Tómas"),
                (3, "Julia")
            };

            foreach (var p in people2)
            {
                Console.WriteLine($"{p.Item1}  {p.Item2}");
            }

            var cityInfo = getLocationCDMX();

            Console.WriteLine($"\nLat:{cityInfo.lat} - Lon:{cityInfo.lon} - Name: {cityInfo.name}");

            var (_, log, _) = getLocationCDMX();



            Console.WriteLine($"\nLon:{log}");

        }


        public static (float lat, float lon, string name) getLocationCDMX()
        {
            float lat = 19.12345f;
            float lon = -99.2912f;
            string name = "Ciudad de México";

            return (lat, lon, name); 
        }
    }
}