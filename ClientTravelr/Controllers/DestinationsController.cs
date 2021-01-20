using ClientTravelr.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
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

      public IActionResult Create()
      {
        return View();
      }

      [HttpPost]
      public IActionResult Create(Destination destination)
      {
        Destination.Post(destination);
        var timer = Task.Delay(100); //DO NOT KEEP THIS HERE
        timer.Wait();
        return RedirectToAction("Index");
      }

      public IActionResult Edit(int id)
      {
        var thisDestination = Destination.GetDetails(id);
        return View(thisDestination);
      }

      [HttpPost]
      public IActionResult Edit(Destination destination)
      {
        Destination.Put(destination);
        return RedirectToAction("Details", new { id = destination.DestinationId });
      }

      [HttpPost]
      public IActionResult Delete(int id)
      {
        Destination.Delete(id);
        return RedirectToAction("Index");
      }
    }
}