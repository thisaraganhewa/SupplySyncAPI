
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SupplySync.Infrastructure.Configuration;
using SupplySync.Infrastructure.Persistence;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.Configure<MongoDbSettings>(
        builder.Configuration.GetSection("Mongo")
    );

builder.Services.AddSingleton<IMongoClient>(sp =>
{
    var settings = sp.GetRequiredService<IOptions<MongoDbSettings>>().Value;
    return new MongoClient(settings.ConnectionString);
});

builder.Services.AddScoped<MongoDbContext>();

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<MongoDbContext>();   

    await context.PingAsync();

    Console.WriteLine("Successfully connected to MongoDB!");
}


    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.MapOpenApi();
    }

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
