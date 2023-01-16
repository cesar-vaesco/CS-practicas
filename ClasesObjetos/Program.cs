namespace ClasesObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sale sale1 = new Sale(100, DateTime.Now);
            Sale sale2 = new Sale(500, DateTime.Now);

            Console.WriteLine(Math.E);

            Console.WriteLine( sale1.getInfo());

            Console.WriteLine(sale2.getInfo());




        }
    }

    class Sale
    {

        int total;
        DateTime date;

        public Sale(int total, DateTime date)
        { 
            this.total = total;
            this.date = date;
        }

        public string getInfo()
        { 
            return "Venta total: " + total + " \nFecha: " + date.ToLongDateString();
        }

        public void Show()
        {
            Console.WriteLine("Hola, soy una venta");
        }
    }

    class NLog
    {
        // Private Constructor:
        private NLog() { }

        public static double e = Math.E;  //2.71828...
    }
}