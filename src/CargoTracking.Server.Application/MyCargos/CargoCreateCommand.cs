using CargoTracking.Server.Domain.Cargos;
using FluentValidation;
using GenericRepository;
using Mapster;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace CargoTracking.Server.Application.MyCargos;

    public sealed record CargoCreateCommand(Person Sender, Person Recipient, Address DeliveryAddress, CargoInformationDto CargoInformation) : IRequest<Result<string>>;

    public sealed record CargoInformationDto(
        int CargoTypeValue,
        int weight);

    public sealed class CargoCreateCommandValidator: AbstractValidator<CargoCreateCommand>
    {
        public CargoCreateCommandValidator()
        {
            RuleFor(p => p.Sender).NotNull().WithMessage("Sender cannot be null.");
            RuleFor(p => p.Recipient).NotNull().WithMessage("Recipient cannot be null.");
            RuleFor(p => p.DeliveryAddress).NotNull().WithMessage("Delivery address cannot be null.");
            RuleFor(p => p.CargoInformation).NotNull().WithMessage("Cargo information cannot be null.");
            RuleFor(p => p.Sender.FirstName).NotEmpty().WithMessage("Sender's first name cannot be empty.");
            RuleFor(p => p.Sender.LastName).NotEmpty().WithMessage("Sender's last name cannot be empty.");
            RuleFor(p => p.CargoInformation.CargoTypeValue).GreaterThanOrEqualTo(0).WithMessage("select a valid cargo type").LessThan(CargoTypeEnum.List.Count()).WithMessage("select a valid cargo type");
        }
    }
    internal sealed class CargoCreateCommandHandler( 
           ICargoRepository cargoRepository, 
           IUnitOfWork unitOfWork
        ) : IRequestHandler<CargoCreateCommand, Result<string>>
    {
        public async Task<Result<string>> Handle(CargoCreateCommand request, CancellationToken cancellationToken)
           {
        Cargo cargo = request.Adapt<Cargo>();
        CargoInformation cargoInformation =  new (
            CargoTypeEnum.FromValue(request.CargoInformation.CargoTypeValue), request.CargoInformation.weight);
        cargo.CargoInformation = cargoInformation;
        cargo.cargoStatus = Cargo.CargoStatusEnum.pending;
        cargoRepository.Add(cargo);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Cargo created successfully!"; // You might want to return the ID or some other identifier of the created cargo.
    }
       
       
    }
