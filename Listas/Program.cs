//using System.Collections.Generic; 


namespace Listas
{
     class Program
    {
        static void Main(string[] args)
        {
            //Crear una lista
            List<int> numbers = new List<int>();
            //Agregando elementos
            numbers.Add(5);
            numbers.Add(2);

            //Mostrando cantidad de elementos
            Console.WriteLine(numbers.Count);

            //Inicializador en línea de una lista
            List<int> numbers2 = new List<int>() { 5, 5, 6, 8 };

            Console.WriteLine(numbers2.Count);

            //Acceder a elementos de una lista de forma individula segun su indice
            Console.WriteLine(numbers[0]);

            //Limpiar una lista
            numbers2.Clear();

            Console.WriteLine("Elementos en la lista: " + numbers2.Count);

            List<string> nombres = new List<string>();

            nombres.Add("César");
            nombres.Add("José");

            foreach(string nombre in nombres) 
            {
                Console.WriteLine(nombre);
            }

            // ¡Forma de insertar elementos a una lista  usando un indice
            nombres.Insert(2, "Martha");

            Console.WriteLine(nombres.Count);


            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            //nombres.Short();

            //Insert agrea un elemento a la lista y si el index ya esta ocupado recorre posiciones en el arreglo creando un nuevo index
            nombres.Insert(0, "Tulio");
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }


            //Eliminando elementos - Si se quiere borrar un elemento y no se pasa nada, remove no genera ninguna acción

            nombres.Remove("");

            nombres.Remove("César");
            
            Console.WriteLine("\nRemoviendo usando método Remove\n");
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            //Eliminando por indice

            nombres.RemoveAt(0);
            Console.WriteLine("\nRemoviendo por índice\n");
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
        }

       
        
     }
}