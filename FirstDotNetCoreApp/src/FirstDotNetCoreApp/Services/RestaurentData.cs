using System.Collections.Generic;
using System.Linq;
using FirstDotNetCoreApp.Entities;

namespace FirstDotNetCoreApp.Services
{
    public interface IRestaurentData
    {
        IEnumerable<Restaurent> GetAll();
        Restaurent GetById(int id);
    }
    
    public class RestaurentData:IRestaurentData
    {
        private List<Restaurent> _restaurents;

        public RestaurentData()
        {
            _restaurents = new List<Restaurent>
            {
                new Restaurent { Id = 1, Name = "pizabaxar"},
                new Restaurent {Id=2,Name="Kahabar Hat" },
                new Restaurent {Id=3,Name="New Hat" },
                new Restaurent {Id=4,Name="Talha Hat" },
                new Restaurent {Id=5,Name="Kahabar Hat" }
            };
        }
        public IEnumerable<Restaurent> GetAll()
        {
            return _restaurents;
        }

        public Restaurent GetById(int id)
        {
            return _restaurents.FirstOrDefault(p => p.Id == id);
        }
    }
}
