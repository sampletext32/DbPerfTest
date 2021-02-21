using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DbPerfTest.Contexts;
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
        public string Index()
        {
            return "Alive";
        }

        [HttpGet]
        public IEnumerable<Country> SelectAll()
        {
            return _context.Countries.ToList();
        }

        [HttpGet]
        public IEnumerable<Country> SelectAllJoined()
        {
            return _context.Countries.Include(c => c.Cities).ToList();
        }

        [HttpGet]
        public Country SelectOne(int id)
        {
            return _context.Countries.Find(id);
        }

        [HttpGet]
        public Country SelectOneJoined(int id)
        {
            return _context.Countries.Include(c => c.Cities).First(t => t.Id == id);
        }

        [HttpPut]
        public void AddOne(Country country)
        {
            _context.Countries.Add(country);
            _context.SaveChanges();
        }

        [HttpPut]
        public void AddMany(IEnumerable<Country> countries)
        {
            _context.Countries.AddRange(countries);
            _context.SaveChanges();
        }
    }
}