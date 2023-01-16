
namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> numbers = new MyList<int>(10);

            numbers.Add(10);
            numbers.Add(6);

            MyList<string> strings = new MyList<string>(10);
            strings.Add("Armando");
            strings.Add("José");
            strings.Add("María");
            strings.Add("Herminía");
            //Regresa valor 0, que es el valor generico que por default entrega un objeto de tipo Generic
            Console.WriteLine(numbers.GetElement(11));
            //Regresa elemento de la colección que si existe
            Console.WriteLine(strings.GetElement(0));

            Console.WriteLine(numbers.GetString());
            Console.WriteLine(strings.GetString());


            MyList<People> people = new MyList<People>(5);
            people.Add(new People("César", "México"));
            people.Add(new People("Messi","Argentina"));

            Console.WriteLine(people.GetString().ToString());
            

        }
    }

    public class People
    {
        public string Name { get; set; }
        public string Country { get; set; }


        public People(string name, string country) 
        {
        
            Name = name;
            Country = country;
        }

        public override string ToString()
        {
            return $"Nombre: {Name} - Pais: {Country}";
        }
    }


    public class MyList<T>
    {
        private T[] _elements;
        private int _index = 0;

        public MyList(int n)
        {

            _elements = new T[n];
        }

        public void Add(T e)
        {

            if (_index < _elements.Length)
            {
                _elements[_index] = e;
                _index++;
            }
        }

        public T GetElement(int i)
        {
            if (i <= _index && i >= 0)
            {

                return _elements[i];
            }

            return default(T);
        }


        public string GetString()
        {
            int i = 0;

            string result = "";

            while (i < _index)
            {
                result += _elements[i].ToString() + " |";
                i++;
            }

            return result;

        }

    }
}