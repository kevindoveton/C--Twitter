using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CSharpReactTwitter.Models;
namespace CSharpReactTwitter.Controllers {
  [Route("api/[controller]")]
  public class Tweets : Controller {
    private DB db = new MockDatabase();

    // GET api/values
    [HttpGet]
    public string Get() {
      return JsonConvert.SerializeObject(db.GetNewsfeedForUser(0));
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public string Get(int id) {
      return JsonConvert.SerializeObject(db.GetTweetById(id));;
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody]string value) {
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]string value) {
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id) {
    }
  }
}
