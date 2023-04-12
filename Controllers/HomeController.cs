using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthorizationPage.Models;

namespace AuthorizationPage.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public IActionResult Index() => View();
    }
}
