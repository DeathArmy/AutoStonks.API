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
        DataContext _context;
        private readonly IMapper _mapper;
        public UserService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ServiceResponse<User>> AddUser(AddUserDto newUser)
        {
            ServiceResponse<User> serviceResponse = new ServiceResponse<User>();
            User user = new User();
            try
            {
                user = _mapper.Map<User>(newUser);
                _context.Users.Add(user);
                _context.SaveChanges();
                serviceResponse.Data = user;
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<DeleteUserDto>> DeleteUser(int id)
        {
            ServiceResponse<DeleteUserDto> serviceResponse = new ServiceResponse<DeleteUserDto>();
            try
            {
                User user = _context.Users.FirstOrDefault(u => u.Id == id);
                user.IsActive = false;
                _context.SaveChanges();
                serviceResponse.Data = _mapper.Map<DeleteUserDto>(user);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetUsersDto>>> GetAllUsers()
        {
            ServiceResponse<List<GetUsersDto>> serviceResponse = new ServiceResponse<List<GetUsersDto>>();
            try
            {
                serviceResponse.Data = _context.Users.Where(u => u.IsActive != false).Select(u => _mapper.Map<GetUsersDto>(u)).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetUserDto>> GetUserById(int id)
        {
            ServiceResponse<GetUserDto> serviceResponse = new ServiceResponse<GetUserDto>();
            try
            {
                serviceResponse.Data = _mapper.Map<GetUserDto>(_context.Users.FirstOrDefault(u => u.Id == id));
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetUserDto>> UpdateUser(UpdateUserDto updateCharacter)
        {
            ServiceResponse<GetUserDto> serviceResponse = new ServiceResponse<GetUserDto>();
            try
            {
                User user = _context.Users.FirstOrDefault(u => u.Id == updateCharacter.Id);
                user.Username = updateCharacter.Username;
                user.EmailAddress = updateCharacter.EmailAddress;
                user.Role = updateCharacter.Role;
                if (user.Password != updateCharacter.Password)
                {
                    user.Password = updateCharacter.Password;
                    user.Salt = updateCharacter.Salt;
                    user.LastPasswordChange = updateCharacter.LastPasswordChange;
                    user.EnforcePasswordChange = false;
                }
                serviceResponse.Data = _mapper.Map<GetUserDto>(user);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }
    }
}
