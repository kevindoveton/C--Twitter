using System;
using System.Collections.Generic;

namespace CSharpReactTwitter.Models {
  public abstract class DB {
    public DB() {
    }

    public abstract User GetUserById(int id);
    public abstract List<Tweet> GetNewsfeedForUser(int id);
    public abstract Tweet GetTweetById(int id);
		public abstract List<Tweet> GetTweetsByUserId(int id);
  }
}
