using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelApi.Models;
using Microsoft.EntityFrameworkCore;


namespace TravelApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DestinationsController : ControllerBase
  {
    private TravelApiContext _db;

    public DestinationsController(TravelApiContext db)
    {
      _db = db;
    }

    // GET api/destinations
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
    [HttpPost]
    public void Post([FromBody] Destination destination)
    {
      _db.Destinations.Add(destination);
      _db.SaveChanges();
    }

    [HttpGet("{id}")]
    public ActionResult<Destination> Get(int id)
    {
      return _db.Destinations.FirstOrDefault(entry => entry.DestinationId == id);
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Destination destination)
    {
      destination.DestinationId = id;
      _db.Entry(destination).State=EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var destinationDeletion = _db.Destinations.FirstOrDefault(entry => entry.DestinationId == id);
      _db.Destinations.Remove(destinationDeletion);
      _db.SaveChanges();
    }
  }
}