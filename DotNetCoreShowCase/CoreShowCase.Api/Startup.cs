using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreShowCase.Api.Entities;
using CoreShowCase.Api.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoreShowCase.Api
{
    public class Startup
    {
        private IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //EF Core InMemory Database
            //services.AddDbContext<CoreShowCaseContext>(o => o.UseInMemoryDatabase("BlogPosts"));

            var connectionString = Configuration["connectionStrings:coreShowCaseDBConnectionString"];
            services.AddDbContext<CoreShowCaseContext>(o => o.UseSqlServer(connectionString));

            services.AddMvc();

            services.AddScoped<ICSCRepository, CSCRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc();
        }
    }
}
