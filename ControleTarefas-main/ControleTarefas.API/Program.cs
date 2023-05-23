using ControleTarefas.API.Data;
using ControleTarefas.API.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//adicionando as configurações do Banco de Dados
builder.Services.AddEntityFrameworkSqlServer()
    .AddDbContext<ControleTarefasDBContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("DataBase"))
    );

//IoC
builder.Services.AddScoped<IUsuarioRepositorio, UsuarioRepositorio>();



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
