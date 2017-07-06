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
            new Planets { id = 1, name = "Mercury", distance = "1221212" },
            new Planets { id = 2, name = "Venus", distance = "1123213213" },
            new Planets { id = 3, name = "Earth", distance = "45378923" },
            new Planets { id = 4, name = "Mars", distance = "24324324" },
            new Planets { id = 5, name = "Jupiter", distance = "1123213213" },
            new Planets { id = 6, name = "Saturn", distance = "45378923" },
            new Planets { id = 7, name = "Uranus", distance = "1221212" },
            new Planets { id = 8, name = "Neptune", distance = "1123213213" },
            new Planets { id = 9, name = "Pluto", distance = "45378923" },

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
