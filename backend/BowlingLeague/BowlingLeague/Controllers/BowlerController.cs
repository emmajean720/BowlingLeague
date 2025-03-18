using BowlingLeague.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BowlingLeague.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BowlerController : ControllerBase
    {
        private readonly BowlerRepository _repository;

        public BowlerController(BowlerRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var bowlers = _repository.GetBowlersForMarlinsAndSharks();
            return Ok(bowlers); // Return filtered bowlers
        }
    }
}

