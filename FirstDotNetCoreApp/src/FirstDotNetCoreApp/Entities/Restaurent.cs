using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required(ErrorMessage = "Name field is required")]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        public Types Type { get; set; }


    }
}
