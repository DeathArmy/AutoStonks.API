using AutoStonks.API.Dtos.User;
using AutoStonks.API.Models;
using AutoStonks.API.Services.UserService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoStonks.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            ServiceResponse<List<GetUsersDto>> response = await _userService.GetAllUsers();
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSpecific(int id)
        {
            ServiceResponse<GetUserDto> response = await _userService.GetUserById(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserDto newUser)
        {
            ServiceResponse<UserDto> response = await _userService.AddUser(newUser);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser(UpdateUserDto updateUser)
        {
            ServiceResponse<GetUserDto> response = await _userService.UpdateUser(updateUser);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            ServiceResponse<DeleteUserDto> response = await _userService.DeleteUser(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto login)
        {
            ServiceResponse<UserDto> response = await _userService.Login(login);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpPost("pwd")]
        public async Task<IActionResult> PasswordChange(PasswordChangeDto pwdChange)
        {
            ServiceResponse<UserDto> response = await _userService.PasswordChange(pwdChange);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
    }
}
