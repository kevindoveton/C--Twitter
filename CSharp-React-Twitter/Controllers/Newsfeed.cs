using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CSharpReactTwitter.Models;
namespace CSharpReactTwitter.Controllers {
  [Route("api/[controller]")]
  public class Newsfeed : Controller {
    private DB db = new MockDatabase();

    // GET api/values
    [HttpGet]
    public string Get() {
      return JsonConvert.SerializeObject(db.GetNewsfeedForUser(0));
    }
  }
}
