using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FirstDotNetCoreApp.Entities
{
    public class OTodoFoodDbContext:DbContext
    {
         
        public OTodoFoodDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Restaurent> Restaurents { get; set; }
    }
}
