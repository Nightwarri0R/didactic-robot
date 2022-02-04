using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotificationLeads.Models
{
    public class Validation : Controller
    {
      


        [HttpGet]
        public IActionResult GetEmail()
        {


            return View();
        }
    }

}
