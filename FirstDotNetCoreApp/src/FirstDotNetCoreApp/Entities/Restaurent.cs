using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstDotNetCoreApp.Entities
{
    public enum Types
    {
        None,
        Italiean,
        French,
        American,
        Chainese
    }
    public class Restaurent
    {
        
        public int Id { get; set; }

        public string Name { get; set; }

        public Types Type { get; set; }


    }
}
