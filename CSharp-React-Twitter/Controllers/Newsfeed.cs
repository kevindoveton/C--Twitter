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

    [HttpGet("trending")]
    public IActionResult GetTrending() {
      var response = new[] {
        new {
          Heading = "NRLBroncosRoosters",
          Hashtag = true,
          SubHeading = "NRL players cops a falcon to the face"
        },
        new {
          Heading = "AFLCrowsDog",
          Hashtag = true,
          SubHeading = "2,870 Tweets"
        },
         new {
          Heading = "Prince Charles",
          Hashtag = false,
          SubHeading = "Meghan Markle asks Prince Charles to walk her down the aisle"
        },
        new {
          Heading = "DragRace",
          Hashtag = true,
          SubHeading = "18.7k Tweets"
        },
        new {
          Heading = "FridayMotivation",
          Hashtag = true,
          SubHeading = "4,811 Tweets"
        },
        new {
          Heading = "SydFilmFest",
          Hashtag = true,
          SubHeading = ""
        }
      };
      return Ok(response);
    }

    }
}
