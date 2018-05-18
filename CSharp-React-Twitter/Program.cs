﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
namespace CSharpReactTwitter {
  public class Program {
    public static void Main(string[] args) {

      var host = BuildWebHost(args);

      using (var scope = host.Services.CreateScope()) {
        var services = scope.ServiceProvider;
        try {
          var context = services.GetRequiredService<Database.ApiContext>();
          Database.SeedData.AddTestData(context);
        } catch (Exception ex) {
          var logger = services.GetRequiredService<ILogger<Program>>();
          logger.LogError(ex, "An error occurred while migrating the database.");
        }
      }

      host.Run();
    }

    public static IWebHost BuildWebHost(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .Build();
  }
}
