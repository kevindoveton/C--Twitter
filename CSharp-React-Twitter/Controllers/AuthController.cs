using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CSharpReactTwitter.Controllers {

  [Route("api/[controller]")]
  public class AuthController : Controller {
    
    [HttpPost("login")]
    public async Task<IActionResult> PostLogin(Models.User user) {
      return Ok();
    }
  }
}