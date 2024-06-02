var builder = WebApplication.CreateBuilder(args);
//Di Services  To Container
var app = builder.Build();
//Configure the http request

app.Run();
