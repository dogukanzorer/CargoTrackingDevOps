﻿namespace CargoTracking.Server.WebAPI.Modules;

public static class RouteRegistrar
{
    public static void RegisterRoutes(this IEndpointRouteBuilder app)
    {
        app.RegisterCargoRoutes();
        app.RegisterAuthRoutes();
    }
}
