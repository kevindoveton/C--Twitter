using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using CSharpReactTwitter.Database;

namespace CSharpReactTwitter.Controllers {

  [Route("api/[controller]")]
	 public class UserController : ControllerBase {

		private readonly ApiContext _context;

    public UserController(ApiContext context) {
      this._context = context;
    }

		// GET /api/user/{handle}/img
		[HttpGet("{handle}/img")]
		public FileContentResult GetUserImage(string handle) {
			Random rand = new Random(handle.GetHashCode());
      string color = rand.Next()
                         .ToString("X")
                         .Substring(0, 6);   
      using (WebClient client = new WebClient()) {
				var dataBytes = client.DownloadData("https://placehold.it/100x100/" + color);
				return new FileContentResult(dataBytes, "image/png");
      }
		}

		// GET /api/user/{handle}/
		[HttpGet("{handle}")]  
		public async Task<IActionResult> GetHandle(string handle) {

			var u = await _context.Users
									  .Where(x => x.Handle == handle)
									  .Include(x => x.Followers)
									  .ThenInclude(x => x.Follower)
									  .Include(x => x.Following)
									  .ThenInclude(x => x.Following)
									  .Include(x => x.Tweets)
									 .FirstAsync();

      var response = new {
        User = new {
          u.Name,
          u.Handle,
          u.Id,
          FollowerCount = u.Followers.Count(),
          FollowingCount = u.Following.Count(),
          TweetCount = u.Tweets.Count(),
          Followers = u.Followers.Select(x => new {
            x.Follower.Name,
            x.Follower.Id,
            x.Follower.Handle
          }),
          Following = u.Following.Select(x => new {
            x.Following.Name,
            x.Following.Id,
            x.Following.Handle
          }),
        },
        Tweets = u.Tweets.Select(x => new {
          x.Id,
          x.Text,
          x.DateTime,
          User = new {
           x.User.Name,
           x.User.Id,
           x.User.Handle
          }
        })
			};

			return Ok(response);
		}

		// GET /api/user/{handle}/feed
		[HttpGet("{handle}/feed")]
		public async Task<IActionResult> GetUsersFeed(string handle) {
			var u = await _context.Users
                    .Where(x => x.Handle == handle)
                                .Include(x => x.Tweets)
                                .ThenInclude(x => x.User)
                                .FirstAsync();
      var response = u.Tweets.Select(x => new {
        x.Id,
        x.Text,
        x.DateTime,
        User = new {
          x.User.Name,
          x.User.Id,
          x.User.Handle
        }
      });
			return Ok(response);
    }

    // GET /api/user/{handle}/follow/{handle}
    [HttpPost("{handle}/follow")]
    public async Task<IActionResult> PostFollowUser(string handle, [FromBody] Models.User user) {
      var follower = await _context.Users.Where(x => x.Handle == handle).FirstAsync();

      if (user.Handle != null) {
        var following = await _context.Users.Where(x => x.Handle == user.Handle).FirstAsync();
        await _context.Follows.AddAsync(new Models.Follow { FollowerId = follower.Id, FollowingId = following.Id });
      } else if (user.Id != 0) {
        // i'm not sure about this, technically 0 is an invalid id and also the initial state of an int 
        // so in theory everything is okay still feels a little hacky
        // we could create an inherited class but that seems uneccessary
        var following = await _context.Users.Where(x => x.Id == user.Id).FirstAsync();
        await _context.Follows.AddAsync(new Models.Follow { FollowerId = follower.Id, FollowingId = following.Id });
      } else {
        return StatusCode(400, "No Id or Handle");
      }

      await _context.SaveChangesAsync();
      return Ok("Success");
    }
  }
}
