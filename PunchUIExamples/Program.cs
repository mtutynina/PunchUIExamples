// -----------------------------------------------------------------------
// <copyright file="Program.cs" company="Mariya Tutynina">
// Copyright (c) Mariya Tutynina. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace PunchUIExamples
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Hosting;

    /// <summary>
    /// Entry point for the application.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Entry point for the application.
        /// </summary>
        /// <param name="args">Arguments passed to command line.</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Creates web host builder.
        /// </summary>
        /// <param name="args">Arguments passed from command line.</param>
        /// <returns>A <see cref="IWebHostBuilder"/> which could be used for building webserver.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
