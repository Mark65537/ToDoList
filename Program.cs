﻿/*Не думаю что помещать все решение в один проект это плохо*/
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace ToDoList21
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
