namespace ConstructorEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person persona = new Person("César", "Vargas");

            Console.WriteLine(persona.lastName);

        }
    }

    public class Person
    {
        private string last;
        private string first;


        public Person(string lastName, string firstName)
        {
            
            this.first = firstName;
            this.last = lastName;

            get;
            set;
        }

        // Remaining implementation of Person class.
    }
}