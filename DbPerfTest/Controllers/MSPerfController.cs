using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbPerfTest.Contexts;
using DbPerfTest.Extensions;
using DbPerfTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DbPerfTest.Controllers
{
    [ApiController]
    [Route("[controller]/{action}")]
    public class MsPerfController : ControllerBase
    {
        private MSPerfTestContext _context;
        private readonly ILogger<MsPerfController> _logger;

        public MsPerfController(ILogger<MsPerfController> logger, MSPerfTestContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        [HttpGet]
        public ActionResult<string> Index()
        {
            return Ok("Alive");
        }

        [HttpGet]
        public ActionResult<IEnumerable<Country>> SelectAll()
        {
            _logger.LogInformation("SelectAll");
            return _context.Countries.ToList();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Country>> SelectAllJoined()
        {
            _logger.LogInformation("SelectAllJoined");
            return _context.Countries.Include(c => c.Cities).ToList();
        }

        [HttpGet]
        public ActionResult<Country> SelectOne(int id)
        {
            _logger.LogInformation("SelectOne");
            return _context.Countries.Find(id);
        }

        [HttpGet]
        public ActionResult<Country> SelectOneJoined(int id)
        {
            _logger.LogInformation("SelectOneJoined");
            return _context.Countries.Include(c => c.Cities).FirstOrDefault(t => t.Id == id);
        }

        [HttpPut]
        public ActionResult AddOne([FromBody] Country country)
        {
            _logger.LogInformation("AddOne");
            _context.Countries.Add(country);
            _context.SaveChanges();
            return Ok(country.Id);
        }

        [HttpPut]
        public ActionResult AddMany(IEnumerable<Country> countries)
        {
            _logger.LogInformation("AddMany");
            _context.Countries.AddRange(countries);
            _context.SaveChanges();
            return Ok();
        }
        
        [HttpGet]
        public ActionResult Clear()
        {
            _logger.LogInformation("Clear");
            _context.Cities.Clear();
            _context.Countries.Clear();
            _context.SaveChanges();
            return Ok();
        }
        
        
    }
}