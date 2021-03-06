﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.Swagger;
using WebApplication1.Models;
using WebApplication1.Repositories.Comm;
using WebApplication1.Repositories.Posts;
using WebApplication1.Repositories.Rating;
using WebApplication1.Services.Comm;
using WebApplication1.Services.Posts;
using WebApplication1.Services.Rating;

namespace WebApplication1
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Лабы",
                    Description = "Хозяин Резника",
                    Contact = new Contact
                    {
                        Name = "Reznik",
                        Email = "kuekewow@yandex.ru"
                    },
                });
            });

            services.AddDbContext<PostgressContext>();

            services.AddScoped<IPostRep, PostRep>();
            services.AddScoped<ICommRep, CommRep>();
            services.AddScoped<IRatingRep, RatingRep>();

            services.AddScoped<IRatingService, RatingService>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<ICommService, CommService>();
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
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });
            //app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
