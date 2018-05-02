using System;
namespace CSharpReactTwitter.Models {
  public abstract class DB {
    public DB() {
    }

    public abstract User GetUserById(int id);
  }
}
