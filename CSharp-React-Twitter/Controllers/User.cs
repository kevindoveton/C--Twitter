using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using CSharpReactTwitter.Models;
using System.IO;
using System.Net;
using System.Net.Http;

//using System.Web.Http;

namespace CSharpReactTwitter.Controllers {
  
	[Route("api/[controller]")]
	 public class User : ControllerBase {
		private DB db = new MockDatabase();

		// GET api/values/5
		[HttpGet("img/{username}")]
		public FileContentResult GetUserImage(string username) {
			Random rand = new Random(username.GetHashCode());
      string color = rand.Next()
                         .ToString("X")
                         .Substring(0, 6);   
      using (WebClient client = new WebClient()) {
				var dataBytes = client.DownloadData("https://placehold.it/100x100/" + color);
				return new FileContentResult(dataBytes, "image/png");
      }
		}

		[HttpGet("{userId}")]
		public String GetUsername(string userId) {
			int u = Convert.ToInt32(userId);
			return JsonConvert.SerializeObject(db.GetUserById(u));
		}

		// GET api/values
		[HttpGet("{id}/feed")]
    public string GetUsersFeed(int id) {
      return JsonConvert.SerializeObject(db.GetTweetsByUserId(id));
    }
	}
}
