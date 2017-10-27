using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstDotNetCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstDotNetCoreApp.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            var restaurent = new Restaurent() {Id =1, Name = "Pizaa Hat"};
            return View(restaurent);
        }
    }
}
