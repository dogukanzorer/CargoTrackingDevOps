using CargoTracking.Server.Application.MyCargos;
using MediatR;
using TS.Result;

namespace CargoTracking.Server.WebAPI.Modules;

public static class EmployeeModule
{
    public static void RegisterCargoRoutes(this IEndpointRouteBuilder app)
    {
        RouteGroupBuilder group = app.MapGroup("/myCargos").WithTags("MyCargos"); //.RequireAuthorization();

        group.MapPost(string.Empty,
            async (ISender sender, CargoCreateCommand request, CancellationToken cancellatioNToken) =>
            {
                var response = await sender.Send(request, cancellatioNToken);
                return response.IsSuccessful ? Results.Ok(response) : Results.InternalServerError(response);
            })
            .Produces<Result<string>>().WithName("cargoCreate");

       

        
    }
}
