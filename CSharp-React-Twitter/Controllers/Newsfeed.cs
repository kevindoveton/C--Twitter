﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CSharpReactTwitter.Models;
namespace CSharpReactTwitter.Controllers {
  [Route("api/[controller]")]
  public class Newsfeed : Controller {

    // GET api/values
    [HttpGet]
    public string Get() {
      User kevin = new User { username = "kevin", id = 0, name="Kevin Doveton" };

      string json = JsonConvert.SerializeObject(
        new List<CSharpReactTwitter.Models.Tweet>() {
          new Tweet { user = kevin, dateTime = DateTime.Now, text = "hello, world!", id=0 },
          new Tweet { user = new User { username="amelia", id= 3, name="Amelia Parsons" }, dateTime = DateTime.Parse("05/02/2018 15:50:31"), text = "this is a longer tweet!", id=1 }
        }
      );
      return json;
    }

    // GET api/values/5
    [HttpGet("{id}")]
    public string Get(int id) {
      return "value";
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
