using EKZ19.Interfaces;
using EKZ19.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EKZ19.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult Poster([FromBody] int choto)
        {
            if (choto == 1)
            {
                IManager manager = new Manager();
                return Ok(manager.ChotoDelat());
            }
            else
            {
                return Ok($"choto = {choto}");
            }
        }
    }
}
