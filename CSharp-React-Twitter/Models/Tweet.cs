using System;
namespace CSharpReactTwitter.Models {
  public class Tweet {
    

    //public Tweet(String t, DateTime dt, User u) {
    //  text = t;
    //  dateTime = dt;
    //  user = u;
    //}

    public string text { get; set; }
    public DateTime dateTime { get; set; }
    public User user { get; set; }
  }
}
