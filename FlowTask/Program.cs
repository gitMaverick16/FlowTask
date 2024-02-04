using FlowTask.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

ServiceConfig.AddServices(builder.Services, builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


//TODO
//diseñar bd completa(2/2)
//agregar configuraciones avanzadas de automapper y fluent validation(5/2)
//agregar identity(7/2)
//ejecutar migraciones(8/2)
//agregar ioptions pattern(8/2)
//agregar middleware(8/2)
//agregar unit test(9/2)
//agregar integration test(10/2)
//agregar jobs con hangfire(11/2)
//agregar signalR(11/2)
//agregar httpcleint factory(12/2)
//agregar polly(12/2)
//agregar rate limit(14/2)
//agregar redis(14/2)
//agregar healchecks(15/2)
//agregar rxdotnet(15/2)
//fines de febreo termino el frotend

//marzo - abril medio hago proyecto de microservicios solo back
//abril medio - mayo hago frontend
//junio azure
//julio mvc
//agosto azure
//septiembre con las entrevistas
//iis
//azure
