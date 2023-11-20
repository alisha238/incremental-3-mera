// using System;
// using System.Collections.Generic;
// using System.Diagnostics;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;

// namespace dotnetapp.Controllers
// {
//     [Route("[controller]")]
//     public class PlayerController : Controller
//     {
//         // private readonly ApplicationDbContext context;

//         public PlayerController(ILogger<PlayerController> logger)
//         {
//             _logger = logger;
//         }
      
//         [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//         public IActionResult Error()
//         {
//             return View("Error!");
//         }
//     }
// }