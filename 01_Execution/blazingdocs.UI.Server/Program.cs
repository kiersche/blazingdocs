using blazingdocs.Repositories;
using blazingdocs.ApplicationServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using blazingdocs.Repositories.Files;
using System.IO;

namespace blazingdocs.UI.Server;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllersWithViews();
        builder.Services.AddRazorPages();
        builder.Services.AddRepositories(builder.Configuration.GetConnectionString("Blazingdocs"));
        builder.Services.AddApplicationServices();

        builder.Services.AddOptions<FileStorageConfiguration>()
            .Bind(builder.Configuration)
            .Validate(options => !string.IsNullOrWhiteSpace(options.StorageRootPath) &&
                                 Path.IsPathFullyQualified(options.StorageRootPath),
                      "StorageRootPath must be an absolute directory path.")
            .ValidateOnStart();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();

        app.UseRouting();


        app.MapRazorPages();
        app.MapControllers();
        app.MapFallbackToFile("client/index.html");

        app.Run();
    }
}
