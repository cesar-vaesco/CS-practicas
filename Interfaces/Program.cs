using System.Xml.Linq;

namespace Interfaces
{
     class Program
    {
        static void Main(string[] args)
        {

            Shark[] sharks = new Shark[]
            {
                new Shark("Tibu", 20), 
                new Shark("Ron", 15),
                new Shark("Tiburonsin", 45)
            };

 

            Console.WriteLine("- Mostrando peses con método forEach\n");
            foreach (var shark in sharks)
            {
                Console.WriteLine(shark.Swing());

            }

            IFish[] fish = new IFish[] 
            {
                    new Siren(100),
                    new Shark("Titi", 52)
            };

            ShowFish(sharks);
            ShowAnimals(sharks);
            ShowFish(fish);
            
        }

        public static void ShowFish(IFish[] fishs ) {

            Console.WriteLine("\n -  Mostramos peces  método static - \n");

            int i = 0;

            while (i < fishs.Length) {

                Console.WriteLine(fishs[i].Swing());

                i++;
            }
        
        }

        public static void ShowAnimals(IAnimal[] animals)
        {

            Console.WriteLine("\n -  Mostramos nombre de animales método static - \n");

            int i = 0;

            while (i < animals.Length)
            {

                Console.WriteLine(animals[i].Name);

                i++;
            }

        }
    }


    public class Siren : IFish
    {
        public int Speed { get; set; }

        public Siren(int speed) { 
        
            this.Speed = speed;
        }

        public string Swing() 
        {
            return $"Una sirena nada a {Speed} km/hr";
        }
    }

    public class Shark : IAnimal, IFish
    {
        public string Name { get; set; }

        public int Speed { get; set; }

        public Shark(string name, int speed)
        { 
    
            this.Name = name;
            this.Speed = speed;
        }


        public string Swing()
        {
            return $"{Name} nada a {Speed} km/hr";
        }
    }

    public interface IAnimal
    { 
    
        public string Name { get; set; }
    }

    public interface IFish
    {
    
        public int Speed { get; set; }
        public string Swing();
    }
}