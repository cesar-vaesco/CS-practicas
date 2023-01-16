namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {

            People people1 = new People()
            {
                Name = "César",
                Age = 42
            };

            People people2 = new People()
            {
                Name = "Marío",
                Age = 32
            };

            People people3 = new People()
            {
                Name = "Rosa",
                Age = 32
            };
            People people4 = new People("Carla", 20);
            



            Console.WriteLine(people1.Name);
            Console.WriteLine(people1.Age);

            Console.WriteLine(people1.GetValuesPeople());
            Console.WriteLine(people2.GetValuesPeople());
            Console.WriteLine("Objetos creados: " + People.Count);
            Console.WriteLine(People.GetValuesCount());


           
        }


        public class People
        {

            public static int Count = 0;

           


            public string Name { get; set; }

            public int Age { get; set; }


            public People() {
                Count++;
            }
            public People(string name, int edad)
            { 
                
                this.Name = name;
                this.Age = edad;

                Count++;
            }

            public string GetValuesPeople() {

                return "Nombre: " + Name + " Edad: " + Age;
            
            }

            public static string GetValuesCount() {

                return $"Han sido creados {Count} objetos de la clase People ";
            }
        }
    }

}