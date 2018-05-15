using System;
namespace CSharpReactTwitter.Models {
  public class Tweet {
    public string Text { get; set; }
    public DateTime DateTime { get; set; }
    public int Id { get; set; }
    public int UserId { get; set; }
  }
}
