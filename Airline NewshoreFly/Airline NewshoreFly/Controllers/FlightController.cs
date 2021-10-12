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

        public ActionResult Find(string txtOrigen, string txtDestino, DateTime txtFechaLlegada)
        {
            var listFlights = (from m in Data.Flight
                               where m.DepartureStation==txtOrigen && m.ArrivalStation==txtDestino
                               select m.DepartureDate==txtFechaLlegada).ToList();
            if (listFlights == null)
            {
                return Content("No hay vuelos disponibles.");
            }
            else
            {
                return View(listFlights);
            }            
        }      
                               
    }
}