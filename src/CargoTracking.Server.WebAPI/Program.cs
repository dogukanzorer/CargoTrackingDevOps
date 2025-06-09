using CargoTracking.Server.WebAPI;
using CargoTracking.Server.WebAPI.Installers;
using CargoTracking.Server.WebAPI.Modules;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// ⬇️ 1. Servis kayıtları burada
builder.Services.AddResponseCompression(opt =>
{
    opt.EnableForHttps = true;
});

builder.Services.AddInternalServices(builder.Configuration);
builder.Services.AddExternalServices();

builder.Services.AddControllers();        // ⬅️ Bu satır yukarı taşındı
builder.Services.AddHealthChecks();       // ⬅️ Bu da yukarı taşındı

// ⬇️ 2. Build (artık servis ekleyemezsin)
var app = builder.Build();

// ⬇️ 3. Middleware ve endpoint kayıtları burada
app.MapOpenApi();
app.MapScalarApiReference();

app.AddMiddlewares();

app.MapControllers()
   .RequireRateLimiting("fixed")
   .RequireAuthorization();

app.RegisterRoutes();

ExtensionsMiddleware.CreateFirstUser(app);

app.Run();
