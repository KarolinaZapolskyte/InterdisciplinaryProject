using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Plantify.Models;
using Microsoft.AspNetCore.Mvc;

namespace Plantify.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public IActionResult Index()
        {
            return View();
        }
    }
}