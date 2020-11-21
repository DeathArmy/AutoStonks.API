using AutoMapper;
using AutoStonks.API.Dtos.User;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Services.UserService
{
    public class UserService : IUserService
    {
        //private static List<User> users = new List<User> { new User(), new User { Id = 1, username = "Adam" } };
        //private readonly IMapper _mapper;
        //public UserService(IMapper mapper)
        //{
        //    _mapper = mapper;
        //}

        //public async Task<ServiceResponse<List<GetUserDto>>> AddUser(AddUserDto newUser)
        //{
        //    ServiceResponse<List<GetUserDto>> serviceResponse = new ServiceResponse<List<GetUserDto>>();
        //    User user = _mapper.Map<User>(newUser);
        //    user.Id = users.Max(c => c.Id) + 1;
        //    users.Add(user);
        //    serviceResponse.Data = users.Select(c => _mapper.Map<GetUserDto>(c)).ToList();
        //    return serviceResponse;
        //}

        //public async Task<ServiceResponse<List<GetUserDto>>> GetAllUsers()
        //{
        //    ServiceResponse<List<GetUserDto>> serviceResponse = new ServiceResponse<List<GetUserDto>>();
        //    serviceResponse.Data = (users.Select(c => _mapper.Map<GetUserDto>(c))).ToList();
        //    return serviceResponse;
        //}

        //public async Task<ServiceResponse<GetUserDto>> GetUserById(int id)
        //{
        //    ServiceResponse<GetUserDto> serviceResponse = new ServiceResponse<GetUserDto>();
        //    serviceResponse.Data = _mapper.Map<GetUserDto>(users.FirstOrDefault(u => u.Id == id));
        //    return serviceResponse;
        //}

        //public async Task<ServiceResponse<GetUserDto>> UpdateUser(UpdateUserDto updateCharacter)
        //{
        //    ServiceResponse<GetUserDto> serviceResponse = new ServiceResponse<GetUserDto>();
        //    try
        //    {
        //        User user = users.FirstOrDefault(c => c.Id == updateCharacter.Id);
        //        user.emailAddress = updateCharacter.emailAddress;
        //        user.username = updateCharacter.username;
        //        user.role = updateCharacter.role;
        //        serviceResponse.Data = _mapper.Map<GetUserDto>(user);
        //    }
        //    catch (Exception ex)
        //    {
        //        serviceResponse.Success = false;
        //        serviceResponse.Message = ex.Message;
        //    }
        //    return serviceResponse;
        //}
        public Task<ServiceResponse<List<GetUserDto>>> AddUser(AddUserDto newUser)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<List<GetUserDto>>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<GetUserDto>> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<GetUserDto>> UpdateUser(UpdateUserDto updateCharacter)
        {
            throw new NotImplementedException();
        }
    }
}
