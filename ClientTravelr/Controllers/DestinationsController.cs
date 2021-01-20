using ClientTravelr.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ClientTravelr.Controllers
{
    public class DestinationsController: Controller
    {
      public IActionResult Index()
      {
        var allDestinations = Destination.GetDestinations();
        return View(allDestinations);
      }

      public IActionResult Details(int id)
      {
        var thisDestination = Destination.GetDetails(id);
        return View(thisDestination);
      }
    }
}