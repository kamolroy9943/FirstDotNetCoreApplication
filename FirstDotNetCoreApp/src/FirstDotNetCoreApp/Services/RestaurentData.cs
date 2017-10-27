using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstDotNetCoreApp.Models;

namespace FirstDotNetCoreApp.Services
{
    public interface IRestaurentData
    {
        IEnumerable<Restaurent> GetAll();
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
                new Restaurent {Id=2,Name="New Hat" },
                new Restaurent {Id=2,Name="Talha Hat" },
                new Restaurent {Id=2,Name="Kahabar Hat" }
            };
        }
        public IEnumerable<Restaurent> GetAll()
        {
            return _restaurents;
        }
    }
}
