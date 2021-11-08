using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetsecrettest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var APIKey = "ENbgIgbWFXyoV0bwxsDCNmL9+rUxNY5U9dTRUaXChQSOpTuKTXa12dNhwP8gH/sQZ9GgUT2qV71H3CwqsWPMGw=="; ;
            var APIKey2 = "ENbgIgbWFXyoV0bwxsDCNmL9+rUxNY5U9dTRUaXChQSOpTuKTXa12dNhwP8gH/sQZ9GgUT2qV71H3CwqsWPMGw==";


            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
