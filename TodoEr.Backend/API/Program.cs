using API.Requests.ToDo;
using BusinessLogic.Queries.ToDos;
using Data;
using Data.Repositories;
using FluentValidation;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddValidatorsFromAssemblyContaining<CreateToDoRequestValidator>();

builder.Services.AddDbContext<TodoErContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("Db")));
builder.Services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(GetAllTodos).Assembly));
builder.Services.AddScoped<ToDoRepository, ToDoRepository>();

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
