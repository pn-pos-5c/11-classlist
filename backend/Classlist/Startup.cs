using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Classlist.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ClasslistDb;

namespace Classlist
{
    public class Startup
    {
        private readonly string myAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ClasslistContext>(options => options.UseSqlite(Configuration.GetConnectionString("studentsDb")));

            services.AddScoped<StudentsService>();
            services.AddScoped<ClazzesService>();

            services.AddControllers();

            services.AddCors(options =>
            {
                options.AddPolicy(myAllowSpecificOrigins,
              x => x.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
            );
            });
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(myAllowSpecificOrigins);

            app.UseMvc();
        }
    }
}
