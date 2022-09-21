using Microsoft.EntityFrameworkCore;
using TesteApi.DomainService.IServices;
using TesteApi.Interfaces;
using TesteApi.Repository.Context;
using TesteApi.Service.Services;
using TesteApi.Servicos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IOcorrencia, OcorrenciaToJson>();
builder.Services.AddTransient<IIndicador, IndicadorToJson>();
builder.Services.AddTransient<ICredor, CredorToJson>();
builder.Services.AddTransient<ICredorService, CredorCService>();
builder.Services.AddTransient<IIndicadorService, IndicadorBService>();
builder.Services.AddTransient<IOcorrenciaService, Ocorrencia05Service>();
builder.Services.AddDbContext<ApliccationDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("LogYamaha")));
//builder.Services.AddDbContext<ApliccationDbContext>();
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
