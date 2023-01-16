﻿namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale sale1 = new Sale(500, DateTime.Now);
            sale1.Total = 120;
            Console.WriteLine(sale1.Total);
            Console.WriteLine(sale1.Date);
            
        }
    }

    class Sale
    {

        int total;
        DateTime date;


        public string Date
        {
            get 
            {
                return date.ToLongDateString();
            }
        
        }
    
        public int Total
        {
            get 
            { 
                return total; 
            }

            set 
            {
                if (value < 0)
                    value = 0;

                total = value; 
            }
        
        }

        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }

    }
}