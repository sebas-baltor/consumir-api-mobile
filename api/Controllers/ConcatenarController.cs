using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mobile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConcatenarController : ControllerBase
    {
        // GET: api/<ConcatenarController>
        [HttpGet]
        public string Get(string concatenacion)
        {
            return $"concatenaste {concatenacion}";
        }

        // GET api/<ConcatenarController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ConcatenarController>
        [HttpPost]
        public string Post([FromBody] string value)
        {
            return $"Acabas de consumir la api y concatenaste: {value}";
        }

        // PUT api/<ConcatenarController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ConcatenarController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
