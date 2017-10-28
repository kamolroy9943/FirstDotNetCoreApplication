using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using FirstDotNetCoreApp.Entities;

namespace FirstDotNetCoreApp.ViewModels
{
    public class EditRestaurentViewModel
    {

        [Required(ErrorMessage = "Name field is required")]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        public Types Type { get; set; }


    }
}
