using Blazor.Aplicacion.Core.FilmServices.Configuration;
using Blazor.Aplicacion.Core.Operaciones.Base.Configuration;
using Blazor.Aplicacion.Core.Users.Base.Configuration;
using Blazor.Infraestructura.Datos.Persistencia.Base.Configuration;
using Blazor.Infraestructura.Transversal.GenericMethods.Cofiguration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Blazor.WebApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IHostEnvironment Environment { get; }
        public Startup(IHostEnvironment env)
        {
            Environment = env;
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", false, true)
                .AddJsonFile($"appsettings{env.EnvironmentName}.json", true, true)
                .AddEnvironmentVariables();
            //.EnableSubstitutions();
            Configuration = configurationBuilder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddControllers();
            var dbSettings = Configuration.GetSection("DbConnectionString").Get<string>();
            services.ConfigureFilmService(new DbSettings { ConnectionString = dbSettings });
            services.ConfigureFachadaUserService(new DbSettings { ConnectionString = dbSettings });
            services.ConfigureOperacionesService(new DbSettings { ConnectionString = dbSettings });
            services.ConfigureHttpClientService(new HttpClientSettings
            {
                Context = string.Empty,
                Hostname = "localhost",
                Port = 5000,
                ServiceProtocol = "http"
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapBlazorHub();
                //endpoints.MapFallbackToPage("/_Host");
                endpoints.MapControllers();
            });
        }
    }
}
