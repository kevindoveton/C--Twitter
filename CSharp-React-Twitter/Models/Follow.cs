using System;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace CSharpReactTwitter.Models {
	public class Follow {
		public Follow() { }
  
    public int FollowingId { get; set; }
		public int FollowerId { get; set; }


		//public int Id { get; set; }
    
		[ForeignKey(nameof(FollowerId))]
		public User Follower { get; set; }
  
		[ForeignKey(nameof(FollowingId))]
		public User Following { get; set;}
	}
}
