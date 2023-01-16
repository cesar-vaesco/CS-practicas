namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] areegloEnteros = {1,2,3,4,5,6,85,74,100,2, 45,5, 7 };

            IEnumerable<int> lst = from d in areegloEnteros
                                   where d == 2 || d == 5
                                   orderby d
                                   select d;


            foreach ( var a in lst)
            {
                Console.WriteLine(a);
            }

            Complejo[] complejos =
             {
                new Complejo(1, "patito"),
                new Complejo(2, "gatito"),
                new Complejo(3, "diablito"),
                new Complejo(4, "perrito"),
                new Complejo(5, "foca")
            };

            var oDiablo = (from d in complejos
                          where d.cadena == "diablito"
                          select d).FirstOrDefault();

            var lstComplejos = (from d in complejos
                                where d.numero == 1 || d.numero == 2
                                select d);

            var lstNumero = (from d in complejos
                             orderby d.numero
                             select d);


            Console.WriteLine(oDiablo.imprime());


            foreach (var c in complejos)
            {
                Console.WriteLine(c.imprime());
            }

            Console.WriteLine("#####################");

            foreach (var c in lstComplejos)
            {

                Console.WriteLine(c.imprime());
            }

            Console.WriteLine("#####################");

            foreach (var c in lstNumero)
            {
                Console.WriteLine(c.imprime());
            }


        }
    }


    public class Complejo
    { 
        public int numero { get; set; }
        public string cadena { get; set; }

        public Complejo(int numero, string cadena)
        {
            this.numero = numero;
            this.cadena = cadena;
        }


        public String imprime()
        {
            return "Número: "+numero + "\nNombre: " + cadena; 
        }
    }
}