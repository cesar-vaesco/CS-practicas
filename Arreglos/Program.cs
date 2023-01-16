namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[7]
            {
                "José","Martha","Marío","Manuela","Anna","Rosa",null

            };



            Console.WriteLine("1.- "+ friends[0]);
            Console.WriteLine("2.- "+ friends[1]);
            Console.WriteLine("3.- "+ friends[2]);
            Console.WriteLine("4.- "+ friends[3]);
            Console.WriteLine("5.- "+ friends[4]);
            Console.WriteLine("6.- "+ friends[5]);
            Console.WriteLine("7.- "+ friends[6]);

            friends[6] = "Carlos";

            Console.WriteLine("#######################\n");

            Console.WriteLine("1.- "+ friends[0]);
            Console.WriteLine("2.- "+ friends[1]);
            Console.WriteLine("3.- "+ friends[2]);
            Console.WriteLine("4.- "+ friends[3]);
            Console.WriteLine("5.- "+ friends[4]);
            Console.WriteLine("6.- "+ friends[5]);
            Console.WriteLine("7.- "+ friends[6]);

        }
    }
}