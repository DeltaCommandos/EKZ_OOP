using EKZ19.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace EKZ19.Controllers
{
    public class Manager : IManager
    {
        public string ChotoDelat()
        {
            return "Choto sdelano";
        }
        
    }
}
