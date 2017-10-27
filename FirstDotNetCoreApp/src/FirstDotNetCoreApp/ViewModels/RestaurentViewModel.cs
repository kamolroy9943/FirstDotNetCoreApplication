using System.Collections.Generic;
using FirstDotNetCoreApp.Entities;

namespace FirstDotNetCoreApp.ViewModels
{
    public class RestaurentViewModel
    {
        public IEnumerable<Restaurent> Restaurents { get; set; }
        public string CurrentGreeting { get; set; }

    }
}
