using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpReactTwitter.Models {
  public class User {
    public string Handle { get; set; }  
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Tweet> Tweets { get; set; }
  
		//[InverseProperty("FollowingId")]
		public ICollection<Follow> Followers { get; set; }  
		//[InverseProperty("FollowerId")]
		public ICollection<Follow> Following { get; set; }
  }
}
