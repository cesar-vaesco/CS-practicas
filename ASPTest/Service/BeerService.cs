using ASPTest.Models;

namespace ASPTest.Service
{
    public class BeerService : IBeerService
    {


        private List<Beer> _beers = new List<Beer>()
        {
            new Beer() { Id = 1, Name= "Corona",Brand = "Modelo" },
            new Beer() { Id = 2,Name= "Pikantus", Brand = "Erdin"}
        };
        public IEnumerable<Beer> Get() => _beers;

        public Beer? Get(int id) => _beers.FirstOrDefault(d => d.Id == id);

    }
}
