using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.EntityFrameworkCore;
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

			var user = await _context.Users
									  .Where(u => u.Handle == handle)
									  .Include(x => x.Followers)
									  .ThenInclude(x => x.Follower)
									  .Include(x => x.Following)
									  .ThenInclude(x => x.Following)
									  .Include(x => x.Tweets)
									 .ToArrayAsync();

			var response = user.Select(u => new {
				u.Name,
				u.Handle,
				u.Id,
				FollowerCount = u.Followers.Count(),
				FollowingCount = u.Following.Count(),
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
				u.Tweets
			});

			return Ok(response);
		}

		// GET /api/user/{handle}/feed
		[HttpGet("{handle}/feed")]
		public async Task<IActionResult> GetUsersFeed(string handle) {
			var user = await _context.Users
                    .Where(u => u.Handle == handle)
                                .Include(x => x.Tweets)
                                .ToArrayAsync();

			var response = user.Select(u => new {
				u.Tweets
			});

			return Ok(response);
    }
	}
}
