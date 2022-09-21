using FluentValidation.AspNetCore;
using Prison.Web.Extensions;
using Stoelendans.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.RegisterApiVersioning();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.RegisterSwagger();
builder.Services.RegisterMediatR();
//builder.Services.RegisterApplication();
builder.Services.ConfigureDataServices(builder.Configuration);
builder.Services.RegisterDependencies();
builder.Services.AddMvc().AddFluentValidation(fv => fv.DisableDataAnnotationsValidation = false);


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