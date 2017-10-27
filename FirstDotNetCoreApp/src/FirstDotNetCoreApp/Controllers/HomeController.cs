using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstDotNetCoreApp.Models;
using FirstDotNetCoreApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace FirstDotNetCoreApp.Controllers
{
    public class HomeController:Controller
    {
        private IRestaurentData _restaurentData;

        public HomeController(IRestaurentData restaurentData)
        {
            _restaurentData = restaurentData;
        }
        public ViewResult Index()
        {
            var restaurent = _restaurentData.GetAll();
            return View(restaurent);
        }
    }
}
