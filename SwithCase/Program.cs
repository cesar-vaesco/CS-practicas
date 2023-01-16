namespace SwithCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 5;


            switch (op) 
            {

                case < 0:
                case > 100:
                    Console.WriteLine("Seleccionaste un valor fuera de rango: " + op);
                    break;

                case 1:
                Console.WriteLine("Seleccionaste el caso 1" );
                    break;

                case 2:
                    Console.WriteLine("Seleccionaste el caso 2");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Seleccionaste el caso 3 o 4");
                    break;

                case > 4 and < 10:
                    Console.WriteLine("Seleccionaste " + op + " que se encuentra entre un rango entre 4 y 10");
                    break;
                
                default:
                    Console.WriteLine("No seleccionaste alguna opción valida");
                    break;
            }
        }
    }
}