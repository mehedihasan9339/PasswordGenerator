using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace PasswordGenerator
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Set up dependency injection
            var services = new ServiceCollection();
            ConfigureServices(services);

            // Build the service provider
            var serviceProvider = services.BuildServiceProvider();

            // Run the application
            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // Configure Entity Framework
            services.AddDbContext<databaseContext>(options =>
                options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PasswordGeneratorDb;Trusted_Connection=True;MultipleActiveResultSets=true")); // Use your actual connection string

            // Configure Identity
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<databaseContext>()
                .AddDefaultTokenProviders();

            // Add basic logging services
            services.AddLogging();

            // Register Form1
            services.AddTransient<Form1>();
        }
    }
}
