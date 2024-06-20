var builder = WebApplication.CreateBuilder(args);
//Di Services  To Container
var assembly = typeof(Program).Assembly;
builder.Services.AddCarter(); 
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(assembly);
});
builder.Services.AddMarten(opts =>
{
    opts.Connection(builder.Configuration.GetConnectionString("Database")!);
}).UseLightweightSessions();
var app = builder.Build();
//Configure the http request
app.MapGet("/product", () => {
    // Logic to create product
    return "Hello";
});
app.UseHttpsRedirection();
app.MapCarter();
app.Run();