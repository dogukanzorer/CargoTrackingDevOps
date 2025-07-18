﻿using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using CargoTracking.Server.Application.Services;
using CargoTracking.Server.Domain.Users;
using CargoTracking.Server.Infrastructure.Options;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace CargoTracking.Server.Infrastructure.Services;
internal sealed class JwtProvider(
    IOptions<JwtOptions> options) : IJwtProvider
{
    public Task<string> CreateTokenAsync(AppUser user, string password, CancellationToken cancellationToken = default)
    {
        List<Claim> claims = new()
        {
            new Claim(ClaimTypes.NameIdentifier,user.Id.ToString())
        };

        var expires = DateTime.Now.AddDays(1);

        SymmetricSecurityKey securityKey = new(Encoding.UTF8.GetBytes(options.Value.SecretKey));
        SigningCredentials signingCredentials = new(securityKey, SecurityAlgorithms.HmacSha512);

        JwtSecurityToken securityToken = new(
            issuer: options.Value.Issuer,
            audience: options.Value.Audience,
            claims: claims,
            notBefore: DateTime.Now,
            expires: expires,
            signingCredentials: signingCredentials);

        JwtSecurityTokenHandler handler = new();

        string token = handler.WriteToken(securityToken);

        return Task.FromResult(token);
    }
}
