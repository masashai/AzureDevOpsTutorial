using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCore.Answer.Web.Models;
using AspNetCore.Answer.Web.Data;

namespace AspNetCore.Answer.Web.Services
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
            
            if (hour < 5)
            {
                greeting = "こんばんは";
            }
            else　if(hour < 12)
            {
                greeting = "おはよう";
            }
            else if (hour < 17)
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
