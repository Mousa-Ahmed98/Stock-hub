using Microsoft.AspNetCore.Identity;
using Stock_hub.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_hub.Application
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<dynamic> Login(UserLoginDTO userLoginDTO)
        {
            return await _userRepository.Login(userLoginDTO);
        }

        public async Task<IdentityResult> Register(UserRegisterDTO userRegisterDTO)
        {
            return await _userRepository.Register(userRegisterDTO);
        }
    }
}
