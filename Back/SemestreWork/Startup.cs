using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SemestreWork.Models;
using SemestreWork.Repository;

namespace SemestreWork
{
    public class Startup
    {
        public Startup(IConfiguration configuration)    
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddMvc().AddRazorPagesOptions(options =>
            {
                options.Conventions.AddPageRoute("/Home", "");
            });
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {

                options.IdleTimeout = TimeSpan.FromDays(1);
                options.Cookie.HttpOnly = false;
            });
            services.AddSingleton<IConfiguration>(Configuration);

            services.AddTransient<IDuActions1Repository, DuActions1Repository>();
            services.AddTransient<IPushkinoActionsRepository, PushkinoActionsRepository>();
            services.AddTransient<IMetaRepository, MetaRepository>();
            services.AddTransient<IRegisterRepository,RegisterRepository>();
            services.AddTransient<ICommentsRepository, CommentsRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IRegisterRepository registerRep)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();
          
            app.Use(async (context,next) =>
            {
                if (!context.Session.Keys.Contains("AuthReady"))
                    context.Session.Set("AuthReady","false");
                await next.Invoke();
            });
            app.Use(async (context, next) =>
            {
                string CookieId;
                string Email;
                if (context.Request.Cookies.ContainsKey("CookieId")
           &&
           context.Request.Cookies.ContainsKey("Email"))
                    if (context.Request.Cookies.TryGetValue("CookieId", out CookieId)
                &&
                context.Request.Cookies.TryGetValue("Email", out Email))
                {
                    var user = registerRep.GetUserByCookie(int.Parse(CookieId), Email);
                    if (!(user is null)) { 
                        context.Session.Set<RegisterModel>("AuthUser", user);
                        context.Session.Set("AuthReady", "true");
                    }
                }
    
                await next.Invoke();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
