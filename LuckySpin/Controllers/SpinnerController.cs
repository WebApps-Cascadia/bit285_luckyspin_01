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

            System.Random rand = new System.Random();
            rand.Next(10);

            int[] spin = new int[] { rand.Next(10), rand.Next(10), rand.Next(10) };

            string[] nums = new string[]
            {
                "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"
            };

            string number = "";
            for(int i = 0; i < luck; i++)
            {
                number = nums[i];
            }

            System.Text.StringBuilder htmlToShow =
              new System.Text.StringBuilder("<body><h1>Lucky " + number + "</h1><button onclick='history.go(0)'>Spin</button>");
            htmlToShow.Append("<div>" + spin[0] + "</div>");
            htmlToShow.Append("<div>" + spin[1] + "</div>");
            htmlToShow.Append("<div>" + spin[2] + "</div>");

            for (int i = 0; i < spin.Length; i++)
            {
                if (spin[i] == luck)
                {
                    htmlToShow.Append("<img src='http://faculty.cascadia.edu/brianb/images/LuckySevenExercise.jpg'/></body>");
                    break;
                }
            }


            return new ContentResult { Content = htmlToShow.ToString(), ContentType="text/html"};
        }
    }
}