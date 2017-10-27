using FirstDotNetCoreApp.Services;
using FirstDotNetCoreApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FirstDotNetCoreApp.Controllers
{
    public class HomeController:Controller
    {
        
        private IRestaurentData _restaurentData;
        private IGreeter _greeter;

        public HomeController(IRestaurentData restaurentData,
            IGreeter greeter)
        {
            _restaurentData = restaurentData;
            _greeter = greeter;
        }
        public ViewResult Index()
        {
            var restaurent = new RestaurentViewModel();
            restaurent.Restaurents = _restaurentData.GetAll();
            restaurent.CurrentGreeting =_greeter.GetAllGreetings();
            return View(restaurent);
        }
    }
}
