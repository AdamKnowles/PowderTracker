using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PowderTracker.Data;
using PowderTracker.Models;

namespace PowderTracker.Controllers
{
    [Route("api/trails")]
    [ApiController]
    public class TrailsController : ControllerBase
    {
        private readonly MockPowderTrackerRepo _repository = new MockPowderTrackerRepo();
        [HttpGet]
        public ActionResult <IEnumerable<Trail>> GetAllTrails()
        {
            var trailItems = _repository.GetAppTrails();

            return Ok(trailItems);
        }

        [HttpGet("{id}")]
        public ActionResult <Trail> GetTrailById(int id)
        {
            var trailItem = _repository.GetTrailById(id);

            return Ok(trailItem);
        }
    }
}