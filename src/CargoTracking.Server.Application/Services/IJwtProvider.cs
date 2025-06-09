using CargoTracking.Server.Domain.Users;

namespace CargoTracking.Server.Application.Services;
public interface IJwtProvider
{
    public Task<string> CreateTokenAsync(AppUser user, string password, CancellationToken cancellationToken = default);
}
