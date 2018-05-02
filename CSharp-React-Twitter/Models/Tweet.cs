using System;
namespace CSharpReactTwitter.Models {
  public class Tweet {
    private String _text;
    private DateTime _time;
    private User _user;

    public Tweet(String text, DateTime time, User user) {
      SetText(text);
      SetTime(time);
      SetUser(user);
    }

    public String GetText() { return _text; }
    public void SetText(String text) { _text = text; }
    public DateTime GetTime() { return _time; }
    public void SetTime(DateTime dt) { _time = dt; }
    public User GetUser() { return _user; }
    public void SetUser(User user) { _user = user; }
  }
}
