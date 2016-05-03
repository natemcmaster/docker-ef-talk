using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace PortableWebApp
{
    public class Startup
    {
        private IConfiguration _config;
        public Startup(IHostingEnvironment env)
        {
            _config = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("config.json")
                .AddEnvironmentVariables()
                .Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging();
            services.AddMvc();

            services.AddDbContext<StoreContext>(
                o => o.UseNpgsql(_config["Npgsql:ConnectionString"]));
        }

        public void Configure(IApplicationBuilder app,
                DbContextOptions<StoreContext> options,
                ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(LogLevel.Information);

            app.UseMvcWithDefaultRoute();
            
            InitializeDatabase(options, loggerFactory.CreateLogger("InitializeDatabase"));
        }

        private void InitializeDatabase(DbContextOptions<StoreContext> options, ILogger logger)
        {
            using (var db = new StoreContext(options))
            {
                db.Database.Migrate();

                if (db.Customers.Count() == 0)
                {
                    db.AddRange(SeedData.CreateCustomers());
                    var changes = db.SaveChanges();
                    
                    logger.LogInformation($"Added {changes} new customers to database");
                }
                else
                {
                    logger.LogInformation("Database already has data. Skipping seeding");
                }
            }
        }
    }
}