using System.Reflection.Metadata.Ecma335;

namespace SentenciaIfElseIf
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool areYouHungry = true;
            bool yourHaveMoney = true;


            if (areYouHungry &&  yourHaveMoney && isOpenRestaurant("José", 9) )
            {

                Console.WriteLine("Come ahora!");
            }
            else 
            {
                Console.WriteLine("No comes!");
            }
            
        }

        static bool isOpenRestaurant(string name, int hour = 0)
        {
            if (name == "lonches pepe" && hour > 8 && hour < 23)
            {
                return true;
            }
            else if(name == "Restaurant 24 horas")
            {
                return true;
            } else
            {
                return false;
            }
        
        }
    }
}