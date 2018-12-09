using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Karlson.Application.Token.Queries
{
	public class GetTokenQueryHandler : IRequestHandler<GetTokenQuery, string>
	{
		private IConfiguration config;

		public GetTokenQueryHandler(IConfiguration config)
		{
			this.config = config;
		}

		public Task<string> Handle(GetTokenQuery request, CancellationToken cancellationToken)
		{
			var claims = new Claim[]
			{
				new Claim(JwtRegisteredClaimNames.Sub, request.Email),
				new Claim(JwtRegisteredClaimNames.UniqueName, request.Email),
				new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
				new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString())
			};

			var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"]));
			var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);
			var jwt = new JwtSecurityToken
			(
				issuer: config["Jwt:Issuer"],
				audience: config["Jwt:Audience"],
				claims: claims,
				expires: DateTime.UtcNow.AddDays(2),
				notBefore: DateTime.UtcNow,
				signingCredentials: signingCredentials
			);

			return Task.FromResult(new JwtSecurityTokenHandler().WriteToken(jwt));
		}
	}
}
