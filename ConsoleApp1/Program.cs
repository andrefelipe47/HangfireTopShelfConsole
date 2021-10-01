using Microsoft.Owin.Hosting;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (WebApp.Start<Startup>("http://localhost:8888"))
            {
                Console.WriteLine("Server started... press ENTER to shut down");
                Console.ReadLine();
            }
        }
    }
}
