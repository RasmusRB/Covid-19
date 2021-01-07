using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelLib.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CovidService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CovidRecordsController : ControllerBase
    {
        private static List<CovidRecord> liste = new List<CovidRecord>()
        {
            new CovidRecord{Id = 1, City = "Cph", Household = 2, Sick = 0, Tested = 2},
            new CovidRecord{Id = 2, City = "Taastrup", Household = 1, Sick = 1, Tested = 1},
            new CovidRecord{Id = 3, City = "Ballerup", Household = 3, Sick = 1, Tested = 3},
            new CovidRecord{Id = 4, City = "Roskilde", Household = 5, Sick = 1, Tested = 1},
            new CovidRecord{Id = 5, City = "Ishøj", Household = 2, Sick = 1, Tested = 2}
        };

        private static int _nextId = liste.Count + 1;

        // GET: api/<CovidRecordsController>
        [HttpGet]
        public IEnumerable<CovidRecord> GetAllRecords()
        {
            return liste;
        }

        // GET api/<CovidRecordsController>/5
        [HttpGet]
        [Route("{id}")]
        public CovidRecord GetById(int id)
        {
            return liste.Find(c => c.Id == id);
        }

        [HttpGet]
        [Route("findBy/{city}")]
        public IEnumerable<CovidRecord> GetRecordsByCity(string city)
        {
            return liste.FindAll(c => c.City.Contains(city));
        }

        // POST api/<CovidRecordsController>
        [HttpPost]
        public int AddRecord(CovidRecord record)
        {
            record.Id = _nextId++;
            liste.Add(record);
            return record.Id;
        }
    }
}
