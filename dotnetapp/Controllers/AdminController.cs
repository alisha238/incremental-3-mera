// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Cors;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using dotnetapp.Models;
 
// namespace dotnetapp.Controllers
// {
 
   
//     [ApiController]
//     [Route("/[controller]")]
//     public class AdminController : ControllerBase
//     {
//         private readonly ApplicationDbContext context;
//     //    ApplicationDbContext context = new ApplicationDbContext();
 
//         public AdminController(ApplicationDbContext _context)
//         {
//             context = _context;
//         }
 
//         public IActionResult GetPlayers(){
//             var data = context.Players.ToList();
//             return Ok(data);
//         }


//         [HttpPut]
//         [Route("EditPlayer/{id}")]
//         public IActionResult PutPlayer(int id, Player player){

//             try{

//             if(ModelState.IsValid)
//             {
//                 Player p = new Player();
//                 Player e = context.Players.Find(id);
//                 e.Name = player.Name;
//                 e.Age= player.Age;
//                 e.Category=player.Category;
//                 e.BiddingPrice= player.BiddingPrice;
//                 context.SaveChanges();
//                 return Ok();
//             }
//             return Ok();
//             }catch(System.Exception ex){
//                 return BadRequest(ex.Message);
//             }
//         }

//         [HttpDelete]
//         [Route("DeletePlayer/{id}")]
//         public IActionResult DeletePlayer(int id)
//         {
//             try{
//             var data = context.Players.Find(id);
//             context.Players.Remove(data);
//             context.SaveChanges();
//             return Ok();
//             }catch(System.Exception ex){
//                 return BadRequest(ex.Message);
//             }
//         }

//         [HttpPost]
//         [Route(AddPlayer)]
//         public IActionResult Post(Player p){
//             try{
//                 if(ModelState.IsValid){
//                     context.Players.Add(p);
//                     context.SaveChanges();
//                 }
//             }catch(System.Exception ex){

//             }
//         }




//         //// TEAM CONTROLLER//////

//         [HttpGet]
//         [Route("GetTeams")]
//         public IActionResult GetTeam(){
//             var data = context.Teams.ToList();
//             return Ok(data);
//         }

//         [HttpPut]
//         [Route("EditTeam"/{id})]
//         Public IActionResult PutTeam(int id,Team t) {
//             try{
//                 if(ModelState.IsValid){
//                     Team e = CollectionExtensions.Teams.Find(id);
//                     e.TeamName = t.TeamName;
//                     context.SaveChanges();
//                     return Ok();
//                 }
//             }
//             catch(System.Exception ex){
//                 return BadRequest(ex.Message);
//             }
//             return BadRequest("Unable to Editr Record");
//         }

//         [HttpDelete]
//         [Route("DeleteTeam")]
//         public IActionResult DeleteTeam(int id)
//         {
//             try
//             {
//                 var data = context.Teams.Find(id);
//                 context.Teams.Remove(data);
//                 context.SaveChanges();
//                 return Ok();
//             }
//             catch(System.Exception ex)
//             {
//                 return BadRequest(ex.Message);
 
//             }
//         }
 
//         [HttpPost]
//         [Route("AddTeam")]
//         public IActionResult PostTeam(Team t)
//         {
//             if(ModelState.IsValid)
//             {
//                 try{
//                     context.Teams.Add(t);
//                     context.SaveChanges();
//                 }
//                 catch(SystemException ex)
//                 {
//                     return BadRequest(ex.InnerException.Message);
//                 }
//             }
 
//             return Created("Record Added", t); //
//         }
//     }
// }



        






// //         [HttpGet]
 
// //         [Route("ListTeam")]
// //         public IActionResult GetPlayers()
// //         {
// //             var data=from m in context.Teams select m;
// //             return Ok(data);
// //         }
 
// //         [HttpGet]
 
// //         [Route("ListTeam/{id}")]
// //         public IActionResult Get(int id)
// //         {
// //             // var data=context.Teams.ToList();
// //             if(id==null)
// //             {
// //                 return BadRequest("Id cannot be null");
// //             }
// //             var data=(from m in context.Teams where m.TeamId==id select m).FirstOrDefault();
// //             // var data=context.Teams.Find(id);
// //             if(data==null)
// //             {
// //                 return NotFound($"Movie {id} not found");
// //             }
// //             return Ok(data);
           
// //         }
// //         [HttpPost]
// //         [Route("AddTeam")]
// //         public IActionResult Post(Team Team)
// //         {
// //             if(ModelState.IsValid)
// //             {
// //                 try{
// //                     context.Teams.Add(Team);
// //                     context.SaveChanges();
 
// //                 }
// //                 catch(System.Exception ex){
// //                     return BadRequest(ex.InnerException.Message);
 
// //                 }
// //             }
// //             return Created("Record Added",Team);
 
// //         }
// //         [HttpPut]
// //         [Route("EditTeam/{id}")]
// //         public IActionResult Put(int id, Team Team)
// //         {
// //             if(ModelState.IsValid)
// //             {
// //                 Team mv = context.Teams.Find(id);
// //                 mv.TeamName = Team.TeamName;
// //                 context.SaveChanges();
// //                 return Ok();
               
 
 
 
// //             }
// //             return BadRequest("Unable to Edit Record");
// //         }
// //         [HttpDelete]
// //         [Route("DeleteTeam/{id}")]
// //         public IActionResult Delete(int id)
// //         {
 
// //                 var data=context.Teams.Find(id);
// //                 context.Teams.Remove(data);
// //                 context.SaveChanges();
// //                 return Ok();
 
           
// //         }
 
// //     }
// // }




using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnetapp.Models;
 
namespace dotnetapp.Controllers
{
 
   
    [ApiController]
    [Route("/[controller]")]
    public class AdminController : ControllerBase
    {
        private readonly ApplicationDbContext context;
  
 
        public AdminController(ApplicationDbContext _context)
        {
            context = _context;
        }
 
        [HttpGet]
        [Route("GetPlayer")]
 
        public IActionResult GetPlayers()
        {
            var data=context.Players.ToList();
            return Ok(data);
        }
 
         [HttpGet]
        [Route("GetPlayer/{id}")]
        public IActionResult GetPlayersbyid(int id){
             
             var data=context.Players.Find(id);
             if(data!=null)
             {
                return Ok(data);
             }
             return BadRequest();
 
        }
 
 
       
 
        [HttpPut]
        [Route("EditPlayer/{id}")]
        public IActionResult PutPlayer(int id, Player player)
        {
            try
            {
 
            if(ModelState.IsValid)
            {
                Player p = new Player{};
                Player e = context.Players.Find(id);
                e.Name = player.Name;
                e.Age = player.Age;
                e.Category = player.Category;
                e.BiddingPrice = player.BiddingPrice;
                context.SaveChanges();
                return Ok();
            }
            }
            catch(System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
 
            return BadRequest("Unable to Edit Record");
        }
 
        [HttpDelete]
        [Route("DeletePlayer/{id}")]
        public IActionResult DeletePlayer(int id)
        {
            try
            {
                var data = context.Players.Find(id);
                context.Players.Remove(data);
                context.SaveChanges();
                return Ok();
            }
            catch(System.Exception ex)
            {
                return BadRequest(ex.Message);
 
            }
        }
 
        [HttpPost]
        [Route("AddPlayer")]
        public IActionResult Post(Player p)
        {
            if(ModelState.IsValid)
            {
                try{
                    context.Players.Add(p);
                    context.SaveChanges();
                }
                catch(SystemException ex)
                {
                    return BadRequest(ex.InnerException.Message);
                }
            }
 
            return Created("Record Added", p); //
        }
       
       
        ///////////////////////////////////////////////////////////////////////////
 
        [HttpGet]
        [Route("GetTeams")]
        public IActionResult GetTeams(int id)
        {
            var data=context.Teams.ToList();
            return Ok(data);  
        }
 
        [HttpPut]
        [Route("EditTeam")]
        public IActionResult PutTeam(int id, Team t)
        {
            try
            {
 
            if(ModelState.IsValid)
            {
                // Team t = new Team{};
                Team e = context.Teams.Find(id);
                e.TeamName = t.TeamName;
                context.SaveChanges();
                return Ok();
            }
            }
            catch(System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
 
            return BadRequest("Unable to Edit Record");
        }
 
 
        [HttpDelete]
        [Route("DeleteTeam")]
        public IActionResult DeleteTeam(int id)
        {
            try
            {
                var data = context.Teams.Find(id);
                context.Teams.Remove(data);
                context.SaveChanges();
                return Ok();
            }
            catch(System.Exception ex)
            {
                return BadRequest(ex.Message);
 
            }
        }
 
        [HttpPost]
        [Route("AddTeam")]
        public IActionResult PostTeam(Team t)
        {
            if(ModelState.IsValid)
            {
                try{
                    context.Teams.Add(t);
                    context.SaveChanges();
                }
                catch(SystemException ex)
                {
                    return BadRequest(ex.InnerException.Message);
                }
            }
 
            return Created("Record Added", t); //
        }
 
    }
 
 
}