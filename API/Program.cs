using Microsoft.EntityFrameworkCore;
using Persistence;
using Application;
using Application.Core;
using API.Extensions;
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddApplicationServices(builder.Configuration);
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseCors("CorsPolicy");
app.UseAuthorization();
app.MapControllers();
using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
try
{
    System.Console.WriteLine("doing");
    var context = services.GetRequiredService<DataContext>();
    await context.Database.EnsureDeletedAsync();
    // Create a new database and apply migrations
    await context.Database.MigrateAsync();
    //context.Database.EnsureCreated();
    System.Console.WriteLine("before seed data");
    await Seed.SeedData(context);
}
catch (Exception ex)
{
    var logger = services.GetRequiredService<ILogger<Program>>();
    logger.LogError(ex, "an error  occurred during migration");
}
app.Run();
