using System;
namespace CSharpReactTwitter.Models {
  public class Tweet {
    public string text { get; set; }
    public DateTime dateTime { get; set; }
    public User user { get; set; }
    public int id { get; set; }
  }
}
