using Ardalis.SmartEnum;
using CargoTracking.Server.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTracking.Server.Domain.Cargos;

    public sealed class Cargo : Entity
    {
       public Person Sender { get; set; } = default!; 
       public Person Recipient { get; set; } = default!;
       public Address DeliveryAddress { get; set; } = default!;
       public CargoInformation CargoInformation { get; set; } = default!;
       public CargoStatusEnum cargoStatus { get; set; } = default!;

    public sealed class CargoStatusEnum : SmartEnum<CargoStatusEnum>
    {
        public static CargoStatusEnum pending = new("pending", 0);
        public static CargoStatusEnum deliveredVehicle = new("delivered to the Vehicle", 1);    
        public static CargoStatusEnum DispatchedCargo = new("The cargo has departed", 2);
        public static CargoStatusEnum ArrivedAtDeliveryBranch = new("The cargo has arrived at delivery branch", 3);
        public static CargoStatusEnum OutForDelivery = new("set out for delivery", 4);
        public static CargoStatusEnum Delivered = new("delivered", 5);
        public static CargoStatusEnum RecipientNotAvailable = new("The delivery attempt failed because no one was present at the recipient's address", 6);
        public static CargoStatusEnum Cancelled = new("Shipping was cancelled ", 7);

        public CargoStatusEnum(string name, int value) : base(name, value) { }
    }
}
