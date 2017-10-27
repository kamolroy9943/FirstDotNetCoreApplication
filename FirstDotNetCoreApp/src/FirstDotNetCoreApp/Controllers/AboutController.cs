using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstDotNetCoreApp.Controllers
{
    [Route("company/[Controller]/[action]")]
    public class AboutController
    {
       // [Route("")]
        public string Phone()
        {
            return "+88 01762-709943";
        }

       // [Route("action")]
        public string Country()
        {
            return "Bangladesh";
        }
    }
}
