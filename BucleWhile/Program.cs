namespace BucleWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 100;

            string[] friends = new string[7]
           {
                "José","Martha","Marío","Manuela","Anna","Rosa",null

           };
            /*
            int index = 0;
            while (index <= friends.Length) 
            {
                Console.WriteLine(index + " - " + friends[index]);
                if (friends[6] == null) 
                {
                    friends[6] = "César";
                }

                index++;
            }

*/
            bool run = false;

            do {

                Show();
            
            } while (run);

            /*while (i < 10)
            {
                Console.WriteLine("Iteraacción de i = " + i);
                i++;

                if (i > 9) 
                {
                    Console.WriteLine("\n\n\n");
                    Console.WriteLine("#################");
                    Console.WriteLine( "\n\n\n" );
                
                }
            
            }



            while (j > 0)
            {
                Console.WriteLine("Iteracción de j = " + j );
                j--;

                if (j == 50) {

                    Console.WriteLine("J vale " + j + " y con ello se rompe el while");
                    break;
                }

            }


*/

            static void Show() 
            {

                Console.WriteLine("Entro una vez y ya");
            }

        }
    }
}