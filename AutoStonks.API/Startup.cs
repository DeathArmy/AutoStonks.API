using AutoMapper;
using AutoStonks.API.Services.AdvertEquipmentService;
using AutoStonks.API.Services.AdvertService;
using AutoStonks.API.Services.BrandService;
using AutoStonks.API.Services.EquipmentService;
using AutoStonks.API.Services.GenerationService;
using AutoStonks.API.Services.ModelService;
using AutoStonks.API.Services.PackageService;
using AutoStonks.API.Services.PaymentService;
using AutoStonks.API.Services.PhotoService;
using AutoStonks.API.Services.UserService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API
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
            services.AddControllers();
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IBrandService, BrandService>();
            services.AddScoped<IAdvertService, AdvertService>();
            services.AddScoped<IAdvertEquipmentService, AdvertEquipmentService>();
            services.AddScoped<IEquipmentService, EquipmentService>();
            services.AddScoped<IGenerationService, GenerationService>();
            services.AddScoped<IModelService, ModelService>();
            services.AddScoped<IPackageService, PackageService>();
            services.AddScoped<IPaymentService, PaymentService>();
            services.AddScoped<IPhotoService, PhotoService>();

            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("AutoStonksDb"));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
