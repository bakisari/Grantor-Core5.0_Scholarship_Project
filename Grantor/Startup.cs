using BussinesLayer.ValidationRules;
using DataAcessLayer.Concrete;
using FluentValidation.AspNetCore;
using Grantor.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grantor
{
    public class Startup
    {


        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews().AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<Startup>());
            services.AddIdentity<AppUser, AppRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 8;
                opts.Password.RequireNonAlphanumeric = true;
                opts.Password.RequireLowercase = true;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = true;
            }).AddErrorDescriber<CustomIdentityErrorDescriber>().AddEntityFrameworkStores<Context>().AddDefaultTokenProviders();
            services.AddDbContext<Context>();
            services.AddSession();
            services.AddMvc();
            services.AddAuthentication(
             CookieAuthenticationDefaults.AuthenticationScheme)
             .AddCookie(x =>
             {
                 x.LoginPath = "/Login/Index";
             }
             );
            CookieBuilder cookieBuilder = new CookieBuilder();
            cookieBuilder.Name = "GrantorCookie";
            cookieBuilder.HttpOnly = false;
            cookieBuilder.SameSite = SameSiteMode.Lax;
            cookieBuilder.SecurePolicy = CookieSecurePolicy.SameAsRequest;

            IServiceCollection serviceCollection = services.ConfigureApplicationCookie(opts=>
            {
                
                opts.LoginPath = new PathString("/Login/LogIn");
                opts.LogoutPath = new PathString("/Login/LogOut");
                opts.AccessDeniedPath = new PathString("/Admin/AdminLogin/LogIn");
                opts.Cookie = cookieBuilder;
                opts.SlidingExpiration = true;
                opts.ExpireTimeSpan = System.TimeSpan.FromDays(60);
            });
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseCookiePolicy();
         
           
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
