using AutoStonks.API.Dtos.User;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Services.UserService
{
    public interface IUserService
    {
        public Task<ServiceResponse<GetUserDto>> GetUserById(int id);
        public Task<ServiceResponse<List<GetUserDto>>> AddUser(AddUserDto newUser);
        public Task<ServiceResponse<List<GetUserDto>>> GetAllUsers();
        public Task<ServiceResponse<GetUserDto>> UpdateUser(UpdateUserDto updateCharacter);
    }
}
