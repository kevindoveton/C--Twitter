using System;
namespace CSharpReactTwitter.Models {
  public class User {
    public string username { get; set; }
    public int id { get; set; }
    public string name { get; set; }
		public int followers { get; set; }
		public int following { get; set; }
		public int tweets { get; set; }
  }
}
