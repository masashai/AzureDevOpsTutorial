using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCore.Web.Models;
using AspNetCore.Web.Data;

namespace AspNetCore.Web.Services
{
    public interface IHomeService
    {
        string Greet(int hour);
    }

    public class HomeService : IHomeService
    {
        public string Greet(int hour)
        {
            var greeting = "";

            if (hour < 12)
            {
                greeting = "おはよう";
            }
            else if (hour < 18)
            {
                greeting = "こんにちは";
            }
            else
            {
                greeting = "こんばんは";
            }
            return greeting;
        }
    }
}
