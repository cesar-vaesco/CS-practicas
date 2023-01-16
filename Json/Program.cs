
using System.Text.Json;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {

            Beer myBeer = new Beer()
            {
                Name = "Pikantus",
                Brand = "Erdinger"
            };


            //string json = "{\"Name\": \"Pikantus\", \"Brand\": \"Erdinger\"}";

            string jsonSerializado = JsonSerializer.Serialize(myBeer);
            Beer beer = JsonSerializer.Deserialize<Beer>(jsonSerializado);

            string jsonColeccion = "[" +
                "{\"Name\": \"Pikantus\", \"Brand\": \"Erdinger\"}," +
                 "{\"Name\": \"XX Lager\", \"Brand\": \"Cuautemoc\"}" +
                "]";

            Beer[] beers = new Beer[]
            {
                 new Beer() {
                    Name = "Pikantus",
                    Brand = "Erdinger"
                },

                 new Beer()
                 {
                     Name = "XX Lager",
                    Brand = "Cuautemoc"
                 }
            };

            Console.WriteLine("Colección de Json inicializados como objetos: ");
            foreach (var _beer in beers)
            {
                Console.WriteLine(_beer.GetBeer());
            }

            //Console.WriteLine("\nJson en cadena de string: \n" + json);

            
            Console.WriteLine("\nObjeto json: \n" + myBeer.GetBeer());
            Console.WriteLine("\nColección de Json: \n" + jsonColeccion);
            Console.WriteLine($"\nJson Serializado: {jsonSerializado}");
            Console.WriteLine("Json deserializado: " + beer.GetBeer());

        }
    }

    class Beer
    {
        public string Name { get; set; }
        public string Brand { get; set; }

        public string GetBeer()
        {
            return $"Nombre: {Name} - Marca: {Brand} ";
        }
    }
}