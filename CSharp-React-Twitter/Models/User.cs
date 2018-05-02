using System;
namespace CSharpReactTwitter.Models {
  public class User {
    private string _username;
    private int _id;

    public User(string username, int id) {
      SetUsername(username);
      SetId(id);
    }

    public void SetUsername(string username) { _username = username; }
    public string GetUsername() { return _username; }
    public void SetId(int id) { _id = id; }
    public int GetId() { return _id; }
  }
}
