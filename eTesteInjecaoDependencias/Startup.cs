using eTesteInjecaoDependencias.Services;
using eTesteInjecaoDependencias.Services.Contracts;
using eTesteInjecaoDependencias.Services.Operacoes;
using eTesteInjecaoDependencias.Services.Operacoes.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace eTesteInjecaoDependencias
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
            services.AddControllers();

            services.AddScoped<IAdicao, Adicao>();
            services.AddScoped<ISubtracao, Subtracao>();
            services.AddScoped<IMultiplicacao, Multiplicacao>();
            services.AddScoped<IDivisao, Divisao>();

            services.AddScoped<ICalculadora, Calculadora>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
