using Hangfire;
using Microsoft.Owin;
using Owin;
using System;

[assembly: OwinStartup(typeof(ConsoleApp1.Startup))]

namespace ConsoleApp1
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseErrorPage();

            GlobalConfiguration.Configuration.UseSqlServerStorage("Server=127.0.0.1;Database=hangfire;User Id=hangfire;Password=123456;");

            app.UseHangfireServer();
            app.UseHangfireDashboard("/hangfire");

            RecurringJob.AddOrUpdate(
    () => Console.WriteLine("Recurring!"),
    Cron.Minutely);
        }
    }
}
