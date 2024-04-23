using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using Stock_hub.Application.Interfaces;
using Stock_hub.Core.Entities;
using Stock_hub.DTOS;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Stock_hub.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public UserRepository(UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<IdentityResult> Register(UserRegisterDTO userRegisterDTO)
        {
            ApplicationUser user = _mapper.Map<ApplicationUser>(userRegisterDTO);

            IdentityResult IdRes = await _userManager.CreateAsync(user, userRegisterDTO.Password);
            return IdRes;
        }

        public async Task<dynamic> Login(UserLoginDTO userLoginDTO)
        {
            ApplicationUser? user = await _userManager.FindByNameAsync(userLoginDTO.UserName);
            if (user != null && await _userManager.CheckPasswordAsync(user, userLoginDTO.Password))
            {
                //Claims
                List<Claim> claims =
                [
                    new Claim(ClaimTypes.NameIdentifier, user.Id),
                    new Claim(ClaimTypes.Name, user.UserName!)
                ];

                //secretKey
                SymmetricSecurityKey authSecretKey =
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes("I am Mousa---ITI, hack it if you can"));

                //
                SigningCredentials credentials =
                    new SigningCredentials(authSecretKey, SecurityAlgorithms.HmacSha256);
                //Create token
                JwtSecurityToken token = new JwtSecurityToken(
                    issuer: "http://localhost:5052",
                    audience: "http://localhost:4200",
                    expires: DateTime.Now.AddHours(1),
                    claims: claims,
                    signingCredentials: credentials
                    );
                return new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo,
                    ApplicationUserId = user.Id
                };

            }
            else
            {
                return null;
            }
        }
    }
}
