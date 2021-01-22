using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Travelr.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Travelr.Services;
using Travelr.Entities;


namespace Travelr.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DestinationsController : ControllerBase
  {
    private TravelrContext _db;

    public DestinationsController(TravelrContext db)
    {
      _db = db;
    }

    // GET api/destinations
    [Authorize]
    [HttpGet]
    public ActionResult<IEnumerable<Destination>> Get(string CityName, string Country, int Rating)
    {
      var query = _db.Destinations.AsQueryable();

      if (CityName != null)
      {
        query = query.Where(entry => entry.CityName == CityName);
      }

      if (Country != null)
      {
        query = query.Where(entry => entry.Country == Country);
      }

      if (Rating != 0)
      {
        query = query.Where(entry => entry.Rating == Rating);
      }    

      return query.ToList();
    }

    // POST api/destinations
    [Authorize(Roles = Role.Admin)]
    [HttpPost]
    public void Post([FromBody] Destination destination)
    {
      _db.Destinations.Add(destination);
      _db.SaveChanges();
    }

    [Authorize]
    [HttpGet("{id}")]
    public ActionResult<Destination> Get(int id)
    {
      return _db.Destinations.FirstOrDefault(entry => entry.DestinationId == id);
    }

    [Authorize(Roles = Role.Admin)]
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Destination destination)
    {
      destination.DestinationId = id;
      _db.Entry(destination).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [Authorize(Roles = Role.Admin)]
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var destinationDeletion = _db.Destinations.FirstOrDefault(entry => entry.DestinationId == id);
      _db.Destinations.Remove(destinationDeletion);
      _db.SaveChanges();
    }
  }
}