namespace CargoTracking.Server.Domain.Cargos;

public sealed record Address(
    string City,
    string County,
    string Street, 
    string State,
    string ZipCode
);
