using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CSharpReactTwitter.Models;
using System.Net;
namespace CSharpReactTwitter.Controllers {
  [Route("api/[controller]")]
  public class User : Controller {
  
    // GET api/values/5
    [HttpGet("{username}")]
    public string Get(string username) {
      Random rand = new Random(username.GetHashCode());
      string color = rand.Next()
                         .ToString("X")
                         .Substring(0, 6);

      using (WebClient client = new WebClient()) {
        client.DownloadFile("https://cdn.sstatic.net/Sites/stackoverflow/img/404.svg", "image.png");

        Console.Write("hello");
        return "Hello";
      }
    }

  }
}
