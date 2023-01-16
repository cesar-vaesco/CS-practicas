namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[7]
           {
                "José","Martha","Marío","Manuela","Anna","Rosa",null

           };


            bool run = true;

            for (int i = 0; i < friends.Length && run; i++)
            {
                if (friends[i] == null) 
                {

                    friends[6] = "César";
                }

                Console.WriteLine(friends[i]);
            }


            foreach (String friend in friends)
            {
                Console.WriteLine("Recorriendo en foreach: " + friend);
            }

        }
    }
}