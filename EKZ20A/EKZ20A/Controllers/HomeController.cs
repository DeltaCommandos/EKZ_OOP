using EKZ20A.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EKZ20A.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class PushController : Controller
    {
        [HttpGet] 
        public IActionResult Pusher()
        {
            Element[] element = new Element[3];
            element[0] = new Element { Id = 1, Name = "Bublik", Description = "Bolshoi" };
            element[1] = new Element { Id = 2, Name = "Pelmen", Description = "So smetanoi" };
            element[2] = new Element { Id = 3, Name = "Ogurec", Description = "Pupyrchaty" };
            return Ok(element);
        }

    }
}
