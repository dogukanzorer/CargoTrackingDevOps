using CargoTracking.Server.Domain.Cargos;
using CargoTracking.Server.Infrastructure.Context;
using GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CargoTracking.Server.Infrastructure.Repositories;

internal sealed class CargoRepository : Repository<Cargo, ApplicationDbContext>, ICargoRepository
{
    public CargoRepository(ApplicationDbContext context) : base(context)
    {
    }
}
