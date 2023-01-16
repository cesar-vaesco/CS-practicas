namespace SobreescrituraMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            A a = new A();  
            Console.WriteLine(b.Hi());

            Sale sale = new Sale(10);
           
            sale.Add(3);
            sale.Add(2);

            Console.WriteLine("Venta sin impuestos: " + sale.GetTotal());

            SaleWithTax saleWith = new SaleWithTax(10,1.16m);
            saleWith.Add(2);
            saleWith.Add(3);

            Console.WriteLine("Venta con impuestos: " + saleWith.GetTotal());


            
        }
    }


    public class Sale 
    {

        private decimal[] _amount;
        private int _n;
        private int _end;




        public Sale( int n)
        {
            _amount = new decimal[n];
            _n = n;
            _end = 0;

        }


        public void Add(decimal amount) 
        {

            if (_end < _n)
            {
                _amount[_end] = amount;
                _end++;
            }
        }

        public virtual decimal GetTotal()
        {
            decimal result = 0;

            int i = 0;

            while (i < _amount.Length)
            {
                result += _amount[i];
                i++;
            }

            return result;
        }

    }


    public class SaleWithTax : Sale 
    {

        private decimal _tax;

        public SaleWithTax(int n, decimal tax) : base (n)
        {
            _tax = tax;
        }

        public override decimal GetTotal()
        {
            return base.GetTotal() * _tax;
        }

    } 

    class A
    {
        public virtual string Hi()
        {
            return "Hola soy A";
        }
    
    }

    class B:A 
    {
        public override string Hi()
        {
            return "Hola soy B en método sobreescrito de Hi";
        }
    
    }
}