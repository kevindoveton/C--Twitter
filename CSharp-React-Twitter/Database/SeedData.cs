using System;
//using CSharpReactTwitter;

namespace CSharpReactTwitter.Database {
  public class SeedData {

    public static void AddTestData(ApiContext context) {
      AddUsers(context);
      AddTweets(context);
    }

    private static void AddUsers(ApiContext context) {
			context.Users.Add(new Models.User { Handle = "amelia", Id = 1, Name = "Amelia Parsons" });
      context.Users.Add(new Models.User { Handle = "mark", Id = 2, Name = "MarkyD" });
      context.Users.Add(new Models.User { Handle = "bazz223", Id = 3, Name = "Trent Barry" });
			context.Users.Add(new Models.User { Handle = "appel", Id = 4, Name = "Appel Corporation" });
      context.Users.Add(new Models.User { Handle = "kevin", Id = 5, Name = "Kevin Doveton" });
      context.Users.Add(new Models.User { Handle = "zuky", Id = 6, Name = "Merk Zuck" });
      context.Users.Add(new Models.User { Handle = "macroseft", Id = 7, Name = "macroseft" });


      // following amelia - 1
      context.Follows.Add(new Models.Follow { FollowingId = 1, FollowerId = 5 });
      context.Follows.Add(new Models.Follow { FollowingId = 1, FollowerId = 2 });
      
      // following mark - 2
      context.Follows.Add(new Models.Follow { FollowingId = 2, FollowerId = 5 });
      context.Follows.Add(new Models.Follow { FollowingId = 2, FollowerId = 1 });

      // following bazz223 - 3
      context.Follows.Add(new Models.Follow { FollowingId = 3, FollowerId = 1 });
      context.Follows.Add(new Models.Follow { FollowingId = 3, FollowerId = 7 });

      // following appel - 4
      context.Follows.Add(new Models.Follow { FollowingId = 4, FollowerId = 1 });
      context.Follows.Add(new Models.Follow { FollowingId = 4, FollowerId = 2 });
      context.Follows.Add(new Models.Follow { FollowingId = 4, FollowerId = 3 });
      context.Follows.Add(new Models.Follow { FollowingId = 4, FollowerId = 5 });

      // following kevin - 5
      context.Follows.Add(new Models.Follow { FollowingId = 5, FollowerId = 4 });
      context.Follows.Add(new Models.Follow { FollowingId = 5, FollowerId = 2 });
      context.Follows.Add(new Models.Follow { FollowingId = 5, FollowerId = 1 });
      context.Follows.Add(new Models.Follow { FollowingId = 5, FollowerId = 6 });
      context.Follows.Add(new Models.Follow { FollowingId = 5, FollowerId = 7 });

      // following zuky - 6
      context.Follows.Add(new Models.Follow { FollowingId = 6, FollowerId = 7 });
      context.Follows.Add(new Models.Follow { FollowingId = 6, FollowerId = 2 });
      context.Follows.Add(new Models.Follow { FollowingId = 6, FollowerId = 3 });

      // following macroseft - 7
      context.Follows.Add(new Models.Follow { FollowingId = 7, FollowerId = 2 });
      context.Follows.Add(new Models.Follow { FollowingId = 7, FollowerId = 3 });
      context.Follows.Add(new Models.Follow { FollowingId = 7, FollowerId = 5 });
      context.Follows.Add(new Models.Follow { FollowingId = 7, FollowerId = 6 });
      
      context.SaveChanges();
    }

    private static void AddTweets(ApiContext context) {
      context.Tweets.Add(new Models.Tweet {
        UserId = 5,
        DateTime = DateTime.Now,
        Text = "hello, world!",
        Id = 7
      });
      context.Tweets.Add(new Models.Tweet {
        UserId = 1,
        DateTime = DateTime.Parse("05/02/2018 15:50:31"),
        Text = "hello, world!",
        Id = 1
      });
      context.Tweets.Add(new Models.Tweet {
        UserId = 4,
        DateTime = DateTime.Parse("02/02/2018 18:20:31"),
        Text = "We have not been defeated!",
        Id = 6
      });
      context.Tweets.Add(new Models.Tweet {
        UserId = 3,
        DateTime = DateTime.Parse("05/02/2018 5:50:31"),
        Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
          "Morbi sed elementum erat, eget placerat odio. Donec viverra " +
          "placerat placerat. A Do",
        Id = 2
      });
      context.Tweets.Add(new Models.Tweet {
        UserId = 2,
        DateTime = DateTime.Parse("04/02/2018 18:50:31"),
        Text = "Quisque tristique a odio at maximus.Ut ultricies mattis " +
          "justo, id commodo ante dictum vitae",
        Id = 3
      });
      context.Tweets.Add(new Models.Tweet {
        UserId = 4,
        DateTime = DateTime.Parse("02/02/2018 18:20:31"),
        Text = "We have been defeated!",
        Id = 4
      });
      context.Tweets.Add(new Models.Tweet {
        UserId = 5,
        DateTime = DateTime.Parse("02/02/2018 18:20:31"),
        Text = "Appel is down!",
        Id = 5
      });
      context.SaveChanges();
    }

  }
}
