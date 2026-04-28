using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
using TaskManager.Adapters.Adapters.Task;
using TaskManager.Adapters.DI;
using TaskManager.Adapters.Persistence;
using TaskManager.Adapters.Security;
using TaskManager.API.Facades;
using TaskManager.Core.DI;
using TaskManager.Core.Ports.Persistence.Task;
using TaskManager.Core.Ports.Security;

namespace TaskManager.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "TaskManager",
                    Version = "v1",
                });


                //Facades
                builder.Services.AddScoped<TaskUseCaseFacade>();
                builder.Services.AddScoped<TaskCategoryUseCaseFacade>();
                builder.Services.AddScoped<UserUseCaseFacade>();

                builder.Services.AddCore();
                builder.Services.AddAdapters(builder.Configuration);
                builder.Services.AddHttpContextAccessor();

                //Autenticação JWT

                //Autorização
                builder.Services.AddAuthorization();

                var app = builder.Build();

                //pipeline HTTP
                if (app.Environment.IsDevelopment())
                {
                    app.UseSwagger();
                    app.UseSwaggerUI(c =>
                    {
                        c.SwaggerEndpoint("/swagger/v1/swagger.json", "E-Commerce API v1");
                    });
                }

                app.UseHttpsRedirection();

                app.UseAuthentication();
                app.UseAuthorization();

                app.MapControllers();

                app.Run();
            });
        }
    }
}
