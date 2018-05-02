using System;
namespace CSharpReactTwitter.Models {
  public class MockDatabase : DB {
    private User[] _users;

    public MockDatabase() {
    }

    public override User GetUserById(int id) {
      return new User("kevin", id);
    }
  }
}
