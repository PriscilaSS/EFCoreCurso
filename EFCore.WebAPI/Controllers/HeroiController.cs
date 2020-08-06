using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.WebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroiController : ControllerBase
    {
        public static List<Heroi> Herois = new List<Heroi>();

        [HttpGet]
        public List<Heroi> ListaHerois()
        {
            return Herois;
        }

        [HttpPost]
        public void InsereHeroi(string nome)
        {
            if (!string.IsNullOrEmpty(nome)) 
            {
                //Herois.Add(new Heroi(nome));
                Heroi objHeroi = new Heroi();
                objHeroi.Nome = nome;
                Herois.Add(objHeroi);                
            }            
        }

        [HttpDelete]
        public void ExcluiHeroi(string nome)
        {
            Herois.RemoveAt(
                Herois.IndexOf(
                    Herois.First(h => h.Nome.Equals(nome))
                )
            );
        }
    }
}
