using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PlanetsAPI.Models;

namespace PlanetsAPI.Controllers
{
    public class PlanetsController : ApiController
    {
        Planets[] planets = new Planets[]
        {
            new Planets { id = 1, name = "Tomato Soup", distance = "1221212" },
            new Planets { id = 2, name = "Yo-yo", distance = "1123213213" },
            new Planets { id = 3, name = "Hammer", distance = "45378923" }
        };

        public IEnumerable<Planets> GetAllPlanets()
        {
            return planets;
        }

        public IHttpActionResult GetPlanet(int id)
        {
            var planet = planets.FirstOrDefault((p) => p.id == id);
            if (planet == null)
            {
                return NotFound();
            }
            return Ok(planet);
        }
    }
}
