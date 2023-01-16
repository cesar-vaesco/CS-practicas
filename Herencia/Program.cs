using System.Runtime.CompilerServices;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Doctor doctor1 = new Doctor("César", 42, "Cardialogo");

            Console.WriteLine("Dr. " + doctor1.GetData());

            Dev dev1 = new Dev("César", 42, "C#");

            Console.WriteLine("Developer: " + dev1.GetData());

            Console.WriteLine(dev1.Glenguaje);

            dev1.Glenguaje = "Java";

            Console.WriteLine(dev1.Glenguaje);

        }


    }

    class People
    {
        private string _name;
        private int _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set {_age = value; }
        }

        public People(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string GetInfo() 
        { 
            return _name + " " + _age; 
        }
    
    }

    class Doctor : People 
    {

        private string _speciality;
        public Doctor(string name, int age, string speciality) : base(name, age)
        { 
            _speciality = speciality;
            
        }

        public string GetData()
        {
            return GetInfo() + " " + _speciality;
        }
    }

    class Dev : People
    {
        private string _lenguaje;

        public string Glenguaje
        {
            get { return _lenguaje; }

            set { _lenguaje = value; }
        }

        public Dev(string name, int age, string lenguaje) : base(name, age)
        {
            _lenguaje = lenguaje;
        }

        public string GetData()
        {
            return GetInfo() + " " + _lenguaje;
        }
    }
}