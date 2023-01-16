namespace SobrecargaMetodos
{
   class Program
    {
        static void Main(string[] args)
        {

            Math math = new Math();
            Console.WriteLine("resultado: " + math.Sum(5,5));

            Console.WriteLine("resultado: " + math.Sum("10", "20"));

            int[] numbers = new int[] { 1, 5, 7, 42 };

            Console.WriteLine("Resultado: " + math.Sum(numbers) );
        }
    }

    class Math 
    {

        public int Sum (int a, int b) 
        {
            return a + b;
        }

        public int Sum(string a, string b)
        {
            return int.Parse(a) +  int.Parse(b);
        }

        public int Sum(int[] numbers)
        {
            int result = 0;
            int i = 0;

            while (i < numbers.Length) 
            {
                result += numbers[i];
                i++;
            }

            return result;
        }

    }
}