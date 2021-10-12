using Airline_NewshoreFly.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;



namespace Airline_NewshoreFly.Controllers
{
    public class FlightController : Controller
    {
        private AirlineEntities Data = new AirlineEntities();

        // GET: Flight
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Find(string origen, string destino, DateTime fechaLlegada)
        {
            var listFlights = (from m in Data.Flight
                               where m.DepartureStation == origen && m.ArrivalStation == destino && m.DepartureDate == fechaLlegada
                               select m).ToList();
            return Newtonsoft.Json.JsonConvert.SerializeObject(listFlights,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }
        
        public string ListarVuelos()
        {
            var vuelos = (from m in Data.Flight
                          select m).ToList();

            return Newtonsoft.Json.JsonConvert.SerializeObject(vuelos,
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
        }       
    }
}