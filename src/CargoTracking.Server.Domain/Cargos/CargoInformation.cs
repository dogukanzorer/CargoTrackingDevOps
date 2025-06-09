namespace CargoTracking.Server.Domain.Cargos;

public sealed record CargoInformation(
    CargoTypeEnum cargoType,
    int weight);
