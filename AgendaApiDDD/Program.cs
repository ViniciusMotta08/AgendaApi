using Microsoft.AspNetCore.Http;
using Agenda.Aplication.Interfaces;
using Agenda.Aplication.Repository;
using Agenda.Infra.Data;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddScoped<DbSession>();
builder.Services.AddScoped<IDbConnection>((d) => new SqlConnection(builder.Configuration.GetConnectionString("DevAgenda")));
builder.Services.AddTransient<IAgendaRepository, AgendaRepository>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
