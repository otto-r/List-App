using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using listBackend.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace listBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IDatabaseListService _databaseListService;

        public ValuesController(IDatabaseListService databaseListService)
        {
            _databaseListService = databaseListService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list = _databaseListService.FetchUserList();
            //var json = JsonConvert.SerializeObject(list);

            return  Ok(list);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
