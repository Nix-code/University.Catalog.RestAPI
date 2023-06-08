
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;
using University.Catalog.Entities;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<DbContext, DBContext>();
builder.Services.AddSwaggerGen();
builder.Services.AddEntityFrameworkMySQL().AddDbContext<DBContext>(options => {
    options.UseMySQL(builder.Configuration.GetConnectionString("DefaultConnection"));
});

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
