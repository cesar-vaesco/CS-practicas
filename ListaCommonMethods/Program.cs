using System.Collections.Generic;

namespace ListaCommonMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> numbers = new List<int>()
            { 
                45,6,8,96
            };

            Show(numbers);

            //Insertar elementos a la lista en la posición deseada
            //En posición cero
            numbers.Insert(0,50);
            Show(numbers);

            numbers.Insert(0, 51);
            Show(numbers);
            //Identificar si existe un elemento en la lista

            if (numbers.Contains(51))
            {
                Console.WriteLine("Existe");
            }
            else
            {

                Console.WriteLine("No existe");
            }

            //Mostrar posición del elemeno

            int pos = numbers.IndexOf(50);
            Console.WriteLine("\nPosición del elemento: ");
            Console.WriteLine($"Existe el elemento: {pos} - 1:si - 0:no");

            //Ordenando lista
            Console.WriteLine("** Ordenando una lista");
            numbers.Sort();

            //Short
            Show(numbers);

            //Método AddRange - juntando los listas
            var numbers2 = new List<int>() { 20,15,63,85,45 };

            numbers.AddRange(numbers2);

            Show(numbers);

            numbers.Sort();
            Show(numbers);





        }


        public static void Show(List<int> numbers)
        {
            Console.WriteLine("**** Números****");

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}