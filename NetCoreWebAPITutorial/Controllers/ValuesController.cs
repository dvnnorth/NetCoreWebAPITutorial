using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreWebAPITutorial.Controllers
{
  // This Attribute syntax works because the class is called ValuesController
  // SO, [controller] is swapped with Values, so /api/values works
  [Route("api/[controller]")]
  public class ValuesController : ControllerBase
  {
    
    // GET: api/values
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
      // This is an array creation expression. The syntax with type[] { value, otherValue } will
      // create an array with the length equal to the number of values. Values must be of type 
      // the array is declared with (in above example, all values must be strings)
    }
    
    // GET api/values/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return $"value {id}";
      // string interpolation
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