using AutoMapper;
using FlowTask.Repositories;
using FlowTask.Services;

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
            services.AddScoped<ISectionRepository, SectionRepository>();
            services.AddScoped<ISectionRepository, SectionRepository>();
            services.AddScoped<ISectionRepository, SectionRepository>();

        }
    }
}
