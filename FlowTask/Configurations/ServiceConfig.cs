using AutoMapper;
using FlowTask.Context;
using FlowTask.Repositories;
using FlowTask.Services;
using Microsoft.EntityFrameworkCore;

namespace FlowTask.Configurations
{
    public static class ServiceConfig
    {
        public static void AddServices(IServiceCollection services, IConfiguration configuration)
        {
            //Services
            services.AddScoped<IBoardService, BoardService>();
            services.AddScoped<ICardService, CardService>();
            services.AddScoped<ISectionService, SectionService>();

            //Repositories
            services.AddScoped<IBoardRepository, BoardRepository>();
            services.AddScoped<ICardRepository, CardRepository>();
            services.AddScoped<ISectionRepository, SectionRepository>();

            //Database
            services.AddDbContext<FlowTaskContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("FlowTaskConnection"));
            });

        }
    }
}
