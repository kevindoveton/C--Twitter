using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CSharpReactTwitter.Models {
  public class User {
    public string Handle { get; set; }
    public int Id { get; set; }
    public string Name { get; set; }
		public int Followers { get; set; }
		public int Following { get; set; }
    public List<Tweet> Tweets { get; set; }
  }
}
