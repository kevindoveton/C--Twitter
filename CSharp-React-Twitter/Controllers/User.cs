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
		// GET api/values/5
		[HttpGet("{username}")]
		public FileContentResult Get(string username) {
			Random rand = new Random(username.GetHashCode());
      string color = rand.Next()
                         .ToString("X")
                         .Substring(0, 6);

      

      using (WebClient client = new WebClient()) {
				var dataBytes = client.DownloadData("https://placehold.it/100x100/" + color);
				return new FileContentResult(dataBytes, "image/png");
      }
		}
	}
}
