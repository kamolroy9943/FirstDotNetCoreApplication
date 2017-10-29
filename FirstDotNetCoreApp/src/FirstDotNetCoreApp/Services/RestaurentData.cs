using System.Collections.Generic;
using System.Linq;
using FirstDotNetCoreApp.Entities;

namespace FirstDotNetCoreApp.Services
{
    public interface IRestaurentData
    {
        IEnumerable<Restaurent> GetAll();
        Restaurent GetById(int id);
        void Add(Restaurent aRestaurent);
    }







    public class SqlData:IRestaurentData
    {
        protected OTodoFoodDbContext context;

        public SqlData(OTodoFoodDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Restaurent> GetAll()
        {
            return context.Restaurents.ToList();
        }

        public Restaurent GetById(int id)
        {
            return context.Restaurents.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Restaurent aRestaurent)
        {
            context.Restaurents.Add(aRestaurent);
            context.SaveChanges();
        }
    }







    public class RestaurentData:IRestaurentData
    {
        static List<Restaurent> _restaurents;

        static RestaurentData()
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

        public void Add(Restaurent aRestaurent)
        {
            aRestaurent.Id = _restaurents.Max(x => x.Id)+1;
            _restaurents.Add(aRestaurent);
        }
    }
}
