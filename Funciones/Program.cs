namespace Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            Show();

            Sum(4, 7);

            Console.WriteLine(Mul(5, 6));

            int resultado = Mul(5 , 5);

            Console.WriteLine(resultado);

        }


        static void Sum(int a, int b) 
        {
            int num3 = a + b;

            Console.WriteLine( a + " + " + b + " = " + num3);
            
        }


        static int Mul(int a, int b) 
        {
            return a * b;
        }

        static void Show() 
        {
            Console.WriteLine("Hola soy un texto que se imprime desde función");
        
        }

    }
}