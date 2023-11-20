using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnetapp.Models;
 
namespace dotnetapp.Controllers
{
   
 
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext context;
 
        public UserController(ApplicationDbContext _context)
        {
            context = _context;
        }
 
        [HttpGet]
 
        [Route("ListTeam")]
        public IActionResult Get()
        {
            var data=from m in context.Teams select m;
            return Ok(data);
        }
 
        [HttpPost]
        [Route("UserLogin")]
 
        public IActionResult Login(User U) {
            if(ModelState.IsValid){
                var data= context.Users.FirstOrDefault(u=> u.Name== U.Name && u.password == U.password)
                return RedirectToAction("Login", U);
            }
            return Ok();

        }
 
        [HttpPost]
        [Route("UserRegister")]
        public IActionResult Register() {

            context.Users.Add(u);
            context.SaveChanges();
            return Ok();
        }
 
 
 
       
    }
}
