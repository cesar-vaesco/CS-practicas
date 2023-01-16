namespace ExcepcionPersonalizada
{
     class Program
    {
        static void Main(string[] args)
        {
            Beer cerveza = new Beer()
            {
                //Name = "XX Lager",
                Brand = "Cuautemoc"
            };


            try 
            { 
            
            Console.WriteLine(cerveza);

            }catch(invalidBeerException ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }

    public class invalidBeerException : Exception
    {

        public invalidBeerException() : base("La cerveza no tiene nombre o marca por lo cual es invalida")
        {
            
        }
    }

    class Beer
    {

        public string Name { get; set; }
        public string Brand { get; set;}


        public override string ToString()
        {

            if (Name == null || Brand == null)
            {

                throw new invalidBeerException();
            }

            return $"Cerveza: {Name} - Marca: {Brand}";
        }

    }
}