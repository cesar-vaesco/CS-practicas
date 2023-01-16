using System.Collections.Generic;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>()
            {
                2,5,9,52,75,63
            };

            var students = new List<People>()
            {

                new People("José", "México"),
                new People("Martha", "USA")
            };

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //Creadno un objeto de tipo People y agregandolo a lista de estudiantes
            var maria = new People("María", "Japón");
            students.Add(maria);
            
            Show(students);
        }


        static void Show(List<People> students)
        {

            Console.WriteLine("**** Personas ****");
            foreach (var people in students)
            {
                Console.WriteLine($"Nombre: {people.name}, Pais: {people.country}");
            
            }
        }


    }

    class People
    {
        public string name { get; set; }

        public string country { get; set; }

        public People(string name, string country) 
        {
            this.name = name;
            this.country = country;
        }
    }

  


}