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
<<<<<<< HEAD
    public async Task<IActionResult> Get() {

      // get the following
			var following = await _context.Follows
										  .Where(x => x.FollowerId == 5)
			                              .Select(x => x.FollowingId)
										  .ToArrayAsync();   

      // get all tweets from following
			var tweets = await _context.Tweets
									   .Where(x => following.Contains(x.UserId))
									   .ToArrayAsync();

			var response = tweets.Select(x => x);

      return Ok(response);
=======
    public string Get() {
			return JsonConvert.SerializeObject(new {
        tweets = db.GetNewsfeedForUser(0),
        user = db.GetUserById(0)
      });
>>>>>>> master
    }
    
  }
}
