namespace CargoTracking.Server.Domain.Cargos;

public sealed record Person(
    string FirstName,
    string LastName,
    string Ssn,
    string Email,
    string Address,
    string PhoneNumber
);
