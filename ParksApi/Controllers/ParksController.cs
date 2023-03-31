using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksApi.Models;
using System;

namespace ParksApiController.Controllers

{
  [Route("api/[controller]")]
  [ApiController]
  public class ParksController : ControllerBase
  {
    private readonly ParksApiContext _db;

    public ParksController(ParksApiContext db)
    {
      _db = db;
    }

    // Pagination Code:
    [HttpGet("page/{page}")]
    public async Task<ActionResult<List<Park>>> GetPages(int page, int pageSize = 4)
    {
        if (_db.Parks == null)
        return NotFound();

      int pageCount = _db.Parks.Count();

      var parks = await _db.Parks
        .Skip((page - 1) * pageSize)
        .Take(pageSize)
        .ToListAsync();

      var response = new ParkResponse
      {
        Parks = parks,
        //page number inside the url
        CurrentPage = page,
        //the amount of parks returned from the database
        Pages = pageCount,
        //amnt of items on the page
        PageSize = pageSize
      };
      return Ok(response);
    }
	
    [HttpGet]
    public async Task<List<Park>> Get( string name, string location, string review, int rating)
    {
      
      IQueryable<Park> query = _db.Parks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (location != null)
      {
        query = query.Where(entry => entry.Location == location);
      }

      if (review != null)
      {
        query = query.Where(entry => entry.Review == review);
      }

      if (rating >= 0)
      {
        query = query.Where(entry => entry.Rating >= rating);
      }

      return await query.ToListAsync();
    }

    //Get: api/Parks/1
    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      Park park = await _db.Parks.FindAsync(id);

      if (park == null)
      {
        return NotFound();
      }

      return Ok(park);
    }

    //POST api/parks
    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }

    //PUT: api/Parks/2
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }

      _db.Parks.Update(park);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }

    private bool ParkExists(int id)
    {
      return _db.Parks.Any(location => location.ParkId == id);
    }

    //DELETE: api/Parks/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      Park park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }

      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    // WIP: Random Park Endpoint
    [Route("api/[controller]/random")]
    [HttpGet("random/{id}")]
    public async Task<ActionResult<Park>> RandomPark(int id)
    {
      Park park = await _db.Parks.FindAsync(id);
      int randoPark =  park.Math.Random(id);

      int parkCount = Math.Ceiling(_db.Destinations.Count(id));

      return Ok(randoPark);
    }
  }
}