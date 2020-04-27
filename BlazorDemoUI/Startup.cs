using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BlazorDemoUI.Data;
using DataAccessLibrary;
using DataAccessLibrary.Bussiness_Logic;
using DataAccessLibrary.Bussiness_Logic.BooksLogic;
using BlazorDemoUI.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Blazored.SessionStorage;
using Syncfusion.Blazor;

namespace BlazorDemoUI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            services.AddTransient<ISqlDataAccess, SqlDataAccess>();
            services.AddTransient<IUserData, UserData>();
            services.AddTransient<IBookData, BookData>();
            services.AddTransient<IBooksBussinessLogic, BooksBussinessLogic>();
            services.AddTransient < ILocationData, LocationData>();
            services.AddScoped<IFileUpload, FileUpload>();
            services.AddSingleton<IBooksBuyService, BooksBuyService>();
            services.AddSingleton<IBooksCreateService, BooksCreateService>();
            services.AddSingleton<ISiteReviewData, SiteReviewData>();
            services.AddScoped<ILocationWeb, LocationWeb>();

            services.AddScoped<AuthenticationStateProvider,CustomAuthenticationStateProvider>();
            services.AddBlazoredSessionStorage();

            //Maps shit
            services.AddSyncfusionBlazor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
