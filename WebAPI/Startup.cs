using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Fructuoso.Template.Infra.Repository;
using Microsoft.EntityFrameworkCore;
using Fructuoso.Template.Domain.Core.Interfaces.Service;
using Fructuoso.Template.Domain.Services;
using Fructuoso.Template.Domain.Core.Interfaces.Repository;

namespace WebAPI
{
    public class Startup
    {
        private readonly IConfiguration _Configuration;

        public Startup(IConfiguration configuration)
        {
            _Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Fructuoso.Template", Version = "v1" });
            });
            #endregion

            #region DbContext
            services.AddDbContext<RepositoryContext>(options => options.UseInMemoryDatabase(databaseName: "FructuosoDB"));
            #endregion

            #region Dependency Injectionn
            services.AddTransient(typeof(IServiceCrud<,>), typeof(GenericServiceCrud<,>));
            services.AddTransient(typeof(IRepositoryCrud<,>), typeof(GenericRepositoryCrud<,>));
            #endregion

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            #region Swagger
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API");
            });
            #endregion

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
