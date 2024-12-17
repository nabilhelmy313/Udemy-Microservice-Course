using Ordering.API;
using Ordering.Application;
using Ordering.Infrastructure;
var builder = WebApplication.CreateBuilder(args);

 
var app = builder.Build();

 //add Service container
 builder.Services
    .AddApplicationServices()
    .AddInfrastructureServices(builder.Configuration)
    .AddApiServices();

 
app.Run();

 
