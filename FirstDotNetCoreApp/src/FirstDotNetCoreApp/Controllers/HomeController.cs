using System;
using FirstDotNetCoreApp.Services;
using FirstDotNetCoreApp.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net.Http;
using FirstDotNetCoreApp.Entities;

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

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(EditRestaurentViewModel restaurent)
        {
            Restaurent aRestaurent=new Restaurent();
            aRestaurent.Name = restaurent.Name;
            aRestaurent.Type = restaurent.Type;

            _restaurentData.Add(aRestaurent);
            return View("Details",aRestaurent);
        }

        public IActionResult Details(int id)
        {
            var restaurent = _restaurentData.GetById(id);
            if (restaurent == null)
            {
                return StatusCode(404);
            }
            return View(restaurent);
        }

         
    }
}
