using CargoTracking.Server.Domain.Abstractions;
using CargoTracking.Server.Domain.Cargos;
using CargoTracking.Server.Domain.Users;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTracking.Server.Application.MyCargos
{
    public sealed record CargoGetAllQuery(
        ) : IRequest<IQueryable<CargoGetAllQueryResponse>>;

   
    public sealed class CargoGetAllQueryResponse : EntityDto
    {
        public string SenderFullName { get; set; } = default!;
        public string RecipientFullName { get; set; } = default!;
        public string DeliveryAddressCity { get; set; } = default!;
        public string DeliveryAddressTown { get; set; } = default!;
        public string CargoTypeName { get; set; } = default!;
        public int Weight { get; set; }
        public string CargoStatusName { get; set; } = default!;
    }

    internal sealed class CargoGetAllQueryHandler(
        ICargoRepository cargoRepository, UserManager<AppUser> userManager
        ) : IRequestHandler<CargoGetAllQuery,IQueryable<CargoGetAllQueryResponse>> 
    { 
    public Task<IQueryable<CargoGetAllQueryResponse>> Handle(CargoGetAllQuery request,CancellationToken cancellationToken)
        {
            var response = (from entity in cargoRepository.GetAll()
                            join create_user in userManager.Users.AsQueryable() on entity.CreateUserId equals create_user.Id
                            join update_user in userManager.Users.AsQueryable() on entity.CreateUserId equals update_user.Id into update_user
                            from update_users in update_user.DefaultIfEmpty()
                            select new CargoGetAllQueryResponse
                            {
                                RecipientFullName = entity.Recipient.FirstName + " " + entity.Recipient.LastName,
                                SenderFullName = entity.Sender.FirstName + " " + entity.Sender.LastName,
                                Weight = entity.CargoInformation.weight,
                                CargoTypeName = entity.CargoInformation.cargoType.Name,
                                DeliveryAddressCity = entity.DeliveryAddress.City,
                                DeliveryAddressTown = entity.DeliveryAddress.County,
                                CargoStatusName = entity.cargoStatus.Name,
                                CreateAt = entity.CreateAt,
                                DeleteAt = entity.DeleteAt,
                                Id = entity.Id,
                                IsDeleted = entity.IsDeleted,
                                UpdateAt = entity.UpdateAt,
                                CreateUserId = entity.CreateUserId,
                                CreateUserName = create_user.FirstName + " " + create_user.LastName + " (" + create_user.Email + ")",
                                UpdateUserId = entity.UpdateUserId,
                                UpdateUserName = entity.UpdateUserId == null ? null : update_users.FirstName + " " + update_users.LastName + " (" + update_users.Email + ")",
                            });

            return Task.FromResult(response);
        }
    }
}
