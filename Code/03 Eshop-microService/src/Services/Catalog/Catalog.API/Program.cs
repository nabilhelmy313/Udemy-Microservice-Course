var builder = WebApplication.CreateBuilder(args);
//Di Services  To Container
builder.Services.AddCarter();
builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblies(typeof(Program).Assembly));
var app = builder.Build();
//Configure the http request
app.MapCarter();
app.Run();
