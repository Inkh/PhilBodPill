using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PhilBodPill.Data;
using PhilBodPill.Models;
using PhilBodPill.Models.Interfaces;
using PhilBodPill.Models.Services;
using PhilBodPill.Models.Handlers;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace PhilBodPill
{
    public class Startup
    {
        private IConfiguration Configuration { get; set; }

        public Startup()
        {
            var builder = new ConfigurationBuilder().AddEnvironmentVariables();
            builder.AddUserSecrets<Startup>();
            Configuration = builder.Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<UserDbContext>()
                .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = "/User/AccessDenied";
                options.LoginPath = "/User/Login";
            });

            services.AddDbContext<UserDbContext>(options =>
            //options.UseSqlServer(Configuration["ConnectionStrings:IdentityConnection"])
            options.UseSqlServer(Configuration["ConnectionStrings:IdentityConnection"])
            );

            services.AddDbContext<PhilBodPillDbContext>(options =>
            //options.UseSqlServer(Configuration["ConnectionStrings:ProductionDb"])
            options.UseSqlServer(Configuration["ConnectionStrings:ProductionDB"])
            );

            services.AddAuthorization(options =>
            {
                options.AddPolicy("NoChetsAllowed", policy => policy.Requirements.Add(new ForbiddenNameRequirement("Chet")));
                options.AddPolicy("AdminOnly", policy => policy.RequireRole(UserRoles.Admin));
            });

            services.AddScoped<IInventory, ProductService>();
            services.AddScoped<IBasket, BasketService>();
            services.AddScoped<IEmailSender, EmailSenderService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "default",
                template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
