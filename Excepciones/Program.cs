
using System.IO;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {

                string context = File.ReadAllText(@"C:\Users\cesar\Desktop\Impresion_textil.txt");

                Console.WriteLine(context);


                //string context2 = File.ReadAllText(@"C:\Users\cesar\Desktop\Impresion_textil2.txt");

                //Console.WriteLine(context2);

                throw new Exception("Ocurrio algo raro");

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("El archivo no existe\n");
                Console.WriteLine(e);
            }

            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally 
            {
                Console.WriteLine("\nAquí me he ejecutado pase lo que pase");
            }

            Console.WriteLine("\nAquí se sigue ejecutando");
        }
    }
}