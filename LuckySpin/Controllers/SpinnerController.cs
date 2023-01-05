using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LuckySpin.Controllers
{
    public class SpinnerController : Controller
    {

        public IActionResult Index(int luck) 
        {


            return new ContentResult { Content = "<h1>We're Ready to Spin with Controllers</h1>", ContentType="text/html"};
        }
    }
}