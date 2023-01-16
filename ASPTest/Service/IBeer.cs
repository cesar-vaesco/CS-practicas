using ASPTest.Models;

namespace ASPTest.Service
{
    public interface IBeerService
    {

        public IEnumerable<Beer> Get();

        public Beer? Get(int id);
    }
}
