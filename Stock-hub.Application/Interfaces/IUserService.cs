﻿using Microsoft.AspNetCore.Identity;
using Stock_hub.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_hub.Application.Interfaces
{
    public interface IUserService
    {
        Task<IdentityResult> Register(UserRegisterDTO userRegisterDTO);
        Task<dynamic> Login(UserLoginDTO userLoginDTO);
    }
}
