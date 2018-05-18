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
      int currentUser = 5;
      // get the following
			var following = await _context.Follows
										  .Where(x => x.FollowerId == currentUser)
			                              .Select(x => x.FollowingId)
										  .ToArrayAsync();   

      // get all tweets from following
			var tweets = await _context.Tweets
									   .Where(x => following.Contains(x.UserId))
                     .Include(x => x.User)
									   .ToArrayAsync();

      var user = await _context.Users
        .Include(x => x.Followers)
        .Include(x => x.Following)
        .Include(x => x.Tweets)
        .Where(x => x.Id == currentUser)
        .FirstAsync();

      //var response = tweets.Select(x => x);
      var response = new {
        tweets = tweets.Select(x => new {
          x.Text,
          x.DateTime,
          x.Id,
          User = new {
            x.User.Id,
            x.User.Name,
            x.User.Handle
          }
        }),
        user = new {
          user.Id,
          user.Name,
          user.Handle,
          FollowerCount = user.Followers.Count(),
          FollowingCount = user.Following.Count(),
          TweetCount = user.Tweets.Count()
        }
      };

      return Ok(response);
    }
    
  }
}
