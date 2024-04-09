using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Walks.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Walks.Controllers
{
    [Route("api/[controller]")]
    public class RegionsController : ControllerBase
    {

        private readonly WalksDbContext dbContext;

        public RegionsController(WalksDbContext dbContext)
        {
            this.dbContext = dbContext;       
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {

            //return new string[] { "value1", "value2" };

            var regions = dbContext.Regions.ToList();

            return Ok(regions);
        }

        // GET api/values/5
        [HttpGet("{id:Guid}")]
        public IActionResult Get(Guid id)
        {
            var region = dbContext.Regions.Find(id);

            return Ok(region);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

