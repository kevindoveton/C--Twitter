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
  public class TweetsController : Controller {
		private readonly ApiContext _context;

		public TweetsController(ApiContext context) {
      this._context = context;
    }

    // GET /api/tweets/
    [HttpGet("{id}")]
		public async Task<IActionResult> Get(int id) {
			var tweet = await _context.Tweets
									   .Where(x => x.Id == id)
									   .Include(x => x.User)
									   .FirstAsync();

			var response = new {
				tweet.Id,
				tweet.DateTime,
				tweet.Text,
        User = new {
					tweet.User.Name,
					tweet.User.Id,
					tweet.User.Handle,
        }
			};

      return Ok(response);
    }

    // POST /api/tweets/
    [HttpPost("")]
    public async Task<IActionResult> PostTweets(Tweet tweet) {
      // reset the user id explicitly
      // TODO: this should come from some sort of cookie
      tweet.UserId = 1;

      await _context.Tweets.AddAsync(tweet);
      await _context.SaveChangesAsync();
      return Ok();
    }

  }
}
