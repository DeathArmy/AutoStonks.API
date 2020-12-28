using AutoMapper;
using AutoStonks.API.Dtos.User;
using AutoStonks.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

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

        public async Task<ServiceResponse<UserDto>> AddUser(AddUserDto newUser)
        {
            ServiceResponse<UserDto> serviceResponse = new ServiceResponse<UserDto>();
            User user = new User();
            PasswordHashing ph = new PasswordHashing();
            try
            {
                user = _mapper.Map<User>(newUser);
                user.Salt = Encoding.Unicode.GetString(ph.GetSalt());
                user.Password = Encoding.Unicode.GetString(ph.GetKey(user.Password, Encoding.Unicode.GetBytes(user.Salt)));
                _context.Users.Add(user);
                _context.SaveChanges();
                serviceResponse.Data = _mapper.Map<UserDto>(user);
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

        public async Task<ServiceResponse<UserDto>> Login(LoginDto login)
        {
            ServiceResponse<UserDto> serviceResponse = new ServiceResponse<UserDto>();
            PasswordHashing ph = new PasswordHashing();
            User entity = new User();
            try
            {
                entity = _context.Users.First(u => u.Username == login.Username);
                if (ph.IsValid(login.Password, entity.Salt, entity.Password)) serviceResponse.Data = _mapper.Map<UserDto>(entity);
                else throw new Exception("");
                if (entity.EnforcePasswordChange == true) throw new Exception("Password should be changed!");
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = "Wrong username or password.\n";
                serviceResponse.Message += (ex.InnerException != null) ? ex.InnerException.Message : ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<UserDto>> PasswordChange(PasswordChangeDto pwdChange)
        {
            ServiceResponse<UserDto> serviceResponse = new ServiceResponse<UserDto>();
            PasswordHashing ph = new PasswordHashing();
            User entity = new User();
            try
            {
                entity = _context.Users.First(u => u.Username == pwdChange.Username);
                if (ph.IsValid(pwdChange.CurrentPassword, entity.Salt, entity.Password))
                {
                    entity.Salt = Encoding.Unicode.GetString(ph.GetSalt());
                    entity.Password = Encoding.Unicode.GetString(ph.GetKey(pwdChange.NewPassword, Encoding.Unicode.GetBytes(entity.Salt)));
                    entity.LastPasswordChange = DateTime.Now;
                    entity.EnforcePasswordChange = false;
                    _context.SaveChanges();
                    serviceResponse.Data = _mapper.Map<UserDto>(entity);
                }
                else throw new Exception("Wrong current password!");
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
