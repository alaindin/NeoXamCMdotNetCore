using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NeoXamFrontNetCore.Config;
using NeoXamFrontNetCore.Serivces;

namespace NeoXamFrontNetCore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {


            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDistributedMemoryCache();
            services.AddMvc().AddSessionStateTempDataProvider();
            services.AddSession(options =>
            {
                options.Cookie.Name = "TanvirArjel.Session";
                options.IdleTimeout = TimeSpan.FromDays(1);
            });
            services.AddSingleton<ApiClientFactory>();

            services.AddTransient<DepartementService>();
            services.AddTransient<RiskService>();
            services.AddTransient<EmployeeService>();
            services.AddTransient<ActionService>();
            services.AddTransient<EvaluationService>();
            services.AddTransient<UserService>();
            services.AddTransient<DiplomaService>();
            services.AddTransient<ExperienceService>();
            services.AddTransient<TrainingService>();
            services.AddTransient<LanguageService>();
            services.AddTransient<ProjectService>();



          
         //   services.AddMvc().AddSessionStateTempDataProvider();
     
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
         
            app.UseSession();
            
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=User}/{action=Login}/{id?}");
            });
        }
    }
}
