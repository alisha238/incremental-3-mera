using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnetapp.Controllers
{
    [Route("[controller]")]
    public class PlayerController : Controller
    {
        private readonly ApplicationDbContext context;

        public PlayerController(ILogger<PlayerController> logger)
        {
            _logger = logger;
        }


        [HttpPost]
        [Route(UserLogin)]
        public IActionResult Login(User U){
            if(ModelState.IsValid){
                var data = ContextBoundObject.Users.FirstOrDefault(u => u.UserName == U.UserName && u.UserPassword == U.UserPassword);
                return RedirectToAction("Login", U);
            }
            return Ok();
        }

        [HttpPost]
        [route()]



        
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}