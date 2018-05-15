using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CSharpReactTwitter.Database;

using CSharpReactTwitter.Models;
namespace CSharpReactTwitter.Controllers {
  [Route("api/[controller]")]
  public class NewsfeedController : Controller {

    private readonly ApiContext _context;

    public NewsfeedController(ApiContext context) {
      this._context = context;
    }
    
    // GET api/newsfeed/
    [HttpGet]
    public async Task<IActionResult> Get() {
      var users = await _context.Users.Include(u => u.Tweets).ToArrayAsync();
      var response = users.Select(u => new {
        u.Name,
        u.Handle,
        Tweets = u.Tweets.Select(t => t)
      });

      return Ok(response);
    }
    
  }
}
