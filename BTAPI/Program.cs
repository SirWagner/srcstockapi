using BTAPI.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<BTContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("BTConnection") ?? throw new InvalidOperationException("Connection string 'BTConnection' not found.")));


builder.Services.AddDbContext<StudentContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("BTConnection") ?? throw new InvalidOperationException("Connection string 'BTConnection' not found.")));

// Add services to the container.

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
