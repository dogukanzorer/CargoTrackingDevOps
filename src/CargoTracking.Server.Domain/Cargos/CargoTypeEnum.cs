using Ardalis.SmartEnum;

namespace CargoTracking.Server.Domain.Cargos;

public sealed class CargoTypeEnum : SmartEnum<CargoTypeEnum>
{
    public static CargoTypeEnum Package = new("Package", 0);
    public static CargoTypeEnum Parcel = new("Parcel", 1);
    public static CargoTypeEnum Envelope = new("Envelope", 2);
    public static CargoTypeEnum Document = new("Document", 3);
    public static CargoTypeEnum Freight = new("Freight", 4);

    public CargoTypeEnum(string name, int value) : base(name, value) { 
    }

}