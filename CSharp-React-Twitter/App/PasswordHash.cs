using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace CSharpReactTwitter.App
{
    public class PasswordHash
    {
    public static string EncodePassword(string password, byte[] salt) {
      string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA1,
            iterationCount: 10000,
            numBytesRequested: 256 / 8));
      return hashed;
    }

    public static bool Verify(string password, string hash, byte[] salt) {
      return EncodePassword(password, salt) == hash;
    }

    public static byte[] GenerateSalt() {
      byte[] salt = new byte[2048 / 8];
      using (var rng = RandomNumberGenerator.Create()) {
        rng.GetBytes(salt);
      }
      return salt;
    }
  }
}
