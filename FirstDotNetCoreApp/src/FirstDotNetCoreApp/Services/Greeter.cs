using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace FirstDotNetCoreApp.Services
{
    public interface IGreeter
    {
        string GetAllGreetings();
    }
    public class Greeter:IGreeter
    {
        private string _greetings;

        public Greeter(IConfiguration configuration)
        {
            _greetings = configuration["greetings"];
        }
        public string GetAllGreetings()
        {
            return _greetings;
        }
    }
}
