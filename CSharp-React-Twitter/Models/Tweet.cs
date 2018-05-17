using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpReactTwitter.Models {
  public class Tweet {
    public string Text { get; set; }
    public DateTime DateTime { get; set; }
    public int Id { get; set; }
    public int UserId { get; set; }

		[ForeignKey(nameof(UserId))]
		public User User { get; set; }
  }
}
